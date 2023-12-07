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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void BtnMethods_Click(object sender, EventArgs e)
        {
            frmMethods frm = new frmMethods();
            frm.ShowDialog();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            frmPic01 frm = new frmPic01();
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void btnPic_Click_1(object sender, EventArgs e)
        {
            frmPic01 frm = new frmPic01();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void btnPic2_Click(object sender, EventArgs e)
        {
            frmPic02 frm = new frmPic02();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void BtnMethods_Click_1(object sender, EventArgs e)
        {
            frmMethods frm = new frmMethods();
            frm.ShowDialog();
        }

        private void BtnClasses_Click(object sender, EventArgs e)
        {
            frmClasses frm = new frmClasses();
            frm.ShowDialog();
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.Show();
        }
    }
    }

