using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNet3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyClass mc = new MyClass(this.button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(this.textBox1.Text);
            this.textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
