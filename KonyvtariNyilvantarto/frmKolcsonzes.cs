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
using System.IO;
namespace KonyvtariNyilvantarto
{  
    public partial class frmKolcsonzes : Form, IMuveletek
    {
        string kapcsolatiSztring= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Konyvtar.mdf;Integrated Security=True";

        /*  public abstract class Kolcsonzes 
        {
            public virtual void Hozzaadas(){ }
            public abstract void Modositas();
            public abstract void Mentes();
            public abstract void Torles();
        }*/
        SqlConnection kapcsolat;    
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();


        DateTime kezdodatum, zarodatum;
        TimeSpan idotartam;
       // DataGridViewCheckBoxColumn hosszabitas, elojegyzes;

        public frmKolcsonzes()
        {
            InitializeComponent();

            kapcsolatiSztring = ConfigurationManager.ConnectionStrings["KonyvtariNyilvantarto.Properties.Settings.KonyvtarConnectionString"].ConnectionString;    
        }

        private void frmKolcsonzes_Load(object sender, EventArgs e)
        {


          /* try
            {

              
                kapcsolat.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Konyvtar.mdf;Integrated Security=True;Connect Timeout=30";
                kapcsolat.Open();
                adapter = new SqlDataAdapter("SELECT KolcsonzesAzonosito, KonyvAzonosito as 'KonyvAzonosito',KolcsonzoAzonosito as'KolcsonzoAzonosito',"+
                    "KiadasDatuma as'KiadasDatuma',VisszaVetelDatuma as'VisszaVetelDatuma',KolcsonzesiIdotartam FROM Kolcsonzes", kapcsolat);
               
                adapter.Fill(ds, "Kolcsonzes");
                dgvKolcsonzes.DataSource = ds.Tables[0];
                kapcsolat.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba történt az adatok beolvasása során!");
            }*/
            this.kolcsonzesTableAdapter.Fill(this.kolcsonzesDST1.Kolcsonzes);

            this.unnepnapok();               //az ünnepnapok megivása a konstruktorban

        }

        private void btnKolcsonzok_Click(object sender, EventArgs e)
        {               
            frmKolcsonzok kolcsonzokAblak = new frmKolcsonzok();
            kolcsonzokAblak.Show();
           // kolcsonzesAblak.Hide();
            
        }

        private void btnKonyvekFrissites_Click(object sender, EventArgs e)
        {
            Frissites();
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            this.Close();

        }
       
        private void btnfrmKolcsonzesRogzit_Click(object sender, EventArgs e)
        {
            

            this.Hozzaadas();
        }      
        public void Frissites()
        {
            this.kolcsonzesTableAdapter.Fill(this.kolcsonzesDST1.Kolcsonzes);
        }
        private void btnfrmKolcsonzesMent_Click(object sender, EventArgs e)
        {
            kolcsonzesTableAdapter.Update(kolcsonzesDST1);
            MessageBox.Show("Adatok elmentve!");
        }
        //Kiadásgomb
        private void btnKiadas_Click(object sender, EventArgs e)
        {
            kezdodatum = mcKiadas.SelectionStart;

            if (mcKiadas.SelectionStart < mcVisszavetel.SelectionEnd)
            {
                    tbKezdes.Text = mcKiadas.SelectionStart.Day.ToString() + "/" +
                    mcKiadas.SelectionStart.Month.ToString() + "/" +
                    mcKiadas.SelectionStart.Year.ToString();
            }
            else
            {
                MessageBox.Show("Rossz kezdődátum!");
            }
        }
        //Visszavételgomb
        private void btnVisszavetel_Click(object sender, EventArgs e)
        {

            zarodatum = mcVisszavetel.SelectionEnd;
            idotartam = zarodatum.Subtract(kezdodatum);

            if (mcVisszavetel.SelectionEnd > mcKiadas.SelectionStart)
            {
                tbKezdes.Text = mcKiadas.SelectionRange.Start.ToShortDateString();
                tbZaras.Text = mcVisszavetel.SelectionRange.Start.ToShortDateString();
                 
                tbZaras.Text = mcVisszavetel.SelectionEnd.Day.ToString() + "/"+
                mcVisszavetel.SelectionEnd.Month.ToString() + "/" +
                mcVisszavetel.SelectionEnd.Year.ToString();

                if (tbIdotartam.Text == "")
                {
                    tbIdotartam.Text = idotartam.Days.ToString();
                }
            }
            else
            {
                MessageBox.Show("Rossz záródátum");
                
            }
            
        }

        private void tbKolcsonzokUjbevitel_MouseHover(object sender, EventArgs e)
        {
            tbKolcsonzokUjbevitel.BackColor = Color.MediumAquamarine;
        }

        private void tbKolcsonzokUjbevitel_MouseLeave(object sender, EventArgs e)
        {
            tbKolcsonzokUjbevitel.BackColor = DefaultBackColor;
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            //adapter.Fill(ds, "Kolcsonzes");
        }
        //szövegmezők kiürítése
        private void tbKolcsonzokUjbevitel_Click(object sender, EventArgs e)
        {
            tbKolcsonzesAzonosito.Text = "";
            tbKCSKonyvAzonosito.Text = "";
            tbKolcsonzoAzonosito.Text = "";
            tbKezdes.Text = "";
            tbZaras.Text = "";
            tbIdotartam.Text = "";

        }
        //nemzeti ünnepek a naptárban
        public void unnepnapok()
        {
            mcKiadas.BoldedDates = new DateTime[]
            {
                DateTime.Today.AddDays(1)
            };
            Controls.Add(mcKiadas);
            Controls.Add(mcVisszavetel);
        }



        public  void Hozzaadas()
        {
                     
            string lekerdezes = "INSERT INTO Kolcsonzes VALUES(@KonyvAzonosito,KolcsonzoAzonosito,"+
                "KiadasDatuma,VisszaVetelDatuma,KolcsonzesiIdotartam)";
            using (kapcsolat = new SqlConnection(kapcsolatiSztring))
            using (SqlCommand hozzaad = new SqlCommand(lekerdezes, kapcsolat))
                try
                {
                    kapcsolat.Open();
                    hozzaad.CommandText = "INSERT INTO Kolcsonzes([KonyvAzonosito],KolcsonzoAzonosito," +
                        "KiadasDatuma,VisszaVetelDatuma,KolcsonzesiIdotartam)" +
                        "VALUES('" + tbKCSKonyvAzonosito.Text + "','" + tbKolcsonzoAzonosito.Text + "'," +
                        "'" + mcKiadas.SelectionRange.Start.ToString("MM-dd-yyyy") + "',"+
                        "'" + mcVisszavetel.SelectionRange.End.ToString("MM-dd-yyyy") + "'," +
                        "'" + tbIdotartam.Text + "')";
                    hozzaad.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Nem sikerült az adatbevitel2");
                }
   
            MessageBox.Show("Adatok felvive!");
            kapcsolat.Close();
            Frissites();







        }
        public  void Modositas()
        {
            adapter = new SqlDataAdapter("SELECT * FROM Kolcsonzes", kapcsolat);
            string modosit = "UPDATE Kolcsonzes SET KonyvAzonosito=@KonyvAzonosito,"+
                "KolcsonzoAzonosito=@KolcsonzoAzonosito,KiadasDatuma=@KiadasDatuma," +
                "VisszaVetelDatuma=@VisszaVetelDatuma,KolcsonzesiIdotartam=@KolcsonzesiIdotartam"+
                "WHERE @KolcsonzesAzonosito=KolcsonzesAzonosito";
            using (kapcsolat = new SqlConnection(kapcsolatiSztring))
            using (SqlCommand modositas = new SqlCommand(modosit, kapcsolat))
                try
                {
                    kapcsolat.Open();
                    modositas.Parameters.AddWithValue("@KolcsonzoAzonosito", tbKolcsonzoAzonosito.Text);
                    modositas.Parameters.AddWithValue("@KonyvAzonosito", tbKCSKonyvAzonosito.Text);
                    modositas.Parameters.AddWithValue("@KolcsonzoAzonosito",tbKolcsonzesAzonosito.Text);
                    modositas.Parameters.AddWithValue("@KiadasDatuma", tbKezdes.Text);
                    modositas.Parameters.AddWithValue("@VisszaVetelDatuma", tbZaras.Text);
                    modositas.Parameters.AddWithValue("@KolcsonzesiIdotartam", tbIdotartam.Text);
                   

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
        public   void Mentes() { }

        

        private void dgvKolcsonzes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                            
        }
        
        public void Torles() { }
        
    }
    
}
