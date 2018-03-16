namespace PaginaPrincipal
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.tituloLbl = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.farmacioImg = new System.Windows.Forms.PictureBox();
            this.labelDipoters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.farmacioImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLbl.Location = new System.Drawing.Point(222, 64);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(250, 49);
            this.tituloLbl.TabIndex = 7;
            this.tituloLbl.Text = "FARMADAM";
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLbl.Location = new System.Drawing.Point(423, 338);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(98, 21);
            this.versionLbl.TabIndex = 6;
            this.versionLbl.Text = "Versió: 1.0.1";
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLbl.Location = new System.Drawing.Point(226, 137);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(295, 123);
            this.descripcionLbl.TabIndex = 5;
            this.descripcionLbl.Text = "FarmaDAM és una empresa farmaceutica especialitzada en analitzar les noves oportu" +
    "nitats en la salud proporcionant els ultims medicaments proporcionats";
            // 
            // farmacioImg
            // 
            this.farmacioImg.Image = ((System.Drawing.Image)(resources.GetObject("farmacioImg.Image")));
            this.farmacioImg.Location = new System.Drawing.Point(56, 47);
            this.farmacioImg.Name = "farmacioImg";
            this.farmacioImg.Size = new System.Drawing.Size(133, 312);
            this.farmacioImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.farmacioImg.TabIndex = 4;
            this.farmacioImg.TabStop = false;
            // 
            // labelDipoters
            // 
            this.labelDipoters.AutoSize = true;
            this.labelDipoters.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDipoters.Location = new System.Drawing.Point(509, 379);
            this.labelDipoters.Name = "labelDipoters";
            this.labelDipoters.Size = new System.Drawing.Size(70, 15);
            this.labelDipoters.TabIndex = 8;
            this.labelDipoters.Text = "By: Diopters";
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 401);
            this.Controls.Add(this.labelDipoters);
            this.Controls.Add(this.tituloLbl);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.descripcionLbl);
            this.Controls.Add(this.farmacioImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcercaDe";
            ((System.ComponentModel.ISupportInitialize)(this.farmacioImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.PictureBox farmacioImg;
        private System.Windows.Forms.Label labelDipoters;
    }
}