namespace Personal
{
    partial class Personal
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
            this.CCcodi = new CustomControl.CustomTextBox();
            this.CCrao = new CustomControl.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAfegir
            // 
            this.btnAfegir.Click += new System.EventHandler(this.btnAfegir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Click += new System.EventHandler(this.actualitzar_Click);
            // 
            // CCcodi
            // 
            this.CCcodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcodi.Location = new System.Drawing.Point(243, 76);
            this.CCcodi.Name = "CCcodi";
            this.CCcodi.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcodi.Placeholder = null;
            this.CCcodi.Size = new System.Drawing.Size(197, 20);
            this.CCcodi.TabIndex = 63;
            this.CCcodi.Tag = "usuari";
            // 
            // CCrao
            // 
            this.CCrao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCrao.Location = new System.Drawing.Point(606, 76);
            this.CCrao.Name = "CCrao";
            this.CCrao.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCrao.Placeholder = null;
            this.CCrao.Size = new System.Drawing.Size(197, 20);
            this.CCrao.TabIndex = 62;
            this.CCrao.Tag = "contrasenya";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(495, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Contrasenya :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(174, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "Usuari :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(441, -12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Personal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CCcodi);
            this.Controls.Add(this.CCrao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Personal";
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            this.Controls.SetChildIndex(this.btnAfegir, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.CCrao, 0);
            this.Controls.SetChildIndex(this.CCcodi, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.CustomTextBox CCcodi;
        private CustomControl.CustomTextBox CCrao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
