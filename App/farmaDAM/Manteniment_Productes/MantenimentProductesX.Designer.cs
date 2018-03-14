namespace Manteniment_Productes
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.customTextBox9 = new CustomControl.CustomTextBox();
            this.customTextBox10 = new CustomControl.CustomTextBox();
            this.CCPros = new CustomControl.CustomTextBox();
            this.CCFitxa = new CustomControl.CustomTextBox();
            this.customTextBox13 = new CustomControl.CustomTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CCRec = new CustomControl.CustomTextBox();
            this.customTextBox6 = new CustomControl.CustomTextBox();
            this.customTextBox5 = new CustomControl.CustomTextBox();
            this.customTextBox2 = new CustomControl.CustomTextBox();
            this.customTextBox1 = new CustomControl.CustomTextBox();
            this.CCcodi = new CustomControl.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MComboBox = new CustomControl.comboBox();
            this.cboxGeneric = new CustomControl.comboBox();
            this.txtSubs = new CustomControl.CustomTextBox();
            this.txtGen = new CustomControl.CustomTextBox();
            this.cboxSubs = new System.Windows.Forms.ComboBox();
            this.ComboRec = new System.Windows.Forms.ComboBox();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnAfegir
            // 
            this.btnAfegir.Location = new System.Drawing.Point(361, 177);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(484, 177);
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
            this.cbProds.Location = new System.Drawing.Point(115, 181);
            this.cbProds.Name = "cbProds";
            this.cbProds.Size = new System.Drawing.Size(121, 21);
            this.cbProds.TabIndex = 145;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(-171, 181);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 18);
            this.lblFiltrar.TabIndex = 146;
            this.lblFiltrar.Text = "Filtrar :";
            // 
            // TxBFilter
            // 
            this.TxBFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBFilter.Location = new System.Drawing.Point(-112, 181);
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
            this.label9.Location = new System.Drawing.Point(-87, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 143;
            this.label9.Text = "Principi actiu:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(310, 54);
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
            this.label12.Location = new System.Drawing.Point(298, 26);
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
            this.label13.Location = new System.Drawing.Point(267, 2);
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
            this.label14.Location = new System.Drawing.Point(336, -25);
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
            this.label15.Location = new System.Drawing.Point(345, -52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 16);
            this.label15.TabIndex = 137;
            this.label15.Text = "PVP:";
            // 
            // customTextBox9
            // 
            this.customTextBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox9.Location = new System.Drawing.Point(389, -53);
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
            this.customTextBox10.Location = new System.Drawing.Point(389, -27);
            this.customTextBox10.Name = "customTextBox10";
            this.customTextBox10.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox10.Placeholder = null;
            this.customTextBox10.Size = new System.Drawing.Size(197, 20);
            this.customTextBox10.TabIndex = 135;
            this.customTextBox10.Tag = "iva";
            // 
            // CCPros
            // 
            this.CCPros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCPros.Location = new System.Drawing.Point(389, 54);
            this.CCPros.Name = "CCPros";
            this.CCPros.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCPros.Placeholder = null;
            this.CCPros.Size = new System.Drawing.Size(197, 20);
            this.CCPros.TabIndex = 134;
            this.CCPros.Tag = "url_prospecte";
            this.CCPros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CCPros_KeyPress);
            // 
            // CCFitxa
            // 
            this.CCFitxa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCFitxa.Enabled = false;
            this.CCFitxa.Location = new System.Drawing.Point(389, 26);
            this.CCFitxa.Name = "CCFitxa";
            this.CCFitxa.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCFitxa.Placeholder = null;
            this.CCFitxa.Size = new System.Drawing.Size(197, 20);
            this.CCFitxa.TabIndex = 133;
            this.CCFitxa.Tag = "url_fitxa_tecnica";
            this.CCFitxa.TextChanged += new System.EventHandler(this.CCFitxa_TextChanged);
            // 
            // customTextBox13
            // 
            this.customTextBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox13.Location = new System.Drawing.Point(389, 0);
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
            this.label8.Location = new System.Drawing.Point(320, 80);
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
            this.label7.Location = new System.Drawing.Point(-59, 114);
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
            this.label6.Location = new System.Drawing.Point(-81, 91);
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
            this.label4.Location = new System.Drawing.Point(-67, 65);
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
            this.label3.Location = new System.Drawing.Point(-73, 12);
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
            this.label1.Location = new System.Drawing.Point(-116, -15);
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
            this.label5.Location = new System.Drawing.Point(-102, -42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 125;
            this.label5.Text = "Nom comercial:";
            // 
            // CCRec
            // 
            this.CCRec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCRec.Enabled = false;
            this.CCRec.Location = new System.Drawing.Point(592, 79);
            this.CCRec.Name = "CCRec";
            this.CCRec.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCRec.Placeholder = null;
            this.CCRec.Size = new System.Drawing.Size(24, 20);
            this.CCRec.TabIndex = 122;
            this.CCRec.Tag = "recepta";
            this.CCRec.TextChanged += new System.EventHandler(this.customTextBox4_TextChanged);
            // 
            // customTextBox6
            // 
            this.customTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox6.Location = new System.Drawing.Point(6, -46);
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
            this.customTextBox5.Location = new System.Drawing.Point(6, -20);
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
            this.customTextBox2.Location = new System.Drawing.Point(6, 61);
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
            this.customTextBox1.Location = new System.Drawing.Point(6, 33);
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
            this.CCcodi.Location = new System.Drawing.Point(211, 8);
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
            this.label2.Location = new System.Drawing.Point(165, -102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 24);
            this.label2.TabIndex = 117;
            this.label2.Text = "Manteniment de productes";
            // 
            // MComboBox
            // 
            this.MComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MComboBox.FormattingEnabled = true;
            this.MComboBox.Location = new System.Drawing.Point(6, 6);
            this.MComboBox.Name = "MComboBox";
            this.MComboBox.Reference = "laboratoris_farmaceutics";
            this.MComboBox.Size = new System.Drawing.Size(197, 21);
            this.MComboBox.TabIndex = 147;
            this.MComboBox.SelectedValueChanged += new System.EventHandler(this.MComboBox_SelectedValueChanged);
            // 
            // cboxGeneric
            // 
            this.cboxGeneric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxGeneric.AutoCompleteCustomSource.AddRange(new string[] {
            "Si",
            "No"});
            this.cboxGeneric.FormattingEnabled = true;
            this.cboxGeneric.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cboxGeneric.Location = new System.Drawing.Point(6, 113);
            this.cboxGeneric.Name = "cboxGeneric";
            this.cboxGeneric.Reference = null;
            this.cboxGeneric.Size = new System.Drawing.Size(197, 21);
            this.cboxGeneric.TabIndex = 149;
            this.cboxGeneric.SelectedIndexChanged += new System.EventHandler(this.cboxGeneric_SelectedIndexChanged);
            // 
            // txtSubs
            // 
            this.txtSubs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubs.Location = new System.Drawing.Point(209, 87);
            this.txtSubs.Name = "txtSubs";
            this.txtSubs.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtSubs.Placeholder = null;
            this.txtSubs.Size = new System.Drawing.Size(25, 20);
            this.txtSubs.TabIndex = 150;
            this.txtSubs.Tag = "substituible";
            this.txtSubs.TextChanged += new System.EventHandler(this.txtSubs_TextChanged);
            // 
            // txtGen
            // 
            this.txtGen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGen.Location = new System.Drawing.Point(209, 113);
            this.txtGen.Name = "txtGen";
            this.txtGen.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtGen.Placeholder = null;
            this.txtGen.Size = new System.Drawing.Size(25, 20);
            this.txtGen.TabIndex = 151;
            this.txtGen.Tag = "generic";
            this.txtGen.TextChanged += new System.EventHandler(this.txtGen_TextChanged);
            // 
            // cboxSubs
            // 
            this.cboxSubs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxSubs.FormattingEnabled = true;
            this.cboxSubs.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cboxSubs.Location = new System.Drawing.Point(6, 87);
            this.cboxSubs.Name = "cboxSubs";
            this.cboxSubs.Size = new System.Drawing.Size(197, 21);
            this.cboxSubs.TabIndex = 152;
            this.cboxSubs.SelectedIndexChanged += new System.EventHandler(this.cboxSubs_SelectedIndexChanged);
            // 
            // ComboRec
            // 
            this.ComboRec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboRec.FormattingEnabled = true;
            this.ComboRec.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.ComboRec.Location = new System.Drawing.Point(389, 79);
            this.ComboRec.Name = "ComboRec";
            this.ComboRec.Size = new System.Drawing.Size(197, 21);
            this.ComboRec.TabIndex = 153;
            this.ComboRec.SelectedIndexChanged += new System.EventHandler(this.ComboRec_SelectedIndexChanged);
            // 
            // Browser
            // 
            this.Browser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Browser.Location = new System.Drawing.Point(720, -164);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(406, 641);
            this.Browser.TabIndex = 154;
            this.Browser.Url = new System.Uri("https://www.aemps.gob.es/home.htm", System.UriKind.Absolute);
            // 
            // MantenimentProductesX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.ComboRec);
            this.Controls.Add(this.cboxSubs);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtSubs);
            this.Controls.Add(this.cboxGeneric);
            this.Controls.Add(this.MComboBox);
            this.Controls.Add(this.cbProds);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.TxBFilter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.customTextBox9);
            this.Controls.Add(this.customTextBox10);
            this.Controls.Add(this.CCPros);
            this.Controls.Add(this.CCFitxa);
            this.Controls.Add(this.customTextBox13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CCRec);
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
            this.Controls.SetChildIndex(this.CCRec, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.customTextBox13, 0);
            this.Controls.SetChildIndex(this.CCFitxa, 0);
            this.Controls.SetChildIndex(this.CCPros, 0);
            this.Controls.SetChildIndex(this.customTextBox10, 0);
            this.Controls.SetChildIndex(this.customTextBox9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.TxBFilter, 0);
            this.Controls.SetChildIndex(this.lblFiltrar, 0);
            this.Controls.SetChildIndex(this.cbProds, 0);
            this.Controls.SetChildIndex(this.MComboBox, 0);
            this.Controls.SetChildIndex(this.cboxGeneric, 0);
            this.Controls.SetChildIndex(this.txtSubs, 0);
            this.Controls.SetChildIndex(this.txtGen, 0);
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnAfegir, 0);
            this.Controls.SetChildIndex(this.cboxSubs, 0);
            this.Controls.SetChildIndex(this.ComboRec, 0);
            this.Controls.SetChildIndex(this.Browser, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProds;
        private System.Windows.Forms.Label lblFiltrar;
        private CustomControl.CustomTextBox TxBFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private CustomControl.CustomTextBox customTextBox9;
        private CustomControl.CustomTextBox customTextBox10;
        private CustomControl.CustomTextBox CCPros;
        private CustomControl.CustomTextBox CCFitxa;
        private CustomControl.CustomTextBox customTextBox13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private CustomControl.CustomTextBox CCRec;
        private CustomControl.CustomTextBox customTextBox6;
        private CustomControl.CustomTextBox customTextBox5;
        private CustomControl.CustomTextBox customTextBox2;
        private CustomControl.CustomTextBox customTextBox1;
        private CustomControl.CustomTextBox CCcodi;
        private System.Windows.Forms.Label label2;
        private CustomControl.comboBox MComboBox;
        private CustomControl.comboBox cboxGeneric;
        private CustomControl.CustomTextBox txtSubs;
        private CustomControl.CustomTextBox txtGen;
        private System.Windows.Forms.ComboBox cboxSubs;
        private System.Windows.Forms.ComboBox ComboRec;
        private System.Windows.Forms.WebBrowser Browser;
    }
}
