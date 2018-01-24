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
            this.btnEsborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(873, 220);
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
            this.btnActualitzar.Click += new System.EventHandler(this.actualitzar_Click);
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
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEsborrar
            // 
            this.btnEsborrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEsborrar.BackColor = System.Drawing.Color.DimGray;
            this.btnEsborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEsborrar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnEsborrar.ForeColor = System.Drawing.Color.White;
            this.btnEsborrar.Location = new System.Drawing.Point(507, 177);
            this.btnEsborrar.Name = "btnEsborrar";
            this.btnEsborrar.Size = new System.Drawing.Size(117, 26);
            this.btnEsborrar.TabIndex = 38;
            this.btnEsborrar.Text = "Esborrar";
            this.btnEsborrar.UseVisualStyleBackColor = false;
            this.btnEsborrar.Click += new System.EventHandler(this.btnEsborrar_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.btnEsborrar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.Tag = "test";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnEsborrar;
        public System.Windows.Forms.Button btnInserir;
        public System.Windows.Forms.Button btnActualitzar;
    }
}