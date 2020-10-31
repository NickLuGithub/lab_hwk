using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyView
{
    public delegate void OperatorClickEventHandler(string op);
    public partial class Form1 : Form
    {
        public event EventHandler T1Changed;
        public event EventHandler T2Changed;

        public event OperatorClickEventHandler OpClick;
        public Form1()
        {
            InitializeComponent();

            T1Changed = null;
            T2Changed = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            T1Changed?.Invoke(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            T2Changed?.Invoke(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpClick?.Invoke("+");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpClick?.Invoke("-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpClick?.Invoke("*");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpClick?.Invoke("/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetResult(string str)
        {
            label1.Text = str;
        }
    }
}
