namespace KonyvtariNyilvantarto
{
    partial class frmMufajok
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
            this.dgvMufajok = new System.Windows.Forms.DataGridView();
            this.mufajAzonositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oszlopMufajNeve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mufajokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mufajokDataSet = new KonyvtariNyilvantarto.mufajokDataSet();
            this.btnMufajRogzit = new System.Windows.Forms.Button();
            this.btnMufajMent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbRogzit = new System.Windows.Forms.TextBox();
            this.tbMent = new System.Windows.Forms.TextBox();
            this.tbTorol = new System.Windows.Forms.TextBox();
            this.mufajokTableAdapter = new KonyvtariNyilvantarto.mufajokDataSetTableAdapters.MufajokTableAdapter();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbMufajNeve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMufajNeve = new System.Windows.Forms.Label();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnFrissit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMufajok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mufajokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mufajokDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMufajok
            // 
            this.dgvMufajok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMufajok.AutoGenerateColumns = false;
            this.dgvMufajok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMufajok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMufajok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMufajok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMufajok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mufajAzonositoDataGridViewTextBoxColumn,
            this.oszlopMufajNeve});
            this.dgvMufajok.DataSource = this.mufajokBindingSource;
            this.dgvMufajok.Location = new System.Drawing.Point(12, 136);
            this.dgvMufajok.Name = "dgvMufajok";
            this.dgvMufajok.Size = new System.Drawing.Size(617, 307);
            this.dgvMufajok.TabIndex = 0;
            // 
            // mufajAzonositoDataGridViewTextBoxColumn
            // 
            this.mufajAzonositoDataGridViewTextBoxColumn.DataPropertyName = "MufajAzonosito";
            this.mufajAzonositoDataGridViewTextBoxColumn.HeaderText = "MufajAzonosito";
            this.mufajAzonositoDataGridViewTextBoxColumn.Name = "mufajAzonositoDataGridViewTextBoxColumn";
            this.mufajAzonositoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oszlopMufajNeve
            // 
            this.oszlopMufajNeve.DataPropertyName = "MufajNeve";
            this.oszlopMufajNeve.HeaderText = "MufajNeve";
            this.oszlopMufajNeve.Name = "oszlopMufajNeve";
            // 
            // mufajokBindingSource
            // 
            this.mufajokBindingSource.DataMember = "Mufajok";
            this.mufajokBindingSource.DataSource = this.mufajokDataSet;
            // 
            // mufajokDataSet
            // 
            this.mufajokDataSet.DataSetName = "mufajokDataSet";
            this.mufajokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMufajRogzit
            // 
            this.btnMufajRogzit.Location = new System.Drawing.Point(22, 32);
            this.btnMufajRogzit.Name = "btnMufajRogzit";
            this.btnMufajRogzit.Size = new System.Drawing.Size(75, 23);
            this.btnMufajRogzit.TabIndex = 1;
            this.btnMufajRogzit.Text = "Rögzít";
            this.btnMufajRogzit.UseVisualStyleBackColor = true;
            this.btnMufajRogzit.Click += new System.EventHandler(this.btnMufajRogzit_Click);
            // 
            // btnMufajMent
            // 
            this.btnMufajMent.Location = new System.Drawing.Point(22, 61);
            this.btnMufajMent.Name = "btnMufajMent";
            this.btnMufajMent.Size = new System.Drawing.Size(75, 23);
            this.btnMufajMent.TabIndex = 2;
            this.btnMufajMent.Text = "Ment";
            this.btnMufajMent.UseVisualStyleBackColor = true;
            this.btnMufajMent.Click += new System.EventHandler(this.btnMufajMent_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Töröl";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbRogzit
            // 
            this.tbRogzit.Location = new System.Drawing.Point(103, 35);
            this.tbRogzit.Name = "tbRogzit";
            this.tbRogzit.Size = new System.Drawing.Size(100, 20);
            this.tbRogzit.TabIndex = 4;
            // 
            // tbMent
            // 
            this.tbMent.Location = new System.Drawing.Point(103, 61);
            this.tbMent.Name = "tbMent";
            this.tbMent.Size = new System.Drawing.Size(100, 20);
            this.tbMent.TabIndex = 5;
            // 
            // tbTorol
            // 
            this.tbTorol.Location = new System.Drawing.Point(103, 90);
            this.tbTorol.Name = "tbTorol";
            this.tbTorol.Size = new System.Drawing.Size(100, 20);
            this.tbTorol.TabIndex = 6;
            // 
            // mufajokTableAdapter
            // 
            this.mufajokTableAdapter.ClearBeforeFill = true;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(460, 22);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 7;
            this.btnHozzaad.Text = "Hozzáad";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mufajokBindingSource, "MufajAzonosito", true));
            this.textBox1.Location = new System.Drawing.Point(317, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // tbMufajNeve
            // 
            this.tbMufajNeve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mufajokBindingSource, "MufajNeve", true));
            this.tbMufajNeve.Location = new System.Drawing.Point(317, 72);
            this.tbMufajNeve.Name = "tbMufajNeve";
            this.tbMufajNeve.Size = new System.Drawing.Size(100, 20);
            this.tbMufajNeve.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // lblMufajNeve
            // 
            this.lblMufajNeve.AutoSize = true;
            this.lblMufajNeve.Location = new System.Drawing.Point(248, 75);
            this.lblMufajNeve.Name = "lblMufajNeve";
            this.lblMufajNeve.Size = new System.Drawing.Size(63, 13);
            this.lblMufajNeve.TabIndex = 11;
            this.lblMufajNeve.Text = "Műfaj neve:";
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(541, 22);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(75, 23);
            this.btnModosit.TabIndex = 12;
            this.btnModosit.Text = "Módosít";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(460, 70);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 13;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnFrissit
            // 
            this.btnFrissit.Location = new System.Drawing.Point(541, 69);
            this.btnFrissit.Name = "btnFrissit";
            this.btnFrissit.Size = new System.Drawing.Size(75, 23);
            this.btnFrissit.TabIndex = 14;
            this.btnFrissit.Text = "Frissítés";
            this.btnFrissit.UseVisualStyleBackColor = true;
            this.btnFrissit.Click += new System.EventHandler(this.btnFrissit_Click);
            // 
            // frmMufajok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.Controls.Add(this.btnFrissit);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.lblMufajNeve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMufajNeve);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.tbTorol);
            this.Controls.Add(this.tbMent);
            this.Controls.Add(this.tbRogzit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMufajMent);
            this.Controls.Add(this.btnMufajRogzit);
            this.Controls.Add(this.dgvMufajok);
            this.Name = "frmMufajok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Könyvek műfajai";
            this.Load += new System.EventHandler(this.frmMufajok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMufajok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mufajokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mufajokDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMufajok;
        private System.Windows.Forms.Button btnMufajRogzit;
        private System.Windows.Forms.Button btnMufajMent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbRogzit;
        private System.Windows.Forms.TextBox tbMent;
        private System.Windows.Forms.TextBox tbTorol;
        private mufajokDataSet mufajokDataSet;
        private System.Windows.Forms.BindingSource mufajokBindingSource;
        private mufajokDataSetTableAdapters.MufajokTableAdapter mufajokTableAdapter;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbMufajNeve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMufajNeve;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnFrissit;
        private System.Windows.Forms.DataGridViewTextBoxColumn mufajAzonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oszlopMufajNeve;
    }
}