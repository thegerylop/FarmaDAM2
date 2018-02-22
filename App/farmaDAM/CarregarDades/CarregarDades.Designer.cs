namespace CarregarDades
{
    partial class carregarDades
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
            this.btn_InserirDades = new System.Windows.Forms.Button();
            this.btn_FindFile = new System.Windows.Forms.Button();
            this.txt_RutaFitxer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_InserirDades
            // 
            this.btn_InserirDades.Location = new System.Drawing.Point(152, 283);
            this.btn_InserirDades.Name = "btn_InserirDades";
            this.btn_InserirDades.Size = new System.Drawing.Size(121, 23);
            this.btn_InserirDades.TabIndex = 0;
            this.btn_InserirDades.Text = "Inserir Dades";
            this.btn_InserirDades.UseVisualStyleBackColor = true;
            this.btn_InserirDades.Click += new System.EventHandler(this.btn_InserirDades_Click);
            // 
            // btn_FindFile
            // 
            this.btn_FindFile.Location = new System.Drawing.Point(152, 176);
            this.btn_FindFile.Name = "btn_FindFile";
            this.btn_FindFile.Size = new System.Drawing.Size(121, 23);
            this.btn_FindFile.TabIndex = 1;
            this.btn_FindFile.Text = "Escollir Arxiu";
            this.btn_FindFile.UseVisualStyleBackColor = true;
            this.btn_FindFile.Click += new System.EventHandler(this.btn_FindFile_Click);
            // 
            // txt_RutaFitxer
            // 
            this.txt_RutaFitxer.Location = new System.Drawing.Point(329, 178);
            this.txt_RutaFitxer.Name = "txt_RutaFitxer";
            this.txt_RutaFitxer.ReadOnly = true;
            this.txt_RutaFitxer.Size = new System.Drawing.Size(252, 20);
            this.txt_RutaFitxer.TabIndex = 2;
            // 
            // carregarDades
            // 
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.txt_RutaFitxer);
            this.Controls.Add(this.btn_FindFile);
            this.Controls.Add(this.btn_InserirDades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "carregarDades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InserirDades;
        private System.Windows.Forms.Button btn_FindFile;
        private System.Windows.Forms.TextBox txt_RutaFitxer;
    }
}
