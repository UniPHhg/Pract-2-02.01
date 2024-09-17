using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Формы_с_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n; string k;
            n = Convert.ToInt32(textBox1.Text);
            switch (n)
            {
                case 1:
                    k = "А"; listBox1.Items.Add(k);
                    break;
                case 2:
                    k = "Б"; listBox1.Items.Add(k);
                    break;
                case 3:
                    k = "В"; listBox1.Items.Add(k);
                    break;
                case 4:
                    k = "Г"; listBox1.Items.Add(k);
                    break;
                case 5:
                    k = "Д"; listBox1.Items.Add(k);
                    break;
                case 6:
                    k = "Е"; listBox1.Items.Add(k);
                    break;
                case 7:
                    k = "Ё"; listBox1.Items.Add(k);
                    break;
                case 8:
                    k = "Ж"; listBox1.Items.Add(k);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

