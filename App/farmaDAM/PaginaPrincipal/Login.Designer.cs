namespace PaginaPrincipal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.actionBar = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelExitLog = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iniciarBtn = new System.Windows.Forms.Button();
            this.customControlTBLogin = new CustomControlTB.CustomControlTB();
            this.customControlTBContrasenya = new CustomControlTB.CustomControlTB();
            this.actionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // actionBar
            // 
            this.actionBar.BackColor = System.Drawing.Color.Gray;
            this.actionBar.Controls.Add(this.panel6);
            this.actionBar.Controls.Add(this.panel5);
            this.actionBar.Controls.Add(this.panel4);
            this.actionBar.Controls.Add(this.labelExitLog);
            this.actionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionBar.Location = new System.Drawing.Point(0, 0);
            this.actionBar.Name = "actionBar";
            this.actionBar.Size = new System.Drawing.Size(509, 30);
            this.actionBar.TabIndex = 18;
            this.actionBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.actionBar_MouseDown);
            this.actionBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.actionBar_MouseMove);
            this.actionBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.actionBar_MouseUp);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(507, 1);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(508, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 30);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 30);
            this.panel4.TabIndex = 1;
            // 
            // labelExitLog
            // 
            this.labelExitLog.AutoSize = true;
            this.labelExitLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExitLog.ForeColor = System.Drawing.Color.White;
            this.labelExitLog.Location = new System.Drawing.Point(482, 4);
            this.labelExitLog.Name = "labelExitLog";
            this.labelExitLog.Size = new System.Drawing.Size(23, 23);
            this.labelExitLog.TabIndex = 0;
            this.labelExitLog.Text = "X";
            this.labelExitLog.Click += new System.EventHandler(this.labelExitLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PaginaPrincipal.Properties.Resources.logofarma;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 1);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(508, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 311);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 311);
            this.panel3.TabIndex = 21;
            // 
            // iniciarBtn
            // 
            this.iniciarBtn.BackColor = System.Drawing.Color.Gray;
            this.iniciarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciarBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarBtn.ForeColor = System.Drawing.Color.White;
            this.iniciarBtn.Location = new System.Drawing.Point(199, 298);
            this.iniciarBtn.Name = "iniciarBtn";
            this.iniciarBtn.Size = new System.Drawing.Size(117, 32);
            this.iniciarBtn.TabIndex = 3;
            this.iniciarBtn.Text = "Iniciar Sessió";
            this.iniciarBtn.UseVisualStyleBackColor = false;
            this.iniciarBtn.Click += new System.EventHandler(this.iniciarBtn_Click);
            // 
            // customControlTBLogin
            // 
            this.customControlTBLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControlTBLogin.Location = new System.Drawing.Point(122, 232);
            this.customControlTBLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customControlTBLogin.Name = "customControlTBLogin";
            this.customControlTBLogin.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.customControlTBLogin.Placeholder = "Login";
            this.customControlTBLogin.Size = new System.Drawing.Size(263, 27);
            this.customControlTBLogin.TabIndex = 1;
            this.customControlTBLogin.Load += new System.EventHandler(this.customControlTBLogin_Load);
            // 
            // customControlTBContrasenya
            // 
            this.customControlTBContrasenya.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControlTBContrasenya.Location = new System.Drawing.Point(122, 265);
            this.customControlTBContrasenya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customControlTBContrasenya.Name = "customControlTBContrasenya";
            this.customControlTBContrasenya.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.customControlTBContrasenya.Placeholder = "Contrasenya";
            this.customControlTBContrasenya.Size = new System.Drawing.Size(263, 27);
            this.customControlTBContrasenya.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 342);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.actionBar);
            this.Controls.Add(this.customControlTBLogin);
            this.Controls.Add(this.customControlTBContrasenya);
            this.Controls.Add(this.iniciarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.actionBar.ResumeLayout(false);
            this.actionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel actionBar;
        private System.Windows.Forms.Label labelExitLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button iniciarBtn;
        public CustomControlTB.CustomControlTB customControlTBContrasenya;
        public CustomControlTB.CustomControlTB customControlTBLogin;
    }
}