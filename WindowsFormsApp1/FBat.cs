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
    public partial class FBat : Form
    {
        public FBat()
        {
            InitializeComponent();
            bsBat.DataSource = Modele.listeBat();
        }

        private void BsBat_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
