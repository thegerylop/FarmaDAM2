using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConexioBBDD;
namespace Ventas
{
    public partial class Ventas : Form
    {
        string user;
        double total = 0;
        string table = "clients";
        string query;
        DataSet dataSet = new DataSet();
        DataSet medicaments = new DataSet();
        MySqlConnection conn = new MySqlConnection();
        ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();

        public Ventas()
        {
            InitializeComponent();
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            gbClient.Visible = false;
            gbRecepta.Visible = false;
            groupBoxMed.Visible = false;
            groupBoxLlista.Visible = false;
            CcomboBox.SelectedIndex = 0;
            query = "Select * from " + table;
            dataSet = bd.portarPerConsulta(query, table);
            medicaments = bd.portarPerConsulta("select v.registre_nacional, v.nom_comercial as 'Producte',v.contingut, e.nom as 'Principi_Actiu',v.PVP,v.IVA,v.stock,v.substituible,v.generic from medicaments v , principis_actius e where v.id_PrincipiActiu = e.id_PrincipiActiu", "medicaments");
            CcQuant.SelectedIndex = 0;
            BindingDades("medicaments");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas form = new Ventas();
            form.Refresh();
        }
        private void CCpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                login();
            }
        }
        private void login()
        {
            string login = CClogin.Text;
            string password = CCpassword.Text;
            string select = bd.connexioLogin(login, password);

            if (select != null)
            {
                gbClient.Visible = true;
                user = login;
            }
            else
            {
                MessageBox.Show("El login o la contrasenya son invàlids");
                gbClient.Visible = false;
                groupBoxMed.Visible = false;
                groupBoxLlista.Visible = false;
            }
        }
        private void BindingDades(string table)
        {
            dgvVentas.AutoGenerateColumns = true;
            dgvVentas.DataSource = medicaments.Tables[table]; // dataset
            dgvVentas.Columns[7].Visible = false;
            dgvVentas.Columns[8].Visible = false;
        }
        private void TBClients_Leave(object sender, EventArgs e)
        {
            query = "Select " + CcomboBox.Text + " from clients where " + CcomboBox.Text + " = " + TBClient.Text;
            dataSet = bd.portarPerConsulta(query, table);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("El client indicat no existeix");
                TBClient.Text = "";
            }
            else
            {
                TBClient.Enabled = false;
                CcomboBox.Enabled = false;
                gbRecepta.Visible = true;
                groupBoxMed.Visible = true;
                groupBoxLlista.Visible = true;
            }
        }
        private void dgvVentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean add = true;
            Boolean sumar = true;
            int index = dgvVentas.CurrentCell.RowIndex;
            string medicament;

            //comprovem si el medicament ja esta a la llista
            foreach (ListViewItem itemRow in this.listViewCompra.Items)
            {
                medicament = itemRow.SubItems[0].Text;
                if(medicament == dgvVentas.Rows[index].Cells[1].Value.ToString())
                {
                    add = false;
                    int quantity;
                    quantity = Int32.Parse(itemRow.SubItems[3].Text);
                    if(quantity < Int32.Parse(dgvVentas.Rows[index].Cells[6].Value.ToString()))
                    {
                        quantity += 1;
                        itemRow.SubItems[3].Text = quantity.ToString();
                    }
                    else
                    {
                        sumar = false;
                        MessageBox.Show("Stock per sota del demanat");
                    }
                }
            }
            //si no esta a la llista l'afegim
            if (add)
            {
                string[] row = { dgvVentas.Rows[index].Cells[1].Value.ToString(), dgvVentas.Rows[index].Cells[4].Value.ToString(), dgvVentas.Rows[index].Cells[5].Value.ToString(), "1" };
                var listViewItem = new ListViewItem(row);
                listViewCompra.Items.Add(listViewItem);
            }
            if (sumar)
            {
                double value1 = Convert.ToDouble(dgvVentas.Rows[index].Cells[4].Value.ToString());
                double value2 = Convert.ToDouble(dgvVentas.Rows[index].Cells[5].Value.ToString());
                total += value1 + (value1 * (value2 / 100));
                lblTotal.Text = total.ToString() + " €";
            }
        }

        private void listViewCompra_ItemActivate(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewCompra.Items.Count; i++)
            {
                if (listViewCompra.Items[i].Selected)
                {
                    borrarFactura(listViewCompra.Items[i]);
                    listViewCompra.Items[i].Remove();
                    i = listViewCompra.Items.Count;
                }
            }
        }
        private void borrarFactura(ListViewItem valor)
        {
            double preu = Convert.ToDouble(valor.SubItems[1].Text);
            double iva = Convert.ToDouble(valor.SubItems[2].Text);
            int quantitat = Int32.Parse(valor.SubItems[3].Text);
            double resultat = ((preu + (preu * (iva / 100))) * quantitat);
            total -= resultat;
            lblTotal.Text = total.ToString();

        }

        private void btnAcceptar_Click(object sender, EventArgs e)
        {
            int count = listViewCount();

            //Comprova que el ticket no estigui buit, si es aixi crea la venda
            if (count > 0) {
                string client = bd.resultatComanda("Select id_client from clients where " + CcomboBox.Text + " = " + TBClient.Text);
                string personal = bd.resultatComanda("Select id_personal from personal where usuari = '" + user + "'");

                bd.executaComanda("insert into vendes (id_personal,id_client,data) values (" + client + "," + personal + ",NOW())");

                afegirProductesBBDD();
            }
            else
            {
                MessageBox.Show("ticket buit");
            }
        }
        private void afegirProductesBBDD()
        {
            string id_venda = bd.resultatComanda("SELECT max(id_venda) FROM vendes");
            Boolean VendaCorrecte = true;
            int Id = Int32.Parse(id_venda);

            //Per cada Producte en el ticket l'afageix a linia_venda a la bbdd
            foreach (ListViewItem itemRow in this.listViewCompra.Items)
            {
                string producte = itemRow.SubItems[0].Text;
                string producteID = bd.resultatComanda("SELECT id_medicament FROM medicaments where nom_comercial = '" + producte +"'");
                int IdProd = Int32.Parse(producteID);
                int cantidad = Int32.Parse(itemRow.SubItems[3].Text);
                string preu = itemRow.SubItems[1].Text;
                preu = preu.Replace(@",",".");
                string iva = itemRow.SubItems[2].Text;
                iva = iva.Replace(@",", ".");

                var correcte = bd.executaComanda("insert into linia_venda (id_venda,id_medicament,quantitat,pvp,IVA) values (" + Id + "," + IdProd + "," + cantidad + "," + preu + "," + iva + ")");

                //si s'ha afegit correctament baixara el stock dels medicaments comprats a la bbdd
                if (!correcte.Equals(0))
                {
                    string id_stock = bd.resultatComanda("SELECT stock FROM medicaments where id_medicament = " + IdProd);
                    int stockNumber = Int32.Parse(id_stock);
                    stockNumber -= cantidad;
                    correcte = bd.executaComanda("update medicaments set stock= " + stockNumber + " where id_medicament = " + IdProd);
                    if (correcte.Equals(0))
                    {
                        VendaCorrecte = false;
                    }
                }
                else
                {
                    VendaCorrecte = false;
                }
            }
            if (VendaCorrecte)
            {
                MessageBox.Show("Venda Realitzada");
                //actualitza la dataGridView
                medicaments = bd.portarPerConsulta("select v.registre_nacional, v.nom_comercial as 'Producte',v.contingut, e.nom as 'Principi_Actiu',v.PVP,v.IVA,v.stock,v.substituible,v.generic from medicaments v , principis_actius e where v.id_PrincipiActiu = e.id_PrincipiActiu", "medicaments");
                CcQuant.SelectedIndex = 0;
                BindingDades("medicaments");
            }
            else
            {
                MessageBox.Show("Error al realitzar la venda");
            }
            
        }
        private int listViewCount()
        {
            int count = 0;
            foreach (ListViewItem itemRow in this.listViewCompra.Items)
            {
                count++;
            }
            return count;

        }
        private void TxBFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                //Busco el medicament a la BBDD.
                string medic = "select v.registre_nacional,v.nom_comercial,v.PVP,v.IVA,v.stock from medicaments v where v.registre_nacional = " + TxBFilter.Text;
                DataTable medicament = bd.searchTableFromQuery(medic);
                Boolean afegir = true;
                Boolean sumar = true;
                
                //Si existeix el medicament afaga la quantitat de stock que té.
                if(medicament.Rows.Count > 0 )
                {
                    DataRow r = medicament.Rows[0];
                    int quantity = Int32.Parse(r["stock"].ToString());

                    //Si la quantitat es major que 0.
                    if(quantity > 0)
                    {
                        int cantidad = Int32.Parse(CcQuant.SelectedItem.ToString());
                        //Si la quantitat es major o igual a la que jo demano.
                        if (quantity >= cantidad)
                        {
                            //Busca si el medicament ja esta afegit al ticket
                            foreach (ListViewItem itemRow in this.listViewCompra.Items)
                            {
                                if (itemRow.SubItems[0].Text == r["nom_comercial"].ToString())
                                {
                                    afegir = false;
                                    cantidad += Int32.Parse(itemRow.SubItems[3].Text);
                                    // Comprova que la quantitat del ticket sigui menor que el stock
                                    if (cantidad  <= quantity)
                                    {
                                        itemRow.SubItems[3].Text = cantidad.ToString();
                                    }
                                    else
                                    {
                                        sumar = false;
                                        MessageBox.Show("Stock per sota del demanat");
                                    }
                                }
                            }
                            //Si el medicament introduit no esta ja en el ticket
                            if (afegir)
                            {
                                string[] row = { r["nom_comercial"].ToString(), r["PVP"].ToString(), r["IVA"].ToString(), CcQuant.SelectedItem.ToString()};
                                var listViewItem = new ListViewItem(row);
                                listViewCompra.Items.Add(listViewItem);
                                TxBFilter.Text = "";
                                e.KeyChar = '\r';
                            }
                            if (sumar)
                            {
                                double value1 = Convert.ToDouble(r["PVP"].ToString());
                                double value2 = Convert.ToDouble(r["IVA"].ToString());
                                int cuant = Int32.Parse(CcQuant.SelectedItem.ToString());
                                total += (value1 + (value1 * (value2 / 100))) * cuant;
                                lblTotal.Text = total.ToString() + " €";
                            }
                            CcQuant.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Producte amb stock per sota del demanat");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Producte sense stock");
                        //fa una busqueda a la dataGridView
                        (dgvVentas.DataSource as DataTable).DefaultView.RowFilter = string.Format("registre_nacional = '" + TxBFilter.Text + "'");
                        Boolean subs = Convert.ToBoolean(dgvVentas.Rows[0].Cells[7].Value);
                        //Si no té stock i es substituible, busca altres medicaments
                        if (subs)
                        {
                            string principi = dgvVentas.Rows[0].Cells[3].Value.ToString();
                            (dgvVentas.DataSource as DataTable).DefaultView.RowFilter = string.Format("Principi_Actiu LIKE '{0}'", principi);
                            dgvVentas.Sort(dgvVentas.Columns[4], ListSortDirection.Ascending);
                        }
                    }
                }
            }
        }
    }
}
