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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
            
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void VilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVille openForm = new FVille();
            openForm.Show();
           
        }

        private void SalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSalle openForm = new FSalle();
            openForm.Show();
        }

        private void BatimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBat openForm = new FBat();
            openForm.Show();
        }

        private void TypeOeuvreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTOeuvre openForm = new FTOeuvre();
            openForm.Show();
        }

        private void CompositeursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ParNationalitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCompositeurNation openForm = new FCompositeurNation();
            openForm.Show();
        }

        private void ParStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCompositeurStyle openForm = new FCompositeurStyle();
            openForm.Show();
        }

        private void ParOeuvresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCompositeurOeuvre openForm = new FCompositeurOeuvre();
            openForm.Show();
        }
    }
}
