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
    public partial class frmPic01 : Form
    {
        Assembly _assembly; 
        Stream _imageStream;



        System.Drawing.Graphics graphicsObj3;
        Pen myPen = new Pen(System.Drawing.Color.Blue, 1);
        public frmPic01()
        {
            InitializeComponent();
            picTry.SizeMode = PictureBoxSizeMode.StretchImage;
            picTry2.SizeMode = PictureBoxSizeMode.StretchImage;

            graphicsObj3 = this.picTry.CreateGraphics();
        }
       
        private void BtnImageFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                //C:\Users\Abobo\Pictures\Screenshots
                picTry.Image = Image.FromFile("..\\..\\Screenshot_20230225_104358.png"); // relative path from the debug folder to two levels up
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }
        }
        private void frmPic01_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly(); //set the assembly object
            _imageStream = _assembly.GetManifestResourceStream("IE322_project_23.res.A.jpg");
        }
        private void BtnImageFromRes_Click(object sender, EventArgs e)
        {
        
            try
            {
                picTry2.Image = Image.FromStream(_imageStream);
            }
            catch
            {

                MessageBox.Show("Error creating image from resource!");
            }
        }

        private void RdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoNormal.Checked)
            {
                picTry.SizeMode = PictureBoxSizeMode.Normal;
                picTry2.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void RdoStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoStretch.Checked)
            {
                picTry.SizeMode = PictureBoxSizeMode.StretchImage;
                picTry2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void RdoAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoAuto.Checked)
            {
                picTry.SizeMode = PictureBoxSizeMode.AutoSize;
                picTry2.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void RdoCentre_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoCentre.Checked)
            {
                picTry.SizeMode = PictureBoxSizeMode.CenterImage;
                picTry2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void RdoZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoZoom.Checked)
            {
                picTry.SizeMode = PictureBoxSizeMode.Zoom;
                picTry2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
