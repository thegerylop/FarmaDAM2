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

            groupBoxMed.Visible = false;
            groupBoxLlista.Visible = false;
            CcomboBox.SelectedIndex = 0;
            query = "Select * from " + table;
            dataSet = bd.portarPerConsulta(query, table);
            medicaments = bd.portarPerConsulta("select v.nom_comercial as 'Producte',v.contingut, e.nom as 'Principi Actiu',v.PVP,v.IVA,s.quantitat from medicaments v , principis_actius e , stock s where v.id_PrincipiActiu = e.id_PrincipiActiu and v.id_stock = s.id_stock", "medicaments");
           
            BindingDades("medicaments");
            

        }
        private void BindingDades(string table)
        {
            dgvVentas.AutoGenerateColumns = true;
            dgvVentas.DataSource = medicaments.Tables[table]; // dataset
        }

        private void customTextBox1_Leave(object sender, EventArgs e)
        {
            query = "Select " + CcomboBox.Text + " from clients where " + CcomboBox.Text + " = " + customTextBox1.Text;
            dataSet = bd.portarPerConsulta(query, table);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("El client indicat no existeix");
                customTextBox1.Text = "";
            }
            else
            {
                customTextBox1.Enabled = false;
                CcomboBox.Enabled = false;
                groupBoxMed.Visible = true;
                groupBoxLlista.Visible = true;
            }
        }

        private void customTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvVentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Boolean add = true;
            int index = dgvVentas.CurrentCell.RowIndex;
            string medicament;
            foreach (ListViewItem itemRow in this.listViewCompra.Items)
            {
                medicament = itemRow.SubItems[0].Text;
                if(medicament == dgvVentas.Rows[index].Cells[0].Value.ToString())
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
                string[] row = { dgvVentas.Rows[index].Cells[0].Value.ToString(), dgvVentas.Rows[index].Cells[3].Value.ToString(), dgvVentas.Rows[index].Cells[4].Value.ToString(), "1" };
                var listViewItem = new ListViewItem(row);
                listViewCompra.Items.Add(listViewItem);
            }
            double value1 = Convert.ToDouble(dgvVentas.Rows[index].Cells[3].Value.ToString());
            double value2 = Convert.ToDouble(dgvVentas.Rows[index].Cells[4].Value.ToString());
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

        }
    }
}
