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
            this.idlabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codilabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raosocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCid = new CustomControlTB.CustomControlTB();
            this.CCcodi = new CustomControlTB.CustomControlTB();
            this.CCrao = new CustomControlTB.CustomControlTB();
            this.CCcif = new CustomControlTB.CustomControlTB();
            this.CCden = new CustomControlTB.CustomControlTB();
            this.SuspendLayout();
            // 
            // idlabDataGridViewTextBoxColumn
            // 
            this.idlabDataGridViewTextBoxColumn.DataPropertyName = "id_lab";
            this.idlabDataGridViewTextBoxColumn.HeaderText = "id_lab";
            this.idlabDataGridViewTextBoxColumn.Name = "idlabDataGridViewTextBoxColumn";
            // 
            // codilabDataGridViewTextBoxColumn
            // 
            this.codilabDataGridViewTextBoxColumn.DataPropertyName = "codi_lab";
            this.codilabDataGridViewTextBoxColumn.HeaderText = "codi_lab";
            this.codilabDataGridViewTextBoxColumn.Name = "codilabDataGridViewTextBoxColumn";
            // 
            // raosocialDataGridViewTextBoxColumn
            // 
            this.raosocialDataGridViewTextBoxColumn.DataPropertyName = "rao_social";
            this.raosocialDataGridViewTextBoxColumn.HeaderText = "rao_social";
            this.raosocialDataGridViewTextBoxColumn.Name = "raosocialDataGridViewTextBoxColumn";
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.HeaderText = "cif";
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            // 
            // denominacioDataGridViewTextBoxColumn
            // 
            this.denominacioDataGridViewTextBoxColumn.DataPropertyName = "denominacio";
            this.denominacioDataGridViewTextBoxColumn.HeaderText = "denominacio";
            this.denominacioDataGridViewTextBoxColumn.Name = "denominacioDataGridViewTextBoxColumn";
            // 
            // CCid
            // 
            this.CCid.Location = new System.Drawing.Point(192, 29);
            this.CCid.Name = "CCid";
            this.CCid.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.CCid.Placeholder = null;
            this.CCid.Size = new System.Drawing.Size(197, 27);
            this.CCid.TabIndex = 38;
            this.CCid.Tag = "id_lab";
            // 
            // CCcodi
            // 
            this.CCcodi.Location = new System.Drawing.Point(192, 78);
            this.CCcodi.Name = "CCcodi";
            this.CCcodi.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.CCcodi.Placeholder = null;
            this.CCcodi.Size = new System.Drawing.Size(197, 27);
            this.CCcodi.TabIndex = 39;
            this.CCcodi.Tag = "codi_lab";
            // 
            // CCrao
            // 
            this.CCrao.Location = new System.Drawing.Point(192, 129);
            this.CCrao.Name = "CCrao";
            this.CCrao.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.CCrao.Placeholder = null;
            this.CCrao.Size = new System.Drawing.Size(197, 27);
            this.CCrao.TabIndex = 40;
            this.CCrao.Tag = "rao_social";
            // 
            // CCcif
            // 
            this.CCcif.Location = new System.Drawing.Point(513, 29);
            this.CCcif.Name = "CCcif";
            this.CCcif.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.CCcif.Placeholder = null;
            this.CCcif.Size = new System.Drawing.Size(197, 27);
            this.CCcif.TabIndex = 41;
            this.CCcif.Tag = "cif";
            // 
            // CCden
            // 
            this.CCden.Location = new System.Drawing.Point(513, 78);
            this.CCden.Name = "CCden";
            this.CCden.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.CCden.Placeholder = null;
            this.CCden.Size = new System.Drawing.Size(197, 27);
            this.CCden.TabIndex = 42;
            this.CCden.Tag = "Denominacio";
            // 
            // Laboratoris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1199, 648);
            this.Controls.Add(this.CCden);
            this.Controls.Add(this.CCcif);
            this.Controls.Add(this.CCrao);
            this.Controls.Add(this.CCcodi);
            this.Controls.Add(this.CCid);
            this.Name = "Laboratoris";
            this.Controls.SetChildIndex(this.CCid, 0);
            this.Controls.SetChildIndex(this.CCcodi, 0);
            this.Controls.SetChildIndex(this.CCrao, 0);
            this.Controls.SetChildIndex(this.CCcif, 0);
            this.Controls.SetChildIndex(this.CCden, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn idlabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codilabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raosocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacioDataGridViewTextBoxColumn;
        private CustomControlTB.CustomControlTB CCid;
        private CustomControlTB.CustomControlTB CCcodi;
        private CustomControlTB.CustomControlTB CCrao;
        private CustomControlTB.CustomControlTB CCcif;
        private CustomControlTB.CustomControlTB CCden;
    }
}
