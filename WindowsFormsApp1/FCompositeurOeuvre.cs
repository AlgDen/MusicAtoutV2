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
    public partial class FCompositeurOeuvre : Form
    {
        private bool fermeture = false;

        public FCompositeurOeuvre()
        {
            InitializeComponent();
        }

         
        private void FCompositeurOeuvre_Load(object sender, EventArgs e)
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

        private void BsCompositeur_CurrentChanged(object sender, EventArgs e)
        {
            if (fermeture) return;
            // on utilise l'objet courant de bsStyle pour récupérer l'ensemble des compositeurs du style choisi
            // La programmation objet grâce à la navigabilité permet de récupérer cette liste d’objet de la classe COMPOSITEUR que nous allons trier
            bsDroite.DataSource = ((COMPOSITEUR)bsCompositeur.Current).OEUVRE.OrderBy(x => x.titreOeuvre).ThenBy(x => x.anComposition).ToList();
            dgvCompositeurDroite.DataSource = bsDroite;
            // Modification des colonnes de la grille
            for (int i = 0; i < dgvCompositeurDroite.ColumnCount; i++)
            {
                dgvCompositeurDroite.Columns[i].Visible = false;
            }
            dgvCompositeurDroite.Columns["titreOeuvre"].Visible = true;
            dgvCompositeurDroite.Columns["anComposition"].Visible = true;
            dgvCompositeurDroite.Columns["titreOeuvre"].HeaderText = "Oeuvre";
            dgvCompositeurDroite.Columns["titreOeuvre"].DisplayIndex = 0;
            dgvCompositeurDroite.Columns["anComposition"].HeaderText = "Composition";
            dgvCompositeurDroite.Columns["anComposition"].DisplayIndex = 1;


            textBox3.Text = ((STYLE)bsStyle.Current).libStyle;
            textBox1.Text = ((COMPOSITEUR)bsCompositeur.Current).nomCompositeur;
            textBox2.Text = ((COMPOSITEUR)bsCompositeur.Current).NATIONALITE.libNation;
            textBox4.Text = ((COMPOSITEUR)bsCompositeur.Current).anNais.ToString();
            textBox5.Text = ((COMPOSITEUR)bsCompositeur.Current).anMort.ToString();
            textBox6.Text = ((COMPOSITEUR)bsCompositeur.Current).remarque;
        }
    }
}
