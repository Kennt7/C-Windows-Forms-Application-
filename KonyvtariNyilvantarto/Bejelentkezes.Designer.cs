namespace KonyvtariNyilvantarto
{
    partial class frmBejelentkezes
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
            this.lblFelhasznalonev = new System.Windows.Forms.Label();
            this.lblJelszo = new System.Windows.Forms.Label();
            this.lblJogosultsag = new System.Windows.Forms.Label();
            this.tbFelhasznalonev = new System.Windows.Forms.TextBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.cbJogosultsag = new System.Windows.Forms.ComboBox();
            this.btnBelepes = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFelhasznalonev
            // 
            this.lblFelhasznalonev.AutoSize = true;
            this.lblFelhasznalonev.Location = new System.Drawing.Point(12, 35);
            this.lblFelhasznalonev.Name = "lblFelhasznalonev";
            this.lblFelhasznalonev.Size = new System.Drawing.Size(84, 13);
            this.lblFelhasznalonev.TabIndex = 0;
            this.lblFelhasznalonev.Text = "Felhasználónév:";
            // 
            // lblJelszo
            // 
            this.lblJelszo.AutoSize = true;
            this.lblJelszo.Location = new System.Drawing.Point(12, 66);
            this.lblJelszo.Name = "lblJelszo";
            this.lblJelszo.Size = new System.Drawing.Size(39, 13);
            this.lblJelszo.TabIndex = 1;
            this.lblJelszo.Text = "Jelszó:";
            // 
            // lblJogosultsag
            // 
            this.lblJogosultsag.AutoSize = true;
            this.lblJogosultsag.Location = new System.Drawing.Point(12, 93);
            this.lblJogosultsag.Name = "lblJogosultsag";
            this.lblJogosultsag.Size = new System.Drawing.Size(63, 13);
            this.lblJogosultsag.TabIndex = 2;
            this.lblJogosultsag.Text = "Jogosultság";
            // 
            // tbFelhasznalonev
            // 
            this.tbFelhasznalonev.Location = new System.Drawing.Point(121, 31);
            this.tbFelhasznalonev.Name = "tbFelhasznalonev";
            this.tbFelhasznalonev.Size = new System.Drawing.Size(110, 20);
            this.tbFelhasznalonev.TabIndex = 1;
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(121, 59);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.PasswordChar = '☺';
            this.tbJelszo.Size = new System.Drawing.Size(110, 20);
            this.tbJelszo.TabIndex = 2;
            this.tbJelszo.UseSystemPasswordChar = true;
            // 
            // cbJogosultsag
            // 
            this.cbJogosultsag.FormattingEnabled = true;
            this.cbJogosultsag.Items.AddRange(new object[] {
            "rendszergazda",
            "könyvtáros"});
            this.cbJogosultsag.Location = new System.Drawing.Point(121, 89);
            this.cbJogosultsag.Name = "cbJogosultsag";
            this.cbJogosultsag.Size = new System.Drawing.Size(109, 21);
            this.cbJogosultsag.TabIndex = 3;
            // 
            // btnBelepes
            // 
            this.btnBelepes.Location = new System.Drawing.Point(15, 138);
            this.btnBelepes.Name = "btnBelepes";
            this.btnBelepes.Size = new System.Drawing.Size(75, 23);
            this.btnBelepes.TabIndex = 4;
            this.btnBelepes.Text = "Belepés";
            this.btnBelepes.UseVisualStyleBackColor = true;
            this.btnBelepes.Click += new System.EventHandler(this.btnBelepes_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(156, 138);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(75, 23);
            this.btnKilepes.TabIndex = 5;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // frmBejelentkezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnBelepes);
            this.Controls.Add(this.cbJogosultsag);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbFelhasznalonev);
            this.Controls.Add(this.lblJogosultsag);
            this.Controls.Add(this.lblJelszo);
            this.Controls.Add(this.lblFelhasznalonev);
            this.Name = "frmBejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFelhasznalonev;
        private System.Windows.Forms.Label lblJelszo;
        private System.Windows.Forms.Label lblJogosultsag;
        private System.Windows.Forms.TextBox tbFelhasznalonev;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.ComboBox cbJogosultsag;
        private System.Windows.Forms.Button btnBelepes;
        private System.Windows.Forms.Button btnKilepes;
    }
}

