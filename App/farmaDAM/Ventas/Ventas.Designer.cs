namespace Ventas
{
    partial class Ventas
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
            this.lblVentas = new System.Windows.Forms.Label();
            this.groupBoxMed = new System.Windows.Forms.GroupBox();
            this.CcQuant = new CustomControl.comboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.TxBFilter = new CustomControl.CustomTextBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.listViewCompra = new System.Windows.Forms.ListView();
            this.Medicament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IVA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantitat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxLlista = new System.Windows.Forms.GroupBox();
            this.btnAcceptar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblPreu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.Tancar = new System.Windows.Forms.Button();
            this.CCpassword = new CustomControl.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CClogin = new CustomControl.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TBClient = new CustomControl.CustomTextBox();
            this.CcomboBox = new CustomControl.comboBox();
            this.gbRecepta = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBRec = new CustomControl.CustomTextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.groupBoxMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.groupBoxLlista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.gbRecepta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblVentas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVentas.Location = new System.Drawing.Point(419, 45);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(68, 24);
            this.lblVentas.TabIndex = 2;
            this.lblVentas.Text = "Ventas";
            // 
            // groupBoxMed
            // 
            this.groupBoxMed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxMed.Controls.Add(this.CcQuant);
            this.groupBoxMed.Controls.Add(this.lblFiltrar);
            this.groupBoxMed.Controls.Add(this.TxBFilter);
            this.groupBoxMed.Controls.Add(this.dgvVentas);
            this.groupBoxMed.Location = new System.Drawing.Point(-116, 242);
            this.groupBoxMed.Name = "groupBoxMed";
            this.groupBoxMed.Size = new System.Drawing.Size(539, 335);
            this.groupBoxMed.TabIndex = 51;
            this.groupBoxMed.TabStop = false;
            // 
            // CcQuant
            // 
            this.CcQuant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CcQuant.FormattingEnabled = true;
            this.CcQuant.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CcQuant.Location = new System.Drawing.Point(253, 15);
            this.CcQuant.Name = "CcQuant";
            this.CcQuant.Reference = null;
            this.CcQuant.Size = new System.Drawing.Size(41, 21);
            this.CcQuant.TabIndex = 90;
            this.CcQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBFilter_KeyPress);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblFiltrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFiltrar.Location = new System.Drawing.Point(3, 16);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(97, 18);
            this.lblFiltrar.TabIndex = 88;
            this.lblFiltrar.Text = "Medicament :";
            // 
            // TxBFilter
            // 
            this.TxBFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBFilter.Location = new System.Drawing.Point(115, 16);
            this.TxBFilter.Name = "TxBFilter";
            this.TxBFilter.Options = CustomControl.CustomTextBox.Items.Text;
            this.TxBFilter.Placeholder = null;
            this.TxBFilter.Size = new System.Drawing.Size(119, 20);
            this.TxBFilter.TabIndex = 86;
            this.TxBFilter.Tag = "";
            this.TxBFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBFilter_KeyPress);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(5, 70);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(522, 259);
            this.dgvVentas.TabIndex = 51;
            this.dgvVentas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentDoubleClick);
            // 
            // listViewCompra
            // 
            this.listViewCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Medicament,
            this.Preu,
            this.IVA,
            this.Quantitat});
            this.listViewCompra.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCompra.Location = new System.Drawing.Point(12, 47);
            this.listViewCompra.Name = "listViewCompra";
            this.listViewCompra.Size = new System.Drawing.Size(266, 356);
            this.listViewCompra.TabIndex = 52;
            this.listViewCompra.UseCompatibleStateImageBehavior = false;
            this.listViewCompra.View = System.Windows.Forms.View.Details;
            this.listViewCompra.ItemActivate += new System.EventHandler(this.listViewCompra_ItemActivate);
            // 
            // Medicament
            // 
            this.Medicament.Text = "Medicament";
            this.Medicament.Width = 72;
            // 
            // Preu
            // 
            this.Preu.Text = "Preu";
            // 
            // IVA
            // 
            this.IVA.Text = "IVA";
            // 
            // Quantitat
            // 
            this.Quantitat.Text = "Quantitat";
            // 
            // groupBoxLlista
            // 
            this.groupBoxLlista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxLlista.Controls.Add(this.btnAcceptar);
            this.groupBoxLlista.Controls.Add(this.lblTotal);
            this.groupBoxLlista.Controls.Add(this.lblTicket);
            this.groupBoxLlista.Controls.Add(this.lblPreu);
            this.groupBoxLlista.Controls.Add(this.listViewCompra);
            this.groupBoxLlista.Location = new System.Drawing.Point(604, 90);
            this.groupBoxLlista.Name = "groupBoxLlista";
            this.groupBoxLlista.Size = new System.Drawing.Size(297, 487);
            this.groupBoxLlista.TabIndex = 53;
            this.groupBoxLlista.TabStop = false;
            // 
            // btnAcceptar
            // 
            this.btnAcceptar.BackColor = System.Drawing.Color.DimGray;
            this.btnAcceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceptar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnAcceptar.ForeColor = System.Drawing.Color.White;
            this.btnAcceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAcceptar.Location = new System.Drawing.Point(181, 436);
            this.btnAcceptar.Name = "btnAcceptar";
            this.btnAcceptar.Size = new System.Drawing.Size(70, 22);
            this.btnAcceptar.TabIndex = 56;
            this.btnAcceptar.Text = "Acceptar";
            this.btnAcceptar.UseVisualStyleBackColor = false;
            this.btnAcceptar.Click += new System.EventHandler(this.btnAcceptar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotal.Location = new System.Drawing.Point(67, 436);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 18);
            this.lblTotal.TabIndex = 55;
            // 
            // lblTicket
            // 
            this.lblTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTicket.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTicket.Location = new System.Drawing.Point(9, 12);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(69, 18);
            this.lblTicket.TabIndex = 53;
            this.lblTicket.Text = "Ticket nº ";
            // 
            // lblPreu
            // 
            this.lblPreu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreu.AutoSize = true;
            this.lblPreu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPreu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPreu.Location = new System.Drawing.Point(12, 436);
            this.lblPreu.Name = "lblPreu";
            this.lblPreu.Size = new System.Drawing.Size(49, 18);
            this.lblPreu.TabIndex = 54;
            this.lblPreu.Text = "Total :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.Tancar);
            this.groupBox1.Controls.Add(this.CCpassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CClogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 117);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DimGray;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_login.Location = new System.Drawing.Point(139, 87);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(70, 22);
            this.btn_login.TabIndex = 58;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Tancar
            // 
            this.Tancar.BackColor = System.Drawing.Color.DimGray;
            this.Tancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tancar.Font = new System.Drawing.Font("Verdana", 9F);
            this.Tancar.ForeColor = System.Drawing.Color.White;
            this.Tancar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Tancar.Location = new System.Drawing.Point(139, 87);
            this.Tancar.Name = "Tancar";
            this.Tancar.Size = new System.Drawing.Size(70, 22);
            this.Tancar.TabIndex = 57;
            this.Tancar.Text = "Tancar";
            this.Tancar.UseVisualStyleBackColor = false;
            this.Tancar.Visible = false;
            this.Tancar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CCpassword
            // 
            this.CCpassword.Location = new System.Drawing.Point(88, 56);
            this.CCpassword.Name = "CCpassword";
            this.CCpassword.Options = CustomControl.CustomTextBox.Items.Password;
            this.CCpassword.Placeholder = "Password";
            this.CCpassword.Size = new System.Drawing.Size(121, 20);
            this.CCpassword.TabIndex = 2;
            this.CCpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CCpassword_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(7, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "Password";
            // 
            // CClogin
            // 
            this.CClogin.Location = new System.Drawing.Point(88, 19);
            this.CClogin.Name = "CClogin";
            this.CClogin.Options = CustomControl.CustomTextBox.Items.Text;
            this.CClogin.Placeholder = "Login";
            this.CClogin.Size = new System.Drawing.Size(121, 20);
            this.CClogin.TabIndex = 1;
            this.CClogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CClogin_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(38, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Login";
            // 
            // gbClient
            // 
            this.gbClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbClient.Controls.Add(this.btn_buscar);
            this.gbClient.Controls.Add(this.label5);
            this.gbClient.Controls.Add(this.TBClient);
            this.gbClient.Controls.Add(this.CcomboBox);
            this.gbClient.Location = new System.Drawing.Point(-116, 121);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(460, 52);
            this.gbClient.TabIndex = 54;
            this.gbClient.TabStop = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.DimGray;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_buscar.Location = new System.Drawing.Point(327, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(107, 22);
            this.btn_buscar.TabIndex = 59;
            this.btn_buscar.Text = "Buscar client";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Client :";
            // 
            // TBClient
            // 
            this.TBClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBClient.Location = new System.Drawing.Point(63, 20);
            this.TBClient.Name = "TBClient";
            this.TBClient.Options = CustomControl.CustomTextBox.Items.Text;
            this.TBClient.Placeholder = null;
            this.TBClient.Size = new System.Drawing.Size(121, 20);
            this.TBClient.TabIndex = 3;
            this.TBClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBClient_KeyPress);
            // 
            // CcomboBox
            // 
            this.CcomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CcomboBox.FormattingEnabled = true;
            this.CcomboBox.Items.AddRange(new object[] {
            "DNI",
            "Targeta sanitaria"});
            this.CcomboBox.Location = new System.Drawing.Point(199, 20);
            this.CcomboBox.Name = "CcomboBox";
            this.CcomboBox.Reference = null;
            this.CcomboBox.Size = new System.Drawing.Size(107, 21);
            this.CcomboBox.TabIndex = 4;
            // 
            // gbRecepta
            // 
            this.gbRecepta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbRecepta.Controls.Add(this.label7);
            this.gbRecepta.Controls.Add(this.TBRec);
            this.gbRecepta.Location = new System.Drawing.Point(-116, 184);
            this.gbRecepta.Name = "gbRecepta";
            this.gbRecepta.Size = new System.Drawing.Size(460, 52);
            this.gbRecepta.TabIndex = 55;
            this.gbRecepta.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(4, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Recepta :";
            // 
            // TBRec
            // 
            this.TBRec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBRec.Location = new System.Drawing.Point(81, 21);
            this.TBRec.Name = "TBRec";
            this.TBRec.Options = CustomControl.CustomTextBox.Items.Text;
            this.TBRec.Placeholder = null;
            this.TBRec.Size = new System.Drawing.Size(121, 20);
            this.TBRec.TabIndex = 3;
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.UserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserName.Location = new System.Drawing.Point(-111, 102);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(0, 18);
            this.UserName.TabIndex = 91;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 602);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.gbRecepta);
            this.Controls.Add(this.gbClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxLlista);
            this.Controls.Add(this.groupBoxMed);
            this.Controls.Add(this.lblVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBoxMed.ResumeLayout(false);
            this.groupBoxMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.groupBoxLlista.ResumeLayout(false);
            this.groupBoxLlista.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbRecepta.ResumeLayout(false);
            this.gbRecepta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.GroupBox groupBoxMed;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ListView listViewCompra;
        private System.Windows.Forms.GroupBox groupBoxLlista;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.ColumnHeader Medicament;
        private System.Windows.Forms.ColumnHeader Preu;
        private System.Windows.Forms.ColumnHeader Quantitat;
        private System.Windows.Forms.ColumnHeader IVA;
        private System.Windows.Forms.Label lblPreu;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Button btnAcceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Label label5;
        private CustomControl.CustomTextBox TBClient;
        private CustomControl.comboBox CcomboBox;
        private CustomControl.CustomTextBox CClogin;
        private CustomControl.CustomTextBox CCpassword;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button Tancar;
        private System.Windows.Forms.Label lblFiltrar;
        private CustomControl.CustomTextBox TxBFilter;
        private System.Windows.Forms.GroupBox gbRecepta;
        private System.Windows.Forms.Label label7;
        private CustomControl.CustomTextBox TBRec;
        private CustomControl.comboBox CcQuant;
        private System.Windows.Forms.Label UserName;
        public System.Windows.Forms.Button btn_login;
        public System.Windows.Forms.Button btn_buscar;
    }
}