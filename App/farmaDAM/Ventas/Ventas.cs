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
        private void Ventas_Load(object sender, EventArgs e)
        {
            gbClient.Visible = false;
            gbRecepta.Visible = false;
            groupBoxMed.Visible = false;
            groupBoxLlista.Visible = false;
            CcomboBox.SelectedIndex = 0;
            query = "Select * from " + table;
            dataSet = bd.portarPerConsulta(query, table);
            medicaments = bd.portarPerConsulta("select v.registre_nacional, v.nom_comercial as 'Producte',v.contingut, e.nom as 'Principi_Actiu',v.PVP,v.IVA,s.quantitat,v.substituible,v.generic from medicaments v , principis_actius e , stock s where v.id_PrincipiActiu = e.id_PrincipiActiu and v.id_stock = s.id_stock", "medicaments");
            CcQuant.SelectedIndex = 0;
            BindingDades("medicaments");
            

        }
        private void BindingDades(string table)
        {
            dgvVentas.AutoGenerateColumns = true;
            dgvVentas.DataSource = medicaments.Tables[table]; // dataset
            dgvVentas.Columns[7].Visible = false;
            dgvVentas.Columns[8].Visible = false;
        }

        private void customTextBox1_Leave(object sender, EventArgs e)
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
            int index = dgvVentas.CurrentCell.RowIndex;
            string medicament;
            foreach (ListViewItem itemRow in this.listViewCompra.Items)
            {
                medicament = itemRow.SubItems[0].Text;
                if(medicament == dgvVentas.Rows[index].Cells[1].Value.ToString())
                {
                    add = false;
                    int quantity;
                    quantity = Int32.Parse(itemRow.SubItems[3].Text);
                    quantity += 1;
                    itemRow.SubItems[3].Text = quantity.ToString();
                }
            }
            if (add)
            {
                string[] row = { dgvVentas.Rows[index].Cells[1].Value.ToString(), dgvVentas.Rows[index].Cells[4].Value.ToString(), dgvVentas.Rows[index].Cells[5].Value.ToString(), "1" };
                var listViewItem = new ListViewItem(row);
                listViewCompra.Items.Add(listViewItem);
            }
            double value1 = Convert.ToDouble(dgvVentas.Rows[index].Cells[4].Value.ToString());
            double value2 = Convert.ToDouble(dgvVentas.Rows[index].Cells[5].Value.ToString());
            total += value1 + (value1 * (value2 / 100));
            lblTotal.Text = total.ToString() + " €";
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
            //bd.executaComanda('insert into vendes (id_personal,id_client,num_ticket) values ()');
        }

        private void CCpassword_Enter(object sender, EventArgs e)
        {
            if (CCpassword.Text == "Password")
            {
                CCpassword.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas form = new Ventas();
            form.Show();
            this.Dispose();
        }

        private void TxBFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\r')
            {
                //Busco el medicament a la BBDD.
                string medic = "select v.registre_nacional,v.nom_comercial,v.PVP,v.IVA,s.quantitat from medicaments v , stock s where v.id_stock = s.id_stock and v.registre_nacional = " + TxBFilter.Text;
                DataTable medicament = bd.searchTableFromQuery(medic);
                Boolean afegir = true;
                
                //Si existeix el medicament afaga la quantitat de stock que té.
                if(medicament.Rows.Count > 0 )
                {
                    DataRow r = medicament.Rows[0];
                    int quantity = Int32.Parse(r["quantitat"].ToString());

                    //Si la quantitat es major que 0.
                    if(quantity > 0)
                    {
                        //Si la quantitat es major o igual a la que jo demano.
                        if(quantity >= Int32.Parse(CcQuant.SelectedItem.ToString()))
                        {
                            //Busca si el medicament ja esta afegit al ticket
                            foreach (ListViewItem itemRow in this.listViewCompra.Items)
                            {
                                if (itemRow.SubItems[0].Text == r.ItemArray[0].ToString())
                                {
                                    afegir = false;
                                    int cantidad;
                                    cantidad = Int32.Parse(itemRow.SubItems[3].Text);
                                    cantidad += Int32.Parse(CcQuant.SelectedItem.ToString());
                                    itemRow.SubItems[3].Text = cantidad.ToString();
                                }
                            }
                            //Si el medicament introduit no esta ja en el ticket
                            if (afegir)
                            {
                                string[] row = { r.ItemArray[0].ToString(), r.ItemArray[1].ToString(), r.ItemArray[2].ToString(), CcQuant.SelectedItem.ToString()};
                                var listViewItem = new ListViewItem(row);
                                listViewCompra.Items.Add(listViewItem);
                                TxBFilter.Text = "";
                                CcQuant.SelectedIndex = 0;
                                e.KeyChar = '\r';
                            }
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
                        Boolean subs = Convert.ToBoolean(dgvVentas.Rows[0].Cells[6].Value);
                        //Si no té stock i es substituible, busca altres medicaments
                        if (subs)
                        {
                            string principi = dgvVentas.Rows[0].Cells[2].Value.ToString();
                            (dgvVentas.DataSource as DataTable).DefaultView.RowFilter = string.Format("Principi_Actiu LIKE '{0}'", principi);
                            dgvVentas.Sort(dgvVentas.Columns[4], ListSortDirection.Ascending);
                        }
                    }
                }
            }
        }
    }
}
