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
    public partial class frmControlesBasicos : Form
    {
        public frmControlesBasicos()
        {
            InitializeComponent();
        }

        private void cmdTOCAAQUI_Click(object sender, EventArgs e)
        {
            
        }


        private void lolI_Load(object sender, EventArgs e)
        {

        }

        private void lblEscribir_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void optAzul_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTextoqueAparece_TextChanged(object sender, EventArgs e)
        {
            lblTextodeColor.Text = txtTextoqueAparece.Text;
        }

        private void optRojo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked == true)
            {
                lblTextodeColor.ForeColor = Color.Blue;
                txtTextoqueAparece.ForeColor = Color.Blue;
            }
            if (optRojo.Checked == true)
            {
                lblTextodeColor.ForeColor = Color.Red;
                txtTextoqueAparece.ForeColor = Color.Red;
            }
        }

        private void lblTextodeColor_Click(object sender, EventArgs e)
        {

        }

        private void chkPicante_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMayonesa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkKetchup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            string textoConcatenar = "";
            if (chkPicante.Checked == true)
            {
                lblAderezo.Text = "Picante";
                textoConcatenar = textoConcatenar + "Picante";
            }
            if (chkMayonesa.Checked == true)
            {
                lblAderezo.Text = "Mayonesa";
                textoConcatenar = textoConcatenar + " Mayonesa";
            }
            if (chkKetchup.Checked == true)
            {
                lblAderezo.Text = "Kethup";
                textoConcatenar = textoConcatenar + " Ketchup";
            }

            lblAderezo.Text = textoConcatenar;
            cboAdicional.Items.Add(textoConcatenar);
        }

        private void cboAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
