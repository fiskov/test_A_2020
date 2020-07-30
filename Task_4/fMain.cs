using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_4
{
    public partial class FormMain : Form
    {
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
                if (e.Button == MouseButtons.Left) 
                    Helper.StartPointUpdate(point);

                if (e.Button == MouseButtons.Right)
                    Helper.EndPointUpdate(point);

                if (e.Button == MouseButtons.Middle)
                {
                    Helper.CellToggle(point);
                    pointOld = point;
                }

                updateField();
            }
        }
        
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Helper.GetPoint(e.Location, out Point point))
                if (e.Button == MouseButtons.Middle)
                    if (pointOld != point)
                    {
                        Helper.CellToggle(point);
                        pointOld = point;
                        updateField();
                    }
        }

        private void updateField()
        {
            pictureBox.Size = Helper.GetFieldSizePixel();
            pictureBox.Image = Helper.DrawChessField();
        }

        private void btnChangeSize_Click(object sender, EventArgs e)
        {
            Helper.ResetField((int)numSize.Value);

            updateField();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int res = Helper.GetSteps();
            updateField();

            if (res <= 0)
                MessageBox.Show("Путь не найден");
        }


        private void btnSave_Click(object sender, EventArgs ea)
        {
            try
            {
                HelperDB.CheckDatabaseExists();
                string res = "Таблица " + DateTime.Now.ToString("FFF");
                if ( Helper.ShowInputDialog("Введите название таблицы с шариками", ref res)== DialogResult.OK)
                {
                    HelperDB.SaveMazeToDB( Helper.GetFieldData(), res, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    MessageBox.Show($"Таблица [{res}] успешно сохранена");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs ea)
        {
            try
            {
                HelperDB.CheckDatabaseExists();

                FLoad fLoad = new FLoad();

                fLoad.ShowDialog();

                updateField();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }                
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Helper.GenerateMaze();
            updateField();
        }
    }
}
