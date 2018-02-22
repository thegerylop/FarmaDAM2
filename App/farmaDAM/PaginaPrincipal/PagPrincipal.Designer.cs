namespace PaginaPrincipal
{
    partial class PagPrincipal
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
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Laboratoris
            // 
            this.Laboratoris.Click += new System.EventHandler(this.Laboratoris_Click);
            // 
            // MantenimentProductes
            // 
            this.MantenimentProductes.Click += new System.EventHandler(this.MantenimentProductes_Click);
            // 
            // PrincipisActius
            // 
            this.PrincipisActius.Click += new System.EventHandler(this.PrincipisActius_Click);
            // 
            // Personal
            // 
            this.Personal.Click += new System.EventHandler(this.Personal_Click);
            // 
            // tancarSessioButton
            // 
            this.tancarSessioButton.Click += new System.EventHandler(this.tancarSessioButton_Click);
            // 
            // btn_CarregaDades
            // 
            this.btn_CarregaDades.Click += new System.EventHandler(this.btn_CarregaDades_Click);
            // 
            // PagPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1120, 518);
            this.Name = "PagPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
