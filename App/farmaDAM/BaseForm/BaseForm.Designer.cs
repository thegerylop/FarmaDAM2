namespace BaseForm
{
    partial class BaseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAfegir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(873, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualitzar.BackColor = System.Drawing.Color.DimGray;
            this.btnActualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualitzar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnActualitzar.ForeColor = System.Drawing.Color.White;
            this.btnActualitzar.Location = new System.Drawing.Point(753, 177);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(132, 26);
            this.btnActualitzar.TabIndex = 36;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = false;
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInserir.BackColor = System.Drawing.Color.DimGray;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(630, 177);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(117, 26);
            this.btnInserir.TabIndex = 37;
            this.btnInserir.Text = "Portar dades";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click_1);
            // 
            // btnAfegir
            // 
            this.btnAfegir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAfegir.BackColor = System.Drawing.Color.DimGray;
            this.btnAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAfegir.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnAfegir.ForeColor = System.Drawing.Color.White;
            this.btnAfegir.Location = new System.Drawing.Point(507, 177);
            this.btnAfegir.Name = "btnAfegir";
            this.btnAfegir.Size = new System.Drawing.Size(117, 26);
            this.btnAfegir.TabIndex = 38;
            this.btnAfegir.Text = "Afegir";
            this.btnAfegir.UseVisualStyleBackColor = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.btnAfegir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.Tag = "test";
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnAfegir;
        public System.Windows.Forms.Button btnInserir;
        public System.Windows.Forms.Button btnActualitzar;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}