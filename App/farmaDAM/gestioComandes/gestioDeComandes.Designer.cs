namespace gestioComandes
{
    partial class gestioDeComandes
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
            this.dataComanda = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDTD = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.richXML = new System.Windows.Forms.RichTextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataComanda
            // 
            this.dataComanda.CustomFormat = "yyyy\\MM\\dd";
            this.dataComanda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataComanda.Location = new System.Drawing.Point(92, 52);
            this.dataComanda.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dataComanda.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dataComanda.Name = "dataComanda";
            this.dataComanda.Size = new System.Drawing.Size(127, 20);
            this.dataComanda.TabIndex = 0;
            this.dataComanda.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data :";
            // 
            // btnDTD
            // 
            this.btnDTD.Location = new System.Drawing.Point(950, 52);
            this.btnDTD.Name = "btnDTD";
            this.btnDTD.Size = new System.Drawing.Size(75, 23);
            this.btnDTD.TabIndex = 2;
            this.btnDTD.Text = "Validar";
            this.btnDTD.UseVisualStyleBackColor = true;
            this.btnDTD.Click += new System.EventHandler(this.btnDTD_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(950, 683);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // richXML
            // 
            this.richXML.Enabled = false;
            this.richXML.Location = new System.Drawing.Point(635, 89);
            this.richXML.Name = "richXML";
            this.richXML.Size = new System.Drawing.Size(390, 588);
            this.richXML.TabIndex = 4;
            this.richXML.Text = "";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(54, 89);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(548, 617);
            this.crystalReportViewer1.TabIndex = 5;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Mostrar comanda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gestioDeComandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 664);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.richXML);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnDTD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataComanda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestioDeComandes";
            this.Text = "gestioDeComandes";
            this.Load += new System.EventHandler(this.gestioDeComandes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataComanda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDTD;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox richXML;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button3;
    }
}