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
    public partial class EditionCommercial : Form
    {
        public EditionCommercial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COMMERCIAL c = (from x in modeleBase.COMMERCIAL
                            where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                            select x).First();
            modeleBase.COMMERCIAL.Remove(c);
            modeleBase.SaveChanges();
            COMMERCIAL commercial = new COMMERCIAL();
            commercial.NOM_COMMERCIAL = nom.Text;
            commercial.PRENOM_COMMERCIAL = prenom.Text;
            commercial.EMAIL = email.Text;
            commercial.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text);
            commercial.TÉLÉPHONE_FIXE_PRO = Int32.Parse(fixePro.Text);
            commercial.TÉLÉPHONE_PERSONNEL = Int32.Parse(telephonePerso.Text);
            commercial.EMAIL = email.Text;
            commercial.STATUT_COMMERCIAL = "actif";

          //  modeleBase.COMMERCIAL.Update(commercial);
            modeleBase.SaveChanges();
        }

        public static EnfinEntities2 modeleBase = new EnfinEntities2();

    }
}
