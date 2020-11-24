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
    public partial class FConnex : Form
    {
        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }

        public FConnex()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string message = "";

            message = Modele.validConnexion(txtID.Text, txtPW.Text);
            if(Modele.ConnexionValide == true)
            {
                btnValider.Hide();
                lblInfo.BackColor = Color.Green;
                lblInfo.Text = message;
                lblInfo.Show();
                btnOK.Show();
            }
            else
            {
                lblInfo.BackColor = Color.Red;
                lblInfo.Text = message;
            }
        }

        private void FConnex_Load(object sender, EventArgs e)
        {
            lblInfo.Hide();
        }
    }
}
