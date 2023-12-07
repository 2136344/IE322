using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_project_23
{
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {

        }

        private void btnShowSelected_Click(object sender, EventArgs e)
        {
            string msg  = "";
            if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;

            }
            if(chkDonut.Checked == true)
            {
                msg=msg + " " + chkDonut.Text;
            }
            if (chkBrownie.Checked == true)
            {
                msg = msg + " " + chkBrownie.Text;
            }
            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " slected");
            }
            else
            {
                MessageBox.Show("Nothing selected");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chkCoffee.Checked = false;
            chkDonut.Checked = false;
            chkBrownie.Checked = false;
            checkJava.Checked = false;
            checkJavascript.Checked = false;
            checkPython.Checked = false;
            ChkCsharp.Checked= false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string msg="";
            if (checkPython.Checked == true)
            {
                msg=checkPython.Text;
            }
            if(checkJavascript.Checked == true)
            {
                msg=msg+ " " + checkJavascript.Text;
            }
            if(checkJava.Checked == true)
            {
                msg= msg+ " " + checkJava.Text;
            }
            if (ChkCsharp.Checked == true)
            {
                msg = msg + "" + ChkCsharp.Text;
            }
            if (msg.Length>0)
            {
                MessageBox.Show(msg + " Selected");
            }
            else
            {
                MessageBox.Show("Nothing selected");
            }
        }
    }
}
