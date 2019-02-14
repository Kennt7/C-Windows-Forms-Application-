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
    public partial class frmMufajok : Form
    {
        string kapcsolatSztring=@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Konyvtar.mdf;Integrated Security=True";
        SqlConnection kapcsolat;
        SqlCommand eskuelutasitas;
        SqlCommandBuilder utasitas;
        SqlDataAdapter adapter=null;
        DataTable mufajokTabla = new DataTable();
       
        public frmMufajok()
        {
            InitializeComponent();

           
           


            //kapcsolatSztring = ConfigurationManager.ConnectionStrings["KonyvtariNyilvantarto.Properties.Settings.KonyvtarConnectionString"].ConnectionString;
        }

        private void frmMufajok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mufajokDataSet.Mufajok' table. You can move, or remove it, as needed.
            this.mufajokTableAdapter.Fill(this.mufajokDataSet.Mufajok);
            // TODO: This line of code loads data into the 'mufajokDataSet.Mufajok' table. You can move, or remove it, as needed.
            // this.mufajokTableAdapter.Fill(this.mufajokDataSet.Mufajok);

        }
        
        //Frissítés
        private void Frissites()
        {
            tbMufajNeve.Text = "";
        }
        
        private void Torles()//Törlő eljárás
        {
            if(MessageBox.Show("Biztosan törölni akarod?","Törlés",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int index = dgvMufajok.SelectedRows[0].Index;
                dgvMufajok.Rows.RemoveAt(index);
            }
        }
        private void btnMufajRogzit_Click(object sender, EventArgs e)
        {
            kapcsolat.Open();
            if(tbRogzit.Text!=String.Empty)
            {
                eskuelutasitas.Parameters.Clear();
                eskuelutasitas.Parameters.Add("MufajNeve", SqlDbType.NVarChar);
                eskuelutasitas.Parameters["MufajNeve"].Value = tbRogzit.Text;
            }
            eskuelutasitas.ExecuteNonQuery();
            kapcsolat.Close();
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
          
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            Torles();
        }

        private void btnFrissit_Click(object sender, EventArgs e)
        {
            dgvMufajok.Rows.Clear();
        }

        private void btnMufajMent_Click(object sender, EventArgs e)
        {
            utasitas = new SqlCommandBuilder(adapter);
            adapter.Update(mufajokTabla);
            MessageBox.Show("Adatok elmentve!");
        }
    }
}
