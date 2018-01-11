namespace LaboratorisFarm
{
    partial class Laboratoris
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customControlTB1 = new CustomControlTB.CustomControlTB();
            this.customControlTB2 = new CustomControlTB.CustomControlTB();
            this.customControlTB3 = new CustomControlTB.CustomControlTB();
            this.customControlTB4 = new CustomControlTB.CustomControlTB();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Denominació :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Raó Social :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "CIF :";
            // 
            // customControlTB1
            // 
            this.customControlTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControlTB1.Location = new System.Drawing.Point(673, 183);
            this.customControlTB1.Name = "customControlTB1";
            this.customControlTB1.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.customControlTB1.Placeholder = null;
            this.customControlTB1.Size = new System.Drawing.Size(200, 27);
            this.customControlTB1.TabIndex = 8;
            this.customControlTB1.Load += new System.EventHandler(this.customControlTB1_Load);
            // 
            // customControlTB2
            // 
            this.customControlTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControlTB2.Location = new System.Drawing.Point(673, 234);
            this.customControlTB2.Name = "customControlTB2";
            this.customControlTB2.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.customControlTB2.Placeholder = null;
            this.customControlTB2.Size = new System.Drawing.Size(200, 27);
            this.customControlTB2.TabIndex = 16;
            // 
            // customControlTB3
            // 
            this.customControlTB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControlTB3.Location = new System.Drawing.Point(673, 291);
            this.customControlTB3.Name = "customControlTB3";
            this.customControlTB3.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.customControlTB3.Placeholder = null;
            this.customControlTB3.Size = new System.Drawing.Size(200, 27);
            this.customControlTB3.TabIndex = 17;
            // 
            // customControlTB4
            // 
            this.customControlTB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControlTB4.Location = new System.Drawing.Point(673, 342);
            this.customControlTB4.Name = "customControlTB4";
            this.customControlTB4.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.customControlTB4.Placeholder = null;
            this.customControlTB4.Size = new System.Drawing.Size(200, 27);
            this.customControlTB4.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(770, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 27;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(624, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Laboratoris Farmacèutics";
            // 
            // Laboratoris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 557);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customControlTB4);
            this.Controls.Add(this.customControlTB3);
            this.Controls.Add(this.customControlTB2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customControlTB1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Laboratoris";
            this.Text = "Laboratoris";
            this.Controls.SetChildIndex(this.customControlTB1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.customControlTB2, 0);
            this.Controls.SetChildIndex(this.customControlTB3, 0);
            this.Controls.SetChildIndex(this.customControlTB4, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomControlTB.CustomControlTB customControlTB1;
        private CustomControlTB.CustomControlTB customControlTB2;
        private CustomControlTB.CustomControlTB customControlTB3;
        private CustomControlTB.CustomControlTB customControlTB4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}