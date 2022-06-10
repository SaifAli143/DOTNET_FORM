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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
          try
            {
                FileStream fs = new FileStream(@"E:\SnQBatch1\Test1.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                int ID = Convert.ToInt32(txtCOURSE_ID.Text);
                string Name = txtCOURSE_NAME.Text;
                String Fees = txtCOURSE_FEES.Text;
                bw.Write(ID);
                bw.Write(Name);
                bw.Write(Fees);
                bw.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
                

            


        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SnQBatch1\Test1.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int ID = br.ReadInt32();
                string Name = br.ReadString();
                String Location = br.ReadString();
                txtCOURSE_ID.Text = ID.ToString();
                txtCOURSE_NAME.Text = Name;
                txtCOURSE_FEES.Text = Location;
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
