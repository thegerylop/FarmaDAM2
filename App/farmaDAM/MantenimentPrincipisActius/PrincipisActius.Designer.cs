namespace MantenimentPrincipisActius
{
    partial class PrincipisActius
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CCcodi = new CustomControl.CustomTextBox();
            this.CCid = new CustomControl.CustomTextBox();
            this.CCrao = new CustomControl.CustomTextBox();
            this.CCcif = new CustomControl.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAfegir
            // 
            this.btnAfegir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Click += new System.EventHandler(this.actualitzar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(445, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "Codi :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(26, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Num registre sanitari :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(128, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(148, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Id :";
            // 
            // CCcodi
            // 
            this.CCcodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcodi.Location = new System.Drawing.Point(179, 108);
            this.CCcodi.Name = "CCcodi";
            this.CCcodi.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcodi.Placeholder = null;
            this.CCcodi.Size = new System.Drawing.Size(197, 20);
            this.CCcodi.TabIndex = 59;
            this.CCcodi.Tag = "nom";
            // 
            // CCid
            // 
            this.CCid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCid.Location = new System.Drawing.Point(181, 58);
            this.CCid.Name = "CCid";
            this.CCid.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCid.Placeholder = null;
            this.CCid.Size = new System.Drawing.Size(197, 20);
            this.CCid.TabIndex = 58;
            this.CCid.Tag = "id_PrincipiActiu";
            // 
            // CCrao
            // 
            this.CCrao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCrao.Location = new System.Drawing.Point(180, 160);
            this.CCrao.Name = "CCrao";
            this.CCrao.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCrao.Placeholder = null;
            this.CCrao.Size = new System.Drawing.Size(197, 20);
            this.CCrao.TabIndex = 57;
            this.CCrao.Tag = "num_RegistreSanitari";
            // 
            // CCcif
            // 
            this.CCcif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcif.Location = new System.Drawing.Point(502, 59);
            this.CCcif.Name = "CCcif";
            this.CCcif.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcif.Placeholder = null;
            this.CCcif.Size = new System.Drawing.Size(197, 20);
            this.CCcif.TabIndex = 56;
            this.CCcif.Tag = "codi";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(338, -13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Manteniment de principis actius";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PrincipisActius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CCcodi);
            this.Controls.Add(this.CCid);
            this.Controls.Add(this.CCrao);
            this.Controls.Add(this.CCcif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "PrincipisActius";
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            this.Controls.SetChildIndex(this.btnAfegir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.CCcif, 0);
            this.Controls.SetChildIndex(this.CCrao, 0);
            this.Controls.SetChildIndex(this.CCid, 0);
            this.Controls.SetChildIndex(this.CCcodi, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private CustomControl.CustomTextBox CCcodi;
        private CustomControl.CustomTextBox CCid;
        private CustomControl.CustomTextBox CCrao;
        private CustomControl.CustomTextBox CCcif;
        private System.Windows.Forms.Label label2;
    }
}
