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
    }
}
