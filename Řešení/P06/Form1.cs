using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double[] pole;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[n];
            for(int v = 0; v < n; v++)
            {
                pole[v] = rnd.NextDouble() * 2000 - 1000;
                listBox1.Items.Add(pole[v]);
            }
            double avg = pole.Average();
            double max = -1001;
            foreach(double cislo in pole)
            {
                if (cislo <= avg)
                    if (cislo > max)
                        max = cislo;
            }
            MessageBox.Show("Největší číslo menší nebo rovno průměru" + avg + " je " + max, "Max menší než průměr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
