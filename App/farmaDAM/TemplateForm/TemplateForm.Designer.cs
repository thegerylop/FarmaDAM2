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
            this.lblUsuari = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLaboratorisFarmaceutics = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnTancarSessio = new System.Windows.Forms.Button();
            this.btnPerfilUsuari = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnMantenimentProductes = new System.Windows.Forms.Button();
            this.btnVendaMedicaments = new System.Windows.Forms.Button();
            this.btnGestioComandesCompra = new System.Windows.Forms.Button();
            this.btnMantenimentPrincipisActius = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.actualizacionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.lblUsuari);
            this.panel4.Controls.Add(this.lblDate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblMinimize);
            this.panel4.Controls.Add(this.lblExit);
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
            // lblUsuari
            // 
            this.lblUsuari.AutoSize = true;
            this.lblUsuari.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuari.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuari.ForeColor = System.Drawing.Color.White;
            this.lblUsuari.Location = new System.Drawing.Point(207, 8);
            this.lblUsuari.Name = "lblUsuari";
            this.lblUsuari.Size = new System.Drawing.Size(110, 16);
            this.lblUsuari.TabIndex = 9;
            this.lblUsuari.Text = "Usuari: JCASAS";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(758, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 16);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "DD/MM/YYYY";
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
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(1075, 1);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 24);
            this.lblMinimize.TabIndex = 6;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.minimizeLabel_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(1095, 1);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(25, 24);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.labelExitLog_Click);
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
            // btnLaboratorisFarmaceutics
            // 
            this.btnLaboratorisFarmaceutics.BackColor = System.Drawing.Color.DimGray;
            this.btnLaboratorisFarmaceutics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLaboratorisFarmaceutics.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaboratorisFarmaceutics.ForeColor = System.Drawing.Color.White;
            this.btnLaboratorisFarmaceutics.Location = new System.Drawing.Point(3, 105);
            this.btnLaboratorisFarmaceutics.Name = "btnLaboratorisFarmaceutics";
            this.btnLaboratorisFarmaceutics.Size = new System.Drawing.Size(201, 51);
            this.btnLaboratorisFarmaceutics.TabIndex = 28;
            this.btnLaboratorisFarmaceutics.Text = "Laboratoris Farmacèutics";
            this.btnLaboratorisFarmaceutics.UseVisualStyleBackColor = false;
            this.btnLaboratorisFarmaceutics.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.DimGray;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClients.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Location = new System.Drawing.Point(3, 261);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(201, 51);
            this.btnClients.TabIndex = 26;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // btnTancarSessio
            // 
            this.btnTancarSessio.BackColor = System.Drawing.Color.DarkRed;
            this.btnTancarSessio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTancarSessio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTancarSessio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTancarSessio.ForeColor = System.Drawing.Color.White;
            this.btnTancarSessio.Location = new System.Drawing.Point(0, 442);
            this.btnTancarSessio.Name = "btnTancarSessio";
            this.btnTancarSessio.Size = new System.Drawing.Size(207, 23);
            this.btnTancarSessio.TabIndex = 25;
            this.btnTancarSessio.Text = "Tancar Sessió";
            this.btnTancarSessio.UseVisualStyleBackColor = false;
            this.btnTancarSessio.Click += new System.EventHandler(this.tancarSessioButton_Click);
            // 
            // btnPerfilUsuari
            // 
            this.btnPerfilUsuari.BackColor = System.Drawing.Color.DimGray;
            this.btnPerfilUsuari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPerfilUsuari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPerfilUsuari.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfilUsuari.ForeColor = System.Drawing.Color.White;
            this.btnPerfilUsuari.Location = new System.Drawing.Point(0, 465);
            this.btnPerfilUsuari.Name = "btnPerfilUsuari";
            this.btnPerfilUsuari.Size = new System.Drawing.Size(207, 23);
            this.btnPerfilUsuari.TabIndex = 24;
            this.btnPerfilUsuari.Text = "Perfil d\'usuari";
            this.btnPerfilUsuari.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Controls.Add(this.btnMantenimentProductes);
            this.panel8.Controls.Add(this.btnVendaMedicaments);
            this.panel8.Controls.Add(this.btnGestioComandesCompra);
            this.panel8.Controls.Add(this.btnLaboratorisFarmaceutics);
            this.panel8.Controls.Add(this.btnMantenimentPrincipisActius);
            this.panel8.Controls.Add(this.btnClients);
            this.panel8.Controls.Add(this.btnTancarSessio);
            this.panel8.Controls.Add(this.btnPerfilUsuari);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 30);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(207, 488);
            this.panel8.TabIndex = 8;
            // 
            // btnMantenimentProductes
            // 
            this.btnMantenimentProductes.BackColor = System.Drawing.Color.DimGray;
            this.btnMantenimentProductes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMantenimentProductes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimentProductes.ForeColor = System.Drawing.Color.White;
            this.btnMantenimentProductes.Location = new System.Drawing.Point(3, 157);
            this.btnMantenimentProductes.Name = "btnMantenimentProductes";
            this.btnMantenimentProductes.Size = new System.Drawing.Size(201, 51);
            this.btnMantenimentProductes.TabIndex = 31;
            this.btnMantenimentProductes.Text = "Manteniment de productes";
            this.btnMantenimentProductes.UseVisualStyleBackColor = false;
            // 
            // btnVendaMedicaments
            // 
            this.btnVendaMedicaments.BackColor = System.Drawing.Color.DimGray;
            this.btnVendaMedicaments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVendaMedicaments.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaMedicaments.ForeColor = System.Drawing.Color.White;
            this.btnVendaMedicaments.Location = new System.Drawing.Point(3, 1);
            this.btnVendaMedicaments.Name = "btnVendaMedicaments";
            this.btnVendaMedicaments.Size = new System.Drawing.Size(201, 51);
            this.btnVendaMedicaments.TabIndex = 30;
            this.btnVendaMedicaments.Text = "Venda de medicaments";
            this.btnVendaMedicaments.UseVisualStyleBackColor = false;
            this.btnVendaMedicaments.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnGestioComandesCompra
            // 
            this.btnGestioComandesCompra.BackColor = System.Drawing.Color.DimGray;
            this.btnGestioComandesCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestioComandesCompra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioComandesCompra.ForeColor = System.Drawing.Color.White;
            this.btnGestioComandesCompra.Location = new System.Drawing.Point(3, 53);
            this.btnGestioComandesCompra.Name = "btnGestioComandesCompra";
            this.btnGestioComandesCompra.Size = new System.Drawing.Size(201, 51);
            this.btnGestioComandesCompra.TabIndex = 29;
            this.btnGestioComandesCompra.Text = "Gestió de comandes de compra";
            this.btnGestioComandesCompra.UseVisualStyleBackColor = false;
            // 
            // btnMantenimentPrincipisActius
            // 
            this.btnMantenimentPrincipisActius.BackColor = System.Drawing.Color.DimGray;
            this.btnMantenimentPrincipisActius.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMantenimentPrincipisActius.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimentPrincipisActius.ForeColor = System.Drawing.Color.White;
            this.btnMantenimentPrincipisActius.Location = new System.Drawing.Point(3, 209);
            this.btnMantenimentPrincipisActius.Name = "btnMantenimentPrincipisActius";
            this.btnMantenimentPrincipisActius.Size = new System.Drawing.Size(201, 51);
            this.btnMantenimentPrincipisActius.TabIndex = 27;
            this.btnMantenimentPrincipisActius.Text = "Manteniment de principis actius";
            this.btnMantenimentPrincipisActius.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Controls.Add(this.actualizacionLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(207, 501);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(913, 17);
            this.panel7.TabIndex = 9;
            // 
            // actualizacionLabel
            // 
            this.actualizacionLabel.AutoSize = true;
            this.actualizacionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.actualizacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizacionLabel.ForeColor = System.Drawing.Color.White;
            this.actualizacionLabel.Location = new System.Drawing.Point(836, 0);
            this.actualizacionLabel.Name = "actualizacionLabel";
            this.actualizacionLabel.Size = new System.Drawing.Size(77, 13);
            this.actualizacionLabel.TabIndex = 0;
            this.actualizacionLabel.Text = "Actualizando...";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(207, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 476);
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
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUsuari;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLaboratorisFarmaceutics;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnTancarSessio;
        private System.Windows.Forms.Button btnPerfilUsuari;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnMantenimentProductes;
        private System.Windows.Forms.Button btnVendaMedicaments;
        private System.Windows.Forms.Button btnGestioComandesCompra;
        private System.Windows.Forms.Button btnMantenimentPrincipisActius;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label actualizacionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}