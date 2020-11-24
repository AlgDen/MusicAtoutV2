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
            int annee_mort = 0;
            if (!string.IsNullOrEmpty(txtAnMort.Text))
            {
                annee_mort = int.Parse(txtAnMort.Text);
            }
            int idNation = int.Parse(cboNation.SelectedValue.ToString());
            int idStyle = int.Parse(cboStyle.SelectedValue.ToString());

            if (Modele.ActionGestionCompositeur == 1)
            {
                if (Modele.AjoutCompositeur(nom, prenom, remarque, annee_nais, annee_mort, idNation, idStyle))
                {
                    MessageBox.Show("Compositeur ajouté avec succès.", "Ajout", MessageBoxButtons.OK);
                    Form.ActiveForm.Close();
                }
            }
            else
            {
                if (Modele.ModifCompositeur(nom,prenom,remarque,annee_nais,annee_mort,idNation,idStyle))
                {
                    MessageBox.Show("Les modifications ont été enregistrées.", "Modification", MessageBoxButtons.OK);
                    Form.ActiveForm.Close();
                }
            }
        }

        private bool TestRempli(out string erreur)
        {
            bool vretour = true;
            var mydate = DateTime.Now;
            int annee_actuelle = mydate.Year;
            int annee_sub15 = annee_actuelle - 15;
            int annee_add15 = annee_actuelle + 15;
            int annee_add125 = annee_actuelle + 125;

            erreur = "Erreur de saisie :\n";

            try
            {
                int.Parse(txtAnNais.Text);
            }
            catch(Exception e)
            {
                erreur += "\u25C9\tLa date de naissance doit être un entier\n";
                vretour = false;
            }

            try
            {
                if(!string.IsNullOrEmpty(txtAnMort.Text))
                {
                    int.Parse(txtAnMort.Text);
                }
            }
            catch (Exception e)
            {
                erreur += "\u25C9\tLa date de mort doit être un entier\n";
                vretour = false;
            }

            if (txtNom.Text == "")
            {
                erreur += "\u25C9\tVeuillez renseigner le nom.\n";
                vretour = false;
            }

            if(txtPrenom.Text == "")
            {
                erreur += "\u25C9\tVeuillez renseigner le prénom.\n";
                vretour = false;
            }

            if(txtRemarque.Text == "")
            {
                erreur += "\u25C9\tVeuillez renseigner une remarque\n";
                vretour = false;
            }

            if(txtAnNais.Text == "")
            {
                erreur += "\u25C9\tVeuillez renseigner une année de naissance.\n";
                vretour = false;
            }
            else
            {
                try
                {
                    if (int.Parse(txtAnNais.Text) < 500)
                    {
                        erreur += "\u25C9\tL'année de naissance doit au minimum dater de 500 après J-C.\n";
                        vretour = false;
                    }

                    if (int.Parse(txtAnNais.Text) > annee_sub15)
                    {
                        erreur += "\u25C9\tL'année de naissance doit dater d'il y a 15 ans au minimum.\n";
                        vretour = false;
                    }
                }
                catch(Exception e)
                {

                }
            }


            if ((txtAnMort.Text == "") == false)
            {
                try
                {
                    if (int.Parse(txtAnMort.Text) < int.Parse(txtAnNais.Text) + 15)
                    {
                        erreur += "\u25C9\tL'année de mort doit être au minimum 15 ans après la naissance.\n";
                        vretour = false;
                    }

                    if (int.Parse(txtAnMort.Text) > int.Parse(txtAnNais.Text) + 125)
                    {
                        erreur += "\u25C9\tL'année de mort doit être au maximum 125 ans après la naissance.\n";
                        vretour = false;
                    }

                    if (int.Parse(txtAnMort.Text) > annee_actuelle)
                    {
                        erreur += "\u25C9\tVous prévoyez la mort vous ?\n";
                        vretour = false;
                    }
                }
                catch(Exception e)
                {

                }
            }

            return vretour;
        }

        private void FAjoutModifCompositeur_Shown(object sender, EventArgs e)
        {
            if(Modele.ActionGestionCompositeur == 2 && Modele.CompositeurChoisi != null)
            {
                this.txtNom.Text = Modele.CompositeurChoisi.nomCompositeur;
                this.txtPrenom.Text = Modele.CompositeurChoisi.prenomCompositeur;
                this.txtAnNais.Text = Modele.CompositeurChoisi.anNais.ToString();
                this.txtRemarque.Text = Modele.CompositeurChoisi.remarque;
                this.txtAnMort.Text = Modele.CompositeurChoisi.anMort.ToString();
                this.cboNation.Text = Modele.CompositeurChoisi.NATIONALITE.libNation.ToString();
                this.cboStyle.Text = Modele.CompositeurChoisi.STYLE.libStyle.ToString();
            }

        }
    }
}
