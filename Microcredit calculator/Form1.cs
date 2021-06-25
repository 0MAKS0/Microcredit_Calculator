using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                double ZAIM = Convert.ToDouble(SummZayma.Text);
                double PERIOD = Convert.ToDouble(Period.Text);

                if (ZAIM > 500000 || ZAIM < 0)
                {
                    MessageBox.Show("!Сумма займа введена неверно!");
                    throw new ArgumentNullException();
                }

                if (PERIOD > 365 || PERIOD < 1)
                {
                    MessageBox.Show("!Период введен неверно!");
                    throw new ArgumentNullException();
                }

                var data = Proc.Text.Split(' ');

                for (int i = 0; i < PERIOD; i++)
                {
                    SummProcent += Convert.ToDouble(data[i]) / 100 * ZAIM;
                }

                SumProc.Text = SummProcent.ToString();

                TotalSumm = ZAIM + SummProcent;
                TotalSum.Text = TotalSumm.ToString();

                EffStavka = SummProcent / ZAIM / PERIOD * 100;
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

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTableAsCSV = new SaveFileDialog();
            saveTableAsCSV.Filter = "Документ TXT (*.txt) |*.txt";
            saveTableAsCSV.Title = "Сохранить результат расчетов";
            if (saveTableAsCSV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(saveTableAsCSV.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(file, Encoding.Default);
                    sw.Write("Общая сумма выплаты" + ":" + " " + TotalSum.Text);
                    sw.WriteLine();
                    sw.Write("Сумма переплаты" + ":" + " " + SumProc.Text);
                    sw.WriteLine();
                    sw.Write("Эффективная ставка" + ":" + " " + EffStav.Text);
                    sw.WriteLine();

                    sw.Close();
                }
                catch
                { }
            }
        }
    }
}
