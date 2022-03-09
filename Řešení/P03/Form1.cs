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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int[] pole_a = new int[n];
            for (int v = 0; v < n; v++)
            {
                pole_a[v] = rnd.Next(3, 11);
                listBox1.Items.Add(pole_a[v]);
            }
            int m = Convert.ToInt32(textBox2.Text);
            int[] pole_b = new int[m];
            for (int c = 0; c < m; c++)
            {
                pole_b[c] = rnd.Next(3, 11);
                listBox2.Items.Add(pole_b[c]);
            }
            Array.Sort(pole_a);
            Array.Reverse(pole_a);
            Array.Sort(pole_b);
            Array.Reverse(pole_b);
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

        }
    }
}
