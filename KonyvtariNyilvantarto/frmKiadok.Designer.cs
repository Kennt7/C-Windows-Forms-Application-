namespace KonyvtariNyilvantarto
{
    partial class frmKiadok
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kiadokDataSet = new KonyvtariNyilvantarto.kiadokDataSet();
            this.konyvKiadokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konyvKiadokTableAdapter = new KonyvtariNyilvantarto.kiadokDataSetTableAdapters.KonyvKiadokTableAdapter();
            this.kiadoAzonositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadoNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiadokDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konyvKiadokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kiadoAzonositoDataGridViewTextBoxColumn,
            this.kiadoNeveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.konyvKiadokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(85, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // kiadokDataSet
            // 
            this.kiadokDataSet.DataSetName = "kiadokDataSet";
            this.kiadokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // konyvKiadokBindingSource
            // 
            this.konyvKiadokBindingSource.DataMember = "KonyvKiadok";
            this.konyvKiadokBindingSource.DataSource = this.kiadokDataSet;
            // 
            // konyvKiadokTableAdapter
            // 
            this.konyvKiadokTableAdapter.ClearBeforeFill = true;
            // 
            // kiadoAzonositoDataGridViewTextBoxColumn
            // 
            this.kiadoAzonositoDataGridViewTextBoxColumn.DataPropertyName = "KiadoAzonosito";
            this.kiadoAzonositoDataGridViewTextBoxColumn.HeaderText = "KiadoAzonosito";
            this.kiadoAzonositoDataGridViewTextBoxColumn.Name = "kiadoAzonositoDataGridViewTextBoxColumn";
            this.kiadoAzonositoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kiadoNeveDataGridViewTextBoxColumn
            // 
            this.kiadoNeveDataGridViewTextBoxColumn.DataPropertyName = "KiadoNeve";
            this.kiadoNeveDataGridViewTextBoxColumn.HeaderText = "KiadoNeve";
            this.kiadoNeveDataGridViewTextBoxColumn.Name = "kiadoNeveDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 343);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // frmKiadok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 469);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKiadok";
            this.Text = "frmKiadok";
            this.Load += new System.EventHandler(this.frmKiadok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiadokDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konyvKiadokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kiadokDataSet kiadokDataSet;
        private System.Windows.Forms.BindingSource konyvKiadokBindingSource;
        private kiadokDataSetTableAdapters.KonyvKiadokTableAdapter konyvKiadokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiadoAzonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiadoNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}