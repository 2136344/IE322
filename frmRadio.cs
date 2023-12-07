using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_project_23
{
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked == true)
                rdoRed.ForeColor = Color.FromName("red");
            else
                rdoRed.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen.Checked == true)
                rdoGreen.ForeColor = Color.FromName("Green");
            else
                rdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked == true)
                rdoBlue.ForeColor = Color.FromName("Blue");
            else
                rdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow.Checked == true)
                rdoYellow.ForeColor = Color.FromName("Yellow");
            else
                rdoYellow.ForeColor = Color.FromArgb(0,0,0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoRed.Checked = false;
            rdoGreen.Checked = false;
            rdoBlue.Checked = false;
            rdoYellow.Checked = false;

            rdoRed.ForeColor = Color.FromName("Black");
            rdoGreen.ForeColor = Color.FromName("Black");
            rdoBlue.ForeColor = Color.FromName("Black");
            rdoYellow.ForeColor = Color.FromName("Black");


            rdoRed2.Checked = false;
            rdoGreen2.Checked = false;
            rdoBlue2.Checked = false;
            rdoYellow2.Checked = false;

            rdoRed2.ForeColor = Color.FromName("Black");
            rdoGreen2.ForeColor = Color.FromName("Black");
            rdoBlue2.ForeColor = Color.FromName("Black");
            rdoYellow2.ForeColor = Color.FromName("Black");
        }

        private void rdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            rdoRed2.ForeColor = Color.FromName("Red");

        }

        private void rdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            rdoGreen2.ForeColor = Color.FromName("Green");
        }

        private void rdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            rdoBlue2.ForeColor = Color.FromName("Blue");
        }

        private void rdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            rdoYellow2.ForeColor = Color.FromName("Yellow");
        }
    }
}
