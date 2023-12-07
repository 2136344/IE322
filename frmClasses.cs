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
    public partial class frmClasses : Form
    {
        Car MyCar = new Car();
        Car HisCar = new Car();
        public frmClasses()
        {
            InitializeComponent();
        }

        private void BtnMyHisCar_Click(object sender, EventArgs e)
        {
            MyCar.Start();
        }

        private void BtnAccMyCar_Click(object sender, EventArgs e)
        {

        }

        private void BtnStopMyCar_Click(object sender, EventArgs e)
        {

        }

        private void BtnStartHisCar_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}
