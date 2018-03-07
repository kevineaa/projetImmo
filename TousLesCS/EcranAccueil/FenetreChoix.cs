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
    public partial class FenetreChoix : Form
    {
        public FenetreChoix()
        {
            InitializeComponent();
        }

        private void button_ajouter_client_Click(object sender, EventArgs e)
        {
            AjoutClient ajouClient = new AjoutClient();
            ajouClient.Show();
            this.Hide();
        }
    }
}
