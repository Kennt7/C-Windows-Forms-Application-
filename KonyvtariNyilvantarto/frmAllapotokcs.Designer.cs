namespace KonyvtariNyilvantarto
{
    partial class frmAllapotok
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
            this.components = new System.ComponentModel.Container();
            this.btnAllapotokHozzaadas = new System.Windows.Forms.Button();
            this.btnAllapotokModositas = new System.Windows.Forms.Button();
            this.btnAllapotokMentes = new System.Windows.Forms.Button();
            this.btnAllapotokTorles = new System.Windows.Forms.Button();
            this.btnAllapotokFrissites = new System.Windows.Forms.Button();
            this.btnAllapotokUjbevitel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAllapotneve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAllapotazonosito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllapotok = new System.Windows.Forms.DataGridView();
            this.allapotokDST = new KonyvtariNyilvantarto.allapotokDST();
            this.allapotokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allapotokTableAdapter = new KonyvtariNyilvantarto.allapotokDSTTableAdapters.AllapotokTableAdapter();
            this.AllapotAzonosito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllapotNeve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllapotok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allapotokDST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allapotokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllapotokHozzaadas
            // 
            this.btnAllapotokHozzaadas.Location = new System.Drawing.Point(5, 12);
            this.btnAllapotokHozzaadas.Name = "btnAllapotokHozzaadas";
            this.btnAllapotokHozzaadas.Size = new System.Drawing.Size(75, 23);
            this.btnAllapotokHozzaadas.TabIndex = 1;
            this.btnAllapotokHozzaadas.Text = "Hozzáadás";
            this.btnAllapotokHozzaadas.UseVisualStyleBackColor = true;
            this.btnAllapotokHozzaadas.Click += new System.EventHandler(this.btnAllapotokHozzaadas_Click);
            // 
            // btnAllapotokModositas
            // 
            this.btnAllapotokModositas.Location = new System.Drawing.Point(5, 41);
            this.btnAllapotokModositas.Name = "btnAllapotokModositas";
            this.btnAllapotokModositas.Size = new System.Drawing.Size(75, 23);
            this.btnAllapotokModositas.TabIndex = 1;
            this.btnAllapotokModositas.Text = "Módosítás";
            this.btnAllapotokModositas.UseVisualStyleBackColor = true;
            // 
            // btnAllapotokMentes
            // 
            this.btnAllapotokMentes.Location = new System.Drawing.Point(5, 70);
            this.btnAllapotokMentes.Name = "btnAllapotokMentes";
            this.btnAllapotokMentes.Size = new System.Drawing.Size(75, 23);
            this.btnAllapotokMentes.TabIndex = 1;
            this.btnAllapotokMentes.Text = "Mentés";
            this.btnAllapotokMentes.UseVisualStyleBackColor = true;
            // 
            // btnAllapotokTorles
            // 
            this.btnAllapotokTorles.Location = new System.Drawing.Point(5, 99);
            this.btnAllapotokTorles.Name = "btnAllapotokTorles";
            this.btnAllapotokTorles.Size = new System.Drawing.Size(75, 23);
            this.btnAllapotokTorles.TabIndex = 1;
            this.btnAllapotokTorles.Text = "Törlés";
            this.btnAllapotokTorles.UseVisualStyleBackColor = true;
            // 
            // btnAllapotokFrissites
            // 
            this.btnAllapotokFrissites.Location = new System.Drawing.Point(5, 128);
            this.btnAllapotokFrissites.Name = "btnAllapotokFrissites";
            this.btnAllapotokFrissites.Size = new System.Drawing.Size(75, 23);
            this.btnAllapotokFrissites.TabIndex = 1;
            this.btnAllapotokFrissites.Text = "Frissítés";
            this.btnAllapotokFrissites.UseVisualStyleBackColor = true;
            // 
            // btnAllapotokUjbevitel
            // 
            this.btnAllapotokUjbevitel.Location = new System.Drawing.Point(5, 157);
            this.btnAllapotokUjbevitel.Name = "btnAllapotokUjbevitel";
            this.btnAllapotokUjbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAllapotokUjbevitel.TabIndex = 1;
            this.btnAllapotokUjbevitel.Text = "Új bevitel";
            this.btnAllapotokUjbevitel.UseVisualStyleBackColor = true;
            this.btnAllapotokUjbevitel.Click += new System.EventHandler(this.btnAllapotokUjbevitel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAllapotneve);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAllapotazonosito);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatbevitel";
            // 
            // tbAllapotneve
            // 
            this.tbAllapotneve.Location = new System.Drawing.Point(10, 74);
            this.tbAllapotneve.Name = "tbAllapotneve";
            this.tbAllapotneve.Size = new System.Drawing.Size(94, 20);
            this.tbAllapotneve.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Állapot neve:";
            // 
            // tbAllapotazonosito
            // 
            this.tbAllapotazonosito.Location = new System.Drawing.Point(10, 37);
            this.tbAllapotazonosito.Name = "tbAllapotazonosito";
            this.tbAllapotazonosito.Size = new System.Drawing.Size(66, 20);
            this.tbAllapotazonosito.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Állapotazonosító:";
            // 
            // dgvAllapotok
            // 
            this.dgvAllapotok.AutoGenerateColumns = false;
            this.dgvAllapotok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllapotok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AllapotAzonosito,
            this.AllapotNeve});
            this.dgvAllapotok.DataSource = this.allapotokBindingSource;
            this.dgvAllapotok.Location = new System.Drawing.Point(152, 12);
            this.dgvAllapotok.Name = "dgvAllapotok";
            this.dgvAllapotok.Size = new System.Drawing.Size(259, 278);
            this.dgvAllapotok.TabIndex = 3;
            // 
            // allapotokDST
            // 
            this.allapotokDST.DataSetName = "allapotokDST";
            this.allapotokDST.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allapotokBindingSource
            // 
            this.allapotokBindingSource.DataMember = "Allapotok";
            this.allapotokBindingSource.DataSource = this.allapotokDST;
            // 
            // allapotokTableAdapter
            // 
            this.allapotokTableAdapter.ClearBeforeFill = true;
            // 
            // AllapotAzonosito
            // 
            this.AllapotAzonosito.DataPropertyName = "AllapotAzonosito";
            this.AllapotAzonosito.HeaderText = "AllapotAzonosito";
            this.AllapotAzonosito.Name = "AllapotAzonosito";
            this.AllapotAzonosito.ReadOnly = true;
            // 
            // AllapotNeve
            // 
            this.AllapotNeve.DataPropertyName = "AllapotNeve";
            this.AllapotNeve.HeaderText = "AllapotNeve";
            this.AllapotNeve.Name = "AllapotNeve";
            // 
            // frmAllapotok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 412);
            this.Controls.Add(this.dgvAllapotok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAllapotokUjbevitel);
            this.Controls.Add(this.btnAllapotokFrissites);
            this.Controls.Add(this.btnAllapotokTorles);
            this.Controls.Add(this.btnAllapotokMentes);
            this.Controls.Add(this.btnAllapotokModositas);
            this.Controls.Add(this.btnAllapotokHozzaadas);
            this.Name = "frmAllapotok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Könyvek minőségi állapota";
            this.Load += new System.EventHandler(this.frmAllapotok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllapotok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allapotokDST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allapotokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn allapotAzonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allapotNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAllapotokHozzaadas;
        private System.Windows.Forms.Button btnAllapotokModositas;
        private System.Windows.Forms.Button btnAllapotokMentes;
        private System.Windows.Forms.Button btnAllapotokTorles;
        private System.Windows.Forms.Button btnAllapotokFrissites;
        private System.Windows.Forms.Button btnAllapotokUjbevitel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAllapotneve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAllapotazonosito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllapotok;
        private allapotokDST allapotokDST;
        private System.Windows.Forms.BindingSource allapotokBindingSource;
        private allapotokDSTTableAdapters.AllapotokTableAdapter allapotokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllapotAzonosito;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllapotNeve;
    }
}