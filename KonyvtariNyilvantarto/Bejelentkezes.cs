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

namespace KonyvtariNyilvantarto
{
    public partial class frmBejelentkezes : Form
    {
       
        string kapcsolatiSztring;

        //kapcsolat létrehozása
        public static SqlConnection kapcsolat = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Konyvtar.mdf;Integrated Security=True");

        public frmBejelentkezes()
        {
            InitializeComponent();

            kapcsolatiSztring = ConfigurationManager.ConnectionStrings["KonyvtariNyilvantarto.Properties.Settings.KonyvtarConnectionString"].ConnectionString;
        }
      
        private void btnBelepes_Click(object sender, EventArgs e)//autentikáció
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Felhasznalok WHERE Felhasznalonev='"
            +tbFelhasznalonev.Text+"'AND Jelszo='"+tbJelszo.Text+"'AND Jogosultsag='"+cbJogosultsag.Text+"'", kapcsolat);
            try
            {
                kapcsolat.Open();
                this.Hide();
                DataTable adatTabla = new DataTable();

                sda.Fill(adatTabla);

                if (adatTabla.Rows[0][0].ToString() == "1")
                {
                    KonyvtarAblak KA = new KonyvtarAblak(cbJogosultsag.Text);//példányosítom a KonyvtarAblak osztályt
                    KA.Show();                                             
                }
                else
                {
                    MessageBox.Show("Kérem ellenőrizze a felhasználónevet és/vagy a jelszót!"); //üzenet a felhasználónak
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show
                    (ex.Message,"Adatbázis kapcsolódási hiba!"+
                    "Zárd be a párbeszédablakot és próbálj belépni újra!");
            }
            kapcsolat.Close();
           
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
