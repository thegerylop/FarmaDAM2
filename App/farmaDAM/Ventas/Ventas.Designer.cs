namespace Ventas
{
    partial class Ventas
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
            this.label2 = new System.Windows.Forms.Label();
            this.CcomboBox = new CustomControl.comboBox();
            this.customTextBox1 = new CustomControl.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxMed = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.listViewCompra = new System.Windows.Forms.ListView();
            this.groupBoxLlista = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Medicament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantitat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.groupBoxLlista.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, -15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Laboratoris farmaceutics";
            // 
            // CcomboBox
            // 
            this.CcomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CcomboBox.FormattingEnabled = true;
            this.CcomboBox.Items.AddRange(new object[] {
            "DNI",
            "Targeta sanitaria"});
            this.CcomboBox.Location = new System.Drawing.Point(201, 78);
            this.CcomboBox.Name = "CcomboBox";
            this.CcomboBox.Reference = null;
            this.CcomboBox.Size = new System.Drawing.Size(107, 21);
            this.CcomboBox.TabIndex = 3;
            // 
            // customTextBox1
            // 
            this.customTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox1.Location = new System.Drawing.Point(63, 79);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox1.Placeholder = null;
            this.customTextBox1.Size = new System.Drawing.Size(121, 20);
            this.customTextBox1.TabIndex = 4;
            this.customTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customTextBox1_KeyPress);
            this.customTextBox1.Leave += new System.EventHandler(this.customTextBox1_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(7, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Client :";
            // 
            // groupBoxMed
            // 
            this.groupBoxMed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxMed.Controls.Add(this.label1);
            this.groupBoxMed.Controls.Add(this.dgvVentas);
            this.groupBoxMed.Location = new System.Drawing.Point(5, 137);
            this.groupBoxMed.Name = "groupBoxMed";
            this.groupBoxMed.Size = new System.Drawing.Size(539, 260);
            this.groupBoxMed.TabIndex = 51;
            this.groupBoxMed.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Medicaments :";
            // 
            // dgvVentas
            // 
            this.dgvVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(6, 65);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(522, 150);
            this.dgvVentas.TabIndex = 51;
            this.dgvVentas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentDoubleClick);
            // 
            // listViewCompra
            // 
            this.listViewCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Medicament,
            this.Preu,
            this.Quantitat});
            this.listViewCompra.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCompra.Location = new System.Drawing.Point(12, 47);
            this.listViewCompra.Name = "listViewCompra";
            this.listViewCompra.Size = new System.Drawing.Size(266, 356);
            this.listViewCompra.TabIndex = 52;
            this.listViewCompra.UseCompatibleStateImageBehavior = false;
            this.listViewCompra.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxLlista
            // 
            this.groupBoxLlista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxLlista.Controls.Add(this.label3);
            this.groupBoxLlista.Controls.Add(this.listViewCompra);
            this.groupBoxLlista.Location = new System.Drawing.Point(604, 31);
            this.groupBoxLlista.Name = "groupBoxLlista";
            this.groupBoxLlista.Size = new System.Drawing.Size(297, 429);
            this.groupBoxLlista.TabIndex = 53;
            this.groupBoxLlista.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Compra :";
            // 
            // Medicament
            // 
            this.Medicament.Text = "Medicament";
            // 
            // Preu
            // 
            this.Preu.Text = "Preu";
            // 
            // Quantitat
            // 
            this.Quantitat.Text = "Quantitat";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.groupBoxLlista);
            this.Controls.Add(this.groupBoxMed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.CcomboBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBoxMed.ResumeLayout(false);
            this.groupBoxMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.groupBoxLlista.ResumeLayout(false);
            this.groupBoxLlista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private CustomControl.comboBox CcomboBox;
        private CustomControl.CustomTextBox customTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ListView listViewCompra;
        private System.Windows.Forms.GroupBox groupBoxLlista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Medicament;
        private System.Windows.Forms.ColumnHeader Preu;
        private System.Windows.Forms.ColumnHeader Quantitat;
    }
}