namespace LabFarm
{
    partial class Laboratoris
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAct = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.CustomCIF = new CustomControlTB.CustomControlTB();
            this.CustomSocial = new CustomControlTB.CustomControlTB();
            this.CustomDen = new CustomControlTB.CustomControlTB();
            this.CustomCodi = new CustomControlTB.CustomControlTB();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomId = new CustomControlTB.CustomControlTB();
            this.BtnEsborrarCamps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.Location = new System.Drawing.Point(169, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codi :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F);
            this.label4.Location = new System.Drawing.Point(106, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Denominació :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F);
            this.label5.Location = new System.Drawing.Point(459, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Raó social :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11F);
            this.label6.Location = new System.Drawing.Point(506, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "CIF :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F);
            this.label7.Location = new System.Drawing.Point(355, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Laboratoris farmacèutics";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.BackColor = System.Drawing.Color.DimGray;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAceptar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(685, 233);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(77, 26);
            this.BtnAceptar.TabIndex = 27;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Visible = false;
            this.BtnAceptar.Click += new System.EventHandler(this.SubmitLab);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 295);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(571, 128);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnAct
            // 
            this.BtnAct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAct.BackColor = System.Drawing.Color.DimGray;
            this.BtnAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAct.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BtnAct.ForeColor = System.Drawing.Color.White;
            this.BtnAct.Location = new System.Drawing.Point(671, 352);
            this.BtnAct.Name = "BtnAct";
            this.BtnAct.Size = new System.Drawing.Size(91, 26);
            this.BtnAct.TabIndex = 29;
            this.BtnAct.Text = "Actualitzar";
            this.BtnAct.UseVisualStyleBackColor = false;
            this.BtnAct.Click += new System.EventHandler(this.Actualitzar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(671, 397);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(91, 26);
            this.BtnEliminar.TabIndex = 31;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInserir.BackColor = System.Drawing.Color.DimGray;
            this.BtnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInserir.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BtnInserir.ForeColor = System.Drawing.Color.White;
            this.BtnInserir.Location = new System.Drawing.Point(685, 234);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(77, 26);
            this.BtnInserir.TabIndex = 32;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = false;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // CustomCIF
            // 
            this.CustomCIF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomCIF.Location = new System.Drawing.Point(565, 178);
            this.CustomCIF.Name = "CustomCIF";
            this.CustomCIF.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.CustomCIF.Placeholder = null;
            this.CustomCIF.Size = new System.Drawing.Size(197, 27);
            this.CustomCIF.TabIndex = 13;
            // 
            // CustomSocial
            // 
            this.CustomSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomSocial.Location = new System.Drawing.Point(565, 126);
            this.CustomSocial.Name = "CustomSocial";
            this.CustomSocial.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.CustomSocial.Placeholder = null;
            this.CustomSocial.Size = new System.Drawing.Size(197, 27);
            this.CustomSocial.TabIndex = 12;
            // 
            // CustomDen
            // 
            this.CustomDen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomDen.Location = new System.Drawing.Point(233, 232);
            this.CustomDen.Name = "CustomDen";
            this.CustomDen.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.CustomDen.Placeholder = null;
            this.CustomDen.Size = new System.Drawing.Size(197, 27);
            this.CustomDen.TabIndex = 11;
            // 
            // CustomCodi
            // 
            this.CustomCodi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomCodi.Location = new System.Drawing.Point(233, 180);
            this.CustomCodi.Name = "CustomCodi";
            this.CustomCodi.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.CustomCodi.Placeholder = null;
            this.CustomCodi.Size = new System.Drawing.Size(197, 27);
            this.CustomCodi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(193, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Id:";
            // 
            // CustomId
            // 
            this.CustomId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomId.Enabled = false;
            this.CustomId.Location = new System.Drawing.Point(233, 128);
            this.CustomId.Name = "CustomId";
            this.CustomId.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.CustomId.Placeholder = null;
            this.CustomId.Size = new System.Drawing.Size(197, 27);
            this.CustomId.TabIndex = 33;
            // 
            // BtnEsborrarCamps
            // 
            this.BtnEsborrarCamps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEsborrarCamps.BackColor = System.Drawing.Color.DimGray;
            this.BtnEsborrarCamps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEsborrarCamps.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BtnEsborrarCamps.ForeColor = System.Drawing.Color.White;
            this.BtnEsborrarCamps.Location = new System.Drawing.Point(509, 233);
            this.BtnEsborrarCamps.Name = "BtnEsborrarCamps";
            this.BtnEsborrarCamps.Size = new System.Drawing.Size(156, 26);
            this.BtnEsborrarCamps.TabIndex = 35;
            this.BtnEsborrarCamps.Text = "Esborrar camps";
            this.BtnEsborrarCamps.UseVisualStyleBackColor = false;
            this.BtnEsborrarCamps.Click += new System.EventHandler(this.button1_Click);
            // 
            // Laboratoris
            // 
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(913, 476);
            this.Controls.Add(this.BtnEsborrarCamps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomId);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomCIF);
            this.Controls.Add(this.CustomSocial);
            this.Controls.Add(this.CustomDen);
            this.Controls.Add(this.CustomCodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laboratoris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Laboratoris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControlTB.CustomControlTB CustomCodi;
        private CustomControlTB.CustomControlTB CustomDen;
        private CustomControlTB.CustomControlTB CustomSocial;
        private CustomControlTB.CustomControlTB CustomCIF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAct;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Label label1;
        private CustomControlTB.CustomControlTB CustomId;
        private System.Windows.Forms.Button BtnEsborrarCamps;
    }
}
