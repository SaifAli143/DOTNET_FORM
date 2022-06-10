using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTNET_FORM
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtName.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

      
    }
}
