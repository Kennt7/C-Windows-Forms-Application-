namespace KonyvtariNyilvantarto
{
    partial class frmSelejtKonyvek
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSelejtek = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSelejtezesDarabszama = new System.Windows.Forms.TextBox();
            this.tbSelejtezesDatuma = new System.Windows.Forms.TextBox();
            this.tbSelejtezesOka = new System.Windows.Forms.TextBox();
            this.tbKonyvAzonosito = new System.Windows.Forms.TextBox();
            this.tbSelejtAzonosito = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSelejtHozzad = new System.Windows.Forms.Button();
            this.selejtKonyvekDataSet = new KonyvtariNyilvantarto.SelejtKonyvekDataSet();
            this.selejtKonyvekTableAdapter = new KonyvtariNyilvantarto.SelejtKonyvekDataSetTableAdapters.SelejtKonyvekTableAdapter();
            this.selejtKonyvekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selejtAzonositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konyvAzonositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selejtezesOkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selejtezesDatumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selejtezettekDarabszamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelejtek)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selejtKonyvekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selejtKonyvekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelejtek
            // 
            this.dgvSelejtek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelejtek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selejtAzonositoDataGridViewTextBoxColumn,
            this.konyvAzonositoDataGridViewTextBoxColumn,
            this.selejtezesOkaDataGridViewTextBoxColumn,
            this.selejtezesDatumaDataGridViewTextBoxColumn,
            this.selejtezettekDarabszamaDataGridViewTextBoxColumn});
            this.dgvSelejtek.Location = new System.Drawing.Point(356, 42);
            this.dgvSelejtek.Name = "dgvSelejtek";
            this.dgvSelejtek.Size = new System.Drawing.Size(605, 225);
            this.dgvSelejtek.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSelejtezesDarabszama);
            this.groupBox1.Controls.Add(this.tbSelejtezesDatuma);
            this.groupBox1.Controls.Add(this.tbSelejtezesOka);
            this.groupBox1.Controls.Add(this.tbKonyvAzonosito);
            this.groupBox1.Controls.Add(this.tbSelejtAzonosito);
            this.groupBox1.Location = new System.Drawing.Point(25, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok felvitele";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Selejtezés darabszáma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Selejtezés dátuma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Selejtezés oka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Könyv azonosító";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selejt azonosító:";
            // 
            // tbSelejtezesDarabszama
            // 
            this.tbSelejtezesDarabszama.Location = new System.Drawing.Point(130, 168);
            this.tbSelejtezesDarabszama.Name = "tbSelejtezesDarabszama";
            this.tbSelejtezesDarabszama.Size = new System.Drawing.Size(100, 20);
            this.tbSelejtezesDarabszama.TabIndex = 10;
            // 
            // tbSelejtezesDatuma
            // 
            this.tbSelejtezesDatuma.Location = new System.Drawing.Point(130, 137);
            this.tbSelejtezesDatuma.Name = "tbSelejtezesDatuma";
            this.tbSelejtezesDatuma.Size = new System.Drawing.Size(100, 20);
            this.tbSelejtezesDatuma.TabIndex = 9;
            // 
            // tbSelejtezesOka
            // 
            this.tbSelejtezesOka.Location = new System.Drawing.Point(130, 104);
            this.tbSelejtezesOka.Name = "tbSelejtezesOka";
            this.tbSelejtezesOka.Size = new System.Drawing.Size(100, 20);
            this.tbSelejtezesOka.TabIndex = 8;
            // 
            // tbKonyvAzonosito
            // 
            this.tbKonyvAzonosito.Location = new System.Drawing.Point(130, 71);
            this.tbKonyvAzonosito.Name = "tbKonyvAzonosito";
            this.tbKonyvAzonosito.Size = new System.Drawing.Size(100, 20);
            this.tbKonyvAzonosito.TabIndex = 7;
            // 
            // tbSelejtAzonosito
            // 
            this.tbSelejtAzonosito.Location = new System.Drawing.Point(130, 45);
            this.tbSelejtAzonosito.Name = "tbSelejtAzonosito";
            this.tbSelejtAzonosito.Size = new System.Drawing.Size(100, 20);
            this.tbSelejtAzonosito.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnSelejtHozzad);
            this.groupBox2.Location = new System.Drawing.Point(48, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 208);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Műveletek";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(132, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSelejtHozzad
            // 
            this.btnSelejtHozzad.Location = new System.Drawing.Point(26, 36);
            this.btnSelejtHozzad.Name = "btnSelejtHozzad";
            this.btnSelejtHozzad.Size = new System.Drawing.Size(75, 23);
            this.btnSelejtHozzad.TabIndex = 0;
            this.btnSelejtHozzad.Text = "Selejtezés";
            this.btnSelejtHozzad.UseVisualStyleBackColor = true;
            this.btnSelejtHozzad.Click += new System.EventHandler(this.btnSelejtHozzad_Click);
            // 
            // selejtKonyvekDataSet
            // 
            this.selejtKonyvekDataSet.DataSetName = "SelejtKonyvekDataSet";
            this.selejtKonyvekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selejtKonyvekTableAdapter
            // 
            this.selejtKonyvekTableAdapter.ClearBeforeFill = true;
            // 
            // selejtKonyvekBindingSource
            // 
            this.selejtKonyvekBindingSource.DataMember = "SelejtKonyvek";
            this.selejtKonyvekBindingSource.DataSource = this.selejtKonyvekDataSet;
            // 
            // selejtAzonositoDataGridViewTextBoxColumn
            // 
            this.selejtAzonositoDataGridViewTextBoxColumn.DataPropertyName = "SelejtAzonosito";
            this.selejtAzonositoDataGridViewTextBoxColumn.HeaderText = "SelejtAzonosito";
            this.selejtAzonositoDataGridViewTextBoxColumn.Name = "selejtAzonositoDataGridViewTextBoxColumn";
            // 
            // konyvAzonositoDataGridViewTextBoxColumn
            // 
            this.konyvAzonositoDataGridViewTextBoxColumn.DataPropertyName = "KonyvAzonosito";
            this.konyvAzonositoDataGridViewTextBoxColumn.HeaderText = "KonyvAzonosito";
            this.konyvAzonositoDataGridViewTextBoxColumn.Name = "konyvAzonositoDataGridViewTextBoxColumn";
            // 
            // selejtezesOkaDataGridViewTextBoxColumn
            // 
            this.selejtezesOkaDataGridViewTextBoxColumn.DataPropertyName = "SelejtezesOka";
            this.selejtezesOkaDataGridViewTextBoxColumn.HeaderText = "SelejtezesOka";
            this.selejtezesOkaDataGridViewTextBoxColumn.Name = "selejtezesOkaDataGridViewTextBoxColumn";
            // 
            // selejtezesDatumaDataGridViewTextBoxColumn
            // 
            this.selejtezesDatumaDataGridViewTextBoxColumn.DataPropertyName = "SelejtezesDatuma";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.selejtezesDatumaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.selejtezesDatumaDataGridViewTextBoxColumn.HeaderText = "SelejtezesDatuma";
            this.selejtezesDatumaDataGridViewTextBoxColumn.Name = "selejtezesDatumaDataGridViewTextBoxColumn";
            // 
            // selejtezettekDarabszamaDataGridViewTextBoxColumn
            // 
            this.selejtezettekDarabszamaDataGridViewTextBoxColumn.DataPropertyName = "SelejtezettekDarabszama";
            this.selejtezettekDarabszamaDataGridViewTextBoxColumn.HeaderText = "SelejtezettekDarabszama";
            this.selejtezettekDarabszamaDataGridViewTextBoxColumn.Name = "selejtezettekDarabszamaDataGridViewTextBoxColumn";
            // 
            // frmSelejtKonyvek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSelejtek);
            this.Name = "frmSelejtKonyvek";
            this.Text = "frmSelejtKonyvek";
            this.Load += new System.EventHandler(this.frmSelejtKonyvek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelejtek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selejtKonyvekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selejtKonyvekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelejtek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSelejtAzonosito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSelejtezesDarabszama;
        private System.Windows.Forms.TextBox tbSelejtezesDatuma;
        private System.Windows.Forms.TextBox tbSelejtezesOka;
        private System.Windows.Forms.TextBox tbKonyvAzonosito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSelejtHozzad;
        private SelejtKonyvekDataSet selejtKonyvekDataSet;
        private SelejtKonyvekDataSetTableAdapters.SelejtKonyvekTableAdapter selejtKonyvekTableAdapter;
        private System.Windows.Forms.BindingSource selejtKonyvekBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn selejtAzonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konyvAzonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selejtezesOkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selejtezesDatumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selejtezettekDarabszamaDataGridViewTextBoxColumn;
    }
}