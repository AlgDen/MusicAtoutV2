using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FAjoutModifCompositeur : Form
    {
        public FAjoutModifCompositeur()
        {
            InitializeComponent();
        }

        private void FAjoutModifCompositeur_Load(object sender, EventArgs e)
        {
            cboStyle.ValueMember = "idStyle"; //permet de stocker l'identifiant
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = Modele.Style();
            cboStyle.DataSource = bsStyle;

            cboNation.ValueMember = "idNation";
            cboNation.DisplayMember = "libNation";
            bsNationalite.DataSource = Modele.listeNation();
            cboNation.DataSource = bsNationalite;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bsCompositeur_CurrentChanged(object sender, EventArgs e)
        {
            System.Type type = bsCompositeur.Current.GetType();
            int id = (int)type.GetProperty("idCompositeur").GetValue(bsCompositeur.Current, null);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string erreur = "";
            if (TestRempli(out erreur) == false)
            {
                MessageBox.Show(erreur, "ATTENTION !", MessageBoxButtons.OK);
                return;
            }

            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string remarque = txtRemarque.Text;
            int annee_nais = int.Parse(txtAnNais.Text);
            int annee_mort = int.Parse(txtAnMort.Text);
            int idNation = int.Parse(cboNation.Text);
            int idStyle = int.Parse(cboStyle.Text);

            Modele.AjoutCompositeur(nom, prenom, remarque, annee_nais, annee_mort, idNation, idStyle);
        }

        private bool TestRempli(out string erreur)
        {
            bool vretour = true;
            var mydate = DateTime.Now;
            int annee_actuelle = mydate.Year;
            
            erreur = "Erreur de saisie :\n";

            if(string.IsNullOrEmpty(txtNom.Text))
            {
                erreur += "\u25C9\tNom Compositeur vide\n";
                vretour = false;
            }

            if(string.IsNullOrEmpty(txtPrenom.Text))
            {
                erreur += "\u25C9\tPrénom Compositeur vide\n";
                vretour = false;
            }

            if(string.IsNullOrEmpty(txtRemarque.Text))
            {
                erreur += "\u25C9\tRemarque Compositeur vide\n";
                vretour = false;
            }

            if(string.IsNullOrEmpty(txtAnNais.Text))
            {
                erreur += "\u25C9\tAnnée naissance Compositeur vide\n";
                vretour = false;
            }
            else
            {

                if (int.Parse(txtAnNais.Text) < 500)
                {
                    erreur += "\u25C9\tAnnée naissance Compositeur incompatible\n";
                    vretour = false;
                }

                if (DateTime.Parse(txtAnNais.Text) > mydate.AddYears(-15))
                {
                    erreur += "\u25C9\tAnnée naissance Compositeur incompatible\n";
                    vretour = false;
                }
            }


            if (string.IsNullOrEmpty(txtAnMort.Text) == false)
            {
                if (DateTime.Parse(txtAnMort.Text) < DateTime.Parse(txtAnNais.Text).AddYears(15))
                {
                    erreur += "\u25C9\tAnnée mort Compositeur incompatible\n";
                    vretour = false;
                }

                if (DateTime.Parse(txtAnMort.Text) > DateTime.Parse(txtAnNais.Text).AddYears(125))
                {
                    erreur += "\u25C9\tAnnée mort Compositeur incompatible\n";
                    vretour = false;
                }

                if (int.Parse(txtAnMort.Text) > annee_actuelle)
                {
                    erreur += "\u25C9\tAnnée mort Compositeur incompatible\n";
                    vretour = false;
                }
            }

            return vretour;
        }
    }
}
