namespace LabFarm
{
    partial class Laboratoris
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
            this.customControlTB1 = new CustomControlTB.CustomControlTB();
            this.customControlTB2 = new CustomControlTB.CustomControlTB();
            this.customControlTB3 = new CustomControlTB.CustomControlTB();
            this.customControlTB4 = new CustomControlTB.CustomControlTB();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customControlTB1
            // 
            this.customControlTB1.Location = new System.Drawing.Point(378, 144);
            this.customControlTB1.Name = "customControlTB1";
            this.customControlTB1.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.customControlTB1.Placeholder = null;
            this.customControlTB1.Size = new System.Drawing.Size(197, 27);
            this.customControlTB1.TabIndex = 10;
            // 
            // customControlTB2
            // 
            this.customControlTB2.Location = new System.Drawing.Point(378, 196);
            this.customControlTB2.Name = "customControlTB2";
            this.customControlTB2.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.customControlTB2.Placeholder = null;
            this.customControlTB2.Size = new System.Drawing.Size(197, 27);
            this.customControlTB2.TabIndex = 11;
            // 
            // customControlTB3
            // 
            this.customControlTB3.Location = new System.Drawing.Point(378, 248);
            this.customControlTB3.Name = "customControlTB3";
            this.customControlTB3.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.customControlTB3.Placeholder = null;
            this.customControlTB3.Size = new System.Drawing.Size(197, 27);
            this.customControlTB3.TabIndex = 12;
            // 
            // customControlTB4
            // 
            this.customControlTB4.Location = new System.Drawing.Point(378, 300);
            this.customControlTB4.Name = "customControlTB4";
            this.customControlTB4.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.customControlTB4.Placeholder = null;
            this.customControlTB4.Size = new System.Drawing.Size(197, 27);
            this.customControlTB4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(314, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(253, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Denominació :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label5.Location = new System.Drawing.Point(272, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Raó social :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label6.Location = new System.Drawing.Point(319, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "CIF :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Laboratoris farmacèutics";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(497, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Laboratoris
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(913, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customControlTB4);
            this.Controls.Add(this.customControlTB3);
            this.Controls.Add(this.customControlTB2);
            this.Controls.Add(this.customControlTB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laboratoris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControlTB.CustomControlTB customControlTB1;
        private CustomControlTB.CustomControlTB customControlTB2;
        private CustomControlTB.CustomControlTB customControlTB3;
        private CustomControlTB.CustomControlTB customControlTB4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}
