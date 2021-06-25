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
        public double TotalSumm = 0;
        public double SummProcent = 0;
        public double EffStavka = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double zaym = Convert.ToDouble(SummZayma.Text);
                double period = Convert.ToDouble(Period.Text);

                if (zaym > 500000 || zaym < 0)
                {
                    MessageBox.Show("!Сумма займа введена неверно!");
                    throw new ArgumentNullException();
                }


                if (period > 365 || period < 1)
                {
                    MessageBox.Show("!Период введен неверно!");
                    throw new ArgumentNullException();
                }

                var data = txProc.Text.Split(' ');

                for (int i = 0; i < period; i++)
                {
                    SummProcent += Convert.ToDouble(data[i]) / 100 * zaym;
                }

                SumProc.Text = SummProcent.ToString();

                TotalSumm = zaym + SummProcent;
                TotalSum.Text = TotalSumm.ToString();

                EffStavka = SummProcent / zaym / period * 100;
                EffStav.Text = EffStavka.ToString();

                SummProcent = 0;
            }
            catch
            {
                MessageBox.Show("!Подставте правильные значения!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txProc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
