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
            this.CustomCIF = new CustomControlTB.CustomControlTB();
            this.CustomSocial = new CustomControlTB.CustomControlTB();
            this.CustomDen = new CustomControlTB.CustomControlTB();
            this.CustomCodi = new CustomControlTB.CustomControlTB();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(166, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(105, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Denominació :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(459, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Raó social :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(506, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "CIF :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Laboratoris farmacèutics";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.DimGray;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(685, 233);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(77, 26);
            this.BtnAceptar.TabIndex = 27;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.SubmitLab);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 128);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnAct
            // 
            this.BtnAct.BackColor = System.Drawing.Color.DimGray;
            this.BtnAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnAct.ForeColor = System.Drawing.Color.White;
            this.BtnAct.Location = new System.Drawing.Point(621, 352);
            this.BtnAct.Name = "BtnAct";
            this.BtnAct.Size = new System.Drawing.Size(91, 26);
            this.BtnAct.TabIndex = 29;
            this.BtnAct.Text = "Actualitzar";
            this.BtnAct.UseVisualStyleBackColor = false;
            this.BtnAct.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomCIF
            // 
            this.CustomCIF.Location = new System.Drawing.Point(565, 178);
            this.CustomCIF.Name = "CustomCIF";
            this.CustomCIF.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.CustomCIF.Placeholder = null;
            this.CustomCIF.Size = new System.Drawing.Size(197, 27);
            this.CustomCIF.TabIndex = 13;
            // 
            // CustomSocial
            // 
            this.CustomSocial.Location = new System.Drawing.Point(565, 126);
            this.CustomSocial.Name = "CustomSocial";
            this.CustomSocial.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.CustomSocial.Placeholder = null;
            this.CustomSocial.Size = new System.Drawing.Size(197, 27);
            this.CustomSocial.TabIndex = 12;
            // 
            // CustomDen
            // 
            this.CustomDen.Location = new System.Drawing.Point(230, 178);
            this.CustomDen.Name = "CustomDen";
            this.CustomDen.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.CustomDen.Placeholder = null;
            this.CustomDen.Size = new System.Drawing.Size(197, 27);
            this.CustomDen.TabIndex = 11;
            // 
            // CustomCodi
            // 
            this.CustomCodi.Location = new System.Drawing.Point(230, 126);
            this.CustomCodi.Name = "CustomCodi";
            this.CustomCodi.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.CustomCodi.Placeholder = null;
            this.CustomCodi.Size = new System.Drawing.Size(197, 27);
            this.CustomCodi.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(621, 397);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(91, 26);
            this.BtnEliminar.TabIndex = 31;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnInserir
            // 
            this.BtnInserir.BackColor = System.Drawing.Color.DimGray;
            this.BtnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnInserir.ForeColor = System.Drawing.Color.White;
            this.BtnInserir.Location = new System.Drawing.Point(685, 233);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(77, 26);
            this.BtnInserir.TabIndex = 32;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = false;
            this.BtnInserir.Visible = false;
            // 
            // Laboratoris
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(913, 476);
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laboratoris";
            this.Load += new System.EventHandler(this.Laboratoris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnInserir;
    }
}
