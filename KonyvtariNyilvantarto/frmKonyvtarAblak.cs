using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace KonyvtariNyilvantarto
{
    //ha valamelyik műveletet kihagynám nem fordulna le a program
    public partial class KonyvtarAblak : Form, IMuveletek
    {
        //kapcsolatobjektum,adatbázis kapcsolatsztring
        static string kapcsolatisztring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Konyvtar.mdf;Integrated Security=True";
        SqlDataAdapter adapter;
        SqlConnection kapcsolat = new SqlConnection(kapcsolatisztring);
        DataTable konyvekTablaAdatai = new DataTable();

        SqlCommand parancs;
        SqlCommandBuilder utasitalak;
        SqlDataReader olvasas = null;

        //egy int változóban tartjuk nyilván a fh. pozicióját egy DataGridViewRow objektumban
        int konyvektablasorpozicio = 0;


        public KonyvtarAblak()
        {
            InitializeComponent();

        }

        public KonyvtarAblak(String Felhasznalo)
        {
            InitializeComponent();


            lblJogSzint.Text = "Felhasználó:" + Felhasznalo;    //ha a rendszergazda felhasználó lép be, akkor megjelenik a "menüje"
            if (Felhasznalo == "rendszergazda")
            {
                rendszergazdaBeallitasok.Enabled = true;
                kölcsönzésiAdatokToolStripMenuItem.Enabled = false;

               
            }
            kapcsolatisztring = ConfigurationManager.ConnectionStrings["KonyvtariNyilvantarto.Properties.Settings.KonyvtarConnectionString"].ConnectionString;


        }

        private void btnKilepes_Click(object sender, EventArgs e)//kilépőgomb
        {
            Application.Exit();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)//mégegykilépőgomb
        {
            this.Close();
        }


        private void eztBezárToolStripMenuItem_Click(object sender, EventArgs e)//bezárógomb
        {
            this.Close();
        }

        private void rGazdaFül_Click(object sender, EventArgs e)//rendszergazdának
        {
            frmRendszergazda rGazda = new frmRendszergazda();
            rGazda.Show();
        }


          private void dgvKonyvek_CellClick(object sender, DataGridViewCellEventArgs e)// dupla kattintásra megjelenik a celllák tartalma a tb-okban (Foxall könyv)
         {
            try
            {
                konyvektablasorpozicio = e.RowIndex;
                DataGridViewRow sor = dgvKonyvek.Rows[konyvektablasorpozicio];

                tbKonyvAzonosito.Text = sor.Cells[0].Value.ToString();
                tbKonyvCime.Text = sor.Cells[1].Value.ToString();
                cbMufaj.Text = sor.Cells[2].Value.ToString();
                cbSzerzo.Text = sor.Cells[3].Value.ToString();
                cbAllapot.Text = sor.Cells[4].Value.ToString();
                cbKiado.Text = sor.Cells[5].Value.ToString();
                tbMegjelenesHelye.Text = sor.Cells[6].Value.ToString();
                tbKiadasEve.Text = sor.Cells[7].Value.ToString();
                tbEredetiNyelv.Text = sor.Cells[8].Value.ToString();
                tbOldalakSzama.Text = sor.Cells[9].Value.ToString();
                cbBoritoTipusa.Text = sor.Cells[10].Value.ToString();
                tbMennyiseg.Text = sor.Cells[11].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba!");
            }
        }




        private void szovegKiiratas()//sorszám szerinti hozzáférés 
        {
            if (konyvekTablaAdatai.Rows.Count == 0)
            {
                tbKonyvAzonosito.Text = "";
                tbKonyvCime.Text = "";
                cbMufaj.Text = "";
                cbSzerzo.Text = "";
                cbAllapot.Text = "";
                cbKiado.Text = "";
                tbMegjelenesHelye.Text = "";
                tbKiadasEve.Text = "";
                tbKiadasEve.Text = "";
                tbEredetiNyelv.Text = "";
                tbOldalakSzama.Text = "";
                cbBoritoTipusa.Text = "";
                tbMennyiseg.Text = "";
            }
            tbKonyvAzonosito.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["KonyvAzonosito"].ToString();
            tbKonyvCime.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["KonyvCime"].ToString();
            cbMufaj.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["Mufaj"].ToString();
            cbSzerzo.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["Szerzo"].ToString();
            cbAllapot.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["Allapot"].ToString();
            cbKiado.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["Kiado"].ToString();
            tbMegjelenesHelye.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["MegjelenesHelye"].ToString();
            tbKiadasEve.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["KiadasEve"].ToString();
            tbEredetiNyelv.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["EredetiNyelv"].ToString();
            tbOldalakSzama.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["OldalakSzama"].ToString();
            cbBoritoTipusa.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["BoritoTipusa"].ToString();
            tbMennyiseg.Text = konyvekTablaAdatai.Rows[konyvektablasorpozicio]["Mennyiseg"].ToString();
        }

        private void KonyvtarAblak_Load(object sender, EventArgs e)
        {
            

            kapcsolat.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Konyvtar.mdf;Integrated Security=True";

        }

        private void mKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
        

        //DataSet beltöltése
        public void Frissites()
        {
            this.konyvekTableAdapter.Fill(this.konyvekDST.Konyvek);
        }

        //PDF formátumba való mentés
        //Forrás: CSharpSpace:How to export datagridview to pdf in Windows Forms Application
        public void MentesPDF(DataGridView dgvKonyvek, string fajlneve)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

            PdfPTable pdftabla = new PdfPTable(dgvKonyvek.Columns.Count);
            pdftabla.DefaultCell.Padding = 3;
            pdftabla.WidthPercentage = 100;
            pdftabla.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftabla.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font szoveg = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Fejléc hozzáadása
            foreach (DataGridViewColumn oszlop in dgvKonyvek.Columns)
            {
                PdfPCell cella = new PdfPCell(new Phrase(oszlop.HeaderText,szoveg));
                cella.BackgroundColor = new BaseColor(240, 240, 240);
                pdftabla.AddCell(cella);
            }

            //Adatsor hozzáadása
            foreach (DataGridViewRow sor in dgvKonyvek.Rows)
            {
                foreach (DataGridViewCell cella in sor.Cells)
                {
                    pdftabla.AddCell(new Phrase(cella.Value.ToString(), szoveg));
                }
            }
            var fajlMentese = new SaveFileDialog();
            fajlMentese.FileName = fajlneve;
            fajlMentese.DefaultExt = ".pdf";
            if (fajlMentese.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(fajlMentese.FileName, FileMode.Create))
                {
                    Document pdfdoksi = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoksi, fs);
                    pdfdoksi.Open();
                    pdfdoksi.Add(pdftabla);
                    pdfdoksi.Close();
                    fs.Close();
                    pdfdoksi.Close();
                }
            }
        }

        private void btnKilepKaForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kölcsönzésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKolcsonzes kolcsonzesAblak = new frmKolcsonzes();
            kolcsonzesAblak.Show();


        }

        private void selejtezettKönyvekToolStripMenuItem_Click(object sender, EventArgs e)                   //Selejtkönyvek ablakának megjelenítése
        {
            frmSelejtKonyvek selejtKonyvekAblak = new frmSelejtKonyvek();
            selejtKonyvekAblak.Show();
        }

        private void btnfrmKonyvekTorol_Click(object sender, EventArgs e)                                       //Egy sor törlése
        {
            Torles();
        }

        private void btnMegjelenit_Click(object sender, EventArgs e)                        //Könyvek tábla adatainak megjelenítő gomb
        {
            this.konyvekTableAdapter.Fill(this.konyvekDST.Konyvek);                      //adathalmaz betöltése a Könyvek táblából
        }




        private void btnfrmKonyvekMent_Click(object sender, EventArgs e)//adatok elmentése
        {

            Mentes();
            //konyvekTableAdapter.Update(konyvekDST);
        }

        //Keresés-gomb
        private void btnKereses_Click(object sender, EventArgs e)                                    //Keresőgomb klikk eseménye
        {
            try                                                                                    //hibakezelés
            {


                if (rbCim.Checked == true && tbKereses.Text.Length > 0)
                {
                    this.konyvCimKeres();
                }


                if (rbSzerzo.Checked == true && tbKereses.Text.Length > 0)
                {
                    szerzoKeres();
                }

                if (rbMufaj.Checked == true && tbKereses.Text.Length > 0)
                {
                    mufajKeres();
                }

                if (rbKiado.Checked == true && tbKereses.Text.Length > 0)
                {
                    kiadoKeres();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Valamit elrontottál!");
            }
        }

        private void táblaÜrítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dgvKonyvek.Clear();
        }

        private void frissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.konyvekTableAdapter.Fill(this.konyvekDataSet.Konyvek);
        }

        //pdf-be való mentés gombja, két parmétert vár meg kell adnunk neki a DataGridView objektumot, és az elmentendő pdf fájl nevét
        private void btnMentesPdf_Click(object sender, EventArgs e)
        {

           MentesPDF(dgvKonyvek,"fajlneve");
        }

        
        private void btnKAFrissit_Click(object sender, EventArgs e)
        {
            Frissites();
        }

        private void btnTbFrissit_Click(object sender, EventArgs e)//Az adatbeviteli szövegdobozok kiürítése
        {
            tbKonyvAzonosito.Text = "";
            tbKonyvCime.Text = "";
            cbMufaj.Text = "";
            cbSzerzo.Text = "";
            cbAllapot.Text = "";
            cbKiado.Text = "";
            tbMegjelenesHelye.Text = "";
            tbKiadasEve.Text = "";
            tbEredetiNyelv.Text = "";
            tbOldalakSzama.Text = "";
            cbBoritoTipusa.Text = "";
            tbMennyiseg.Text = "";

        }

        private void műfajokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMufajok mufajokAblak = new frmMufajok();
            mufajokAblak.Show();
        }

        private void aktuálisÁllapotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllapotok allapotAblak = new frmAllapotok();
            allapotAblak.Show();
        }


        //Adatok bevitele
        private void btnfrmKonyvekRogzit_Click(object sender, EventArgs e)
        {
            Hozzaadas();
        }

        private void btbfrmKonyvekModositas_Click(object sender, EventArgs e)
        {
            Modositas();
        }
        public void Hozzaadas()
        {
            string bázis = "INSERT INTO Konyvek VALUES(@KonyvCime,Mufaj,Szerzo,Allapot,Kiado," +
                           "MegjelenesHelye,KiadasEve,EredetiNyelv,OldalakSzama,BoritoTipusa,Mennyiseg)";
            using (kapcsolat = new SqlConnection(kapcsolatisztring))
            using (SqlCommand rogzit = new SqlCommand(bázis, kapcsolat))

                try
                {
                    {
                        kapcsolat.Open();
                        rogzit.CommandText =
                            "INSERT INTO Konyvek([KonyvCime],Mufaj,Szerzo,Allapot,Kiado,MegjelenesHelye," +
                            "KiadasEve,EredetiNyelv,OldalakSzama,BoritoTipusa,Mennyiseg)" +
                            "VALUES('" + tbKonyvCime.Text + "','" + cbMufaj.Text + "','" + cbSzerzo.Text + "'," +
                            "'" + cbAllapot.Text + "','" + cbKiado.Text + "','" + tbMegjelenesHelye.Text + "'," +
                            "'" + tbKiadasEve.Text + "','" + tbEredetiNyelv.Text + "','" + tbOldalakSzama.Text + "'," +
                            "'" + cbBoritoTipusa.Text + "','" + tbMennyiseg.Text + "')";
                        rogzit.ExecuteNonQuery();
                        Frissites();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba a bevitel során!");

                }
            MessageBox.Show("Adatok rögzítve!");
            kapcsolat.Close();
        }
        public void Modositas()
        {
            adapter = new SqlDataAdapter("SELECT * FROM Konyvek", kapcsolat);
            string modosit = "UPDATE Konyvek SET KonyvCime=@KonyvCime,Mufaj=@Mufaj," +
                "Szerzo=@Szerzo,Allapot=@Allapot,Kiado=@Kiado,MegjelenesHelye=@MegjelenesHelye," +
                "KiadasEve=@KiadasEve,EredetiNyelv=@EredetiNyelv,OldalakSzama=@OldalakSzama," +
                "BoritoTipusa=@BoritoTipusa,Mennyiseg=@Mennyiseg WHERE @KonyvAzonosito=KonyvAzonosito";
            using (kapcsolat = new SqlConnection(kapcsolatisztring))
            using (SqlCommand modositas = new SqlCommand(modosit, kapcsolat))
                try
                {
                    kapcsolat.Open();
                    modositas.Parameters.AddWithValue("@KonyvAzonosito", tbKonyvAzonosito.Text);
                    modositas.Parameters.AddWithValue("@KonyvCime", tbKonyvCime.Text);
                    modositas.Parameters.AddWithValue("@Mufaj", cbMufaj.Text);
                    modositas.Parameters.AddWithValue("@Szerzo", cbSzerzo.Text);
                    modositas.Parameters.AddWithValue("@Allapot", cbAllapot.Text);
                    modositas.Parameters.AddWithValue("@Kiado", cbKiado.Text);
                    modositas.Parameters.AddWithValue("@MegjelenesHelye", tbMegjelenesHelye.Text);
                    modositas.Parameters.AddWithValue("@KiadasEve", tbKiadasEve.Text);
                    modositas.Parameters.AddWithValue("@EredetiNyelv", tbEredetiNyelv.Text);
                    modositas.Parameters.AddWithValue("@OldalakSzama", tbOldalakSzama.Text);
                    modositas.Parameters.AddWithValue("@BoritoTipusa", cbBoritoTipusa.Text);
                    modositas.Parameters.AddWithValue("@Mennyiseg", tbMennyiseg.Text);

                    modositas.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Valami nem sikerült!");
                }
            kapcsolat.Close();
            MessageBox.Show("Adatok módosítva");
            Frissites();
        }
        public void Mentes()
        {

            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM Konyvek", kapcsolat);
                utasitalak = new SqlCommandBuilder(adapter);
                adapter.Update(konyvekTablaAdatai);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Nem sikerült a mentés");
            }
            MessageBox.Show("Adatok elmentve..");
        }
        public void Torles()
        {
            string sor = "DELETE FROM Konyvek WHERE KonyvAzonosito=@KonyvAzonosito";
            using (kapcsolat = new SqlConnection(kapcsolatisztring))
            using (SqlCommand sortTorol = new SqlCommand(sor, kapcsolat))
                if (dgvKonyvek.RowCount > 0)
                {
                    if (MessageBox.Show("Biztosan törölni szeretnéd?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        try
                        {

                            kapcsolat.Open();
                            sortTorol.Parameters.AddWithValue("@KonyvAzonosito", dgvKonyvek.SelectedRows[0].Cells[0].Value);
                            sortTorol.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "Nem sikerült a törlés!");
                        }
                    Frissites();
                    MessageBox.Show("Adatok törölve..");
                    kapcsolat.Close();
                }
        }

        /*private void dgvKonyvek_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
            
                tbKonyvAzonosito.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[0].Value.ToString();
                tbKonyvCime.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[1].Value.ToString();
                cbMufaj.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[2].Value.ToString();
                cbSzerzo.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[3].Value.ToString();
                cbAllapot.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[4].Value.ToString();
                cbKiado.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[5].Value.ToString();
                tbMegjelenesHelye.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[6].Value.ToString();
                tbKiadasEve.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[7].Value.ToString();
                tbEredetiNyelv.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[8].Value.ToString();
                tbOldalakSzama.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[8].Value.ToString();
                cbBoritoTipusa.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[10].Value.ToString();
                tbMennyiseg.Text = dgvKonyvek.SelectedRows[konyvektablasorpozicio].Cells[11].Value.ToString();
            
        }*/

        //Keresések
        //Keresés a KonyvCime oszlopban
        public void konyvCimKeres()
        {
            if (kapcsolat.State == ConnectionState.Closed)
            {
                kapcsolat.Open();
                adapter = new SqlDataAdapter("KonyvCimKereses", kapcsolat);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@KonyvCime", tbKereses.Text.Trim());
                adapter.Fill(konyvekTablaAdatai);
                dgvKonyvek.DataSource = konyvekTablaAdatai;
                kapcsolat.Close();

            }
        }
        //Keresés a Szerzok nevű táblában
        public void szerzoKeres()
        {
            if (kapcsolat.State == ConnectionState.Closed)
            {
                kapcsolat.Open();
                adapter = new SqlDataAdapter("SzerzoKereses", kapcsolat);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@SzerzoNeve", tbKereses.Text.Trim());
                adapter.Fill(konyvekTablaAdatai);
                dgvKonyvek.DataSource = konyvekTablaAdatai;
                kapcsolat.Close();

            }

        }
        //Keresés a Mufajok nevű táblában
        public void mufajKeres()
        {
            if(kapcsolat.State == ConnectionState.Closed)
            {
                kapcsolat.Open();
                adapter = new SqlDataAdapter("MufajKereses", kapcsolat);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@MufajNeve", tbKereses.Text.Trim());
                adapter.Fill(konyvekTablaAdatai);
                dgvKonyvek.DataSource = konyvekTablaAdatai;
                kapcsolat.Close();

            }
        }
        //Keresés a Könyvkiadók nevű táblában
        public void kiadoKeres()
        {
            if(kapcsolat.State == ConnectionState.Closed)
            {
                kapcsolat.Open();
                adapter = new SqlDataAdapter("KiadoKereses", kapcsolat);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@KiadoNeve", tbKereses.Text.Trim());
                adapter.Fill(konyvekTablaAdatai);
                dgvKonyvek.DataSource = konyvekTablaAdatai;
                kapcsolat.Close();

            }
        }

        private void kölcsönzőkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKolcsonzok kolcsonzokAblak = new frmKolcsonzok();
            kolcsonzokAblak.Show();
        }
    }
}