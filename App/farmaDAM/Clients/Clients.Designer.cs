namespace Clients
{
    partial class Clients
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
            this.customNom = new CustomControlTB.CustomControlTB();
            this.customAdreca = new CustomControlTB.CustomControlTB();
            this.customDNI = new CustomControlTB.CustomControlTB();
            this.customEmail = new CustomControlTB.CustomControlTB();
            this.customTS = new CustomControlTB.CustomControlTB();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.siRadioButton = new System.Windows.Forms.RadioButton();
            this.cronicLabel = new System.Windows.Forms.Label();
            this.medicamensLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.customControlTB1 = new CustomControlTB.CustomControlTB();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cronicGB = new System.Windows.Forms.GroupBox();
            this.Periode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantitat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cronicGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.cronicGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cronicGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customNom
            // 
            this.customNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customNom.Location = new System.Drawing.Point(62, 21);
            this.customNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customNom.Name = "customNom";
            this.customNom.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.customNom.Placeholder = "Nom";
            this.customNom.Size = new System.Drawing.Size(197, 27);
            this.customNom.TabIndex = 0;
            // 
            // customAdreca
            // 
            this.customAdreca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.customAdreca.Location = new System.Drawing.Point(62, 119);
            this.customAdreca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customAdreca.Name = "customAdreca";
            this.customAdreca.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.customAdreca.Placeholder = "Adreça";
            this.customAdreca.Size = new System.Drawing.Size(197, 27);
            this.customAdreca.TabIndex = 1;
            // 
            // customDNI
            // 
            this.customDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.customDNI.Location = new System.Drawing.Point(62, 87);
            this.customDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customDNI.Name = "customDNI";
            this.customDNI.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.customDNI.Placeholder = "DNI";
            this.customDNI.Size = new System.Drawing.Size(197, 27);
            this.customDNI.TabIndex = 2;
            // 
            // customEmail
            // 
            this.customEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.customEmail.Location = new System.Drawing.Point(62, 54);
            this.customEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customEmail.Name = "customEmail";
            this.customEmail.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.customEmail.Placeholder = "Cognoms";
            this.customEmail.Size = new System.Drawing.Size(197, 27);
            this.customEmail.TabIndex = 3;
            // 
            // customTS
            // 
            this.customTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.customTS.Location = new System.Drawing.Point(62, 152);
            this.customTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customTS.Name = "customTS";
            this.customTS.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.customTS.Placeholder = "Targeta Sanitaria";
            this.customTS.Size = new System.Drawing.Size(197, 27);
            this.customTS.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(247, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label1.Location = new System.Drawing.Point(128, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipus de carnet:";
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(270, 313);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(39, 17);
            this.noRadioButton.TabIndex = 7;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.noRadioButton_CheckedChanged);
            // 
            // siRadioButton
            // 
            this.siRadioButton.AutoSize = true;
            this.siRadioButton.Location = new System.Drawing.Point(230, 313);
            this.siRadioButton.Name = "siRadioButton";
            this.siRadioButton.Size = new System.Drawing.Size(34, 17);
            this.siRadioButton.TabIndex = 6;
            this.siRadioButton.TabStop = true;
            this.siRadioButton.Text = "Si";
            this.siRadioButton.UseVisualStyleBackColor = true;
            this.siRadioButton.CheckedChanged += new System.EventHandler(this.siRadioButton_CheckedChanged);
            // 
            // cronicLabel
            // 
            this.cronicLabel.AutoSize = true;
            this.cronicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.cronicLabel.Location = new System.Drawing.Point(160, 312);
            this.cronicLabel.Name = "cronicLabel";
            this.cronicLabel.Size = new System.Drawing.Size(56, 18);
            this.cronicLabel.TabIndex = 5;
            this.cronicLabel.Text = "Crònic:";
            // 
            // medicamensLabel
            // 
            this.medicamensLabel.AutoSize = true;
            this.medicamensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.medicamensLabel.Location = new System.Drawing.Point(18, 57);
            this.medicamensLabel.Name = "medicamensLabel";
            this.medicamensLabel.Size = new System.Drawing.Size(172, 18);
            this.medicamensLabel.TabIndex = 11;
            this.medicamensLabel.Text = "Medicaments Necesaris:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.emailLabel.Location = new System.Drawing.Point(18, 21);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(128, 18);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Correu Electrònic:";
            // 
            // customControlTB1
            // 
            this.customControlTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControlTB1.Location = new System.Drawing.Point(147, 15);
            this.customControlTB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customControlTB1.Name = "customControlTB1";
            this.customControlTB1.Options = CustomControlTB.CustomControlTB.Items.Text;
            this.customControlTB1.Placeholder = "e-Mail";
            this.customControlTB1.Size = new System.Drawing.Size(254, 27);
            this.customControlTB1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customEmail);
            this.groupBox1.Controls.Add(this.customDNI);
            this.groupBox1.Controls.Add(this.customTS);
            this.groupBox1.Controls.Add(this.customAdreca);
            this.groupBox1.Controls.Add(this.customNom);
            this.groupBox1.Location = new System.Drawing.Point(101, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 206);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dades Generals";
            // 
            // cronicGB
            // 
            this.cronicGB.Controls.Add(this.cronicGridView);
            this.cronicGB.Controls.Add(this.customControlTB1);
            this.cronicGB.Controls.Add(this.medicamensLabel);
            this.cronicGB.Controls.Add(this.emailLabel);
            this.cronicGB.Location = new System.Drawing.Point(432, 76);
            this.cronicGB.Name = "cronicGB";
            this.cronicGB.Size = new System.Drawing.Size(446, 375);
            this.cronicGB.TabIndex = 13;
            this.cronicGB.TabStop = false;
            this.cronicGB.Text = "Cronic";
            // 
            // Periode
            // 
            this.Periode.HeaderText = "Periode";
            this.Periode.Name = "Periode";
            // 
            // Quantitat
            // 
            this.Quantitat.HeaderText = "Quantitat";
            this.Quantitat.Name = "Quantitat";
            // 
            // Medicament
            // 
            this.Medicament.HeaderText = "Medicament";
            this.Medicament.Name = "Medicament";
            // 
            // cronicGridView
            // 
            this.cronicGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cronicGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicament,
            this.Quantitat,
            this.Periode});
            this.cronicGridView.Location = new System.Drawing.Point(60, 87);
            this.cronicGridView.Name = "cronicGridView";
            this.cronicGridView.Size = new System.Drawing.Size(341, 263);
            this.cronicGridView.TabIndex = 12;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 476);
            this.Controls.Add(this.cronicGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cronicLabel);
            this.Controls.Add(this.siRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clients";
            this.Text = "Clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.cronicGB.ResumeLayout(false);
            this.cronicGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cronicGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControlTB.CustomControlTB customNom;
        private CustomControlTB.CustomControlTB customAdreca;
        private CustomControlTB.CustomControlTB customDNI;
        private CustomControlTB.CustomControlTB customEmail;
        private CustomControlTB.CustomControlTB customTS;
        private System.Windows.Forms.Label cronicLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton siRadioButton;
        private System.Windows.Forms.Label emailLabel;
        private CustomControlTB.CustomControlTB customControlTB1;
        private System.Windows.Forms.Label medicamensLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox cronicGB;
        private System.Windows.Forms.DataGridView cronicGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantitat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periode;
    }
}