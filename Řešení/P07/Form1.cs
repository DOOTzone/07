using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] polecelk = new int[listBox1.Items.Count];
            int cislo = Convert.ToInt32(listBox1.Items[0]);
            int c=0;
            for (int v = 0; cislo != 0; v++)
            {   
                polecelk[v] = cislo;
                cislo = Convert.ToInt32(listBox1.Items[v+1]);
                c = v;
            }
            MessageBox.Show("První prvek dělen posledním prvkem je " + polecelk[0] / polecelk[c],"První/Poslední", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for(int b = 0; b < c; b++)
            {
                if (polecelk[b] < polecelk[c])
                    listBox2.Items.Add(polecelk[b] + " Je menší než " + polecelk[c] + " a jeho index je " + b);
            }
        }
    }
}
