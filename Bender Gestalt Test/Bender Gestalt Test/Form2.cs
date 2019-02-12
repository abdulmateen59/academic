using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bender_Gestalt_Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.bender_gestalt_test_tableTableAdapter.Fill(this.bender_Gestalt_Test_dbDataSet.bender_gestalt_test_table);
            dataGridView1.ClearSelection();
            int nRowIndex = dataGridView1.Rows.Count - 1;
            int nColumnIndex = 1;

            dataGridView1.Rows[nRowIndex].Selected = true;
            dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;


            dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
