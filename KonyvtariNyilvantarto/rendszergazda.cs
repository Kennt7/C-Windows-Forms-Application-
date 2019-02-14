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
    public partial class frmRendszergazda : Form
    {
        SqlConnection kapcsolat; //kapcsolóobjektum
        SqlDataAdapter adapter; //ezzel férünk hozzá az adatforráshoz, a kapcsolaton keresztül
        DataTable felhasznalokTabla = new DataTable();
        DataSet ds=null;                            // ne dobjon nullreference exceptiont
        SqlCommandBuilder utasitas;
        //DataSet ds = null;


      
        
      
        //egy int tipusu változóban tartjuk nyilván a felhasznaló jelenlegi pozícióját(sorát), a DataTable objektumban.
        int sorpozicio = 0;

        string kapcsolatiSztring;
        public frmRendszergazda()
        {
            InitializeComponent();
            //példányosítunk egy kapcsolat-sztring beállító-objektumot a ConfigurationManager osztály ConnectionSTrings tulajdonságának segítségével
           kapcsolatiSztring = ConfigurationManager.ConnectionStrings["KonyvtariNyilvantarto.Properties.Settings.KonyvtarConnectionString"].ConnectionString;
        }

        private void frmRendszergazda_Load(object sender, EventArgs e)
        {                
            //Kapcsolat kiépítése:kapcsolati sztring, mely tartalmazza, az adatbázis:nevet,szervert,kapcsolat biztonsági szintjét
            kapcsolat.ConnectionString =@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Konyvtar.mdf;Integrated Security=True";
          
           
            
        }
        //A tábla frissítése
        private void Frissites()
        {
            this.felhasznalokTableAdapter.Fill(this.felhasznalokDST.Felhasznalok);
        }
        
        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRFelhHozzaAD_Click(object sender, EventArgs e) //Hozzáadás az adatbázishoz
        {

            string sorbaMenj = "INSERT INTO Felhasznalok VALUES(@FelhasznaloAzonosito,Felhasznalonev,Jelszo,Jogosultsag)";
            using (kapcsolat = new SqlConnection(kapcsolatiSztring))
            using (SqlCommand beszur = new SqlCommand(sorbaMenj, kapcsolat))
                try//ha esetleg véletlenül, ugyanaz a felhasználónév kerülne beírásra a keletkező kivételt kezeljük ezzel a try-ággal
                {
                    {
                        kapcsolat.Open();
                       // beszur.Parameters.AddWithValue("@Felhasznalonev", tbR1Felhasznalonev.Text);
                        beszur.CommandText = "INSERT INTO Felhasznalok ([FelhasznaloAzonosito],Felhasznalonev,Jelszo,Jogosultsag) VALUES ('" +tbR0FelhasznaloAzonosito.Text + "','" + tbR1Felhasznalonev.Text +
                        "', '" + tbR2Jelszo.Text + "','" + cbRJogosultsag.Text + "')";
                        beszur.ExecuteScalar();
                        Frissites();
                        //kapcsolat.Close();

                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Ez a felhasználónév már létezik, kérem adjon meg másikat!");
                }
  
        }
        
        
        
        private void btnMegjelenit_Click(object sender, EventArgs e)
        {

            this.felhasznalokTableAdapter.Fill(this.felhasznalokDST.Felhasznalok);
        }



        private void btnRTorles_Click(object sender, EventArgs e)
        {
            string tabla = "DELETE FROM Felhasznalok WHERE FelhasznaloAzonosito=@FelhasznaloAzonosito";
            using (kapcsolat = new SqlConnection(kapcsolatiSztring))
            using (SqlCommand sortorol = new SqlCommand(tabla, kapcsolat))
            {
                if (dgvRendszergazda.RowCount >= 4)
                {
                    if (MessageBox.Show("Figyelem!Biztosan törölni szeretné?", "Adatok törlése", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        try
                        {

                            kapcsolat.Open();
                            sortorol.Parameters.AddWithValue("@FelhasznaloAzonosito", dgvRendszergazda.SelectedRows[0].Cells[0].Value);
                            sortorol.ExecuteNonQuery();
                            Frissites();
                            MessageBox.Show("Sor törölve!");
                            kapcsolat.Close();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                }
                else
                {
                    MessageBox.Show("Nem törölhetsz 3-nál kevesbb felhasználó van!");
                }
            }
        }

        private void btnRgazdaKilep_Click(object sender, EventArgs e)           //Kilépőgomb
        {
            this.Close();
        }
        

        private void btnRUjBevitel_Click(object sender, EventArgs e)// Új adatok bevitele, helyet "szabadítok" fel a tb-ban
        {
            Szovegmezotorles();
        }

        private void Szovegmezotorles()                                  //szövegmezők kiürítése
        {
            tbR0FelhasznaloAzonosito.Text = "";
            tbR1Felhasznalonev.Text = "";
            tbR2Jelszo.Text = "";
            cbRJogosultsag.Text = "";
        }

        private void btnFrissites_Click(object sender, EventArgs e) // a DataGridView frissítése
        {
            this.Frissites();
        }

       
       private void btnRModositas_Click(object sender, EventArgs e)//Módosító metódus
        {
            
            adapter = new SqlDataAdapter("SELECT * FROM Felhasznalok", kapcsolat);
            string modosit = "UPDATE Felhasznalok SET Jelszo=@Jelszo, Jogosultsag=@Jogosultsag,Felhasznalonev=@Felhasznalonev WHERE @FelhasznaloAzonosito=FelhasznaloAzonosito ";
            using (kapcsolat = new SqlConnection(kapcsolatiSztring))
            using (SqlCommand atnevez = new SqlCommand(modosit, kapcsolat)) //parancsobjektum létrehozása

            {
                try
                {
                    //kapcsolat.Open();
                    atnevez.Parameters.AddWithValue("@FelhasznaloAzonosito", tbR0FelhasznaloAzonosito.Text);
                    atnevez.Parameters.AddWithValue("@Felhasznalonev", tbR1Felhasznalonev.Text);
                    atnevez.Parameters.AddWithValue("@Jelszo", tbR2Jelszo.Text);
                    atnevez.Parameters.AddWithValue("@Jogosultsag", cbRJogosultsag.Text);

                    kapcsolat.Open();
                    atnevez.ExecuteNonQuery();
                    kapcsolat.Close();
                    MessageBox.Show("Adatok módosítva!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }               
            }    
            
        }

        private void dgvRendszergazda_MouseDoubleClick(object sender, MouseEventArgs e)//adatok kiolvasása a cellákból:Foxall
        {
            tbR1Felhasznalonev.Text = dgvRendszergazda.SelectedRows[sorpozicio].Cells[0].Value.ToString();
            tbR2Jelszo.Text = dgvRendszergazda.SelectedRows[sorpozicio].Cells[1].Value.ToString();
            cbRJogosultsag.Text = dgvRendszergazda.SelectedRows[sorpozicio].Cells[2].Value.ToString();
        }

        private void btnRMent_Click(object sender, EventArgs e)//változtatások mentése a táblába
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM Felhasznalok", kapcsolat);
                utasitas = new SqlCommandBuilder(adapter);
                adapter.Update(felhasznalokTabla);
                MessageBox.Show("Adatok elmentve!");
            }
            catch(Exception ex) { MessageBox.Show("Hiba",ex.Message); }
           
        }

        private void frissitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frissites();
        }

       /* private void dgvRendszergazda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            felhasznaloktablasorpozicio = e.RowIndex;
            DataGridViewRow sor = dgvRendszergazda.Rows[felhasznaloktablasorpozicio];

            tbR0FelhasznaloAzonosito.Text = sor.Cells[0].Value.ToString();
            tbR1Felhasznalonev.Text= sor.Cells[1].Value.ToString();
            tbR2Jelszo.Text = sor.Cells[2].Value.ToString();
            cbRJogosultsag.Text = sor.Cells[3].Value.ToString();
        }
        */
        
    }
}
