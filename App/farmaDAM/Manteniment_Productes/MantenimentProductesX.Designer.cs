﻿namespace Manteniment_Productes
{
    partial class MantenimentProductesX
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbProds = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.TxBFilter = new CustomControl.CustomTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.customTextBox7 = new CustomControl.CustomTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.customTextBox9 = new CustomControl.CustomTextBox();
            this.customTextBox10 = new CustomControl.CustomTextBox();
            this.customTextBox11 = new CustomControl.CustomTextBox();
            this.customTextBox12 = new CustomControl.CustomTextBox();
            this.customTextBox13 = new CustomControl.CustomTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customTextBox4 = new CustomControl.CustomTextBox();
            this.customTextBox3 = new CustomControl.CustomTextBox();
            this.customTextBox6 = new CustomControl.CustomTextBox();
            this.customTextBox5 = new CustomControl.CustomTextBox();
            this.customTextBox2 = new CustomControl.CustomTextBox();
            this.customTextBox1 = new CustomControl.CustomTextBox();
            this.CCcodi = new CustomControl.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MComboBox = new CustomControl.comboBox();
            this.SuspendLayout();
            // 
            // btnAfegir
            // 
            this.btnAfegir.Location = new System.Drawing.Point(624, 177);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(747, 177);
            // 
            // cbProds
            // 
            this.cbProds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProds.AutoCompleteCustomSource.AddRange(new string[] {
            "codi_laboratori",
            "rao_social",
            "cif",
            "denominacio"});
            this.cbProds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProds.FormattingEnabled = true;
            this.cbProds.Items.AddRange(new object[] {
            "Codi Laboratori",
            "Raó Social",
            "CIF",
            "Denominació"});
            this.cbProds.Location = new System.Drawing.Point(293, 181);
            this.cbProds.Name = "cbProds";
            this.cbProds.Size = new System.Drawing.Size(121, 21);
            this.cbProds.TabIndex = 145;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(11, 182);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 18);
            this.lblFiltrar.TabIndex = 146;
            this.lblFiltrar.Text = "Filtrar :";
            // 
            // TxBFilter
            // 
            this.TxBFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBFilter.Location = new System.Drawing.Point(66, 181);
            this.TxBFilter.Name = "TxBFilter";
            this.TxBFilter.Options = CustomControl.CustomTextBox.Items.Text;
            this.TxBFilter.Placeholder = null;
            this.TxBFilter.Size = new System.Drawing.Size(221, 20);
            this.TxBFilter.TabIndex = 144;
            this.TxBFilter.Tag = "";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(91, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 143;
            this.label9.Text = "Principi actiu:";
            // 
            // customTextBox7
            // 
            this.customTextBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox7.Location = new System.Drawing.Point(184, 113);
            this.customTextBox7.Name = "customTextBox7";
            this.customTextBox7.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox7.Placeholder = null;
            this.customTextBox7.Size = new System.Drawing.Size(197, 20);
            this.customTextBox7.TabIndex = 142;
            this.customTextBox7.Tag = "generic";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(488, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 141;
            this.label11.Text = "Prospecte:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(476, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 140;
            this.label12.Text = "Fitxa tècnica:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.Location = new System.Drawing.Point(445, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 16);
            this.label13.TabIndex = 139;
            this.label13.Text = "Quantitat en stock:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.Location = new System.Drawing.Point(514, -25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 138;
            this.label14.Text = "% IVA:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label15.Location = new System.Drawing.Point(523, -52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 16);
            this.label15.TabIndex = 137;
            this.label15.Text = "PVP:";
            // 
            // customTextBox9
            // 
            this.customTextBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox9.Location = new System.Drawing.Point(567, -53);
            this.customTextBox9.Name = "customTextBox9";
            this.customTextBox9.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox9.Placeholder = null;
            this.customTextBox9.Size = new System.Drawing.Size(197, 20);
            this.customTextBox9.TabIndex = 136;
            this.customTextBox9.Tag = "PVP";
            // 
            // customTextBox10
            // 
            this.customTextBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox10.Location = new System.Drawing.Point(567, -27);
            this.customTextBox10.Name = "customTextBox10";
            this.customTextBox10.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox10.Placeholder = null;
            this.customTextBox10.Size = new System.Drawing.Size(197, 20);
            this.customTextBox10.TabIndex = 135;
            this.customTextBox10.Tag = "iva";
            // 
            // customTextBox11
            // 
            this.customTextBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox11.Location = new System.Drawing.Point(567, 54);
            this.customTextBox11.Name = "customTextBox11";
            this.customTextBox11.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox11.Placeholder = null;
            this.customTextBox11.Size = new System.Drawing.Size(197, 20);
            this.customTextBox11.TabIndex = 134;
            this.customTextBox11.Tag = "url_prospecte";
            // 
            // customTextBox12
            // 
            this.customTextBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox12.Location = new System.Drawing.Point(567, 26);
            this.customTextBox12.Name = "customTextBox12";
            this.customTextBox12.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox12.Placeholder = null;
            this.customTextBox12.Size = new System.Drawing.Size(197, 20);
            this.customTextBox12.TabIndex = 133;
            this.customTextBox12.Tag = "url_fitxa_tecnica";
            // 
            // customTextBox13
            // 
            this.customTextBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox13.Location = new System.Drawing.Point(567, 0);
            this.customTextBox13.Name = "customTextBox13";
            this.customTextBox13.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox13.Placeholder = null;
            this.customTextBox13.Size = new System.Drawing.Size(197, 20);
            this.customTextBox13.TabIndex = 132;
            this.customTextBox13.Tag = "stock";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(498, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 131;
            this.label8.Text = "Recepta:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(119, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 130;
            this.label7.Text = "Genèric:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(97, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 129;
            this.label6.Text = "Substituïble:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(111, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 128;
            this.label4.Text = "Contingut:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(105, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 127;
            this.label3.Text = "Laboratori:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(62, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 126;
            this.label1.Text = "Registre nacional:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(76, -42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 125;
            this.label5.Text = "Nom comercial:";
            // 
            // customTextBox4
            // 
            this.customTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox4.Location = new System.Drawing.Point(567, 80);
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox4.Placeholder = null;
            this.customTextBox4.Size = new System.Drawing.Size(197, 20);
            this.customTextBox4.TabIndex = 122;
            this.customTextBox4.Tag = "recepta";
            // 
            // customTextBox3
            // 
            this.customTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox3.Location = new System.Drawing.Point(184, 87);
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox3.Placeholder = null;
            this.customTextBox3.Size = new System.Drawing.Size(197, 20);
            this.customTextBox3.TabIndex = 121;
            this.customTextBox3.Tag = "substituible";
            // 
            // customTextBox6
            // 
            this.customTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox6.Location = new System.Drawing.Point(184, -46);
            this.customTextBox6.Name = "customTextBox6";
            this.customTextBox6.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox6.Placeholder = null;
            this.customTextBox6.Size = new System.Drawing.Size(197, 20);
            this.customTextBox6.TabIndex = 124;
            this.customTextBox6.Tag = "nom_comercial";
            // 
            // customTextBox5
            // 
            this.customTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox5.Location = new System.Drawing.Point(184, -20);
            this.customTextBox5.Name = "customTextBox5";
            this.customTextBox5.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox5.Placeholder = null;
            this.customTextBox5.Size = new System.Drawing.Size(197, 20);
            this.customTextBox5.TabIndex = 123;
            this.customTextBox5.Tag = "registre_nacional";
            // 
            // customTextBox2
            // 
            this.customTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox2.Location = new System.Drawing.Point(184, 61);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox2.Placeholder = null;
            this.customTextBox2.Size = new System.Drawing.Size(197, 20);
            this.customTextBox2.TabIndex = 120;
            this.customTextBox2.Tag = "contingut";
            // 
            // customTextBox1
            // 
            this.customTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox1.Location = new System.Drawing.Point(184, 33);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox1.Placeholder = null;
            this.customTextBox1.Size = new System.Drawing.Size(197, 20);
            this.customTextBox1.TabIndex = 119;
            this.customTextBox1.Tag = "id_PrincipiActiu";
            // 
            // CCcodi
            // 
            this.CCcodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcodi.Location = new System.Drawing.Point(389, 8);
            this.CCcodi.Name = "CCcodi";
            this.CCcodi.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcodi.Placeholder = null;
            this.CCcodi.Size = new System.Drawing.Size(25, 20);
            this.CCcodi.TabIndex = 118;
            this.CCcodi.Tag = "id_laboratori";
            this.CCcodi.TextChanged += new System.EventHandler(this.CCcodi_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, -102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 24);
            this.label2.TabIndex = 117;
            this.label2.Text = "Manteniment de productes";
            // 
            // MComboBox
            // 
            this.MComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MComboBox.FormattingEnabled = true;
            this.MComboBox.Location = new System.Drawing.Point(184, 6);
            this.MComboBox.Name = "MComboBox";
            this.MComboBox.Reference = "laboratoris_farmaceutics";
            this.MComboBox.Size = new System.Drawing.Size(197, 21);
            this.MComboBox.TabIndex = 147;
            this.MComboBox.SelectedIndexChanged += new System.EventHandler(this.McomboBox_SelectedIndexChanged);
            // 
            // MantenimentProductesX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.MComboBox);
            this.Controls.Add(this.cbProds);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.TxBFilter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customTextBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.customTextBox9);
            this.Controls.Add(this.customTextBox10);
            this.Controls.Add(this.customTextBox11);
            this.Controls.Add(this.customTextBox12);
            this.Controls.Add(this.customTextBox13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customTextBox4);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox6);
            this.Controls.Add(this.customTextBox5);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.CCcodi);
            this.Controls.Add(this.label2);
            this.Name = "MantenimentProductesX";
            this.Load += new System.EventHandler(this.MantenimentProductesX_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CCcodi, 0);
            this.Controls.SetChildIndex(this.customTextBox1, 0);
            this.Controls.SetChildIndex(this.customTextBox2, 0);
            this.Controls.SetChildIndex(this.customTextBox5, 0);
            this.Controls.SetChildIndex(this.customTextBox6, 0);
            this.Controls.SetChildIndex(this.customTextBox3, 0);
            this.Controls.SetChildIndex(this.customTextBox4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.customTextBox13, 0);
            this.Controls.SetChildIndex(this.customTextBox12, 0);
            this.Controls.SetChildIndex(this.customTextBox11, 0);
            this.Controls.SetChildIndex(this.customTextBox10, 0);
            this.Controls.SetChildIndex(this.customTextBox9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.customTextBox7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.TxBFilter, 0);
            this.Controls.SetChildIndex(this.lblFiltrar, 0);
            this.Controls.SetChildIndex(this.cbProds, 0);
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnAfegir, 0);
            this.Controls.SetChildIndex(this.MComboBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProds;
        private System.Windows.Forms.Label lblFiltrar;
        private CustomControl.CustomTextBox TxBFilter;
        private System.Windows.Forms.Label label9;
        private CustomControl.CustomTextBox customTextBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private CustomControl.CustomTextBox customTextBox9;
        private CustomControl.CustomTextBox customTextBox10;
        private CustomControl.CustomTextBox customTextBox11;
        private CustomControl.CustomTextBox customTextBox12;
        private CustomControl.CustomTextBox customTextBox13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private CustomControl.CustomTextBox customTextBox4;
        private CustomControl.CustomTextBox customTextBox3;
        private CustomControl.CustomTextBox customTextBox6;
        private CustomControl.CustomTextBox customTextBox5;
        private CustomControl.CustomTextBox customTextBox2;
        private CustomControl.CustomTextBox customTextBox1;
        private CustomControl.CustomTextBox CCcodi;
        private System.Windows.Forms.Label label2;
        private CustomControl.comboBox MComboBox;
    }
}
