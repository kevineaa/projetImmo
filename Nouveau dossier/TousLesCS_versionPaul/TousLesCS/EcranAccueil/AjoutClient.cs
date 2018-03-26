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
    public partial class AjoutClient : Form
    {
        public AjoutClient()
        {
            InitializeComponent();
        }
            public AjoutClient(ACHETEUR monACheteur)
        {
            InitializeComponent();
            this.checkBox_Acheteur.Checked = true;
            this.nom.Text = monACheteur.NOM_ACHETEUR;
            this.prénom.Text = monACheteur.PRENOM_ACHETEUR;
            this.adresse.Text = monACheteur.ADRESSE;
            this.codePostal.Text = monACheteur.CODE_POSTAL.ToString();
            this.dateTimePicker1_créationClient.Value = monACheteur.DATE_CREATION;
            this.fixe.Text = monACheteur.TÉLÉPHONE.ToString();
            this.mobile.Text = monACheteur.TÉLÉPHONE_MOBILE.ToString();
            this.email.Text = monACheteur.EMAIL;

        }

        private void dateTimePicker1_créationClient_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
