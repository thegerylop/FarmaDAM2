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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.CCid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCid.Location = new System.Drawing.Point(229, 47);
            this.CCid.Name = "CCid";
            this.CCid.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.CCid.Placeholder = null;
            this.CCid.Size = new System.Drawing.Size(197, 27);
            this.CCid.TabIndex = 38;
            this.CCid.Tag = "id_lab";
            // 
            // CCcodi
            // 
            this.CCcodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcodi.Location = new System.Drawing.Point(229, 96);
            this.CCcodi.Name = "CCcodi";
            this.CCcodi.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.CCcodi.Placeholder = null;
            this.CCcodi.Size = new System.Drawing.Size(197, 27);
            this.CCcodi.TabIndex = 39;
            this.CCcodi.Tag = "codi_lab";
            // 
            // CCrao
            // 
            this.CCrao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCrao.Location = new System.Drawing.Point(229, 147);
            this.CCrao.Name = "CCrao";
            this.CCrao.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.CCrao.Placeholder = null;
            this.CCrao.Size = new System.Drawing.Size(197, 27);
            this.CCrao.TabIndex = 40;
            this.CCrao.Tag = "rao_social";
            // 
            // CCcif
            // 
            this.CCcif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcif.Location = new System.Drawing.Point(550, 47);
            this.CCcif.Name = "CCcif";
            this.CCcif.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.CCcif.Placeholder = null;
            this.CCcif.Size = new System.Drawing.Size(197, 27);
            this.CCcif.TabIndex = 41;
            this.CCcif.Tag = "cif";
            // 
            // CCden
            // 
            this.CCden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCden.Location = new System.Drawing.Point(550, 96);
            this.CCden.Name = "CCden";
            this.CCden.Options = CustomControlTB.CustomControlTB.Items.Password;
            this.CCden.Placeholder = null;
            this.CCden.Size = new System.Drawing.Size(197, 27);
            this.CCden.TabIndex = 42;
            this.CCden.Tag = "Denominacio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(198, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(178, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Codi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(139, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Raó social :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(507, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "CIF :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(444, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Denominació :";
            // 
            // Laboratoris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(913, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
