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
    public partial class FCompositeurNation : Form
    {
        private bool fermeture=false;
        public FCompositeurNation()
        {
            InitializeComponent();
        }
        private void FCompositeurNation_Load(object sender, EventArgs e)
        {
            cboNation.ValueMember = "idNation";//permet de stocker l'identifiant
            cboNation.DisplayMember = "libNation";
            bsNation.DataSource = Modele.listeNation();
            cboNation.DataSource = bsNation;
        }

        private void Nationlbl_Click(object sender, EventArgs e)
        {

        }

        private void BsNation_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cboNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(fermeture)
            {
                return;
            }
            bsCompositeur.DataSource = Modele.CompositeurParNationalite(int.Parse(cboNation.SelectedValue.ToString()));
            dgvCompositeur.DataSource = bsCompositeur;
            dgvCompositeur.Columns[0].HeaderText = "NOM";
            dgvCompositeur.Columns[1].HeaderText = "PRENOM";
            dgvCompositeur.Columns[2].HeaderText = "STYLE";
            dgvCompositeur.Columns[3].HeaderText = "Né le";
            dgvCompositeur.Columns[4].HeaderText = "Mort le";
            dgvCompositeur.Columns[5].HeaderText = "Informations";
            dgvCompositeur.Columns[6].Visible = false;
        }

        private void DgvCompositeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FCompositeurNation_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermeture = true;
        }

        private void BtnToutesNationalite_Click(object sender, EventArgs e)
        {
            bsCompositeur.DataSource = Modele.Compositeurs();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            FAjoutModifCompositeur form = new FAjoutModifCompositeur();
            form.Show();
            Modele.ActionGestionCompositeur = 1;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            FAjoutModifCompositeur form = new FAjoutModifCompositeur();
            Modele.ActionGestionCompositeur = 2;

            //récupérer le compositeur sélectionné
            int idCompositeur = findCompositeurID();
            Modele.CompositeurChoisi = (COMPOSITEUR)Modele.CompositeurParID(idCompositeur);

            form.Show();
        }

        private int findCompositeurID()
        {
            System.Type type = bsCompositeur.Current.GetType();
            int id = (int)type.GetProperty("idCompositeur").GetValue(bsCompositeur.Current, null);
            return id;
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            int idCompositeur = findCompositeurID();
            Modele.CompositeurChoisi = (COMPOSITEUR)Modele.CompositeurParID(idCompositeur);

            if (MessageBox.Show("Etes vous sur de vouloir supprimer le compositeur :" +
                Modele.CompositeurChoisi.prenomCompositeur.Trim() + " - " + Modele.CompositeurChoisi.nomCompositeur.Trim(),
                "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Modele.SuppCompositeur()) 
                {
                    MessageBox.Show("Le compositeur a été retiré.", "Suppression", MessageBoxButtons.OK);
                    cboNation_SelectedIndexChanged(cboNation.SelectedValue, e);
                }
            }
            else
            {
                MessageBox.Show("Aucun compositeur retiré.", "Suppression", MessageBoxButtons.OK);
            }

        }
    }
}
