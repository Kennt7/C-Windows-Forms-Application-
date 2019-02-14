namespace KonyvtariNyilvantarto
{
    partial class frmKolcsonzok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKolcsonzok));
            this.btnKilep = new System.Windows.Forms.Button();
            this.btnKolcsonzokFrissites = new System.Windows.Forms.Button();
            this.btnfrmKonyvekTorol = new System.Windows.Forms.Button();
            this.btnfrmKolcsonzokMent = new System.Windows.Forms.Button();
            this.btnfrmKonyvekModosit = new System.Windows.Forms.Button();
            this.btnKolcsonzokRogzit = new System.Windows.Forms.Button();
            this.lblfrmKolcsonzok = new System.Windows.Forms.Label();
            this.gbKolcsonzokMuveletek = new System.Windows.Forms.GroupBox();
            this.btnUjbevitel = new System.Windows.Forms.Button();
            this.gbKolcsonzok2 = new System.Windows.Forms.GroupBox();
            this.tbKolcsonzoAzonosito = new System.Windows.Forms.TextBox();
            this.kolcsonzokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolcsonzokDataSet = new KonyvtariNyilvantarto.kolcsonzokDataSet();
            this.lblKolcsonzoAzonosito = new System.Windows.Forms.Label();
            this.lblTagdij = new System.Windows.Forms.Label();
            this.tbKolcsonzoKeresztnev = new System.Windows.Forms.TextBox();
            this.tbKolcsonzoVezeteknev = new System.Windows.Forms.TextBox();
            this.tbTagdij = new System.Windows.Forms.TextBox();
            this.tbKolcsonzoDarabszam = new System.Windows.Forms.TextBox();
            this.tbKolcsonzoLakohely = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKolcsonzoEmailCim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKolcsonzoTelefonszam = new System.Windows.Forms.TextBox();
            this.dgvKolcsonzok = new System.Windows.Forms.DataGridView();
            this.KA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolcsonzokTableAdapter = new KonyvtariNyilvantarto.kolcsonzokDataSetTableAdapters.KolcsonzokTableAdapter();
            this.gbKolcsonzokMuveletek.SuspendLayout();
            this.gbKolcsonzok2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolcsonzokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolcsonzokDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolcsonzok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(697, 410);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 24);
            this.btnKilep.TabIndex = 16;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // btnKolcsonzokFrissites
            // 
            this.btnKolcsonzokFrissites.Location = new System.Drawing.Point(155, 59);
            this.btnKolcsonzokFrissites.Name = "btnKolcsonzokFrissites";
            this.btnKolcsonzokFrissites.Size = new System.Drawing.Size(70, 30);
            this.btnKolcsonzokFrissites.TabIndex = 15;
            this.btnKolcsonzokFrissites.Text = "Frissítés";
            this.btnKolcsonzokFrissites.UseVisualStyleBackColor = true;
            this.btnKolcsonzokFrissites.Click += new System.EventHandler(this.btnKolcsonzokFrissites_Click);
            // 
            // btnfrmKonyvekTorol
            // 
            this.btnfrmKonyvekTorol.Location = new System.Drawing.Point(85, 59);
            this.btnfrmKonyvekTorol.Name = "btnfrmKonyvekTorol";
            this.btnfrmKonyvekTorol.Size = new System.Drawing.Size(70, 30);
            this.btnfrmKonyvekTorol.TabIndex = 14;
            this.btnfrmKonyvekTorol.Text = "Töröl";
            this.btnfrmKonyvekTorol.UseVisualStyleBackColor = true;
            this.btnfrmKonyvekTorol.Click += new System.EventHandler(this.btnfrmKonyvekTorol_Click);
            // 
            // btnfrmKolcsonzokMent
            // 
            this.btnfrmKolcsonzokMent.Location = new System.Drawing.Point(15, 59);
            this.btnfrmKolcsonzokMent.Name = "btnfrmKolcsonzokMent";
            this.btnfrmKolcsonzokMent.Size = new System.Drawing.Size(70, 30);
            this.btnfrmKolcsonzokMent.TabIndex = 13;
            this.btnfrmKolcsonzokMent.Text = "Ment";
            this.btnfrmKolcsonzokMent.UseVisualStyleBackColor = true;
            this.btnfrmKolcsonzokMent.Click += new System.EventHandler(this.btnfrmKolcsonzokMent_Click);
            // 
            // btnfrmKonyvekModosit
            // 
            this.btnfrmKonyvekModosit.Location = new System.Drawing.Point(85, 25);
            this.btnfrmKonyvekModosit.Name = "btnfrmKonyvekModosit";
            this.btnfrmKonyvekModosit.Size = new System.Drawing.Size(70, 30);
            this.btnfrmKonyvekModosit.TabIndex = 12;
            this.btnfrmKonyvekModosit.Text = "Módosít";
            this.btnfrmKonyvekModosit.UseVisualStyleBackColor = true;
            this.btnfrmKonyvekModosit.Click += new System.EventHandler(this.btnfrmKonyvekModosit_Click);
            // 
            // btnKolcsonzokRogzit
            // 
            this.btnKolcsonzokRogzit.Location = new System.Drawing.Point(15, 25);
            this.btnKolcsonzokRogzit.Name = "btnKolcsonzokRogzit";
            this.btnKolcsonzokRogzit.Size = new System.Drawing.Size(70, 30);
            this.btnKolcsonzokRogzit.TabIndex = 11;
            this.btnKolcsonzokRogzit.Text = "Rögzít";
            this.btnKolcsonzokRogzit.UseVisualStyleBackColor = true;
            this.btnKolcsonzokRogzit.Click += new System.EventHandler(this.btnKolcsonzokRogzit_Click);
            // 
            // lblfrmKolcsonzok
            // 
            this.lblfrmKolcsonzok.AutoSize = true;
            this.lblfrmKolcsonzok.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblfrmKolcsonzok.Location = new System.Drawing.Point(208, -1);
            this.lblfrmKolcsonzok.Name = "lblfrmKolcsonzok";
            this.lblfrmKolcsonzok.Size = new System.Drawing.Size(208, 29);
            this.lblfrmKolcsonzok.TabIndex = 17;
            this.lblfrmKolcsonzok.Text = "Kölcsönzők adatai";
            // 
            // gbKolcsonzokMuveletek
            // 
            this.gbKolcsonzokMuveletek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbKolcsonzokMuveletek.Controls.Add(this.btnUjbevitel);
            this.gbKolcsonzokMuveletek.Controls.Add(this.btnfrmKonyvekTorol);
            this.gbKolcsonzokMuveletek.Controls.Add(this.btnKolcsonzokRogzit);
            this.gbKolcsonzokMuveletek.Controls.Add(this.btnfrmKonyvekModosit);
            this.gbKolcsonzokMuveletek.Controls.Add(this.btnfrmKolcsonzokMent);
            this.gbKolcsonzokMuveletek.Controls.Add(this.btnKolcsonzokFrissites);
            this.gbKolcsonzokMuveletek.Location = new System.Drawing.Point(466, 31);
            this.gbKolcsonzokMuveletek.Name = "gbKolcsonzokMuveletek";
            this.gbKolcsonzokMuveletek.Size = new System.Drawing.Size(250, 103);
            this.gbKolcsonzokMuveletek.TabIndex = 18;
            this.gbKolcsonzokMuveletek.TabStop = false;
            this.gbKolcsonzokMuveletek.Text = "Műveletek";
            // 
            // btnUjbevitel
            // 
            this.btnUjbevitel.Location = new System.Drawing.Point(155, 25);
            this.btnUjbevitel.Name = "btnUjbevitel";
            this.btnUjbevitel.Size = new System.Drawing.Size(70, 30);
            this.btnUjbevitel.TabIndex = 16;
            this.btnUjbevitel.Text = "Új bevitel";
            this.btnUjbevitel.UseVisualStyleBackColor = true;
            this.btnUjbevitel.Click += new System.EventHandler(this.btnUjbevitel_Click);
            // 
            // gbKolcsonzok2
            // 
            this.gbKolcsonzok2.Controls.Add(this.tbKolcsonzoAzonosito);
            this.gbKolcsonzok2.Controls.Add(this.lblKolcsonzoAzonosito);
            this.gbKolcsonzok2.Controls.Add(this.lblTagdij);
            this.gbKolcsonzok2.Controls.Add(this.tbKolcsonzoKeresztnev);
            this.gbKolcsonzok2.Controls.Add(this.tbKolcsonzoVezeteknev);
            this.gbKolcsonzok2.Controls.Add(this.tbTagdij);
            this.gbKolcsonzok2.Controls.Add(this.tbKolcsonzoDarabszam);
            this.gbKolcsonzok2.Controls.Add(this.tbKolcsonzoLakohely);
            this.gbKolcsonzok2.Controls.Add(this.label4);
            this.gbKolcsonzok2.Controls.Add(this.label3);
            this.gbKolcsonzok2.Controls.Add(this.label7);
            this.gbKolcsonzok2.Controls.Add(this.label2);
            this.gbKolcsonzok2.Controls.Add(this.tbKolcsonzoEmailCim);
            this.gbKolcsonzok2.Controls.Add(this.label6);
            this.gbKolcsonzok2.Controls.Add(this.label5);
            this.gbKolcsonzok2.Controls.Add(this.tbKolcsonzoTelefonszam);
            this.gbKolcsonzok2.Location = new System.Drawing.Point(12, 31);
            this.gbKolcsonzok2.Name = "gbKolcsonzok2";
            this.gbKolcsonzok2.Size = new System.Drawing.Size(448, 129);
            this.gbKolcsonzok2.TabIndex = 19;
            this.gbKolcsonzok2.TabStop = false;
            this.gbKolcsonzok2.Text = "Adatbevitel";
            // 
            // tbKolcsonzoAzonosito
            // 
            this.tbKolcsonzoAzonosito.AcceptsTab = true;
            this.tbKolcsonzoAzonosito.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kolcsonzokBindingSource, "Vezeteknev", true));
            this.tbKolcsonzoAzonosito.Location = new System.Drawing.Point(104, 18);
            this.tbKolcsonzoAzonosito.Name = "tbKolcsonzoAzonosito";
            this.tbKolcsonzoAzonosito.ReadOnly = true;
            this.tbKolcsonzoAzonosito.Size = new System.Drawing.Size(100, 20);
            this.tbKolcsonzoAzonosito.TabIndex = 30;
            // 
            // kolcsonzokBindingSource
            // 
            this.kolcsonzokBindingSource.DataMember = "Kolcsonzok";
            this.kolcsonzokBindingSource.DataSource = this.kolcsonzokDataSet;
            // 
            // kolcsonzokDataSet
            // 
            this.kolcsonzokDataSet.DataSetName = "kolcsonzokDataSet";
            this.kolcsonzokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblKolcsonzoAzonosito
            // 
            this.lblKolcsonzoAzonosito.AutoSize = true;
            this.lblKolcsonzoAzonosito.Location = new System.Drawing.Point(13, 16);
            this.lblKolcsonzoAzonosito.Name = "lblKolcsonzoAzonosito";
            this.lblKolcsonzoAzonosito.Size = new System.Drawing.Size(56, 26);
            this.lblKolcsonzoAzonosito.TabIndex = 29;
            this.lblKolcsonzoAzonosito.Text = "Kölcsönző\r\nAzonosító";
            // 
            // lblTagdij
            // 
            this.lblTagdij.AutoSize = true;
            this.lblTagdij.Location = new System.Drawing.Point(213, 104);
            this.lblTagdij.Name = "lblTagdij";
            this.lblTagdij.Size = new System.Drawing.Size(56, 13);
            this.lblTagdij.TabIndex = 28;
            this.lblTagdij.Text = "Tagdíj(Ft):";
            // 
            // tbKolcsonzoKeresztnev
            // 
            this.tbKolcsonzoKeresztnev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kolcsonzokBindingSource, "Keresztnev", true));
            this.tbKolcsonzoKeresztnev.Location = new System.Drawing.Point(104, 73);
            this.tbKolcsonzoKeresztnev.Name = "tbKolcsonzoKeresztnev";
            this.tbKolcsonzoKeresztnev.Size = new System.Drawing.Size(100, 20);
            this.tbKolcsonzoKeresztnev.TabIndex = 22;
            // 
            // tbKolcsonzoVezeteknev
            // 
            this.tbKolcsonzoVezeteknev.AcceptsTab = true;
            this.tbKolcsonzoVezeteknev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kolcsonzokBindingSource, "Vezeteknev", true));
            this.tbKolcsonzoVezeteknev.Location = new System.Drawing.Point(104, 46);
            this.tbKolcsonzoVezeteknev.Name = "tbKolcsonzoVezeteknev";
            this.tbKolcsonzoVezeteknev.Size = new System.Drawing.Size(100, 20);
            this.tbKolcsonzoVezeteknev.TabIndex = 21;
            // 
            // tbTagdij
            // 
            this.tbTagdij.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1000"});
            this.tbTagdij.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.kolcsonzokBindingSource, "Tagdij", true));
            this.tbTagdij.Location = new System.Drawing.Point(319, 104);
            this.tbTagdij.MaxLength = 4;
            this.tbTagdij.Name = "tbTagdij";
            this.tbTagdij.Size = new System.Drawing.Size(59, 20);
            this.tbTagdij.TabIndex = 27;
            // 
            // tbKolcsonzoDarabszam
            // 
            this.tbKolcsonzoDarabszam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kolcsonzokBindingSource, "Darabszam", true));
            this.tbKolcsonzoDarabszam.Location = new System.Drawing.Point(319, 75);
            this.tbKolcsonzoDarabszam.Name = "tbKolcsonzoDarabszam";
            this.tbKolcsonzoDarabszam.Size = new System.Drawing.Size(34, 20);
            this.tbKolcsonzoDarabszam.TabIndex = 26;
            // 
            // tbKolcsonzoLakohely
            // 
            this.tbKolcsonzoLakohely.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kolcsonzokBindingSource, "Lakohely", true));
            this.tbKolcsonzoLakohely.Location = new System.Drawing.Point(104, 101);
            this.tbKolcsonzoLakohely.Name = "tbKolcsonzoLakohely";
            this.tbKolcsonzoLakohely.Size = new System.Drawing.Size(100, 20);
            this.tbKolcsonzoLakohely.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lakóhely(város):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Keresztnév:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Darabszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vezetéknév:";
            // 
            // tbKolcsonzoEmailCim
            // 
            this.tbKolcsonzoEmailCim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kolcsonzokBindingSource, "EmailCim", true));
            this.tbKolcsonzoEmailCim.Location = new System.Drawing.Point(319, 49);
            this.tbKolcsonzoEmailCim.Name = "tbKolcsonzoEmailCim";
            this.tbKolcsonzoEmailCim.Size = new System.Drawing.Size(100, 20);
            this.tbKolcsonzoEmailCim.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email cím:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefonszám(+36):";
            // 
            // tbKolcsonzoTelefonszam
            // 
            this.tbKolcsonzoTelefonszam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kolcsonzokBindingSource, "EmailCim", true));
            this.tbKolcsonzoTelefonszam.Location = new System.Drawing.Point(319, 20);
            this.tbKolcsonzoTelefonszam.MaxLength = 9;
            this.tbKolcsonzoTelefonszam.Name = "tbKolcsonzoTelefonszam";
            this.tbKolcsonzoTelefonszam.Size = new System.Drawing.Size(100, 20);
            this.tbKolcsonzoTelefonszam.TabIndex = 24;
            // 
            // dgvKolcsonzok
            // 
            this.dgvKolcsonzok.AutoGenerateColumns = false;
            this.dgvKolcsonzok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKolcsonzok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KA,
            this.VN,
            this.KN,
            this.LH,
            this.TSZ,
            this.EC,
            this.DSZ,
            this.TD});
            this.dgvKolcsonzok.DataSource = this.kolcsonzokBindingSource;
            this.dgvKolcsonzok.Location = new System.Drawing.Point(12, 176);
            this.dgvKolcsonzok.Name = "dgvKolcsonzok";
            this.dgvKolcsonzok.Size = new System.Drawing.Size(760, 228);
            this.dgvKolcsonzok.TabIndex = 20;
            this.dgvKolcsonzok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKolcsonzok_CellClick);
            // 
            // KA
            // 
            this.KA.DataPropertyName = "KolcsonzoAzonosito";
            this.KA.HeaderText = "KolcsonzoAzonosito";
            this.KA.Name = "KA";
            this.KA.ReadOnly = true;
            this.KA.Width = 130;
            // 
            // VN
            // 
            this.VN.DataPropertyName = "Vezeteknev";
            this.VN.HeaderText = "Vezeteknev";
            this.VN.Name = "VN";
            // 
            // KN
            // 
            this.KN.DataPropertyName = "Keresztnev";
            this.KN.HeaderText = "Keresztnev";
            this.KN.Name = "KN";
            // 
            // LH
            // 
            this.LH.DataPropertyName = "Lakohely";
            this.LH.HeaderText = "Lakohely";
            this.LH.Name = "LH";
            // 
            // TSZ
            // 
            this.TSZ.DataPropertyName = "Telefonszam";
            this.TSZ.HeaderText = "Telefonszam";
            this.TSZ.Name = "TSZ";
            // 
            // EC
            // 
            this.EC.DataPropertyName = "EmailCim";
            this.EC.HeaderText = "EmailCim";
            this.EC.Name = "EC";
            // 
            // DSZ
            // 
            this.DSZ.DataPropertyName = "Darabszam";
            this.DSZ.HeaderText = "Darabszam";
            this.DSZ.Name = "DSZ";
            // 
            // TD
            // 
            this.TD.DataPropertyName = "Tagdij";
            this.TD.HeaderText = "Tagdij";
            this.TD.Name = "TD";
            // 
            // kolcsonzokTableAdapter
            // 
            this.kolcsonzokTableAdapter.ClearBeforeFill = true;
            // 
            // frmKolcsonzok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::KonyvtariNyilvantarto.Properties.Resources.images__2_2;
            this.ClientSize = new System.Drawing.Size(784, 433);
            this.Controls.Add(this.dgvKolcsonzok);
            this.Controls.Add(this.gbKolcsonzok2);
            this.Controls.Add(this.gbKolcsonzokMuveletek);
            this.Controls.Add(this.lblfrmKolcsonzok);
            this.Controls.Add(this.btnKilep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKolcsonzok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKolcsonzok";
            this.Load += new System.EventHandler(this.frmKolcsonzok_Load);
            this.gbKolcsonzokMuveletek.ResumeLayout(false);
            this.gbKolcsonzok2.ResumeLayout(false);
            this.gbKolcsonzok2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolcsonzokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolcsonzokDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolcsonzok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Button btnKolcsonzokFrissites;
        private System.Windows.Forms.Button btnfrmKonyvekTorol;
        private System.Windows.Forms.Button btnfrmKolcsonzokMent;
        private System.Windows.Forms.Button btnfrmKonyvekModosit;
        private System.Windows.Forms.Button btnKolcsonzokRogzit;
        private System.Windows.Forms.Label lblfrmKolcsonzok;
        private System.Windows.Forms.GroupBox gbKolcsonzokMuveletek;
        private System.Windows.Forms.GroupBox gbKolcsonzok2;
        private System.Windows.Forms.TextBox tbKolcsonzoDarabszam;
        private System.Windows.Forms.TextBox tbKolcsonzoEmailCim;
        private System.Windows.Forms.TextBox tbKolcsonzoKeresztnev;
        private System.Windows.Forms.TextBox tbKolcsonzoTelefonszam;
        private System.Windows.Forms.TextBox tbKolcsonzoVezeteknev;
        private System.Windows.Forms.TextBox tbKolcsonzoLakohely;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUjbevitel;
      
        private System.Windows.Forms.Label lblTagdij;
        private System.Windows.Forms.TextBox tbTagdij;
        private System.Windows.Forms.DataGridView dgvKolcsonzok;
        private kolcsonzokDataSet kolcsonzokDataSet;
        private System.Windows.Forms.BindingSource kolcsonzokBindingSource;
        private kolcsonzokDataSetTableAdapters.KolcsonzokTableAdapter kolcsonzokTableAdapter;
        private System.Windows.Forms.TextBox tbKolcsonzoAzonosito;
        private System.Windows.Forms.Label lblKolcsonzoAzonosito;
        private System.Windows.Forms.DataGridViewTextBoxColumn KA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn EC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TD;
    }
}