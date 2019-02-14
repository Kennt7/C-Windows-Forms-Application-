namespace KonyvtariNyilvantarto
{
    partial class frmKolcsonzes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKolcsonzes));
            this.lblKolcsonzes = new System.Windows.Forms.Label();
            this.btnKilep = new System.Windows.Forms.Button();
            this.btnKonyvekFrissites = new System.Windows.Forms.Button();
            this.btnfrmKonyvekTorol = new System.Windows.Forms.Button();
            this.btnfrmKonyvekModosit = new System.Windows.Forms.Button();
            this.btnfrmKolcsonzesRogzit = new System.Windows.Forms.Button();
            this.btnKolcsonzok = new System.Windows.Forms.Button();
            this.btnVisszavetel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbKolcsonzokUjbevitel = new System.Windows.Forms.Button();
            this.btnKiadas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnfrmKolcsonzesMent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIdotartam = new System.Windows.Forms.TextBox();
            this.lblIdotartam = new System.Windows.Forms.Label();
            this.tbZaras = new System.Windows.Forms.TextBox();
            this.tbKezdes = new System.Windows.Forms.TextBox();
            this.lblZaras = new System.Windows.Forms.Label();
            this.lblKezdes = new System.Windows.Forms.Label();
            this.tbKolcsonzoAzonosito = new System.Windows.Forms.TextBox();
            this.tbKolcsonzesAzonosito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKolcsonzesAzonosito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKCSKonyvAzonosito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFrissites = new System.Windows.Forms.Button();
            this.mcKiadas = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.mcVisszavetel = new System.Windows.Forms.MonthCalendar();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.dgvKolcsonzes = new System.Windows.Forms.DataGridView();
            this.kolcsonzesAzonositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konyvAzonositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolcsonzoAzonositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadasDatumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visszaVetelDatumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolcsonzesiIdotartamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolcsonzesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolcsonzesDST1 = new KonyvtariNyilvantarto.KolcsonzesDST1();
            this.kolcsonzesTableAdapter = new KonyvtariNyilvantarto.KolcsonzesDST1TableAdapters.KolcsonzesTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolcsonzes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolcsonzesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolcsonzesDST1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKolcsonzes
            // 
            this.lblKolcsonzes.AutoSize = true;
            this.lblKolcsonzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolcsonzes.Location = new System.Drawing.Point(172, 9);
            this.lblKolcsonzes.Name = "lblKolcsonzes";
            this.lblKolcsonzes.Size = new System.Drawing.Size(427, 29);
            this.lblKolcsonzes.TabIndex = 1;
            this.lblKolcsonzes.Text = "Könyvtári  könyvek kölcsönzési felülete";
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(891, 459);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 22);
            this.btnKilep.TabIndex = 21;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // btnKonyvekFrissites
            // 
            this.btnKonyvekFrissites.Location = new System.Drawing.Point(197, 20);
            this.btnKonyvekFrissites.Name = "btnKonyvekFrissites";
            this.btnKonyvekFrissites.Size = new System.Drawing.Size(70, 40);
            this.btnKonyvekFrissites.TabIndex = 5;
            this.btnKonyvekFrissites.Text = "Frissítés";
            this.btnKonyvekFrissites.UseVisualStyleBackColor = true;
            this.btnKonyvekFrissites.Click += new System.EventHandler(this.btnKonyvekFrissites_Click);
            // 
            // btnfrmKonyvekTorol
            // 
            this.btnfrmKonyvekTorol.BackColor = System.Drawing.SystemColors.Control;
            this.btnfrmKonyvekTorol.Location = new System.Drawing.Point(197, 78);
            this.btnfrmKonyvekTorol.Name = "btnfrmKonyvekTorol";
            this.btnfrmKonyvekTorol.Size = new System.Drawing.Size(70, 40);
            this.btnfrmKonyvekTorol.TabIndex = 6;
            this.btnfrmKonyvekTorol.Text = "Töröl";
            this.btnfrmKonyvekTorol.UseVisualStyleBackColor = false;
            // 
            // btnfrmKonyvekModosit
            // 
            this.btnfrmKonyvekModosit.Location = new System.Drawing.Point(91, 17);
            this.btnfrmKonyvekModosit.Name = "btnfrmKonyvekModosit";
            this.btnfrmKonyvekModosit.Size = new System.Drawing.Size(70, 40);
            this.btnfrmKonyvekModosit.TabIndex = 3;
            this.btnfrmKonyvekModosit.Text = "Módosít";
            this.btnfrmKonyvekModosit.UseVisualStyleBackColor = true;
            // 
            // btnfrmKolcsonzesRogzit
            // 
            this.btnfrmKolcsonzesRogzit.Location = new System.Drawing.Point(10, 18);
            this.btnfrmKolcsonzesRogzit.Name = "btnfrmKolcsonzesRogzit";
            this.btnfrmKolcsonzesRogzit.Size = new System.Drawing.Size(70, 40);
            this.btnfrmKolcsonzesRogzit.TabIndex = 2;
            this.btnfrmKolcsonzesRogzit.Text = "Rögzítés";
            this.btnfrmKolcsonzesRogzit.Click += new System.EventHandler(this.btnfrmKolcsonzesRogzit_Click);
            // 
            // btnKolcsonzok
            // 
            this.btnKolcsonzok.BackColor = System.Drawing.SystemColors.Control;
            this.btnKolcsonzok.Location = new System.Drawing.Point(375, 20);
            this.btnKolcsonzok.Name = "btnKolcsonzok";
            this.btnKolcsonzok.Size = new System.Drawing.Size(70, 40);
            this.btnKolcsonzok.TabIndex = 9;
            this.btnKolcsonzok.Text = "Kölcsönzők";
            this.btnKolcsonzok.UseVisualStyleBackColor = false;
            this.btnKolcsonzok.Click += new System.EventHandler(this.btnKolcsonzok_Click);
            // 
            // btnVisszavetel
            // 
            this.btnVisszavetel.Location = new System.Drawing.Point(278, 78);
            this.btnVisszavetel.Name = "btnVisszavetel";
            this.btnVisszavetel.Size = new System.Drawing.Size(70, 40);
            this.btnVisszavetel.TabIndex = 8;
            this.btnVisszavetel.Text = "Visszavétel";
            this.btnVisszavetel.UseVisualStyleBackColor = true;
            this.btnVisszavetel.Click += new System.EventHandler(this.btnVisszavetel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbKolcsonzokUjbevitel);
            this.panel1.Controls.Add(this.btnKiadas);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnVisszavetel);
            this.panel1.Controls.Add(this.btnKonyvekFrissites);
            this.panel1.Controls.Add(this.btnfrmKolcsonzesMent);
            this.panel1.Controls.Add(this.btnKolcsonzok);
            this.panel1.Controls.Add(this.btnfrmKonyvekModosit);
            this.panel1.Controls.Add(this.btnfrmKolcsonzesRogzit);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnfrmKonyvekTorol);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 268);
            this.panel1.TabIndex = 22;
            // 
            // tbKolcsonzokUjbevitel
            // 
            this.tbKolcsonzokUjbevitel.BackColor = System.Drawing.SystemColors.Control;
            this.tbKolcsonzokUjbevitel.Location = new System.Drawing.Point(375, 75);
            this.tbKolcsonzokUjbevitel.Name = "tbKolcsonzokUjbevitel";
            this.tbKolcsonzokUjbevitel.Size = new System.Drawing.Size(70, 40);
            this.tbKolcsonzokUjbevitel.TabIndex = 10;
            this.tbKolcsonzokUjbevitel.Text = "Új bevitel";
            this.tbKolcsonzokUjbevitel.UseVisualStyleBackColor = false;
            this.tbKolcsonzokUjbevitel.Click += new System.EventHandler(this.tbKolcsonzokUjbevitel_Click);
            this.tbKolcsonzokUjbevitel.MouseLeave += new System.EventHandler(this.tbKolcsonzokUjbevitel_MouseLeave);
            this.tbKolcsonzokUjbevitel.MouseHover += new System.EventHandler(this.tbKolcsonzokUjbevitel_MouseHover);
            // 
            // btnKiadas
            // 
            this.btnKiadas.Location = new System.Drawing.Point(279, 20);
            this.btnKiadas.Name = "btnKiadas";
            this.btnKiadas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKiadas.Size = new System.Drawing.Size(70, 40);
            this.btnKiadas.TabIndex = 7;
            this.btnKiadas.Text = "Kiadás";
            this.btnKiadas.UseVisualStyleBackColor = true;
            this.btnKiadas.Click += new System.EventHandler(this.btnKiadas_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ment\r\n(pdf-be)\r\n";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnfrmKolcsonzesMent
            // 
            this.btnfrmKolcsonzesMent.Location = new System.Drawing.Point(10, 75);
            this.btnfrmKolcsonzesMent.Name = "btnfrmKolcsonzesMent";
            this.btnfrmKolcsonzesMent.Size = new System.Drawing.Size(70, 40);
            this.btnfrmKolcsonzesMent.TabIndex = 3;
            this.btnfrmKolcsonzesMent.Text = "Ment\r\n(táblába)\r\n";
            this.btnfrmKolcsonzesMent.UseVisualStyleBackColor = true;
            this.btnfrmKolcsonzesMent.Click += new System.EventHandler(this.btnfrmKolcsonzesMent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIdotartam);
            this.groupBox1.Controls.Add(this.lblIdotartam);
            this.groupBox1.Controls.Add(this.tbZaras);
            this.groupBox1.Controls.Add(this.tbKezdes);
            this.groupBox1.Controls.Add(this.lblZaras);
            this.groupBox1.Controls.Add(this.lblKezdes);
            this.groupBox1.Controls.Add(this.tbKolcsonzoAzonosito);
            this.groupBox1.Controls.Add(this.tbKolcsonzesAzonosito);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblKolcsonzesAzonosito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbKCSKonyvAzonosito);
            this.groupBox1.Location = new System.Drawing.Point(10, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 110);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatbevitel";
            // 
            // tbIdotartam
            // 
            this.tbIdotartam.Location = new System.Drawing.Point(264, 75);
            this.tbIdotartam.Name = "tbIdotartam";
            this.tbIdotartam.Size = new System.Drawing.Size(100, 20);
            this.tbIdotartam.TabIndex = 16;
            // 
            // lblIdotartam
            // 
            this.lblIdotartam.AutoSize = true;
            this.lblIdotartam.Location = new System.Drawing.Point(184, 75);
            this.lblIdotartam.Name = "lblIdotartam";
            this.lblIdotartam.Size = new System.Drawing.Size(78, 13);
            this.lblIdotartam.TabIndex = 13;
            this.lblIdotartam.Text = "Időtartam(nap):";
            // 
            // tbZaras
            // 
            this.tbZaras.Location = new System.Drawing.Point(264, 49);
            this.tbZaras.Name = "tbZaras";
            this.tbZaras.Size = new System.Drawing.Size(100, 20);
            this.tbZaras.TabIndex = 15;
            // 
            // tbKezdes
            // 
            this.tbKezdes.Location = new System.Drawing.Point(264, 23);
            this.tbKezdes.Name = "tbKezdes";
            this.tbKezdes.Size = new System.Drawing.Size(100, 20);
            this.tbKezdes.TabIndex = 14;
            // 
            // lblZaras
            // 
            this.lblZaras.AutoSize = true;
            this.lblZaras.Location = new System.Drawing.Point(194, 49);
            this.lblZaras.Name = "lblZaras";
            this.lblZaras.Size = new System.Drawing.Size(37, 13);
            this.lblZaras.TabIndex = 10;
            this.lblZaras.Text = "Zárás:";
            // 
            // lblKezdes
            // 
            this.lblKezdes.AutoSize = true;
            this.lblKezdes.Location = new System.Drawing.Point(194, 23);
            this.lblKezdes.Name = "lblKezdes";
            this.lblKezdes.Size = new System.Drawing.Size(45, 13);
            this.lblKezdes.TabIndex = 9;
            this.lblKezdes.Text = "Kezdés:";
            // 
            // tbKolcsonzoAzonosito
            // 
            this.tbKolcsonzoAzonosito.Location = new System.Drawing.Point(126, 75);
            this.tbKolcsonzoAzonosito.Name = "tbKolcsonzoAzonosito";
            this.tbKolcsonzoAzonosito.Size = new System.Drawing.Size(52, 20);
            this.tbKolcsonzoAzonosito.TabIndex = 13;
            // 
            // tbKolcsonzesAzonosito
            // 
            this.tbKolcsonzesAzonosito.Location = new System.Drawing.Point(126, 22);
            this.tbKolcsonzesAzonosito.Name = "tbKolcsonzesAzonosito";
            this.tbKolcsonzesAzonosito.ReadOnly = true;
            this.tbKolcsonzesAzonosito.Size = new System.Drawing.Size(52, 20);
            this.tbKolcsonzesAzonosito.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kölcsönző azonosító:";
            // 
            // lblKolcsonzesAzonosito
            // 
            this.lblKolcsonzesAzonosito.AutoSize = true;
            this.lblKolcsonzesAzonosito.Location = new System.Drawing.Point(6, 22);
            this.lblKolcsonzesAzonosito.Name = "lblKolcsonzesAzonosito";
            this.lblKolcsonzesAzonosito.Size = new System.Drawing.Size(114, 13);
            this.lblKolcsonzesAzonosito.TabIndex = 0;
            this.lblKolcsonzesAzonosito.Text = "Kölcsönzés azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Könyv azonosító:";
            // 
            // tbKCSKonyvAzonosito
            // 
            this.tbKCSKonyvAzonosito.Location = new System.Drawing.Point(126, 49);
            this.tbKCSKonyvAzonosito.Name = "tbKCSKonyvAzonosito";
            this.tbKCSKonyvAzonosito.Size = new System.Drawing.Size(52, 20);
            this.tbKCSKonyvAzonosito.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kiadás dátuma:";
            // 
            // btnFrissites
            // 
            this.btnFrissites.Location = new System.Drawing.Point(702, 303);
            this.btnFrissites.Name = "btnFrissites";
            this.btnFrissites.Size = new System.Drawing.Size(75, 22);
            this.btnFrissites.TabIndex = 19;
            this.btnFrissites.Text = "Frissítés";
            this.btnFrissites.UseVisualStyleBackColor = true;
            // 
            // mcKiadas
            // 
            this.mcKiadas.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2018, 1, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 3, 15, 0, 0, 0, 0),
        new System.DateTime(2018, 3, 31, 0, 0, 0, 0),
        new System.DateTime(2018, 4, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 5, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 5, 20, 0, 0, 0, 0),
        new System.DateTime(2018, 5, 21, 0, 0, 0, 0),
        new System.DateTime(2018, 8, 20, 0, 0, 0, 0),
        new System.DateTime(2018, 10, 23, 0, 0, 0, 0),
        new System.DateTime(2018, 11, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 25, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 26, 0, 0, 0, 0),
        new System.DateTime(((long)(0)))};
            this.mcKiadas.BackColor = System.Drawing.SystemColors.Window;
            this.mcKiadas.BoldedDates = new System.DateTime[] {
        new System.DateTime(2018, 1, 1, 0, 0, 0, 0),
        new System.DateTime(((long)(0))),
        new System.DateTime(2018, 3, 15, 0, 0, 0, 0),
        new System.DateTime(2018, 3, 31, 0, 0, 0, 0),
        new System.DateTime(2018, 4, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 5, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 5, 20, 0, 0, 0, 0),
        new System.DateTime(((long)(0))),
        new System.DateTime(2018, 5, 21, 0, 0, 0, 0),
        new System.DateTime(2018, 8, 20, 0, 0, 0, 0),
        new System.DateTime(2018, 10, 23, 0, 0, 0, 0),
        new System.DateTime(2018, 11, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 25, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 26, 0, 0, 0, 0)};
            this.mcKiadas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcKiadas.Location = new System.Drawing.Point(526, 74);
            this.mcKiadas.Name = "mcKiadas";
            this.mcKiadas.ShowWeekNumbers = true;
            this.mcKiadas.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Visszavétel dátuma:";
            // 
            // mcVisszavetel
            // 
            this.mcVisszavetel.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2018, 1, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 3, 15, 0, 0, 0, 0),
        new System.DateTime(2018, 3, 31, 0, 0, 0, 0),
        new System.DateTime(2018, 4, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 5, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 5, 20, 0, 0, 0, 0),
        new System.DateTime(2018, 5, 21, 0, 0, 0, 0),
        new System.DateTime(2018, 8, 20, 0, 0, 0, 0),
        new System.DateTime(2018, 10, 23, 0, 0, 0, 0),
        new System.DateTime(2018, 11, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 25, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 26, 0, 0, 0, 0),
        new System.DateTime(((long)(0)))};
            this.mcVisszavetel.BackColor = System.Drawing.SystemColors.Window;
            this.mcVisszavetel.BoldedDates = new System.DateTime[] {
        new System.DateTime(2018, 1, 1, 0, 0, 0, 0),
        new System.DateTime(((long)(0))),
        new System.DateTime(2018, 3, 15, 0, 0, 0, 0),
        new System.DateTime(2018, 3, 31, 0, 0, 0, 0),
        new System.DateTime(2018, 4, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 5, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 5, 20, 0, 0, 0, 0),
        new System.DateTime(((long)(0))),
        new System.DateTime(2018, 5, 21, 0, 0, 0, 0),
        new System.DateTime(2018, 8, 20, 0, 0, 0, 0),
        new System.DateTime(2018, 10, 23, 0, 0, 0, 0),
        new System.DateTime(2018, 11, 1, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 25, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 26, 0, 0, 0, 0)};
            this.mcVisszavetel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcVisszavetel.Location = new System.Drawing.Point(766, 74);
            this.mcVisszavetel.Name = "mcVisszavetel";
            this.mcVisszavetel.ShowWeekNumbers = true;
            this.mcVisszavetel.TabIndex = 18;
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.Location = new System.Drawing.Point(618, 27);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(108, 23);
            this.btnBetoltes.TabIndex = 1;
            this.btnBetoltes.Text = "Tábla betöltése";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // dgvKolcsonzes
            // 
            this.dgvKolcsonzes.AutoGenerateColumns = false;
            this.dgvKolcsonzes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKolcsonzes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolcsonzesAzonositoDataGridViewTextBoxColumn,
            this.konyvAzonositoDataGridViewTextBoxColumn,
            this.kolcsonzoAzonositoDataGridViewTextBoxColumn,
            this.kiadasDatumaDataGridViewTextBoxColumn,
            this.visszaVetelDatumaDataGridViewTextBoxColumn,
            this.kolcsonzesiIdotartamDataGridViewTextBoxColumn});
            this.dgvKolcsonzes.DataSource = this.kolcsonzesBindingSource;
            this.dgvKolcsonzes.Location = new System.Drawing.Point(12, 331);
            this.dgvKolcsonzes.Name = "dgvKolcsonzes";
            this.dgvKolcsonzes.Size = new System.Drawing.Size(765, 150);
            this.dgvKolcsonzes.TabIndex = 28;
            // 
            // kolcsonzesAzonositoDataGridViewTextBoxColumn
            // 
            this.kolcsonzesAzonositoDataGridViewTextBoxColumn.DataPropertyName = "KolcsonzesAzonosito";
            this.kolcsonzesAzonositoDataGridViewTextBoxColumn.HeaderText = "KolcsonzesAzonosito";
            this.kolcsonzesAzonositoDataGridViewTextBoxColumn.Name = "kolcsonzesAzonositoDataGridViewTextBoxColumn";
            this.kolcsonzesAzonositoDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolcsonzesAzonositoDataGridViewTextBoxColumn.Width = 140;
            // 
            // konyvAzonositoDataGridViewTextBoxColumn
            // 
            this.konyvAzonositoDataGridViewTextBoxColumn.DataPropertyName = "KonyvAzonosito";
            this.konyvAzonositoDataGridViewTextBoxColumn.HeaderText = "KonyvAzonosito";
            this.konyvAzonositoDataGridViewTextBoxColumn.Name = "konyvAzonositoDataGridViewTextBoxColumn";
            // 
            // kolcsonzoAzonositoDataGridViewTextBoxColumn
            // 
            this.kolcsonzoAzonositoDataGridViewTextBoxColumn.DataPropertyName = "KolcsonzoAzonosito";
            this.kolcsonzoAzonositoDataGridViewTextBoxColumn.HeaderText = "KolcsonzoAzonosito";
            this.kolcsonzoAzonositoDataGridViewTextBoxColumn.Name = "kolcsonzoAzonositoDataGridViewTextBoxColumn";
            this.kolcsonzoAzonositoDataGridViewTextBoxColumn.Width = 140;
            // 
            // kiadasDatumaDataGridViewTextBoxColumn
            // 
            this.kiadasDatumaDataGridViewTextBoxColumn.DataPropertyName = "KiadasDatuma";
            this.kiadasDatumaDataGridViewTextBoxColumn.HeaderText = "KiadasDatuma";
            this.kiadasDatumaDataGridViewTextBoxColumn.Name = "kiadasDatumaDataGridViewTextBoxColumn";
            // 
            // visszaVetelDatumaDataGridViewTextBoxColumn
            // 
            this.visszaVetelDatumaDataGridViewTextBoxColumn.DataPropertyName = "VisszaVetelDatuma";
            this.visszaVetelDatumaDataGridViewTextBoxColumn.HeaderText = "VisszaVetelDatuma";
            this.visszaVetelDatumaDataGridViewTextBoxColumn.Name = "visszaVetelDatumaDataGridViewTextBoxColumn";
            // 
            // kolcsonzesiIdotartamDataGridViewTextBoxColumn
            // 
            this.kolcsonzesiIdotartamDataGridViewTextBoxColumn.DataPropertyName = "KolcsonzesiIdotartam";
            this.kolcsonzesiIdotartamDataGridViewTextBoxColumn.HeaderText = "KolcsonzesiIdotartam";
            this.kolcsonzesiIdotartamDataGridViewTextBoxColumn.Name = "kolcsonzesiIdotartamDataGridViewTextBoxColumn";
            this.kolcsonzesiIdotartamDataGridViewTextBoxColumn.Width = 140;
            // 
            // kolcsonzesBindingSource
            // 
            this.kolcsonzesBindingSource.DataMember = "Kolcsonzes";
            this.kolcsonzesBindingSource.DataSource = this.kolcsonzesDST1;
            // 
            // kolcsonzesDST1
            // 
            this.kolcsonzesDST1.DataSetName = "KolcsonzesDST1";
            this.kolcsonzesDST1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kolcsonzesTableAdapter
            // 
            this.kolcsonzesTableAdapter.ClearBeforeFill = true;
            // 
            // frmKolcsonzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::KonyvtariNyilvantarto.Properties.Resources.pad030;
            this.ClientSize = new System.Drawing.Size(1010, 493);
            this.Controls.Add(this.dgvKolcsonzes);
            this.Controls.Add(this.btnBetoltes);
            this.Controls.Add(this.mcVisszavetel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mcKiadas);
            this.Controls.Add(this.btnFrissites);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.lblKolcsonzes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKolcsonzes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKolcsonzes";
            this.Load += new System.EventHandler(this.frmKolcsonzes_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolcsonzes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolcsonzesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolcsonzesDST1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKolcsonzes;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Button btnKonyvekFrissites;
        private System.Windows.Forms.Button btnfrmKonyvekTorol;
        private System.Windows.Forms.Button btnfrmKonyvekModosit;
        private System.Windows.Forms.Button btnfrmKolcsonzesRogzit;
        private System.Windows.Forms.Button btnKolcsonzok;
        private System.Windows.Forms.Button btnVisszavetel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfrmKolcsonzesMent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbKolcsonzesAzonosito;
        private System.Windows.Forms.Label lblKolcsonzesAzonosito;
        private System.Windows.Forms.Button btnFrissites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKCSKonyvAzonosito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKolcsonzoAzonosito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar mcKiadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblZaras;
        private System.Windows.Forms.Label lblKezdes;
        private System.Windows.Forms.TextBox tbZaras;
        private System.Windows.Forms.TextBox tbKezdes;
        private System.Windows.Forms.Label lblIdotartam;
        private System.Windows.Forms.TextBox tbIdotartam;
        private System.Windows.Forms.Button btnKiadas;
        private System.Windows.Forms.Button tbKolcsonzokUjbevitel;
        private System.Windows.Forms.MonthCalendar mcVisszavetel;
        private System.Windows.Forms.Button btnBetoltes;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolcsonzesiIdotartamnapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgvKolcsonzes;
        private KolcsonzesDST1 kolcsonzesDST1;
        private System.Windows.Forms.BindingSource kolcsonzesBindingSource;
        private KolcsonzesDST1TableAdapters.KolcsonzesTableAdapter kolcsonzesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolcsonzesAzonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konyvAzonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolcsonzoAzonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiadasDatumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visszaVetelDatumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolcsonzesiIdotartamDataGridViewTextBoxColumn;
    }
}