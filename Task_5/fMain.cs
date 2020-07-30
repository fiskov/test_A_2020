using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_5
{
    public partial class FormMain : Form
    {
        bool Lights = false;
        Point pointOld = new Point(0, 0);

        public FormMain()
        {
            InitializeComponent();
            btnChangeSize_Click(null, null);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Helper.GetPoint(e.Location, out Point point))
            {
                if (e.Button == MouseButtons.Right) 
                    Helper.StartPointUpdate(point);

                if (e.Button == MouseButtons.Left)
                {
                    Helper.CellToggle(point);
                    pointOld = point;
                }

                updateField();
            }
        }

        private void updateField()
        {
            pictureBox.Size = Helper.GetFieldSizePixel();
            pictureBox.Image = Helper.DrawField(Lights);
        }

        private void btnChangeSize_Click(object sender, EventArgs e)
        {
            Helper.ResetField((int)numWidth.Value, (int)numHeight.Value);
            updateField();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Helper.GetPoint(e.Location, out Point point))
                if (e.Button == MouseButtons.Left)                
                    if (pointOld != point)
                    {
                        Helper.CellToggle(point);                        
                        pointOld = point;
                        updateField();
                    }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Helper.GenerateMaze();
            updateField();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            Lights = false;
            updateField();
            btnDisable.Enabled = !btnDisable.Enabled;
            btnEnable.Enabled = !btnEnable.Enabled;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            Lights = true;
            updateField();
            btnDisable.Enabled = !btnDisable.Enabled;
            btnEnable.Enabled = !btnEnable.Enabled;
        }
    }
}
