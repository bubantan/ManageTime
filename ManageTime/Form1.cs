using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "Hello";
            string txt2 = " How are you ?";
            string txt3 = " I'm fine. Thank you! ";
            string txt4 = " I love you, Natalia!";
            richTextBox1.Text = txt + txt2 + txt3;

        }
    }
}
