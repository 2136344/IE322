using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_project_23
{
    public partial class frmPic02 : Form
    {
        Assembly _assembly;
        Stream _imageStream;
        public frmPic02()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {

                picTry.Image = Image.FromStream(_imageStream);

            }
            catch
            {
                MessageBox.Show("Error creating image!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }
        private void Form6_Load(object sender, EventArgs e)
        {

            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("IE322_App_KAU.res.A.jpg");



        }

        private void picTry_Click(object sender, EventArgs e)
        {

        }
    }
}
