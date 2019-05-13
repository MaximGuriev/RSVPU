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
            string c = textBox2.Text;
            int result = 0;
            result = chastota(a, c, result);
            string res = Convert.ToString(result);
            label1.Text = res;
        }
        
        private static int chastota(string a, string c, int result)
        {
            string b = a.ToLower();
            string d = c.ToLower();
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == d[0])
                {
                    result += 1;
                }
            }
            return result;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
        }
    }
}
