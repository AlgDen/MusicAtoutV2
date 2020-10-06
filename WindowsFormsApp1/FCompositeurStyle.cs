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
    public partial class FCompositeurStyle : Form
    {
        private bool fermeture = false;

        public FCompositeurStyle()
        {
            InitializeComponent();
        }


        private void FCompositeurStyle_Load(object sender, EventArgs e)
        {
            cboStyle.ValueMember = "idStyle";//permet de stocker l'identifiant
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = Modele.Style();
            cboStyle.DataSource = bsStyle;

        }

        private void LblFin_Click(object sender, EventArgs e)
        {

        }

        private void BsStyle_CurrentChanged(object sender, EventArgs e)
        {
            if (fermeture) return;
            // on utilise l'objet courant de bsStyle pour récupérer l'ensemble des compositeurs du style choisi
            // La programmation objet grâce à la navigabilité permet de récupérer cette liste d’objet de la classe COMPOSITEUR que nous allons trier
            bsCompositeur.DataSource = ((STYLE)bsStyle.Current).COMPOSITEUR.OrderBy(x => x.nomCompositeur).ThenBy(x => x.prenomCompositeur).ToList();
            dgvCompositeur.DataSource = bsCompositeur;
            // Modification des colonnes de la grille
            for (int i = 0; i < dgvCompositeur.ColumnCount; i++)
            {
                dgvCompositeur.Columns[i].Visible = false;
            }
            dgvCompositeur.Columns["nomCompositeur"].Visible = true;
            dgvCompositeur.Columns["prenomCompositeur"].Visible = true;
            dgvCompositeur.Columns["nomCompositeur"].HeaderText = "NOM";
            dgvCompositeur.Columns["nomCompositeur"].DisplayIndex = 0;
            dgvCompositeur.Columns["prenomCompositeur"].HeaderText = "PRENOM";
            dgvCompositeur.Columns["prenomCompositeur"].DisplayIndex = 1;
            txtDebut.Text = ((STYLE)bsStyle.Current).dateDebut.ToString();
            txtFin.Text = ((STYLE)bsStyle.Current).dateFin.ToString();

        }
    }
}
