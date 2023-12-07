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
    public partial class frmCombo : Form
    {
        Graphics g;

        public frmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
            CmbDays.Items.Add("Funday");
            CmbDays.Items.Add("Examday");
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);

            CmbColors.Items.Add("Red");
            CmbColors.Items.Add("Green");
            CmbColors.Items.Add("Blue");

            CmbColors.SelectedIndex = 0;
        }

        private void CmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnShowSelected1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void BtnShowSelected2_Click(object sender, EventArgs e)
        {
            string itemText = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(itemText);
        }

        private void BtnShowSelected3_Click(object sender, EventArgs e)
        { 
            var Myitem = CmbDays.SelectedItem;
            if (Myitem != null)
                MessageBox.Show(Myitem.ToString());
        }

        private void BtnRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove(CmbDays.SelectedItem);
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            

                CmbDays.Items.RemoveAt(1);
                LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);
            
        }

        private void BtnRemoveByName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);
        }

        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Can't remove last item");
            }
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);
        }

        private void BtnRemove2ndLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove 2nd last item");
            }
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            string selectedColor = CmbColors.SelectedItem.ToString();
            Color color = Color.Black;

            switch (selectedColor)
            {
                case "Red":
                    color = Color.Red;
                    break;
                case "Green":
                    color = Color.Green;
                    break;
                case "Blue":
                    color = Color.Blue;
                    break;
            }
            g = PicDraw.CreateGraphics();
            g.Clear(Color.White);

            for (int i = 0; i < 5; i++)
            {
                int x = 5 + i * 50;
                int y = 50;
                int width = 40;
                int height = 40;

                
                g.FillEllipse(new SolidBrush(color), x, y, width, height);
            }

            
            g.Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            g = PicDraw.CreateGraphics();
            g.Clear(Color.White);
            g.Dispose();
        }

        private void PicDraw_Click(object sender, EventArgs e)
        {

        }
    }
}
