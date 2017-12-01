namespace farmaDAM
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.farmacioImg = new System.Windows.Forms.PictureBox();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.tituloLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.farmacioImg)).BeginInit();
            this.SuspendLayout();
            // 
            // farmacioImg
            // 
            this.farmacioImg.Image = ((System.Drawing.Image)(resources.GetObject("farmacioImg.Image")));
            this.farmacioImg.Location = new System.Drawing.Point(21, 12);
            this.farmacioImg.Name = "farmacioImg";
            this.farmacioImg.Size = new System.Drawing.Size(133, 312);
            this.farmacioImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.farmacioImg.TabIndex = 0;
            this.farmacioImg.TabStop = false;
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLbl.Location = new System.Drawing.Point(191, 102);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(295, 123);
            this.descripcionLbl.TabIndex = 1;
            this.descripcionLbl.Text = "FarmaDAM és una empresa farmaceutica especialitzada en analitzar les noves oportu" +
    "nitats en la salud proporcionant els ultims medicaments proporcionats";
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLbl.Location = new System.Drawing.Point(389, 304);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(97, 20);
            this.versionLbl.TabIndex = 2;
            this.versionLbl.Text = "Versió: 1.0.1";
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLbl.Location = new System.Drawing.Point(187, 29);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(210, 46);
            this.tituloLbl.TabIndex = 3;
            this.tituloLbl.Text = "farmaDAM";
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 347);
            this.Controls.Add(this.tituloLbl);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.descripcionLbl);
            this.Controls.Add(this.farmacioImg);
            this.Name = "AcercaDe";
            this.Text = "Acerca de";
            ((System.ComponentModel.ISupportInitialize)(this.farmacioImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox farmacioImg;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Label tituloLbl;
    }
}

