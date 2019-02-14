using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvtariNyilvantarto
{
    public partial class frmKiadok : Form
    {
        public frmKiadok()
        {
            InitializeComponent();
        }

        private void frmKiadok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kiadokDataSet.KonyvKiadok' table. You can move, or remove it, as needed.
            this.konyvKiadokTableAdapter.Fill(this.kiadokDataSet.KonyvKiadok);

        }
    }
}
