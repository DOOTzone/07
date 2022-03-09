using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
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
            Random rnd = new Random();
            int[] pole = new int[n];
            for (int v = 0; v < n; v++)
            {
                pole[v] = rnd.Next(1, 11);
                listBox1.Items.Add(pole[v]);
            }
            Array.Sort(pole);
            int max = pole[n-1];
            int min = pole[0];
            int index_max = Array.IndexOf(pole,max);
            int index_min = Array.LastIndexOf(pole,min);
            int max2 = pole[index_max - 1];
            int min2 = pole[index_min + 1];
            if (radioButton1.Checked)
                Array.Reverse(pole);
            for (int v = 0; v < n; v++)
            {
                listBox2.Items.Add(pole[v]);
            }
        
            MessageBox.Show("2 největší číslo je " + max2 + " a 2 nejmenší je " + min2, "2.max a min", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
