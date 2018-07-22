using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        Form1 f1 = new Form1();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Replace";
            this.label1.Text = "Search";
            this.label2.Text = "Replace";
            this.button1.Text = "Ok";

            this.button1.FlatStyle = FlatStyle.Popup;
            this.button1.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.textBox1.Text = f1.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);
            this.Close();
        }
    }
}
