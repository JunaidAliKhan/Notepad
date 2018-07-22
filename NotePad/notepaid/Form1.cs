using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Junaid Ali Khan";
            this.menuStrip1.Cursor = Cursors.Hand;

            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            timeDateToolStripMenuItem.ShortcutKeys = Keys.Control| Keys.Q;

            this.textBox1.WordWrap = false;
            this.textBox1.ScrollBars = ScrollBars.Both;

        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = false;
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }
        }

        private void withColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = true;
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
                this.textBox1.ForeColor = this.fontDialog1.Color;
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //f1.textBox1.Text.Replace()
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string ab = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(ab);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Text(*.txt|*.txt)";
            DialogResult dr = this.saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string bd = saveFileDialog1.FileName;
                bd += ".txt";
                File.WriteAllText(bd, this.textBox1.Text);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                this.textBox1.Text = "";
            }
            else
            {
                saveFileDialog1.Filter = "All Text(*.txt|*.txt)";
                DialogResult dr = this.saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string bd = saveFileDialog1.FileName;
                    bd += ".txt";
                    File.WriteAllText(bd, this.textBox1.Text);
                }
            }
        }

        private void wordWrapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapeToolStripMenuItem.Checked == false)
            {
                wordWrapeToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            }
            else if(wordWrapeToolStripMenuItem.Checked==true)
            {
                wordWrapeToolStripMenuItem.Checked = false;
                this.textBox1.WordWrap = false;
            }
        }
    }      
}
