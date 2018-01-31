namespace Manteniment_Productes
{
    partial class Manteniment_Productes
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
            this.label2 = new System.Windows.Forms.Label();
            this.CCcodi = new CustomControl.CustomTextBox();
            this.customTextBox1 = new CustomControl.CustomTextBox();
            this.customTextBox2 = new CustomControl.CustomTextBox();
            this.customTextBox3 = new CustomControl.CustomTextBox();
            this.customTextBox4 = new CustomControl.CustomTextBox();
            this.customTextBox5 = new CustomControl.CustomTextBox();
            this.customTextBox6 = new CustomControl.CustomTextBox();
            this.SuspendLayout();
            // 
            // btnAfegir
            // 
            this.btnAfegir.Location = new System.Drawing.Point(507, 162);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(630, 162);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(753, 162);
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.Location = new System.Drawing.Point(360, -57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Manteniment de productes";
            // 
            // CCcodi
            // 
            this.CCcodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcodi.Location = new System.Drawing.Point(165, 47);
            this.CCcodi.Name = "CCcodi";
            this.CCcodi.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcodi.Placeholder = null;
            this.CCcodi.Size = new System.Drawing.Size(197, 20);
            this.CCcodi.TabIndex = 56;
            this.CCcodi.Tag = "codi_lab";
            // 
            // customTextBox1
            // 
            this.customTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox1.Location = new System.Drawing.Point(165, 73);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox1.Placeholder = null;
            this.customTextBox1.Size = new System.Drawing.Size(197, 20);
            this.customTextBox1.TabIndex = 57;
            this.customTextBox1.Tag = "codi_lab";
            // 
            // customTextBox2
            // 
            this.customTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox2.Location = new System.Drawing.Point(165, 101);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox2.Placeholder = null;
            this.customTextBox2.Size = new System.Drawing.Size(197, 20);
            this.customTextBox2.TabIndex = 58;
            this.customTextBox2.Tag = "codi_lab";
            // 
            // customTextBox3
            // 
            this.customTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox3.Location = new System.Drawing.Point(165, 134);
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox3.Placeholder = null;
            this.customTextBox3.Size = new System.Drawing.Size(197, 20);
            this.customTextBox3.TabIndex = 59;
            this.customTextBox3.Tag = "codi_lab";
            // 
            // customTextBox4
            // 
            this.customTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox4.Location = new System.Drawing.Point(165, 166);
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox4.Placeholder = null;
            this.customTextBox4.Size = new System.Drawing.Size(197, 20);
            this.customTextBox4.TabIndex = 60;
            this.customTextBox4.Tag = "codi_lab";
            // 
            // customTextBox5
            // 
            this.customTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox5.Location = new System.Drawing.Point(165, 20);
            this.customTextBox5.Name = "customTextBox5";
            this.customTextBox5.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox5.Placeholder = null;
            this.customTextBox5.Size = new System.Drawing.Size(197, 20);
            this.customTextBox5.TabIndex = 61;
            this.customTextBox5.Tag = "codi_lab";
            // 
            // customTextBox6
            // 
            this.customTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox6.Location = new System.Drawing.Point(165, -6);
            this.customTextBox6.Name = "customTextBox6";
            this.customTextBox6.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox6.Placeholder = null;
            this.customTextBox6.Size = new System.Drawing.Size(197, 20);
            this.customTextBox6.TabIndex = 62;
            this.customTextBox6.Tag = "codi_lab";
            // 
            // Manteniment_Productes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.customTextBox6);
            this.Controls.Add(this.customTextBox5);
            this.Controls.Add(this.customTextBox4);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.CCcodi);
            this.Controls.Add(this.label2);
            this.Name = "Manteniment_Productes";
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            this.Controls.SetChildIndex(this.btnAfegir, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CCcodi, 0);
            this.Controls.SetChildIndex(this.customTextBox1, 0);
            this.Controls.SetChildIndex(this.customTextBox2, 0);
            this.Controls.SetChildIndex(this.customTextBox3, 0);
            this.Controls.SetChildIndex(this.customTextBox4, 0);
            this.Controls.SetChildIndex(this.customTextBox5, 0);
            this.Controls.SetChildIndex(this.customTextBox6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private CustomControl.CustomTextBox CCcodi;
        private CustomControl.CustomTextBox customTextBox1;
        private CustomControl.CustomTextBox customTextBox2;
        private CustomControl.CustomTextBox customTextBox3;
        private CustomControl.CustomTextBox customTextBox4;
        private CustomControl.CustomTextBox customTextBox5;
        private CustomControl.CustomTextBox customTextBox6;
    }
}
