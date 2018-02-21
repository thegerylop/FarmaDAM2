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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CCden = new CustomControl.CustomTextBox();
            this.CCcif = new CustomControl.CustomTextBox();
            this.CCrao = new CustomControl.CustomTextBox();
            this.CCcodi = new CustomControl.CustomTextBox();
            this.TxBFilter = new CustomControl.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnAfegir
            // 
            this.btnAfegir.TabIndex = 7;
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.TabIndex = 8;
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(153, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Codi :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(113, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Raó social :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(480, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "CIF :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(417, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Direcció :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, -13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Laboratoris farmaceutics";
            // 
            // CCden
            // 
            this.CCden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCden.Location = new System.Drawing.Point(523, 104);
            this.CCden.Name = "CCden";
            this.CCden.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCden.Placeholder = null;
            this.CCden.Size = new System.Drawing.Size(197, 20);
            this.CCden.TabIndex = 5;
            this.CCden.Tag = "direccio";
            // 
            // CCcif
            // 
            this.CCcif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcif.Location = new System.Drawing.Point(524, 54);
            this.CCcif.Name = "CCcif";
            this.CCcif.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcif.Placeholder = null;
            this.CCcif.Size = new System.Drawing.Size(197, 20);
            this.CCcif.TabIndex = 3;
            this.CCcif.Tag = "cif";
            // 
            // CCrao
            // 
            this.CCrao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCrao.Location = new System.Drawing.Point(203, 104);
            this.CCrao.Name = "CCrao";
            this.CCrao.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCrao.Placeholder = null;
            this.CCrao.Size = new System.Drawing.Size(197, 20);
            this.CCrao.TabIndex = 4;
            this.CCrao.Tag = "rao_social";
            // 
            // CCcodi
            // 
            this.CCcodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCcodi.Location = new System.Drawing.Point(203, 55);
            this.CCcodi.Name = "CCcodi";
            this.CCcodi.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCcodi.Placeholder = null;
            this.CCcodi.Size = new System.Drawing.Size(197, 20);
            this.CCcodi.TabIndex = 2;
            this.CCcodi.Tag = "codi_laboratori";
            // 
            // TxBFilter
            // 
            this.TxBFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBFilter.Location = new System.Drawing.Point(77, 183);
            this.TxBFilter.Name = "TxBFilter";
            this.TxBFilter.Options = CustomControl.CustomTextBox.Items.Text;
            this.TxBFilter.Placeholder = null;
            this.TxBFilter.Size = new System.Drawing.Size(197, 20);
            this.TxBFilter.TabIndex = 6;
            this.TxBFilter.Tag = "";
            this.TxBFilter.TextChanged += new System.EventHandler(this.TxBFilter_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Codi :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(507, 199);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(117, 14);
            this.progressBar1.TabIndex = 70;
            this.progressBar1.Visible = false;
            // 
            // Laboratoris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxBFilter);
            this.Controls.Add(this.CCcodi);
            this.Controls.Add(this.CCrao);
            this.Controls.Add(this.CCcif);
            this.Controls.Add(this.CCden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Laboratoris";
            this.Load += new System.EventHandler(this.Laboratoris_Load);
            this.Controls.SetChildIndex(this.btnXML, 0);
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnAfegir, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CCden, 0);
            this.Controls.SetChildIndex(this.CCcif, 0);
            this.Controls.SetChildIndex(this.CCrao, 0);
            this.Controls.SetChildIndex(this.CCcodi, 0);
            this.Controls.SetChildIndex(this.TxBFilter, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn idlabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codilabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raosocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private CustomControl.CustomTextBox CCden;
        private CustomControl.CustomTextBox CCcif;
        private CustomControl.CustomTextBox CCrao;
        private CustomControl.CustomTextBox CCcodi;
        private CustomControl.CustomTextBox TxBFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
