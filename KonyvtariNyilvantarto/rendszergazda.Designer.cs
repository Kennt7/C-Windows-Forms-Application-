namespace KonyvtariNyilvantarto
{
    partial class frmRendszergazda
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
            this.btnRFelhHozzaAD = new System.Windows.Forms.Button();
            this.rLBLfelhasznalonev = new System.Windows.Forms.Label();
            this.rLBLjelszo = new System.Windows.Forms.Label();
            this.rLBLjogosultsag = new System.Windows.Forms.Label();
            this.tbR1Felhasznalonev = new System.Windows.Forms.TextBox();
            this.tbR2Jelszo = new System.Windows.Forms.TextBox();
            this.btnRModositas = new System.Windows.Forms.Button();
            this.btnRTorles = new System.Windows.Forms.Button();
            this.btnRMegjelenit = new System.Windows.Forms.Button();
            this.btnRMent = new System.Windows.Forms.Button();
            this.cbRJogosultsag = new System.Windows.Forms.ComboBox();
            this.btnRgazdaKilep = new System.Windows.Forms.Button();
            this.panelRadatBeviteliMezo = new System.Windows.Forms.Panel();
            this.tbR0FelhasznaloAzonosito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFrissites = new System.Windows.Forms.Button();
            this.btnRUjBevitel = new System.Windows.Forms.Button();
            this.panelRMuveletek = new System.Windows.Forms.Panel();
            this.lblRMuveletek = new System.Windows.Forms.Label();
            this.lblRadatbevitel = new System.Windows.Forms.Label();
            this.lblRfAdatok = new System.Windows.Forms.Label();
            this.frissitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helyiMenuFelhasznalok = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvRendszergazda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felhasznalokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.felhasznalokDST = new KonyvtariNyilvantarto.felhasznalokDST();
            this.felhasznalokTableAdapter = new KonyvtariNyilvantarto.felhasznalokDSTTableAdapters.FelhasznalokTableAdapter();
            this.panelRadatBeviteliMezo.SuspendLayout();
            this.panelRMuveletek.SuspendLayout();
            this.helyiMenuFelhasznalok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendszergazda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.felhasznalokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.felhasznalokDST)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRFelhHozzaAD
            // 
            this.btnRFelhHozzaAD.Location = new System.Drawing.Point(3, 203);
            this.btnRFelhHozzaAD.Name = "btnRFelhHozzaAD";
            this.btnRFelhHozzaAD.Size = new System.Drawing.Size(75, 45);
            this.btnRFelhHozzaAD.TabIndex = 6;
            this.btnRFelhHozzaAD.Text = "Hozzáadás";
            this.btnRFelhHozzaAD.UseVisualStyleBackColor = true;
            this.btnRFelhHozzaAD.Click += new System.EventHandler(this.btnRFelhHozzaAD_Click);
            // 
            // rLBLfelhasznalonev
            // 
            this.rLBLfelhasznalonev.AutoSize = true;
            this.rLBLfelhasznalonev.Location = new System.Drawing.Point(12, 55);
            this.rLBLfelhasznalonev.Name = "rLBLfelhasznalonev";
            this.rLBLfelhasznalonev.Size = new System.Drawing.Size(84, 13);
            this.rLBLfelhasznalonev.TabIndex = 2;
            this.rLBLfelhasznalonev.Text = "Felhasználónév:";
            // 
            // rLBLjelszo
            // 
            this.rLBLjelszo.AutoSize = true;
            this.rLBLjelszo.Location = new System.Drawing.Point(15, 94);
            this.rLBLjelszo.Name = "rLBLjelszo";
            this.rLBLjelszo.Size = new System.Drawing.Size(39, 13);
            this.rLBLjelszo.TabIndex = 3;
            this.rLBLjelszo.Text = "Jelszó:";
            // 
            // rLBLjogosultsag
            // 
            this.rLBLjogosultsag.AutoSize = true;
            this.rLBLjogosultsag.Location = new System.Drawing.Point(12, 138);
            this.rLBLjogosultsag.Name = "rLBLjogosultsag";
            this.rLBLjogosultsag.Size = new System.Drawing.Size(66, 13);
            this.rLBLjogosultsag.TabIndex = 4;
            this.rLBLjogosultsag.Text = "Jogosultság:";
            // 
            // tbR1Felhasznalonev
            // 
            this.tbR1Felhasznalonev.Location = new System.Drawing.Point(15, 71);
            this.tbR1Felhasznalonev.MaxLength = 8;
            this.tbR1Felhasznalonev.Name = "tbR1Felhasznalonev";
            this.tbR1Felhasznalonev.Size = new System.Drawing.Size(131, 20);
            this.tbR1Felhasznalonev.TabIndex = 3;
            // 
            // tbR2Jelszo
            // 
            this.tbR2Jelszo.Location = new System.Drawing.Point(15, 110);
            this.tbR2Jelszo.MaxLength = 8;
            this.tbR2Jelszo.Name = "tbR2Jelszo";
            this.tbR2Jelszo.Size = new System.Drawing.Size(131, 20);
            this.tbR2Jelszo.TabIndex = 4;
            // 
            // btnRModositas
            // 
            this.btnRModositas.Location = new System.Drawing.Point(87, 19);
            this.btnRModositas.Name = "btnRModositas";
            this.btnRModositas.Size = new System.Drawing.Size(75, 45);
            this.btnRModositas.TabIndex = 9;
            this.btnRModositas.Text = "Módosítás";
            this.btnRModositas.UseVisualStyleBackColor = true;
            this.btnRModositas.Click += new System.EventHandler(this.btnRModositas_Click);
            // 
            // btnRTorles
            // 
            this.btnRTorles.Location = new System.Drawing.Point(87, 89);
            this.btnRTorles.Name = "btnRTorles";
            this.btnRTorles.Size = new System.Drawing.Size(75, 45);
            this.btnRTorles.TabIndex = 11;
            this.btnRTorles.Text = "Törlés";
            this.btnRTorles.UseVisualStyleBackColor = true;
            this.btnRTorles.Click += new System.EventHandler(this.btnRTorles_Click);
            // 
            // btnRMegjelenit
            // 
            this.btnRMegjelenit.Location = new System.Drawing.Point(197, 24);
            this.btnRMegjelenit.Name = "btnRMegjelenit";
            this.btnRMegjelenit.Size = new System.Drawing.Size(75, 29);
            this.btnRMegjelenit.TabIndex = 1;
            this.btnRMegjelenit.Text = "Megjelenít";
            this.btnRMegjelenit.UseVisualStyleBackColor = true;
            this.btnRMegjelenit.Click += new System.EventHandler(this.btnMegjelenit_Click);
            // 
            // btnRMent
            // 
            this.btnRMent.Location = new System.Drawing.Point(6, 89);
            this.btnRMent.Name = "btnRMent";
            this.btnRMent.Size = new System.Drawing.Size(75, 45);
            this.btnRMent.TabIndex = 10;
            this.btnRMent.Text = "Mentés";
            this.btnRMent.UseVisualStyleBackColor = true;
            this.btnRMent.Click += new System.EventHandler(this.btnRMent_Click);
            // 
            // cbRJogosultsag
            // 
            this.cbRJogosultsag.FormattingEnabled = true;
            this.cbRJogosultsag.Items.AddRange(new object[] {
            "rendszergazda",
            "könyvtáros"});
            this.cbRJogosultsag.Location = new System.Drawing.Point(15, 154);
            this.cbRJogosultsag.Name = "cbRJogosultsag";
            this.cbRJogosultsag.Size = new System.Drawing.Size(131, 21);
            this.cbRJogosultsag.TabIndex = 5;
            // 
            // btnRgazdaKilep
            // 
            this.btnRgazdaKilep.Location = new System.Drawing.Point(632, 481);
            this.btnRgazdaKilep.Name = "btnRgazdaKilep";
            this.btnRgazdaKilep.Size = new System.Drawing.Size(75, 23);
            this.btnRgazdaKilep.TabIndex = 12;
            this.btnRgazdaKilep.Text = "Kilépés";
            this.btnRgazdaKilep.UseVisualStyleBackColor = true;
            this.btnRgazdaKilep.Click += new System.EventHandler(this.btnRgazdaKilep_Click);
            // 
            // panelRadatBeviteliMezo
            // 
            this.panelRadatBeviteliMezo.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelRadatBeviteliMezo.Controls.Add(this.tbR0FelhasznaloAzonosito);
            this.panelRadatBeviteliMezo.Controls.Add(this.label1);
            this.panelRadatBeviteliMezo.Controls.Add(this.btnFrissites);
            this.panelRadatBeviteliMezo.Controls.Add(this.btnRFelhHozzaAD);
            this.panelRadatBeviteliMezo.Controls.Add(this.tbR1Felhasznalonev);
            this.panelRadatBeviteliMezo.Controls.Add(this.rLBLjelszo);
            this.panelRadatBeviteliMezo.Controls.Add(this.rLBLfelhasznalonev);
            this.panelRadatBeviteliMezo.Controls.Add(this.cbRJogosultsag);
            this.panelRadatBeviteliMezo.Controls.Add(this.rLBLjogosultsag);
            this.panelRadatBeviteliMezo.Controls.Add(this.tbR2Jelszo);
            this.panelRadatBeviteliMezo.Location = new System.Drawing.Point(12, 60);
            this.panelRadatBeviteliMezo.Name = "panelRadatBeviteliMezo";
            this.panelRadatBeviteliMezo.Size = new System.Drawing.Size(170, 260);
            this.panelRadatBeviteliMezo.TabIndex = 17;
            // 
            // tbR0FelhasznaloAzonosito
            // 
            this.tbR0FelhasznaloAzonosito.Location = new System.Drawing.Point(15, 32);
            this.tbR0FelhasznaloAzonosito.MaxLength = 8;
            this.tbR0FelhasznaloAzonosito.Name = "tbR0FelhasznaloAzonosito";
            this.tbR0FelhasznaloAzonosito.Size = new System.Drawing.Size(131, 20);
            this.tbR0FelhasznaloAzonosito.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Felhasználóazonositó:";
            // 
            // btnFrissites
            // 
            this.btnFrissites.Location = new System.Drawing.Point(84, 203);
            this.btnFrissites.Name = "btnFrissites";
            this.btnFrissites.Size = new System.Drawing.Size(75, 45);
            this.btnFrissites.TabIndex = 7;
            this.btnFrissites.Text = "Frissítés";
            this.btnFrissites.UseVisualStyleBackColor = true;
            this.btnFrissites.Click += new System.EventHandler(this.btnFrissites_Click);
            // 
            // btnRUjBevitel
            // 
            this.btnRUjBevitel.Location = new System.Drawing.Point(6, 19);
            this.btnRUjBevitel.Name = "btnRUjBevitel";
            this.btnRUjBevitel.Size = new System.Drawing.Size(75, 45);
            this.btnRUjBevitel.TabIndex = 8;
            this.btnRUjBevitel.Text = "Új Bevitel";
            this.btnRUjBevitel.UseVisualStyleBackColor = true;
            this.btnRUjBevitel.Click += new System.EventHandler(this.btnRUjBevitel_Click);
            // 
            // panelRMuveletek
            // 
            this.panelRMuveletek.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelRMuveletek.Controls.Add(this.btnRModositas);
            this.panelRMuveletek.Controls.Add(this.btnRUjBevitel);
            this.panelRMuveletek.Controls.Add(this.btnRTorles);
            this.panelRMuveletek.Controls.Add(this.btnRMent);
            this.panelRMuveletek.Location = new System.Drawing.Point(6, 349);
            this.panelRMuveletek.Name = "panelRMuveletek";
            this.panelRMuveletek.Size = new System.Drawing.Size(173, 155);
            this.panelRMuveletek.TabIndex = 18;
            // 
            // lblRMuveletek
            // 
            this.lblRMuveletek.AutoSize = true;
            this.lblRMuveletek.Location = new System.Drawing.Point(3, 323);
            this.lblRMuveletek.Name = "lblRMuveletek";
            this.lblRMuveletek.Size = new System.Drawing.Size(57, 13);
            this.lblRMuveletek.TabIndex = 19;
            this.lblRMuveletek.Text = "Műveletek";
            // 
            // lblRadatbevitel
            // 
            this.lblRadatbevitel.AutoSize = true;
            this.lblRadatbevitel.Location = new System.Drawing.Point(12, 24);
            this.lblRadatbevitel.Name = "lblRadatbevitel";
            this.lblRadatbevitel.Size = new System.Drawing.Size(129, 13);
            this.lblRadatbevitel.TabIndex = 20;
            this.lblRadatbevitel.Text = "Felhasználók hozzáadása";
            // 
            // lblRfAdatok
            // 
            this.lblRfAdatok.AutoSize = true;
            this.lblRfAdatok.Location = new System.Drawing.Point(371, 24);
            this.lblRfAdatok.Name = "lblRfAdatok";
            this.lblRfAdatok.Size = new System.Drawing.Size(119, 13);
            this.lblRfAdatok.TabIndex = 21;
            this.lblRfAdatok.Text = "Felhasználók állománya";
            // 
            // frissitesToolStripMenuItem
            // 
            this.frissitesToolStripMenuItem.Name = "frissitesToolStripMenuItem";
            this.frissitesToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.frissitesToolStripMenuItem.Text = "Frissites";
            this.frissitesToolStripMenuItem.Click += new System.EventHandler(this.frissitesToolStripMenuItem_Click);
            // 
            // helyiMenuFelhasznalok
            // 
            this.helyiMenuFelhasznalok.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frissitesToolStripMenuItem});
            this.helyiMenuFelhasznalok.Name = "helyiMenuFelhasznalok";
            this.helyiMenuFelhasznalok.Size = new System.Drawing.Size(116, 26);
            // 
            // dgvRendszergazda
            // 
            this.dgvRendszergazda.AutoGenerateColumns = false;
            this.dgvRendszergazda.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvRendszergazda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRendszergazda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvRendszergazda.DataSource = this.felhasznalokBindingSource;
            this.dgvRendszergazda.Location = new System.Drawing.Point(235, 61);
            this.dgvRendszergazda.Name = "dgvRendszergazda";
            this.dgvRendszergazda.Size = new System.Drawing.Size(472, 150);
            this.dgvRendszergazda.TabIndex = 24;
           // this.dgvRendszergazda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRendszergazda_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FelhasznaloAzonosito";
            this.dataGridViewTextBoxColumn4.HeaderText = "FelhasznaloAzonosito";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Felhasznalonev";
            this.dataGridViewTextBoxColumn5.HeaderText = "Felhasznalonev";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Jelszo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Jelszo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Jogosultsag";
            this.dataGridViewTextBoxColumn7.HeaderText = "Jogosultsag";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // felhasznalokBindingSource
            // 
            this.felhasznalokBindingSource.DataMember = "Felhasznalok";
            this.felhasznalokBindingSource.DataSource = this.felhasznalokDST;
            // 
            // felhasznalokDST
            // 
            this.felhasznalokDST.DataSetName = "felhasznalokDST";
            this.felhasznalokDST.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // felhasznalokTableAdapter
            // 
            this.felhasznalokTableAdapter.ClearBeforeFill = true;
            // 
            // frmRendszergazda
            // 
            this.AcceptButton = this.btnRFelhHozzaAD;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(797, 515);
            this.Controls.Add(this.dgvRendszergazda);
            this.Controls.Add(this.panelRadatBeviteliMezo);
            this.Controls.Add(this.lblRfAdatok);
            this.Controls.Add(this.lblRadatbevitel);
            this.Controls.Add(this.lblRMuveletek);
            this.Controls.Add(this.panelRMuveletek);
            this.Controls.Add(this.btnRgazdaKilep);
            this.Controls.Add(this.btnRMegjelenit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRendszergazda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendszergazdai beállítások";
            this.Load += new System.EventHandler(this.frmRendszergazda_Load);
            this.panelRadatBeviteliMezo.ResumeLayout(false);
            this.panelRadatBeviteliMezo.PerformLayout();
            this.panelRMuveletek.ResumeLayout(false);
            this.helyiMenuFelhasznalok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendszergazda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.felhasznalokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.felhasznalokDST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button btnRFelhHozzaAD;
        private System.Windows.Forms.Label rLBLfelhasznalonev;
        private System.Windows.Forms.Label rLBLjelszo;
        private System.Windows.Forms.Label rLBLjogosultsag;
        private System.Windows.Forms.TextBox tbR1Felhasznalonev;
        private System.Windows.Forms.TextBox tbR2Jelszo;
        private System.Windows.Forms.Button btnRModositas;
        private System.Windows.Forms.Button btnRTorles;
        private System.Windows.Forms.Button btnRMegjelenit;
        private System.Windows.Forms.Button btnRMent;
        private System.Windows.Forms.ComboBox cbRJogosultsag;
        private System.Windows.Forms.Button btnRgazdaKilep;
        private System.Windows.Forms.Panel panelRadatBeviteliMezo;
        private System.Windows.Forms.Panel panelRMuveletek;
        private System.Windows.Forms.Label lblRMuveletek;
        private System.Windows.Forms.Label lblRadatbevitel;
        private System.Windows.Forms.Label lblRfAdatok;
        private System.Windows.Forms.Button btnRUjBevitel;
        private System.Windows.Forms.Button btnFrissites;
      
        
        private System.Windows.Forms.DataGridViewTextBoxColumn felhasznaloAzonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn felhasznalonevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelszoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogosultsagDataGridViewTextBoxColumn;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox tbR0FelhasznaloAzonosito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem frissitesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip helyiMenuFelhasznalok;
        private System.Windows.Forms.DataGridView dgvRendszergazda;
        private felhasznalokDST felhasznalokDST;
        private System.Windows.Forms.BindingSource felhasznalokBindingSource;
        private felhasznalokDSTTableAdapters.FelhasznalokTableAdapter felhasznalokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}