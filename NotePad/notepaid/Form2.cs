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
    public partial class Form2 : Form
    {
        Form1 f1 = new Form1();

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Find";
            this.label1.Text = "Search";
            this.button1.Text = "Ok";

            this.button1.FlatStyle = FlatStyle.Popup;
            this.button1.Cursor = Cursors.Hand;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains(f1.textBox1.Text))
            {
                MessageBox.Show("Found");
            }
            else
            {
                MessageBox.Show("Could not be Found ");
            }
        }
    }
}
