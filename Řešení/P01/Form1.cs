using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[n];
            Random rnd = new Random();
            double min = 1001;
            double max = 0;
            int poradi_max=0, poradi_min=0;
            double soucet = 0;
            for (int c = 0; c < n; c++)
            {
                pole[c] = rnd.NextDouble() * (1000 - 1) + 1;
                listBox1.Items.Add(pole[c].ToString("F2"));
                if (pole[c] > max)
                {
                    max = pole[c];
                    poradi_max = c;
                }
                
                if (pole[c] < min)
                {
                min = pole[c];
                    poradi_min = c;
                }
                soucet += pole[c];
            }
            pole[poradi_min] = max;
            pole[poradi_max] = min;
            for (int x = 0; x < n; x++)
                listBox2.Items.Add(pole[x].ToString("F2"));
            soucet -= (max+min);
            double prum = soucet / (n-2);
            MessageBox.Show("Aritmetický průměr náhodných čísel bez maxima a minima je " + prum, "Průměr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[n];
            for(int v = 0; v < n; v++)
            {
                pole[v] = rnd.NextDouble() * (1000 - 1) + 1;
                listBox1.Items.Add(pole[v].ToString("F2"));
            }
            double min = pole.Min();
            double max = pole.Max();
            int pozice_max = Array.IndexOf(pole, max);
            int pozice_min = Array.IndexOf(pole, min);
            pole[pozice_max] = min;
            pole[pozice_min] = max;
            for (int x = 0; x < pole.Length; x++)
                listBox2.Items.Add(pole[x].ToString("F2"));
            double soucet = pole.Sum();
            soucet -= (max + min);
            double prum = soucet / (pole.Length - 2);
            MessageBox.Show("Aritmetický průměr náhodných čísel bez maxima a minima je " + prum, "Průměr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
