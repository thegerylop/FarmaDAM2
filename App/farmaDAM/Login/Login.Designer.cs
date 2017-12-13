namespace Login
{
    partial class Login
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
            this.subtituloLbl = new System.Windows.Forms.Label();
            this.iniciarBtn = new System.Windows.Forms.Button();
            this.customControlTB1 = new CustomControlTB.CustomControlTB();
            this.customControlTB2 = new CustomControlTB.CustomControlTB();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // subtituloLbl
            // 
            this.subtituloLbl.AutoSize = true;
            this.subtituloLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtituloLbl.Location = new System.Drawing.Point(199, 198);
            this.subtituloLbl.Name = "subtituloLbl";
            this.subtituloLbl.Size = new System.Drawing.Size(85, 33);
            this.subtituloLbl.TabIndex = 4;
            this.subtituloLbl.Text = "Login";
            // 
            // iniciarBtn
            // 
            this.iniciarBtn.BackColor = System.Drawing.Color.Transparent;
            this.iniciarBtn.Location = new System.Drawing.Point(193, 315);
            this.iniciarBtn.Name = "iniciarBtn";
            this.iniciarBtn.Size = new System.Drawing.Size(107, 32);
            this.iniciarBtn.TabIndex = 8;
            this.iniciarBtn.Text = "Iniciar Sessió";
            this.iniciarBtn.UseVisualStyleBackColor = false;
            this.iniciarBtn.Click += new System.EventHandler(this.iniciarBtn_Click);
            // 
            // customControlTB1
            // 
            this.customControlTB1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControlTB1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customControlTB1.Location = new System.Drawing.Point(134, 248);
            this.customControlTB1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customControlTB1.Name = "customControlTB1";
            this.customControlTB1.Placeholder = "Login";
            this.customControlTB1.Size = new System.Drawing.Size(234, 34);
            this.customControlTB1.TabIndex = 10;
            // 
            // customControlTB2
            // 
            this.customControlTB2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControlTB2.Location = new System.Drawing.Point(134, 279);
            this.customControlTB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customControlTB2.Name = "customControlTB2";
            this.customControlTB2.Placeholder = "Password";
            this.customControlTB2.Size = new System.Drawing.Size(234, 31);
            this.customControlTB2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 19);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Login.Properties.Resources.logofarma;
            this.pictureBox1.Location = new System.Drawing.Point(160, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(510, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customControlTB2);
            this.Controls.Add(this.customControlTB1);
            this.Controls.Add(this.iniciarBtn);
            this.Controls.Add(this.subtituloLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subtituloLbl;
        private System.Windows.Forms.Button iniciarBtn;
        private CustomControlTB.CustomControlTB customControlTB1;
        private CustomControlTB.CustomControlTB customControlTB2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

