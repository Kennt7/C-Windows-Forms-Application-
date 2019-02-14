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
    public partial class frmKolcsonzok : Form
    {
        
        string kapcsolatiSztring;
        SqlConnection kapcsolat = new SqlConnection();//(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Konyvtar.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter adapter;
        //DataTable kolcsonzokTabla;
        SqlCommandBuilder cb;
        DataSet ds=null;

       
        int kolcsonzoktablasorpozicio=0;
        /*
        string VezetekNev;
        public string KeresztNev;
        public string Telefonszam;
        public string EmailCim;


        public string Vezeteknev
        {
            get { return this.VezetekNev; }
            set { this.VezetekNev = value; }
        }
        */
        
        public frmKolcsonzok()
        {

            InitializeComponent();
           

            
            kapcsolatiSztring = ConfigurationManager.ConnectionStrings["KonyvtariNyilvantarto.Properties.Settings.KonyvtarConnectionString"].ConnectionString;
        }

        private void frmKolcsonzok_Load(object sender, EventArgs e)
        {
            try
            {

                kapcsolat = new SqlConnection();
                kapcsolat.ConnectionString=@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Konyvtar.mdf;Integrated Security=True;Connect Timeout=30";
                kapcsolat.Open();
                adapter = new SqlDataAdapter("SELECT KolcsonzoAzonosito, Vezeteknev as 'Vezeteknev',Keresztnev as'Keresztnev',Lakohely as'Lakohely',Telefonszam as'Telefonszam',EmailCim as'EmailCim',Darabszam as'Darabszam', Tagdij FROM Kolcsonzok", kapcsolat);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Kolcsonzok");
                dgvKolcsonzok.DataSource = ds.Tables[0];
                kapcsolat.Close();
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba történt!");
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region region_Muveletek
        private void btnKolcsonzokRogzit_Click(object sender, EventArgs e)
        {
            kapcsolat.Open();
            SqlCommand parancs = new SqlCommand();
            parancs.Connection =kapcsolat;
            string lekerdezes = "INSERT INTO Kolcsonzok (Vezeteknev,Keresztnev,Lakohely,Telefonszam,EmailCim,DarabSzam,Tagdij) VALUES('"+tbKolcsonzoVezeteknev.Text
            +"','"+tbKolcsonzoKeresztnev.Text+"','"+tbKolcsonzoLakohely.Text+"','"+tbKolcsonzoTelefonszam.Text+"','"+tbKolcsonzoEmailCim.Text+
            "','"+tbKolcsonzoDarabszam.Text+"','"+tbTagdij.Text+"')";
            adapter = new SqlDataAdapter(lekerdezes, kapcsolat);
            adapter.SelectCommand.ExecuteNonQuery();
            kapcsolat.Close();
            MessageBox.Show("Adatok felvive!");
            
        }


        private void btnfrmKolcsonzokMent_Click(object sender, EventArgs e)
        {


            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM Kolcsonzok", kapcsolat);
                cb = new SqlCommandBuilder(adapter);
                MessageBox.Show("Adatok elmentve");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            
        }
        
        private void btnKolcsonzokFrissites_Click(object sender, EventArgs e)
        {
            Frissites();
        }

        private void btnfrmKonyvekTorol_Click(object sender, EventArgs e)
        {
            adapter.DeleteCommand = new SqlCommand("DELETE FROM Kolcsonzok" + "WHERE KolcsonzoAzonosito=@KolcsonzoAzonosito");
            adapter.DeleteCommand.Parameters.Add(new SqlParameter("KolcsonzoAzonosito", SqlDbType.VarChar, 0, ""));
        }

        private void btnfrmKonyvekModosit_Click(object sender, EventArgs e)
        {
            kapcsolat.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Kolcsonzok", kapcsolat);
            adapter.UpdateCommand = new SqlCommand("UPDATE Kolcsonzok SET Vezeteknev='" + tbKolcsonzoVezeteknev.Text + "',Keresztnev='" + tbKolcsonzoKeresztnev.Text +
                "',Lakohely='" + tbKolcsonzoLakohely.Text + "',Telefonszam='" + tbKolcsonzoTelefonszam.Text + "',EmailCim='" + tbKolcsonzoEmailCim.Text +
                "',Darabszam='" + tbKolcsonzoDarabszam.Text + "', WHERE KolcsonzoAzonosito='';",kapcsolat);
            kapcsolat.Close();
            MessageBox.Show("Adatok módosítva!");
            
        }

        private void Frissites()
        {
            kapcsolat.Open();
            adapter = new SqlDataAdapter("SELECT KolcsonzoAzonosito, Vezeteknev as 'Vezeteknev',Keresztnev as'Keresztnev',Lakohely as'Lakohely',Telefonszam as'Telefonszam',EmailCim as'EmailCim',Darabszam as'Darabszam', Tagdij FROM Kolcsonzok", kapcsolat);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Kolcsonzok");
            dgvKolcsonzok.DataSource = ds.Tables[0];
            kapcsolat.Close();
        }

        private void btnUjbevitel_Click(object sender, EventArgs e)
        {
            tbKolcsonzoVezeteknev.Text = "";
            tbKolcsonzoKeresztnev.Text = "";
            tbKolcsonzoLakohely.Text = "";
            tbKolcsonzoTelefonszam.Text = "";
            tbKolcsonzoEmailCim.Text = "";
            tbTagdij.Text = "";
            tbKolcsonzoDarabszam.Text = "";
            
        }

        private void dgvKolcsonzok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kolcsonzoktablasorpozicio = e.RowIndex;
                DataGridViewRow sor = dgvKolcsonzok.Rows[kolcsonzoktablasorpozicio];

                tbKolcsonzoAzonosito.Text= sor.Cells[0].Value.ToString();
                tbKolcsonzoVezeteknev.Text = sor.Cells[1].Value.ToString();
                tbKolcsonzoKeresztnev.Text = sor.Cells[2].Value.ToString();
                tbKolcsonzoLakohely.Text = sor.Cells[3].Value.ToString();
                tbKolcsonzoTelefonszam.Text = sor.Cells[4].Value.ToString();
                tbKolcsonzoEmailCim.Text = sor.Cells[5].Value.ToString();
                tbKolcsonzoDarabszam.Text = sor.Cells[6].Value.ToString();
                tbTagdij.Text = sor.Cells[7].Value.ToString();
        
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");
            }
        }
    }
}
#endregion