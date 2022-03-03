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
            for(int v = 0; v < n; v++)
            {
                pole[v] = rnd.Next(1, 11);
                listBox1.Items.Add(pole[v]);
            }
            if (radioButton1.Checked)
            {
                Array.Sort(pole);
                Array.Reverse(pole);
                for (int v = 0; v < n; v++)
                {
                    listBox2.Items.Add(pole[v]);
                }
            }
            else
            {
                Array.Sort(pole);
                for (int v = 0; v < n; v++)
                {
                    listBox2.Items.Add(pole[v]);
                }
            }
        }
    }
}
