using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Частота_букв_алфавита
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = a.ToLower();
            string c = textBox2.Text;
            string d = c.ToLower();
            int result = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == d[0])
                {
                    result += 1;
                }
            }
            string res = Convert.ToString(result);
            label1.Text = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
        }
    }
}
