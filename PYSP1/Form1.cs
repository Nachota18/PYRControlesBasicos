using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYSP1
{
    public partial class lolI : Form
    {
        public lolI()
        {
            InitializeComponent();
        }

        private void cmdTOCAAQUI_Click(object sender, EventArgs e)
        {
            lblEscribir.Text = " ";
            if (chkVALO.Checked == true)

                lblEscribir.Text += "DEJA EL TINDER  ";


             if (chkLOLSITO.Checked == true)


                lblEscribir.Text += "TOCA PASTO FLACO ";
        }

        private void lolI_Load(object sender, EventArgs e)
        {

        }

        private void lblEscribir_Click(object sender, EventArgs e)
        {

        }
    }
}
