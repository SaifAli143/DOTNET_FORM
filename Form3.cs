using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DOTNET_FORM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult result = fd.ShowDialog();
            if(DialogResult.OK== result)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult result = cd.ShowDialog();
            if(DialogResult.OK == result)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Exit ?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.DefaultExt = ".txt";
            sd.Filter = "Text.doc(.txt)|*.txt|Word.docx(.docx)|*.docx|Pdf File(.pdf)|*.pdf";
            DialogResult result = sd.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text.doc(.txt)|*.txt|Word.docx(.docx)|*.docx|Pdf File(.pdf)|*.pdf|All Files|*.*";
            DialogResult result = op.ShowDialog();
            if(result == DialogResult.OK)
           {
                StreamReader sr = new StreamReader(op.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
               
            }
        }
    }
}
