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
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnAfegir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBase
            // 
            this.dgvBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBase.BackgroundColor = System.Drawing.Color.White;
            this.dgvBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBase.Location = new System.Drawing.Point(12, 209);
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.Size = new System.Drawing.Size(873, 255);
            this.dgvBase.TabIndex = 0;
            this.dgvBase.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvBase_DataError);
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
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // btnAfegir
            // 
            this.btnAfegir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAfegir.BackColor = System.Drawing.Color.DimGray;
            this.btnAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAfegir.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnAfegir.ForeColor = System.Drawing.Color.White;
            this.btnAfegir.Location = new System.Drawing.Point(630, 177);
            this.btnAfegir.Name = "btnAfegir";
            this.btnAfegir.Size = new System.Drawing.Size(117, 26);
            this.btnAfegir.TabIndex = 38;
            this.btnAfegir.Text = "Afegir";
            this.btnAfegir.UseVisualStyleBackColor = false;
            this.btnAfegir.Click += new System.EventHandler(this.btnAfegir_Click_1);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.btnAfegir);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.dgvBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.Tag = "test";
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnAfegir;
        public System.Windows.Forms.Button btnActualitzar;
        public System.Windows.Forms.DataGridView dgvBase;
    }
}