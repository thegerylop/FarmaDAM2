namespace CarregarDades
{
    partial class carregarDades
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
            this.btn_InserirDades = new System.Windows.Forms.Button();
            this.btn_FindFile = new System.Windows.Forms.Button();
            this.txt_RutaFitxer = new System.Windows.Forms.TextBox();
            this.lbl_progres = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_llargada = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btn_InserirDades
            // 
            this.btn_InserirDades.Location = new System.Drawing.Point(152, 283);
            this.btn_InserirDades.Name = "btn_InserirDades";
            this.btn_InserirDades.Size = new System.Drawing.Size(121, 23);
            this.btn_InserirDades.TabIndex = 0;
            this.btn_InserirDades.Text = "Inserir Dades";
            this.btn_InserirDades.UseVisualStyleBackColor = true;
            this.btn_InserirDades.Click += new System.EventHandler(this.btn_InserirDades_Click);
            // 
            // btn_FindFile
            // 
            this.btn_FindFile.Location = new System.Drawing.Point(152, 176);
            this.btn_FindFile.Name = "btn_FindFile";
            this.btn_FindFile.Size = new System.Drawing.Size(121, 23);
            this.btn_FindFile.TabIndex = 1;
            this.btn_FindFile.Text = "Escollir Arxiu";
            this.btn_FindFile.UseVisualStyleBackColor = true;
            this.btn_FindFile.Click += new System.EventHandler(this.btn_FindFile_Click);
            // 
            // txt_RutaFitxer
            // 
            this.txt_RutaFitxer.Location = new System.Drawing.Point(329, 178);
            this.txt_RutaFitxer.Name = "txt_RutaFitxer";
            this.txt_RutaFitxer.ReadOnly = true;
            this.txt_RutaFitxer.Size = new System.Drawing.Size(252, 20);
            this.txt_RutaFitxer.TabIndex = 2;
            // 
            // lbl_progres
            // 
            this.lbl_progres.AutoSize = true;
            this.lbl_progres.Location = new System.Drawing.Point(622, 183);
            this.lbl_progres.Name = "lbl_progres";
            this.lbl_progres.Size = new System.Drawing.Size(0, 13);
            this.lbl_progres.TabIndex = 3;
            this.lbl_progres.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lbl_llargada
            // 
            this.lbl_llargada.AutoSize = true;
            this.lbl_llargada.Location = new System.Drawing.Point(726, 424);
            this.lbl_llargada.Name = "lbl_llargada";
            this.lbl_llargada.Size = new System.Drawing.Size(0, 13);
            this.lbl_llargada.TabIndex = 4;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(152, 283);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(121, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancel·lar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 474);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(913, 10);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // carregarDades
            // 
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_llargada);
            this.Controls.Add(this.lbl_progres);
            this.Controls.Add(this.txt_RutaFitxer);
            this.Controls.Add(this.btn_FindFile);
            this.Controls.Add(this.btn_InserirDades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "carregarDades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InserirDades;
        private System.Windows.Forms.Button btn_FindFile;
        private System.Windows.Forms.TextBox txt_RutaFitxer;
        private System.Windows.Forms.Label lbl_progres;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_llargada;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
