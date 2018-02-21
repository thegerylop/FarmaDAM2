namespace TemplateForm
{
    partial class TemplateForm
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.labelExitLog = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Laboratoris = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Button();
            this.tancarSessioButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Personal = new System.Windows.Forms.Button();
            this.MantenimentProductes = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.PrincipisActius = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.lblUser);
            this.panel4.Controls.Add(this.date);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.minimizeLabel);
            this.panel4.Controls.Add(this.labelExitLog);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1120, 30);
            this.panel4.TabIndex = 5;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(207, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(110, 16);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Usuari: JCASAS";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(758, 7);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(96, 16);
            this.date.TabIndex = 8;
            this.date.Text = "DD/MM/YYYY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "F A R M A D A M ";
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeLabel.ForeColor = System.Drawing.Color.White;
            this.minimizeLabel.Location = new System.Drawing.Point(1075, 1);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Size = new System.Drawing.Size(20, 24);
            this.minimizeLabel.TabIndex = 6;
            this.minimizeLabel.Text = "_";
            this.minimizeLabel.Click += new System.EventHandler(this.minimizeLabel_Click);
            // 
            // labelExitLog
            // 
            this.labelExitLog.AutoSize = true;
            this.labelExitLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelExitLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExitLog.ForeColor = System.Drawing.Color.White;
            this.labelExitLog.Location = new System.Drawing.Point(1095, 1);
            this.labelExitLog.Name = "labelExitLog";
            this.labelExitLog.Size = new System.Drawing.Size(25, 24);
            this.labelExitLog.TabIndex = 5;
            this.labelExitLog.Text = "X";
            this.labelExitLog.Click += new System.EventHandler(this.labelExitLog_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 1);
            this.panel2.TabIndex = 0;
            // 
            // Laboratoris
            // 
            this.Laboratoris.BackColor = System.Drawing.Color.DimGray;
            this.Laboratoris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Laboratoris.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laboratoris.ForeColor = System.Drawing.Color.White;
            this.Laboratoris.Location = new System.Drawing.Point(3, 105);
            this.Laboratoris.Name = "Laboratoris";
            this.Laboratoris.Size = new System.Drawing.Size(201, 51);
            this.Laboratoris.TabIndex = 28;
            this.Laboratoris.Text = "Laboratoris Farmacèutics";
            this.Laboratoris.UseVisualStyleBackColor = false;
            // 
            // Clients
            // 
            this.Clients.BackColor = System.Drawing.Color.DimGray;
            this.Clients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clients.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients.ForeColor = System.Drawing.Color.White;
            this.Clients.Location = new System.Drawing.Point(3, 261);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(201, 51);
            this.Clients.TabIndex = 26;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = false;
            this.Clients.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // tancarSessioButton
            // 
            this.tancarSessioButton.BackColor = System.Drawing.Color.DarkRed;
            this.tancarSessioButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tancarSessioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tancarSessioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tancarSessioButton.ForeColor = System.Drawing.Color.White;
            this.tancarSessioButton.Location = new System.Drawing.Point(0, 465);
            this.tancarSessioButton.Name = "tancarSessioButton";
            this.tancarSessioButton.Size = new System.Drawing.Size(207, 23);
            this.tancarSessioButton.TabIndex = 25;
            this.tancarSessioButton.Text = "Tancar Sessió";
            this.tancarSessioButton.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Controls.Add(this.Personal);
            this.panel8.Controls.Add(this.MantenimentProductes);
            this.panel8.Controls.Add(this.button5);
            this.panel8.Controls.Add(this.button6);
            this.panel8.Controls.Add(this.Laboratoris);
            this.panel8.Controls.Add(this.PrincipisActius);
            this.panel8.Controls.Add(this.Clients);
            this.panel8.Controls.Add(this.tancarSessioButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 30);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(207, 488);
            this.panel8.TabIndex = 8;
            // 
            // Personal
            // 
            this.Personal.BackColor = System.Drawing.Color.DimGray;
            this.Personal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Personal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personal.ForeColor = System.Drawing.Color.White;
            this.Personal.Location = new System.Drawing.Point(3, 313);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(201, 51);
            this.Personal.TabIndex = 32;
            this.Personal.Text = "Personal";
            this.Personal.UseVisualStyleBackColor = false;
            // 
            // MantenimentProductes
            // 
            this.MantenimentProductes.BackColor = System.Drawing.Color.DimGray;
            this.MantenimentProductes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MantenimentProductes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MantenimentProductes.ForeColor = System.Drawing.Color.White;
            this.MantenimentProductes.Location = new System.Drawing.Point(3, 157);
            this.MantenimentProductes.Name = "MantenimentProductes";
            this.MantenimentProductes.Size = new System.Drawing.Size(201, 51);
            this.MantenimentProductes.TabIndex = 31;
            this.MantenimentProductes.Text = "Manteniment de productes";
            this.MantenimentProductes.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(201, 51);
            this.button5.TabIndex = 30;
            this.button5.Text = "Venda de medicaments";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(3, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(201, 51);
            this.button6.TabIndex = 29;
            this.button6.Text = "Gestió de comandes de compra";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // PrincipisActius
            // 
            this.PrincipisActius.BackColor = System.Drawing.Color.DimGray;
            this.PrincipisActius.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrincipisActius.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrincipisActius.ForeColor = System.Drawing.Color.White;
            this.PrincipisActius.Location = new System.Drawing.Point(3, 209);
            this.PrincipisActius.Name = "PrincipisActius";
            this.PrincipisActius.Size = new System.Drawing.Size(201, 51);
            this.PrincipisActius.TabIndex = 27;
            this.PrincipisActius.Text = "Manteniment de principis actius";
            this.PrincipisActius.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(207, 501);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(913, 17);
            this.panel7.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(207, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 471);
            this.panel1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1120, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Label labelExitLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Button Laboratoris;
        public System.Windows.Forms.Button Clients;
        public System.Windows.Forms.Button MantenimentProductes;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button PrincipisActius;
        public System.Windows.Forms.Button Personal;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button tancarSessioButton;
    }
}