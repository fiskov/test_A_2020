using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6
{
    public partial class FormMain : Form
    {
        List<int> tower = new List<int>();
        List<List<int>> towers = new List<List<int>>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddPower_Click(object sender, EventArgs ea)
        {
            tower.Add((int)numPower.Value);
            lblTower.Text = tower.ToStringPowers();
        }

        private void btnClearTower_Click(object sender, EventArgs e)
        {
            tower.Clear();
            lblTower.Text = tower.ToStringPowers();
        }

        private void btnCreateTower_Click(object sender, EventArgs e)
        {
            tower.GeneratePowers();
            lblTower.Text = tower.ToStringPowers();
        }

        private void printTowers(List<List<int>> towers)
        {
            lbTowers.Items.Clear();
            lbTowersSort.Items.Clear();

            foreach (var t in towers)
                lbTowers.Items.Add(t.ToStringPowers());

            foreach (var t in Helper.SortTowers(towers))
                lbTowersSort.Items.Add(t.ToStringPowers());// + "=" + t.ValuePower());
        }

        private void btnAddTower_Click(object sender, EventArgs e)
        {
            var _tower = new List<int>(tower);
            towers.AddTower(_tower);
            printTowers(towers);
        }

        private void btnClearTowerList_Click(object sender, EventArgs e)
        {
            towers.Clear();
            lbTowers.Items.Clear();
            lbTowersSort.Items.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs ea)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var lines = File.ReadAllLines(openFileDialog.FileName);
                        foreach (var line in lines)
                        {
                            string[] numbers = line.Split(' ');

                            tower.Clear();
                            foreach (var t in numbers)
                                tower.AddPower(int.Parse(t));

                            var _tower = new List<int>(tower);
                            towers.AddTower(_tower);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            printTowers(towers);
        }
    }

}
