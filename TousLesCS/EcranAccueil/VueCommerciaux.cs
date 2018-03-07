using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcranAccueil
{
    public partial class VueCommerciaux : Form
    {
        public VueCommerciaux()
        {
            InitializeComponent();
        }

        private void edition_commercial_Click(object sender, EventArgs e)
        {

        }

        private void actif_commercial_Click(object sender, EventArgs e)
        {

        }

        private void ancien_commercial_Click(object sender, EventArgs e)
        {

        }

        private void retour_accueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajout_commercial_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditionCommercial edition = new EditionCommercial();
            edition.Show();
        }
    }
}
