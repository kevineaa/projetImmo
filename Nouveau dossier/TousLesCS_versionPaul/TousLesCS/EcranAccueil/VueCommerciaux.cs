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
        string status = "ACTIF";

        public EnfinEntities2 enfin = new EnfinEntities2();

        public VueCommerciaux()
        {
            InitializeComponent();

              var nomCommerciaux = (from c in enfin.COMMERCIAL
                                    select c.NOM_COMMERCIAL);

            var stat = (from c in enfin.COMMERCIAL
                                  select c.STATUT_COMMERCIAL);
            foreach (string nom in nomCommerciaux)
            {
             listBox1.Items.Add(nom);

            }
        }

        private void editerCommercial_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
          //  nom.Text = "";
            prenom.Text = "";
            email.Text = "";
            portablePro.Text = "";
            fixePro.Text = "";
            telephonePerso.Text = "";
            email.Text = "";
            listBox2.Items.Clear();
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

            }
            else
            {

                //IQueryable<COMMERCIAL> c = (from x in enfin.COMMERCIAL
                //                          where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                //                        select x);

                var nomCommerciaux = (from c in enfin.COMMERCIAL
                                      select c.NOM_COMMERCIAL);


                foreach (string nom in nomCommerciaux)
                {
                    listBox1.Items.Add(nom);
                }
                Refresh();
            }

            if (listBox1.Items.Count == 0)
            {
                actif.Checked = true;
                actif.Enabled = false;
                inactif.Checked = false;
                inactif.Enabled = false;
            }
            else
            {
                actif.Enabled = true;
                inactif.Enabled = true;
            }


        }




        private void supprimerCommercial_Click(object sender, EventArgs e)
        {
            COMMERCIAL c = (from x in enfin.COMMERCIAL
                            where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                            select x).First();
            enfin.COMMERCIAL.Remove(c);
            enfin.SaveChanges();

            nom.Text = "";
            prenom.Text = "";
            email.Text = "";
            portablePro.Text = "";
            fixePro.Text = "";
            telephonePerso.Text = "";
            email.Text = "";
            listBox2.Items.Clear();
        }

        private void ajoutCommercial_Click(object sender, EventArgs e)
        {
            IQueryable<COMMERCIAL> ca = (from x in enfin.COMMERCIAL
                                        where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                                        select x);


            /*  foreach (string nom in nomCommerciaux)
              {
                  listBox1.Items.Add(nom);
              }
              Refresh();*/
            if (ca.Count() == 0)
            {
                actif.Checked = true;
                actif.Enabled = false;
                inactif.Checked = false;
                inactif.Enabled = false;
                status = "ACTIF";
                COMMERCIAL commercial = new COMMERCIAL();
                commercial.NOM_COMMERCIAL = nom.Text;
                commercial.PRENOM_COMMERCIAL = prenom.Text;
                commercial.EMAIL = email.Text;
                commercial.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text);
                commercial.TÉLÉPHONE_FIXE_PRO = Int32.Parse(fixePro.Text);
                commercial.TÉLÉPHONE_PERSONNEL = Int32.Parse(telephonePerso.Text);
                commercial.EMAIL = email.Text;
                commercial.STATUT_COMMERCIAL = status;

                enfin.COMMERCIAL.Add(commercial);
                enfin.SaveChanges();
            }
            else
            {
                COMMERCIAL c = (from x in enfin.COMMERCIAL
                                where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                                select x).First();
                actif.Enabled = true;
                inactif.Enabled = true;
                status = c.STATUT_COMMERCIAL;


                COMMERCIAL commercial = new COMMERCIAL();

                commercial.NOM_COMMERCIAL = nom.Text;
                commercial.PRENOM_COMMERCIAL = prenom.Text;
                commercial.EMAIL = email.Text;
                commercial.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text);
                commercial.TÉLÉPHONE_FIXE_PRO = Int32.Parse(fixePro.Text);
                commercial.TÉLÉPHONE_PERSONNEL = Int32.Parse(telephonePerso.Text);
                commercial.EMAIL = email.Text;
                commercial.STATUT_COMMERCIAL = c.STATUT_COMMERCIAL;

           
                foreach (ACHETEUR r in c.ACHETEUR)
                {
                    commercial.ACHETEUR.Add(r);
                }

                commercial.STATUT_COMMERCIAL = status;
                //commercial.ACHETEUR = c.ACHETEUR;
                enfin.COMMERCIAL.Add(commercial);
                enfin.COMMERCIAL.Remove(c);
                enfin.SaveChanges();
            }
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {
            /*      listBox1.Items.Clear();

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

                  }
                  else
                  {

                      //IQueryable<COMMERCIAL> c = (from x in enfin.COMMERCIAL
                        //                          where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                          //                        select x);

                      var nomCommerciaux = (from c in enfin.COMMERCIAL
                                           select c.NOM_COMMERCIAL);


                      foreach (string nom in nomCommerciaux)
                      {
                          listBox1.Items.Add(nom);
                      }
                      Refresh();
                  }

            */
            IQueryable<COMMERCIAL> c = (from x in enfin.COMMERCIAL
                                      where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                                      select x);


            if (c.Count()== 0)
                  {
                      actif.Checked =true;
                      actif.Enabled = false;
                      inactif.Checked = false;
                      inactif.Enabled = false;
                  }else
                  {
                      actif.Enabled = true;
                      inactif.Enabled = true;
                  }
                  
        }
        private void listeBoxSelected(object sender, EventArgs e) {
            bool t;
            listBox2.Items.Clear();
            string curItem;
         
                 curItem = listBox1.SelectedItem.ToString();

    
                COMMERCIAL commercial = (from x in enfin.COMMERCIAL
                                where x.NOM_COMMERCIAL.StartsWith(curItem)
                                select x).First();
          
                nom.Text = commercial.NOM_COMMERCIAL;
                prenom.Text = commercial.PRENOM_COMMERCIAL;
                email.Text = commercial.EMAIL;
                portablePro.Text = commercial.TÉLÉPHONE_MOBILE_PRO.ToString();
                fixePro.Text = commercial.TÉLÉPHONE_FIXE_PRO.ToString();
                telephonePerso.Text = commercial.TÉLÉPHONE_PERSONNEL.ToString();
                email.Text = commercial.EMAIL;
                status = commercial.STATUT_COMMERCIAL;
                listBox2.Items.Add(commercial.STATUT_COMMERCIAL);



            // listBox2.Items.Add(commercial.STATUT_COMMERCIAL);
            //actif.Checked = true;


            foreach (ACHETEUR acheteur in commercial.ACHETEUR.ToList())
                {
                   // var i=acheteur.IDACHETEUR;
                    listBox2.Items.Add(acheteur.NOM_ACHETEUR);
                }
            // }
           
            
           
            Refresh();
           string inactifs ="INACTIF";
            string actifs = "ACTIF";

            if (String.Compare(status.ToUpper(),inactifs.ToUpper()) == 1)
            {
                actif.Checked = false;
                inactif.Checked = true;

            }
            else if (String.Compare(status.ToUpper(), actifs.ToUpper()) == 1)
            {
                actif.Checked = true;
                inactif.Checked = false;
            }




        }
    //    public static int Compare(string strA, string strB);

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


        private void actif_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
            {
                status = "ACTIF";
                inactif.Checked = false;

            }

        }

        private void inactif_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
            {
                status = "INACTIF";
                actif.Checked = false;

            }


        }

        private void actifView_Click(object sender, EventArgs e)
        {

            nom.Text = "";
            prenom.Text = "";
            email.Text = "";
            portablePro.Text = "";
            fixePro.Text = "";
            telephonePerso.Text = "";
            email.Text = "";
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            IQueryable<COMMERCIAL> c = (from x in enfin.COMMERCIAL
                                        where x.STATUT_COMMERCIAL == "ACTIF"
                                        select x);

            //
            foreach (COMMERCIAL commercial in c)
            {
                listBox1.Items.Add(commercial.NOM_COMMERCIAL.ToString());
            }

        }

        private void inactifView_Click(object sender, EventArgs e)
        {

            nom.Text = "";
            prenom.Text = "";
            email.Text = "";
            portablePro.Text = "";
            fixePro.Text = "";
            telephonePerso.Text = "";
            email.Text = "";
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            IQueryable<COMMERCIAL> c = (from x in enfin.COMMERCIAL
                                        where x.STATUT_COMMERCIAL == "INACTIF"
                                        select x);

            //
            foreach (COMMERCIAL commercial in c)
            {
                listBox1.Items.Add(commercial.NOM_COMMERCIAL.ToString());
            }

        }

        private void tousView_Click(object sender, EventArgs e)
        {

            nom.Text = "";
            prenom.Text = "";
            email.Text = "";
            portablePro.Text = "";
            fixePro.Text = "";
            telephonePerso.Text = "";
            email.Text = "";
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            IQueryable<COMMERCIAL> c = (from x in enfin.COMMERCIAL
                                        select x);

            //
            foreach (COMMERCIAL commercial in c)
            {
                listBox1.Items.Add(commercial.NOM_COMMERCIAL.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Hide();


        }
    }
}
