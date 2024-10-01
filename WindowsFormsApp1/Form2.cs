using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string a;
        string b;

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = textBox2.Text;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
               Form1 form1 = new Form1(a,b);
                form1.Show() ;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Zadejte jména");
            }
        }
    }
}
