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
    public partial class frmAllapotok : Form
    {
        SqlConnection kapcs; //kapcsolóobjektum
        SqlDataAdapter adapter; //ezzel férünk hozzá az adatforráshoz, a kapcsolaton keresztül
        DataTable dtAllapotok = new DataTable();
        DataSet ds = null;                            // ne dobjon nullreference exceptiont

        
        int allapotoktablasorpozicio = 0;
        string kapcsolatiSztring;
        public frmAllapotok()
        {
            InitializeComponent();
            kapcsolatiSztring = ConfigurationManager.ConnectionStrings["KonyvtariNyilvantarto.Properties.Settings.KonyvtarConnectionString"].ConnectionString;
            
        }

        private void frmAllapotok_Load(object sender, EventArgs e)
        {      
           this.allapotokTableAdapter.Fill(this.allapotokDST.Allapotok);
            
            kapcs.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Konyvtar.mdf;Integrated Security=True";
        }

        private void btnAllapotokUjbevitel_Click(object sender, EventArgs e)
        {
            if (tbAllapotazonosito.Text != null)
            { 
            tbAllapotazonosito.Text = "";
                tbAllapotneve.Text = "";
            }
            
        }

        private void dgvAllapotok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                allapotoktablasorpozicio = e.RowIndex;
                DataGridViewRow sor = dgvAllapotok.Rows[allapotoktablasorpozicio];

                tbAllapotazonosito.Text = sor.Cells[0].Value.ToString();
                tbAllapotneve.Text = sor.Cells[1].Value.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllapotokHozzaadas_Click(object sender, EventArgs e)
        {
            string allapot = "INSERT INTO Allapotok VALUES(@AllapotAzonosito,AllapotNeve)";
            using (kapcs = new SqlConnection(kapcsolatiSztring))
            using (SqlCommand hozzaad = new SqlCommand(allapot, kapcs))
                try
                {
                    {
                        kapcs.Open();
                        hozzaad.CommandText = 
                        "INSERT INTO Allapotok ([AllapotNeve]) VALUES ('" + tbAllapotneve.Text + "')";
                        hozzaad.ExecuteScalar();
                        Frissites();
                        //kapcsolat.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Az adatbevitel hibás!");
                }
        }

        private void Frissites()
        {
            this.allapotokTableAdapter.Fill(this.allapotokDST.Allapotok);
        }
    }
}
