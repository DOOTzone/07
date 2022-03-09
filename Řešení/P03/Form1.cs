using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        int[] pole_a;
        int[] pole_b;
        int[] pole_c;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            pole_a = new int[n];
            for (int v = 0; v < n; v++)
            {
                pole_a[v] = rnd.Next(3, 11);
                listBox1.Items.Add(pole_a[v]);
            }
            int m = Convert.ToInt32(textBox2.Text);
            pole_b = new int[m];
            for (int c = 0; c < m; c++)
            {
                pole_b[c] = rnd.Next(3, 11);
                listBox2.Items.Add(pole_b[c]);
            }
            Array.Sort(pole_a);
            Array.Reverse(pole_a);
            Array.Sort(pole_b);
            Array.Reverse(pole_b);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int v = 0; v < n; v++)
            {
                listBox1.Items.Add(pole_a[v]);
            }
            
            for (int c = 0; c < m; c++)
            {
                listBox2.Items.Add(pole_b[c]);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int v = pole_a.Length + pole_b.Length;
            pole_c = new int[v];
            pole_c = pole_a.Concat(pole_b).ToArray();
            for(int b = 0; b < v; b++)
            {
                listBox3.Items.Add(pole_c[b]);
            }
            Array.Sort(pole_c);
            Array.Reverse(pole_c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] pole_d = new int[pole_c.Length];
            pole_c.CopyTo(pole_d, 0);
            pole_d = pole_d.Distinct().ToArray();
            for(int l = 0; l < pole_d.Length; l++)
            {
                listBox4.Items.Add(pole_d[l]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] pole_e = new int[pole_c.Length];
            pole_e = pole_a.Intersect(pole_b).ToArray();
            for(int k = 0; k < pole_e.Length; k++)
            {
                listBox5.Items.Add(pole_e[k]);
            }
        }
    }
}
