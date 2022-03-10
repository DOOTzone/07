using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
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
            int b = Convert.ToInt32(textBox2.Text);
            int[] pole = new int[n];
            int[] pole2;
            int[] pole3;
            bool je_b = false;
            for (int k = 0; k < n; k++)
            {
                pole[k] = rnd.Next(1, 20);
                listBox1.Items.Add(pole[k]);
                if (pole[k] == b)
                    je_b = true;
                
            }
            Array.Sort(pole);
            listBox1.Items.Clear();
            for (int k = 0; k < n; k++)
            {
                listBox1.Items.Add(pole[k]);
            }
            if (je_b)
            {
                int indmax = Array.IndexOf(pole, b);
                int indmaxl = Array.LastIndexOf(pole, b);
                pole2 = pole.Take(indmax + 1).ToArray();
                pole3 = pole.Skip(indmaxl + 1).ToArray();
                for (int k = 0; k < pole2.Length; k++)
                {
                    listBox2.Items.Add(pole2[k]);
                }
                for (int k = 0; k < pole3.Length; k++)
                {
                    listBox3.Items.Add(pole3[k]);
                }
            }
            else
            {
                int y = 0;
                int z = 0;
                
                for (int x = 0; x < pole.Length; x++)
                {

                    if (pole[x] <= b)
                    {
                        pole2[y] = pole[x];
                        y++;
                    }
                    else
                    {
                        pole3[z] = pole[x];
                        z++;
                    }
                }



                foreach (int p in pole2)
                {
                    listBox2.Items.Add(p);
                }
                foreach (int p in pole3)
                {
                    listBox3.Items.Add(p);
                }
            }
        }
    }
}
