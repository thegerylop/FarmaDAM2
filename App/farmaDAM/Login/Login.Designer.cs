﻿namespace Login
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
            this.userTxb = new System.Windows.Forms.TextBox();
            this.passwordTxb = new System.Windows.Forms.TextBox();
            this.iniciarBtn = new System.Windows.Forms.Button();
            this.panelPnl = new System.Windows.Forms.Panel();
            this.tituloLbl = new System.Windows.Forms.Label();
            this.panelPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // subtituloLbl
            // 
            this.subtituloLbl.AutoSize = true;
            this.subtituloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtituloLbl.Location = new System.Drawing.Point(266, 118);
            this.subtituloLbl.Name = "subtituloLbl";
            this.subtituloLbl.Size = new System.Drawing.Size(80, 31);
            this.subtituloLbl.TabIndex = 4;
            this.subtituloLbl.Text = "Login";
            // 
            // userTxb
            // 
            this.userTxb.Location = new System.Drawing.Point(206, 175);
            this.userTxb.Name = "userTxb";
            this.userTxb.Size = new System.Drawing.Size(202, 20);
            this.userTxb.TabIndex = 5;
            this.userTxb.Text = "Usuario";
            // 
            // passwordTxb
            // 
            this.passwordTxb.Location = new System.Drawing.Point(206, 223);
            this.passwordTxb.Name = "passwordTxb";
            this.passwordTxb.PasswordChar = '*';
            this.passwordTxb.Size = new System.Drawing.Size(202, 20);
            this.passwordTxb.TabIndex = 6;
            this.passwordTxb.Text = "Password";
            // 
            // iniciarBtn
            // 
            this.iniciarBtn.Location = new System.Drawing.Point(333, 267);
            this.iniciarBtn.Name = "iniciarBtn";
            this.iniciarBtn.Size = new System.Drawing.Size(75, 23);
            this.iniciarBtn.TabIndex = 8;
            this.iniciarBtn.Text = "Iniciar Sessió";
            this.iniciarBtn.UseVisualStyleBackColor = true;
            this.iniciarBtn.Click += new System.EventHandler(this.iniciarBtn_Click);
            // 
            // panelPnl
            // 
            this.panelPnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPnl.Controls.Add(this.tituloLbl);
            this.panelPnl.Location = new System.Drawing.Point(0, 0);
            this.panelPnl.Name = "panelPnl";
            this.panelPnl.Size = new System.Drawing.Size(603, 89);
            this.panelPnl.TabIndex = 9;
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLbl.Location = new System.Drawing.Point(197, 22);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(223, 46);
            this.tituloLbl.TabIndex = 7;
            this.tituloLbl.Text = "FarmaDAM";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 335);
            this.Controls.Add(this.panelPnl);
            this.Controls.Add(this.iniciarBtn);
            this.Controls.Add(this.passwordTxb);
            this.Controls.Add(this.userTxb);
            this.Controls.Add(this.subtituloLbl);
            this.Name = "Login";
            this.Text = "Form1";
            this.panelPnl.ResumeLayout(false);
            this.panelPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subtituloLbl;
        private System.Windows.Forms.TextBox userTxb;
        private System.Windows.Forms.TextBox passwordTxb;
        private System.Windows.Forms.Button iniciarBtn;
        private System.Windows.Forms.Panel panelPnl;
        private System.Windows.Forms.Label tituloLbl;
    }
}

