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
            this.label2 = new System.Windows.Forms.Label();
            this.CCcodi = new CustomControl.CustomTextBox();
            this.CCrao = new CustomControl.CustomTextBox();
            this.CCcif = new CustomControl.CustomTextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbActius = new System.Windows.Forms.ComboBox();
            this.TxBFilter = new CustomControl.CustomTextBox();
            this.SuspendLayout();
            // 
            // btnAfegir
            // 
            this.btnAfegir.TabIndex = 6;
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(441, 59);
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
            this.label5.Location = new System.Drawing.Point(57, 109);
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
            this.label4.Location = new System.Drawing.Point(160, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, -13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manteniment de principis actius";
            // 
            // CCcodi
            // 
            this.CCcodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcodi.Location = new System.Drawing.Point(211, 59);
            this.CCcodi.Name = "CCcodi";
            this.CCcodi.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcodi.Placeholder = null;
            this.CCcodi.Size = new System.Drawing.Size(197, 20);
            this.CCcodi.TabIndex = 2;
            this.CCcodi.Tag = "nom";
            // 
            // CCrao
            // 
            this.CCrao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCrao.Location = new System.Drawing.Point(211, 109);
            this.CCrao.Name = "CCrao";
            this.CCrao.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCrao.Placeholder = null;
            this.CCrao.Size = new System.Drawing.Size(197, 20);
            this.CCrao.TabIndex = 4;
            this.CCrao.Tag = "num_RegistreSanitari";
            // 
            // CCcif
            // 
            this.CCcif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcif.Location = new System.Drawing.Point(498, 59);
            this.CCcif.Name = "CCcif";
            this.CCcif.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcif.Placeholder = null;
            this.CCcif.Size = new System.Drawing.Size(197, 20);
            this.CCcif.TabIndex = 3;
            this.CCcif.Tag = "codi";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(6, 183);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 18);
            this.lblFiltrar.TabIndex = 55;
            this.lblFiltrar.Text = "Filtrar :";
            // 
            // cbActius
            // 
            this.cbActius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbActius.AutoCompleteCustomSource.AddRange(new string[] {
            "codi_laboratori",
            "rao_social",
            "cif",
            "denominacio"});
            this.cbActius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActius.FormattingEnabled = true;
            this.cbActius.Items.AddRange(new object[] {
            "Nom",
            "Número Registre Sanitari",
            "Codi"});
            this.cbActius.Location = new System.Drawing.Point(287, 183);
            this.cbActius.Name = "cbActius";
            this.cbActius.Size = new System.Drawing.Size(121, 21);
            this.cbActius.TabIndex = 54;
            this.cbActius.SelectedValueChanged += new System.EventHandler(this.cbActius_SelectedValueChanged);
            // 
            // TxBFilter
            // 
            this.TxBFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBFilter.Location = new System.Drawing.Point(60, 183);
            this.TxBFilter.Name = "TxBFilter";
            this.TxBFilter.Options = CustomControl.CustomTextBox.Items.Text;
            this.TxBFilter.Placeholder = null;
            this.TxBFilter.Size = new System.Drawing.Size(221, 20);
            this.TxBFilter.TabIndex = 53;
            this.TxBFilter.Tag = "";
            this.TxBFilter.TextChanged += new System.EventHandler(this.TxBFilter_TextChanged_1);
            // 
            // PrincipisActius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbActius);
            this.Controls.Add(this.TxBFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CCcodi);
            this.Controls.Add(this.CCrao);
            this.Controls.Add(this.CCcif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "PrincipisActius";
            this.Load += new System.EventHandler(this.PrincipisActius_Load);
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnAfegir, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.CCcif, 0);
            this.Controls.SetChildIndex(this.CCrao, 0);
            this.Controls.SetChildIndex(this.CCcodi, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxBFilter, 0);
            this.Controls.SetChildIndex(this.cbActius, 0);
            this.Controls.SetChildIndex(this.lblFiltrar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CustomControl.CustomTextBox CCcodi;
        private CustomControl.CustomTextBox CCrao;
        private CustomControl.CustomTextBox CCcif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbActius;
        private CustomControl.CustomTextBox TxBFilter;
    }
}
