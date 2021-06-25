using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microcredit_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double startcount = Convert.ToDouble(numericUpDown1.Value);
            double rate = Convert.ToDouble(numericUpDown2.Value);
            int day = Convert.ToInt32(numericUpDown3.Value);

            rate = rate / 100;
            int periods = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
