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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EMP ID:" + txtempid.Text + "\n" + "EMP NAME:" + txtempname.Text + "\n" + "SALARY:" + txtempsalary.Text + "\n" + "DEPARMENT:" + txtdepartment.Text) ;
                                  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtempid.Clear();
            txtempname.Clear();
            txtempsalary.Clear();
            txtdepartment.Clear();

        }
    }
}
