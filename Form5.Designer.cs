
namespace DOTNET_FORM
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbldeptname = new System.Windows.Forms.Label();
            this.lbldeptlocation = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtDEPT_ID = new System.Windows.Forms.TextBox();
            this.txtDEPT_NAME = new System.Windows.Forms.TextBox();
            this.txtDEPT_LOCATION = new System.Windows.Forms.TextBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER DEPARTMENT ID";
            // 
            // lbldeptname
            // 
            this.lbldeptname.AutoSize = true;
            this.lbldeptname.Location = new System.Drawing.Point(125, 156);
            this.lbldeptname.Name = "lbldeptname";
            this.lbldeptname.Size = new System.Drawing.Size(116, 13);
            this.lbldeptname.TabIndex = 1;
            this.lbldeptname.Text = "DEPARTMENT NAME";
            // 
            // lbldeptlocation
            // 
            this.lbldeptlocation.AutoSize = true;
            this.lbldeptlocation.Location = new System.Drawing.Point(125, 214);
            this.lbldeptlocation.Name = "lbldeptlocation";
            this.lbldeptlocation.Size = new System.Drawing.Size(139, 13);
            this.lbldeptlocation.TabIndex = 2;
            this.lbldeptlocation.Text = "DEPARTMENT LOCATION";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(128, 257);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(357, 257);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(451, 83);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(129, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "CREATE FOLDER";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtDEPT_ID
            // 
            this.txtDEPT_ID.Location = new System.Drawing.Point(277, 85);
            this.txtDEPT_ID.Name = "txtDEPT_ID";
            this.txtDEPT_ID.Size = new System.Drawing.Size(155, 20);
            this.txtDEPT_ID.TabIndex = 9;
            // 
            // txtDEPT_NAME
            // 
            this.txtDEPT_NAME.Location = new System.Drawing.Point(277, 149);
            this.txtDEPT_NAME.Name = "txtDEPT_NAME";
            this.txtDEPT_NAME.Size = new System.Drawing.Size(155, 20);
            this.txtDEPT_NAME.TabIndex = 10;
            // 
            // txtDEPT_LOCATION
            // 
            this.txtDEPT_LOCATION.Location = new System.Drawing.Point(277, 207);
            this.txtDEPT_LOCATION.Name = "txtDEPT_LOCATION";
            this.txtDEPT_LOCATION.Size = new System.Drawing.Size(155, 20);
            this.txtDEPT_LOCATION.TabIndex = 11;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(451, 146);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(129, 23);
            this.btnCreateFile.TabIndex = 12;
            this.btnCreateFile.Text = "CREATE FILE";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.txtDEPT_LOCATION);
            this.Controls.Add(this.txtDEPT_NAME);
            this.Controls.Add(this.txtDEPT_ID);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.lbldeptlocation);
            this.Controls.Add(this.lbldeptname);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldeptname;
        private System.Windows.Forms.Label lbldeptlocation;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtDEPT_ID;
        private System.Windows.Forms.TextBox txtDEPT_NAME;
        private System.Windows.Forms.TextBox txtDEPT_LOCATION;
        private System.Windows.Forms.Button btnCreateFile;
    }
}