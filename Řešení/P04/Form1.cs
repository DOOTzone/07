using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int[] pole = new int[n];
      
            for(int b = 0; b < n; b++)
            {
                pole[b] = rnd.Next(1, 21);
                listBox1.Items.Add(pole[b]);
            }
            pole = pole.Distinct().ToArray();
            int max = 0;
            int min = 22;
            for (int g = 0; g < pole.Length; g++)
            {
                if (pole[g] > max)
                    max = pole[g];
                if (pole[g] < min)
                    min = pole[g];
                listBox2.Items.Add(pole[g]);
            }

            int indexmax = Array.IndexOf(pole, max);
            int indexmin = Array.IndexOf(pole, min);
            int[] pole1 = pole.Take(indexmax).ToArray();
            int[] pole2 = pole.Skip(indexmax+1).ToArray();
            int[] pole3 = pole1.Concat(pole2).ToArray();
            for (int b = 0; b < pole3.Length; b++)
            {
                listBox3.Items.Add(pole3[b]);
            }
            pole1 = pole3.Take(indexmin).ToArray();
            pole2 = pole3.Skip(indexmin + 1).ToArray();
            pole = pole1.Concat(pole2).ToArray();
            for (int b = 0; b < pole.Length; b++)
            {
                listBox4.Items.Add(pole[b]);
            }
        }
    }
}
