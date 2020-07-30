using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class FLoad : Form
    {
        public FLoad()
        {
            InitializeComponent();

            HelperDB.LoadNames(dataGridView);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount > 0)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                int size = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[3].Value);
                HelperDB.LoadMazeFromDB(id, size);
                Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            btnLoad_Click(sender, null);
        }
    }
}
