namespace client
{
    partial class Client
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
            this.Clients = new System.Windows.Forms.Label();
            this.CCcodi = new CustomControl.CustomTextBox();
            this.CNom = new CustomControl.CustomTextBox();
            this.CTargeta = new CustomControl.CustomTextBox();
            this.CCarnet = new CustomControl.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CCognom2 = new CustomControl.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CCognom1 = new CustomControl.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CAdreça = new CustomControl.CustomTextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.TxBFilter = new CustomControl.CustomTextBox();
            this.SuspendLayout();
            // 
            // btnAfegir
            // 
            this.btnAfegir.TabIndex = 6;
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.TabIndex = 7;
            // 
            // Clients
            // 
            this.Clients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clients.AutoSize = true;
            this.Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients.Location = new System.Drawing.Point(417, -100);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(66, 24);
            this.Clients.TabIndex = 39;
            this.Clients.Text = "Clients";
            // 
            // CCcodi
            // 
            this.CCcodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcodi.Location = new System.Drawing.Point(242, -35);
            this.CCcodi.Name = "CCcodi";
            this.CCcodi.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcodi.Placeholder = null;
            this.CCcodi.Size = new System.Drawing.Size(197, 20);
            this.CCcodi.TabIndex = 50;
            this.CCcodi.Tag = "dni";
            // 
            // CNom
            // 
            this.CNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CNom.Location = new System.Drawing.Point(242, 14);
            this.CNom.Name = "CNom";
            this.CNom.Options = CustomControl.CustomTextBox.Items.Text;
            this.CNom.Placeholder = null;
            this.CNom.Size = new System.Drawing.Size(197, 20);
            this.CNom.TabIndex = 1;
            this.CNom.Tag = "nom";
            // 
            // CTargeta
            // 
            this.CTargeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTargeta.Location = new System.Drawing.Point(617, 9);
            this.CTargeta.Name = "CTargeta";
            this.CTargeta.Options = CustomControl.CustomTextBox.Items.Text;
            this.CTargeta.Placeholder = null;
            this.CTargeta.Size = new System.Drawing.Size(197, 20);
            this.CTargeta.TabIndex = 4;
            this.CTargeta.Tag = "t_sanitaria";
            // 
            // CCarnet
            // 
            this.CCarnet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCarnet.Location = new System.Drawing.Point(617, 60);
            this.CCarnet.Name = "CCarnet";
            this.CCarnet.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCarnet.Placeholder = null;
            this.CCarnet.Size = new System.Drawing.Size(197, 20);
            this.CCarnet.TabIndex = 5;
            this.CCarnet.Tag = "tipus_carnet";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(511, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 57;
            this.label7.Text = "Tipus Carnet :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(484, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "Targeta Sanitaria :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(184, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(192, -34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 54;
            this.label4.Tag = "dni";
            this.label4.Text = "DNI :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(546, -36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Adreça :";
            // 
            // CCognom2
            // 
            this.CCognom2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCognom2.Location = new System.Drawing.Point(242, 105);
            this.CCognom2.Name = "CCognom2";
            this.CCognom2.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCognom2.Placeholder = null;
            this.CCognom2.Size = new System.Drawing.Size(197, 20);
            this.CCognom2.TabIndex = 3;
            this.CCognom2.Tag = "cognom2";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(139, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "2n Cognom :";
            // 
            // CCognom1
            // 
            this.CCognom1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCognom1.Location = new System.Drawing.Point(242, 62);
            this.CCognom1.Name = "CCognom1";
            this.CCognom1.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCognom1.Placeholder = null;
            this.CCognom1.Size = new System.Drawing.Size(197, 20);
            this.CCognom1.TabIndex = 2;
            this.CCognom1.Tag = "cognom1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(142, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "1r Cognom :";
            // 
            // CAdreça
            // 
            this.CAdreça.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CAdreça.Location = new System.Drawing.Point(617, -35);
            this.CAdreça.Name = "CAdreça";
            this.CAdreça.Options = CustomControl.CustomTextBox.Items.Text;
            this.CAdreça.Placeholder = null;
            this.CAdreça.Size = new System.Drawing.Size(197, 20);
            this.CAdreça.TabIndex = 64;
            this.CAdreça.Tag = "direccio";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(10, 183);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 18);
            this.lblFiltrar.TabIndex = 67;
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
            this.cbClients.Location = new System.Drawing.Point(292, 183);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(121, 21);
            this.cbClients.TabIndex = 66;
            // 
            // TxBFilter
            // 
            this.TxBFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBFilter.Location = new System.Drawing.Point(65, 183);
            this.TxBFilter.Name = "TxBFilter";
            this.TxBFilter.Options = CustomControl.CustomTextBox.Items.Text;
            this.TxBFilter.Placeholder = null;
            this.TxBFilter.Size = new System.Drawing.Size(221, 20);
            this.TxBFilter.TabIndex = 65;
            this.TxBFilter.Tag = "";
            this.TxBFilter.TextChanged += new System.EventHandler(this.TxBFilter_TextChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(913, 484);
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
            this.Controls.Add(this.CCarnet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clients);
            this.Name = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnAfegir, 0);
            this.Controls.SetChildIndex(this.Clients, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.CCarnet, 0);
            this.Controls.SetChildIndex(this.CTargeta, 0);
            this.Controls.SetChildIndex(this.CNom, 0);
            this.Controls.SetChildIndex(this.CCcodi, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CCognom2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.CCognom1, 0);
            this.Controls.SetChildIndex(this.CAdreça, 0);
            this.Controls.SetChildIndex(this.TxBFilter, 0);
            this.Controls.SetChildIndex(this.cbClients, 0);
            this.Controls.SetChildIndex(this.lblFiltrar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Clients;
        private CustomControl.CustomTextBox CCcodi;
        private CustomControl.CustomTextBox CNom;
        private CustomControl.CustomTextBox CTargeta;
        private CustomControl.CustomTextBox CCarnet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private CustomControl.CustomTextBox CCognom2;
        private System.Windows.Forms.Label label2;
        private CustomControl.CustomTextBox CCognom1;
        private System.Windows.Forms.Label label3;
        private CustomControl.CustomTextBox CAdreça;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbClients;
        private CustomControl.CustomTextBox TxBFilter;
    }
}
