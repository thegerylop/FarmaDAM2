﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConexioBBDD;

namespace LabFarm
{
    public partial class Laboratoris : Form
    {
        ConexioBBDD.Conexio conn = new ConexioBBDD.Conexio();
        string table = "laboratoris_farmaceutics";
        MySqlConnection connexio = new MySqlConnection();

        public Laboratoris()
        {
            InitializeComponent();
        }
        private void Laboratoris_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM laboratoris_farmaceutics";
            DataTable data = new DataTable();
            data = conn.filltable(query);
            dataGridView1.DataSource = data;  }

        private void button2_Click(object sender, EventArgs e)
        {
            Laboratoris_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                CustomCodi.textBox1.Text = row.Cells[0].Value.ToString();
                CustomDen.textBox1.Text = row.Cells[1].Value.ToString();
                CustomSocial.textBox1.Text = row.Cells[2].Value.ToString();
                CustomCIF.textBox1.Text = row.Cells[3].Value.ToString();
            }
        }

        private void SubmitLab(object sender, EventArgs e)
        {
            string[] Data = new string[4];
            Data = TextBoxData(Data);
            
            string query = "UPDATE " + table + " SET codi_lab = " + Data[1] + " ,rao_social = " + Data[2] + " ,cif = " + Data[3] + " WHERE id_lab = " + Data[0];

            try
            {
                if (conn.update_field(query))
                {
                    MessageBox.Show("Dades actualitzades");
                }
                else
                {
                    MessageBox.Show("Error a la consulta");
                }

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connexio.Close();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnInserir.Visible = false;
            BtnAceptar.Visible = true;
            dataGridView1.Visible = true;
            BtnAct.Visible = true;
            BtnEliminar.Visible = true;
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnInserir.Visible = true;
            BtnAceptar.Visible = false;
            dataGridView1.Visible = false;
            BtnAct.Visible = false;
            BtnEliminar.Visible = false;
                    
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string[] Data = new string[4];
            Data = TextBoxData(Data);

            string query = "DELETE FROM " + table + " WHERE id_lab = " + Data[0];

            if (conn.delete(query)) {
                MessageBox.Show("Dades esborrades");
            } else {
                MessageBox.Show("Error al esborrar dades");
            }           
            Laboratoris_Load(sender, e);
        }

            private string[] TextBoxData(string[] Data)
            {
                Data[0] = CustomCodi.textBox1.Text;
                Data[1] = CustomDen.textBox1.Text;
                Data[2] = CustomSocial.textBox1.Text;
                Data[3] = CustomCIF.textBox1.Text;
                return Data;
            }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            string[] Data = new string[4];
            Data = TextBoxData(Data);

            string query = "INSERT INTO " + table + "(codi_lab,rao_social,cif) VALUES(" + Data[1] + "," + Data[2] + "," + Data[3]+")";
            if (conn.inserir(query)) {
                MessageBox.Show("Dades afegides"); }
            else
            {
                MessageBox.Show("Error al afegir dades");
            }
        }
    }
}