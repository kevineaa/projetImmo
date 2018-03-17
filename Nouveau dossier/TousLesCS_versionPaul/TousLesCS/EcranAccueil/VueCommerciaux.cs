using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public EnfinEntities2 enfin = new EnfinEntities2();

        public VueCommerciaux()
        {
            InitializeComponent();

              var nomCommerciaux = (from c in enfin.COMMERCIAL
                                    select c.NOM_COMMERCIAL);
            foreach (string nom in nomCommerciaux)
            {
             listBox1.Items.Add(nom);
            }

            nom.ReadOnly = true;
        }

        private void editerCommercial_Click(object sender, EventArgs e)
        {
            COMMERCIAL c = (from x in enfin.COMMERCIAL
                            where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                            select x).First();
            COMMERCIAL commercial = new COMMERCIAL();

            commercial.NOM_COMMERCIAL = nom.Text;
            commercial.PRENOM_COMMERCIAL = prenom.Text;
            commercial.EMAIL = email.Text;
            commercial.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text);
            commercial.TÉLÉPHONE_FIXE_PRO = Int32.Parse(fixePro.Text);
            commercial.TÉLÉPHONE_PERSONNEL = Int32.Parse(telephonePerso.Text);
            commercial.EMAIL = email.Text;
            commercial.STATUT_COMMERCIAL = c.STATUT_COMMERCIAL;
            foreach(ACHETEUR r in c.ACHETEUR)
            {
                commercial.ACHETEUR.Add(r);
            }
            
                commercial.STATUT_COMMERCIAL = "inactif";
            //commercial.ACHETEUR = c.ACHETEUR;

            enfin.COMMERCIAL.Add(commercial);
            enfin.COMMERCIAL.Remove(c);

            enfin.SaveChanges();

        }




        private void supprimerCommercial_Click(object sender, EventArgs e)
        {
            COMMERCIAL c = (from x in enfin.COMMERCIAL
                            where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                            select x).First();
            enfin.COMMERCIAL.Remove(c);
            enfin.SaveChanges();
        }

        private void ajoutCommercial_Click(object sender, EventArgs e)
        {
            
            COMMERCIAL commercial = new COMMERCIAL();
            commercial.NOM_COMMERCIAL = nom.Text;
            commercial.PRENOM_COMMERCIAL = prenom.Text;
            commercial.EMAIL = email.Text;
            commercial.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text);
            commercial.TÉLÉPHONE_FIXE_PRO = Int32.Parse(fixePro.Text);
            commercial.TÉLÉPHONE_PERSONNEL = Int32.Parse(telephonePerso.Text);
            commercial.EMAIL = email.Text;
            commercial.STATUT_COMMERCIAL = "actif";
            enfin.COMMERCIAL.Add(commercial);
            enfin.SaveChanges();
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (nom.Text != "")
            {

                 IQueryable<COMMERCIAL> c = (from x in enfin.COMMERCIAL
                                 where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                                 select x);

                //
                foreach (COMMERCIAL commercial in c)
                {
                    listBox1.Items.Add(commercial.NOM_COMMERCIAL.ToString());
                 }



               /* 
                * var c = (from x in enfin.COMMERCIAL
                         where x.NOM_COMMERCIAL.StartsWith(nom.Text)

                         select x.NOM_COMMERCIAL);
                foreach (string nom in c)
                {
                    listBox1.Items.Add(nom);
                }
                */
                Refresh();

            }
            else
            {

                var nomCommerciaux = (from c in enfin.COMMERCIAL
                                      select c.NOM_COMMERCIAL);
                foreach (string nom in nomCommerciaux)
                {
                    listBox1.Items.Add(nom);
                }
                Refresh();
            }
    }
        private void listeBoxSelected(object sender, EventArgs e) {

            listBox2.Items.Clear();

            string curItem = listBox1.SelectedItem.ToString();
            IQueryable<COMMERCIAL> c = (from x in enfin.COMMERCIAL
                                        where x.NOM_COMMERCIAL.StartsWith(curItem)
                                        select x);
            foreach (COMMERCIAL commercial in c)
            {
                nom.Text = commercial.NOM_COMMERCIAL;
                prenom.Text = commercial.PRENOM_COMMERCIAL;
                email.Text = commercial.EMAIL;
                portablePro.Text = commercial.TÉLÉPHONE_MOBILE_PRO.ToString();
                fixePro.Text = commercial.TÉLÉPHONE_FIXE_PRO.ToString();
                telephonePerso.Text = commercial.TÉLÉPHONE_PERSONNEL.ToString();
                email.Text = commercial.EMAIL;
                // commercial.STATUT_COMMERCIAL = "actif";
               

                foreach (ACHETEUR acheteur in commercial.ACHETEUR.ToList())
                {
                    listBox2.Items.Add(acheteur.NOM_ACHETEUR);     
                }
                Refresh();
            }


            
        }

        private void clear_Click(object sender, EventArgs e)
        {

            nom.Text = "";
            prenom.Text = "";
            email.Text = "";
            portablePro.Text = "";
            fixePro.Text = "";
            telephonePerso.Text = "";
            email.Text = "";
            listBox2.Items.Clear();
          
        }
        
    }
}
