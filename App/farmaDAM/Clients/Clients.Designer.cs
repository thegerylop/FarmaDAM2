namespace Clients
{
    partial class Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAfegir = new System.Windows.Forms.Button();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.CcomboBox = new CustomControl.comboBox();
            this.TxBFilter = new CustomControl.CustomTextBox();
            this.CAdreça = new CustomControl.CustomTextBox();
            this.CCognom1 = new CustomControl.CustomTextBox();
            this.CCognom2 = new CustomControl.CustomTextBox();
            this.CCcodi = new CustomControl.CustomTextBox();
            this.CNom = new CustomControl.CustomTextBox();
            this.CTargeta = new CustomControl.CustomTextBox();
            this.customTextBox1 = new CustomControl.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(16, 182);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 18);
            this.lblFiltrar.TabIndex = 85;
            this.lblFiltrar.Text = "Filtrar :";
            // 
            // cbClients
            // 
            this.cbClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClients.AutoCompleteCustomSource.AddRange(new string[] {
            "codi_laboratori",
            "rao_social",
            "cif",
            "denominacio"});
            this.cbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Items.AddRange(new object[] {
            "dni",
            "t_sanitaria",
            "nom"});
            this.cbClients.Location = new System.Drawing.Point(298, 182);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(121, 21);
            this.cbClients.TabIndex = 84;
            this.cbClients.SelectedValueChanged += new System.EventHandler(this.cbClients_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(148, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 81;
            this.label3.Text = "1r Cognom :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(145, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "2n Cognom :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(552, -29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 79;
            this.label1.Text = "Adreça :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(517, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 78;
            this.label7.Text = "Tipus Carnet :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(490, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 77;
            this.label6.Text = "Targeta Sanitaria :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(190, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(198, -27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 75;
            this.label4.Tag = "dni";
            this.label4.Text = "DNI :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, -93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 73;
            this.label8.Text = "Clients";
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.clientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Location = new System.Drawing.Point(19, 221);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(873, 255);
            this.clientsDataGridView.TabIndex = 86;
            // 
            // btnAfegir
            // 
            this.btnAfegir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAfegir.BackColor = System.Drawing.Color.DimGray;
            this.btnAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAfegir.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnAfegir.ForeColor = System.Drawing.Color.White;
            this.btnAfegir.Location = new System.Drawing.Point(596, 182);
            this.btnAfegir.Name = "btnAfegir";
            this.btnAfegir.Size = new System.Drawing.Size(117, 26);
            this.btnAfegir.TabIndex = 88;
            this.btnAfegir.Text = "Afegir";
            this.btnAfegir.UseVisualStyleBackColor = false;
            this.btnAfegir.Click += new System.EventHandler(this.btnAfegir_Click);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualitzar.BackColor = System.Drawing.Color.DimGray;
            this.btnActualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualitzar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnActualitzar.ForeColor = System.Drawing.Color.White;
            this.btnActualitzar.Location = new System.Drawing.Point(719, 182);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(132, 26);
            this.btnActualitzar.TabIndex = 87;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = false;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // CcomboBox
            // 
            this.CcomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CcomboBox.FormattingEnabled = true;
            this.CcomboBox.Location = new System.Drawing.Point(623, 68);
            this.CcomboBox.Name = "CcomboBox";
            this.CcomboBox.Reference = "tipus_carnet";
            this.CcomboBox.Size = new System.Drawing.Size(197, 21);
            this.CcomboBox.TabIndex = 89;
            this.CcomboBox.Tag = "";
            this.CcomboBox.SelectedValueChanged += new System.EventHandler(this.CcomboBox_SelectedValueChanged);
            // 
            // TxBFilter
            // 
            this.TxBFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBFilter.Location = new System.Drawing.Point(71, 182);
            this.TxBFilter.Name = "TxBFilter";
            this.TxBFilter.Options = CustomControl.CustomTextBox.Items.Text;
            this.TxBFilter.Placeholder = null;
            this.TxBFilter.Size = new System.Drawing.Size(221, 20);
            this.TxBFilter.TabIndex = 83;
            this.TxBFilter.Tag = "";
            this.TxBFilter.TextChanged += new System.EventHandler(this.TxBFilter_TextChanged);
            // 
            // CAdreça
            // 
            this.CAdreça.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CAdreça.Location = new System.Drawing.Point(623, -28);
            this.CAdreça.Name = "CAdreça";
            this.CAdreça.Options = CustomControl.CustomTextBox.Items.Text;
            this.CAdreça.Placeholder = null;
            this.CAdreça.Size = new System.Drawing.Size(197, 20);
            this.CAdreça.TabIndex = 82;
            this.CAdreça.Tag = "direccio";
            // 
            // CCognom1
            // 
            this.CCognom1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCognom1.Location = new System.Drawing.Point(248, 69);
            this.CCognom1.Name = "CCognom1";
            this.CCognom1.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCognom1.Placeholder = null;
            this.CCognom1.Size = new System.Drawing.Size(197, 20);
            this.CCognom1.TabIndex = 69;
            this.CCognom1.Tag = "cognom1";
            // 
            // CCognom2
            // 
            this.CCognom2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCognom2.Location = new System.Drawing.Point(248, 111);
            this.CCognom2.Name = "CCognom2";
            this.CCognom2.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCognom2.Placeholder = null;
            this.CCognom2.Size = new System.Drawing.Size(197, 20);
            this.CCognom2.TabIndex = 70;
            this.CCognom2.Tag = "cognom2";
            // 
            // CCcodi
            // 
            this.CCcodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcodi.Location = new System.Drawing.Point(248, -28);
            this.CCcodi.Name = "CCcodi";
            this.CCcodi.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcodi.Placeholder = null;
            this.CCcodi.Size = new System.Drawing.Size(197, 20);
            this.CCcodi.TabIndex = 74;
            this.CCcodi.Tag = "dni";
            // 
            // CNom
            // 
            this.CNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CNom.Location = new System.Drawing.Point(248, 21);
            this.CNom.Name = "CNom";
            this.CNom.Options = CustomControl.CustomTextBox.Items.Text;
            this.CNom.Placeholder = null;
            this.CNom.Size = new System.Drawing.Size(197, 20);
            this.CNom.TabIndex = 68;
            this.CNom.Tag = "nom";
            // 
            // CTargeta
            // 
            this.CTargeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTargeta.Location = new System.Drawing.Point(623, 16);
            this.CTargeta.Name = "CTargeta";
            this.CTargeta.Options = CustomControl.CustomTextBox.Items.Text;
            this.CTargeta.Placeholder = null;
            this.CTargeta.Size = new System.Drawing.Size(197, 20);
            this.CTargeta.TabIndex = 71;
            this.CTargeta.Tag = "t_sanitaria";
            // 
            // customTextBox1
            // 
            this.customTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox1.Location = new System.Drawing.Point(451, 112);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox1.Placeholder = null;
            this.customTextBox1.Size = new System.Drawing.Size(1, 20);
            this.customTextBox1.TabIndex = 90;
            this.customTextBox1.TabStop = false;
            this.customTextBox1.Tag = "tipus_carnet";
            this.customTextBox1.TextChanged += new System.EventHandler(this.customTextBox1_TextChanged);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.CcomboBox);
            this.Controls.Add(this.btnAfegir);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.TxBFilter);
            this.Controls.Add(this.CAdreça);
            this.Controls.Add(this.CCognom1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CCognom2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CCcodi);
            this.Controls.Add(this.CNom);
            this.Controls.Add(this.CTargeta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbClients;
        private CustomControl.CustomTextBox TxBFilter;
        private CustomControl.CustomTextBox CAdreça;
        private CustomControl.CustomTextBox CCognom1;
        private System.Windows.Forms.Label label3;
        private CustomControl.CustomTextBox CCognom2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControl.CustomTextBox CCcodi;
        private CustomControl.CustomTextBox CNom;
        private CustomControl.CustomTextBox CTargeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        public System.Windows.Forms.Button btnAfegir;
        public System.Windows.Forms.Button btnActualitzar;
        private CustomControl.comboBox CcomboBox;
        private CustomControl.CustomTextBox customTextBox1;
    }
}