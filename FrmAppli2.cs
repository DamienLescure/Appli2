using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*  hhhhhhh  */

namespace Appli2 // modifié après ajout elt existant
{
    public partial class FrmAppli2 : Form
    {
        public FrmAppli2()
        {
            InitializeComponent();
            CBoxVit.SelectedIndex = 0;
            CBoxTemp.SelectedIndex = 0;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            GpBoxParam.Visible = true;
            BtnOK.Enabled = false;
            TxtBoxVit.Text = CBoxVit.SelectedItem.ToString();
            TxtBoxTemp.Text = CBoxTemp.SelectedItem.ToString();
        }

        private void BtnRetablir_Click(object sender, EventArgs e)
        {
            GpBoxParam.Visible = false;
            BtnOK.Enabled = true;
            CBoxVit.SelectedIndex = 0;
            CBoxTemp.SelectedIndex = 0;
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAppli2_Load(object sender, EventArgs e)
        {

        }

        private void CBoxVit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBoxVit.SelectedIndex = 0;
        }
    }
}
