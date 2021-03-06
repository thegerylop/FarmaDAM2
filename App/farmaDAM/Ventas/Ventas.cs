﻿using System;
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
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;
using CrystalDecisions.Shared;

namespace Ventas
{
    public partial class Ventas : Form
    {
        string user;
        double total = 0;
        DataSet dataSet = new DataSet();
        DataSet medicaments = new DataSet();
        MySqlConnection conn = new MySqlConnection();
        ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();

        public Ventas()
        {
            InitializeComponent();
        }
        public void Ventas_Load(object sender, EventArgs e)
        {
            amagarItems();
            iniciarTicket();


        }

        public void iniciarTicket()
        {
            CcomboBox.SelectedIndex = 0;
            int ticket = Int32.Parse(bd.resultatComanda("SELECT MAX(id_venda) FROM vendes")) + 1;
            lblTicket.Text = lblTicket.Text + ticket.ToString();
            CcQuant.SelectedIndex = 0;
        }
        public void amagarItems()
        {
            UserName.Visible = false;
            gbClient.Visible = false;
            gbRecepta.Visible = false;
            groupBoxMed.Visible = false;
            groupBoxLlista.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recarregarForm();
        }
        private void CCpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                login();
            }
        }

        public void recarregarForm()
        {
            this.Controls.Clear();
            InitializeComponent();
            lblVentas.Location = new Point(659, 170);
            gbClient.Location = new Point(124, 246);
            UserName.Location = new Point(129, 227);
            gbRecepta.Location = new Point(124, 309);
            groupBoxMed.Location = new Point(124, 367);
            groupBoxLlista.Location =  new Point(884, 216);
            amagarItems();
            iniciarTicket();
        }
        private void login()
        {
            string login = CClogin.Text;
            string password = CCpassword.Text;
            string select = bd.connexioLogin(login, password);
            

            if (select != null)
            { 
                user = login;

                gbClient.Visible = true;
                Tancar.Visible = true;
                btn_login.Visible = false;
                CClogin.Enabled = false;
                CCpassword.Enabled = false;
            }
            else
            {
                MessageBox.Show("Dades d'usuari incorrectes");
            }
        }
        private void BindingDades(string table)
        {
            dgvVentas.AutoGenerateColumns = true;
            dgvVentas.DataSource = medicaments.Tables[table]; // dataset
            dgvVentas.Columns[7].Visible = false;
            dgvVentas.Columns[8].Visible = false;
        }

        private void TBClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buscar_client();
            }
        }
        private void buscar_client()
        {
            String userName = null;
            userName = bd.resultatComanda("Select nom from clients where " + CcomboBox.Text + " = " + TBClient.Text);
            userName += " " + bd.resultatComanda("Select cognom1 from clients where " + CcomboBox.Text + " = " + TBClient.Text);

            if (userName == null || userName == "" || userName == " ")
            {
                MessageBox.Show("Client incorrecte");
                TBClient.Text = "";
                TBClient.Focus();
            }
            else
            {
                mostrarTicket(userName);

            }

        }
        public void mostrarTicket(string userName)
        {
            UserName.Text = userName;
            UserName.Visible = true;
            TBClient.Enabled = false;
            CcomboBox.Enabled = false;
            gbRecepta.Visible = true;
            groupBoxMed.Visible = true;
            groupBoxLlista.Visible = true;
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
                        MessageBox.Show("Stock insuficient");
                    }
                }
            }
            //si no esta a la llista l'afegim
            if (add)
            {
                if(Int32.Parse(dgvVentas.Rows[index].Cells[6].Value.ToString()) > 0)
                {
                    string[] row = { dgvVentas.Rows[index].Cells[1].Value.ToString(), dgvVentas.Rows[index].Cells[4].Value.ToString(), dgvVentas.Rows[index].Cells[5].Value.ToString(), "1" };
                    var listViewItem = new ListViewItem(row);
                    listViewCompra.Items.Add(listViewItem);
                }
                else
                {
                    MessageBox.Show("Producte sense Stock");
                    sumar = false;
                }
                
            }
            if (sumar)
            {
                sumarTicket();
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
            double test = Math.Round(resultat, 2, MidpointRounding.AwayFromZero);
            total = Math.Round(total, 2, MidpointRounding.AwayFromZero);
            total -= test;
            lblTotal.Text = total.ToString() + " €";
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

                ticketCrystalReports();

                recarregarForm();
            }
            else
            {
                MessageBox.Show("Ticket buit");
            }
        }

        private void ticketCrystalReports()
        {
            //Crea la factura i s'envia a imprimir (guardar)
            String pkInstalledPrinters;
            pkInstalledPrinters = PrinterSettings.InstalledPrinters[1];
            ReportDocument factura = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            factura.Load("../Ventas/Ticket.rpt");

            crConnectionInfo.ServerName = "farmaDAM";
            crConnectionInfo.DatabaseName = "g2s2am_FarmaDAM";
            crConnectionInfo.UserID = "g2s2am";
            crConnectionInfo.Password = "diopters12345";

            CrTables = factura.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }



            String numTicket = bd.resultatComanda("Select id_venda from vendes order by id_venda desc limit 1");
            factura.RecordSelectionFormula = "{vendes1.id_venda} = " + numTicket;
            factura.PrintOptions.PrinterName = pkInstalledPrinters;
            factura.PrintToPrinter(1, true, 0, 0);
        }

        private void afegirProductesBBDD() 
        {
            int Id = Int32.Parse(bd.resultatComanda("SELECT max(id_venda) FROM vendes"));
            Boolean VendaCorrecte = true;

            //Per cada Producte en el ticket l'afageix a linia_venda a la bbdd
            foreach (ListViewItem itemRow in this.listViewCompra.Items)
            {
                string producte = itemRow.SubItems[0].Text;
                int IdProd = Int32.Parse(bd.resultatComanda("SELECT id_medicament FROM medicaments where nom_comercial = '" + producte +"'"));
                int cantidad = Int32.Parse(itemRow.SubItems[3].Text);
                string preu = itemRow.SubItems[1].Text;
                preu = preu.Replace(@",",".");
                string iva = itemRow.SubItems[2].Text;
                iva = iva.Replace(@",", ".");

                var correcte = bd.executaComanda("insert into linia_venda (id_venda,id_medicament,quantitat,pvp,IVA) values (" + Id + "," + IdProd + "," + cantidad + "," + preu + "," + iva + ")");

                //si s'ha afegit correctament baixara el stock dels medicaments comprats a la bbdd
                if (!correcte.Equals(0))
                {
                    int stockNumber = Int32.Parse(bd.resultatComanda("SELECT stock FROM medicaments where id_medicament = " + IdProd));

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
                MessageBox.Show("Venda Tramitada");
                //actualitza la dataGridView
                medicaments = bd.portarPerConsulta("select v.registre_nacional, v.nom_comercial as 'Producte',v.contingut, e.nom as 'Principi_Actiu',v.PVP,v.IVA,v.stock,v.substituible,v.generic from medicaments v , principis_actius e where v.id_PrincipiActiu = e.id_PrincipiActiu", "medicaments");
                CcQuant.SelectedIndex = 0;
                BindingDades("medicaments");
            }
            else
            {
                MessageBox.Show("Error al tramitar la venda");
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
                if (TxBFilter.Text.Length > 0)
                {


                    dgvVentas.Refresh();
                    //Busco el medicament a la BBDD.
                    string medic = "select v.registre_nacional,v.nom_comercial,v.id_PrincipiActiu,v.PVP,v.IVA,v.stock, v.substituible from medicaments v where v.registre_nacional = " + TxBFilter.Text;
                    DataTable medicament = bd.searchTableFromQuery(medic);
                    Boolean afegir = true;
                    Boolean fix = false;

                    //Si existeix el medicament afaga la quantitat de stock que té.
                    if (medicament.Rows.Count > 0)
                    {
                        DataRow r = medicament.Rows[0];
                        int quantity = Int32.Parse(r["stock"].ToString());

                        //Si la quantitat es major que 0.
                        if (quantity > 0)
                        {
                            int cantidad = Int32.Parse(CcQuant.SelectedItem.ToString());
                            //Si la quantitat es major o igual a la que jo demano.
                            if (quantity >= cantidad)
                            {
                                fix = false;
                            }
                            else
                            {
                                fix = true;
                            }
                            //Busca si el medicament ja esta afegit al ticket
                            foreach (ListViewItem itemRow in this.listViewCompra.Items)
                            {
                                if (itemRow.SubItems[0].Text == r["nom_comercial"].ToString())
                                {
                                    afegir = false;
                                    if (!fix)
                                    {
                                        cantidad += Int32.Parse(itemRow.SubItems[3].Text);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Stock insuficient, cercant altres medicaments");
                                        cantidad = quantity;
                                        CercarProductes(r);
                                    }

                                    // Comprova que la quantitat del ticket sigui menor que el stock
                                    if (cantidad <= quantity)
                                    {
                                        itemRow.SubItems[3].Text = cantidad.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Stock insuficient");
                                        CercarProductes(r);
                                    }
                                }
                            }
                            //Si el medicament introduit no esta ja en el ticket
                            if (afegir)
                            {
                                var listViewItem = new ListViewItem();
                                if (fix)
                                {
                                    string[] row = { r["nom_comercial"].ToString(), r["PVP"].ToString(), r["IVA"].ToString(), quantity.ToString() };
                                    listViewItem = new ListViewItem(row);
                                    MessageBox.Show("Stock insuficient, cercant altres medicaments");
                                    CercarProductes(r);
                                }
                                else
                                {
                                    string[] row = { r["nom_comercial"].ToString(), r["PVP"].ToString(), r["IVA"].ToString(), CcQuant.SelectedItem.ToString() };
                                    listViewItem = new ListViewItem(row);
                                }
                                listViewCompra.Items.Add(listViewItem);
                                TxBFilter.Text = "";
                                e.KeyChar = '\r';
                            }
                        }
                        //Si no hi ha stock
                        else
                        {
                            MessageBox.Show("Producte sense stock");
                            CercarProductes(r);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Medicament inexistent");
                    }
                    sumarTicket();
                }
                else
                {
                    MessageBox.Show("Medicament necessari");
                }
            }
        }
        public void CercarProductes(DataRow r)
        {
            //fa una busqueda a la dataGridView
            medicaments = bd.portarPerConsulta("select v.registre_nacional, v.nom_comercial as 'Producte',v.contingut, e.nom as 'Principi_Actiu',v.PVP,v.IVA,v.stock,v.substituible,v.generic from medicaments v , principis_actius e where v.id_PrincipiActiu = e.id_PrincipiActiu and v.id_PrincipiActiu = " + r[2].ToString(), "medicaments");
            Boolean subs = Convert.ToBoolean(r[6].ToString());
            if(subs)
            {
                BindingDades("medicaments");
            }
            else
            {
                MessageBox.Show("Medicament insustituible");
            }
        }
        
        public void sumarTicket()
        {
            total = 0;
            foreach (ListViewItem itemRow in this.listViewCompra.Items)
            {
                double pvp = Convert.ToDouble(itemRow.SubItems[1].Text);
                double iva = Convert.ToDouble(itemRow.SubItems[2].Text);
                int cantidad = Int32.Parse(itemRow.SubItems[3].Text);
                total += (pvp + (pvp * (iva / 100))) * cantidad;
                total = Math.Round(total, 2, MidpointRounding.AwayFromZero);
                lblTotal.Text = total.ToString() + " €";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar_client();
        }

        private void CClogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                login();
            }
        }
    }
}