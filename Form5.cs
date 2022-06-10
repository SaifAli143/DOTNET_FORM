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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

       

       

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string path = @"E:\SnQBatch1";
            DirectoryInfo di = new DirectoryInfo(path);
            if(di.Exists)
            {
                MessageBox.Show("FOLDER IS ALREADY EXISTS");
            }
            else
            {
                di.Create();
            }
            
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"E:\SnQBatch1\Test1.txt";
            FileInfo fi = new FileInfo(path);
            if(fi.Exists)
            {
                MessageBox.Show("FILE IS ALREADY CREATED");
            }
            else
            {
                fi.Create();
                MessageBox.Show("FILE CREATED");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SnQBatch1\Test1.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                int ID = Convert.ToInt32(txtDEPT_ID.Text);
                string Name = txtDEPT_NAME.Text;
                String Location = txtDEPT_LOCATION.Text;
                bw.Write(ID);
                bw.Write(Name);
                bw.Write(Location);
                bw.Close();
                fs.Close();

            }
            catch(Exception ex)
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
                txtDEPT_ID.Text = ID.ToString();
                txtDEPT_NAME.Text = Name;
                txtDEPT_LOCATION.Text = Location;
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
