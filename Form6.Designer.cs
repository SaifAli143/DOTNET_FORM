
namespace DOTNET_FORM
{
    partial class Form6
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.txtCOURSE_ID = new System.Windows.Forms.TextBox();
            this.txtCOURSE_NAME = new System.Windows.Forms.TextBox();
            this.txtCOURSE_FEES = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(102, 73);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(66, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "COURSE ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(102, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "COURSE NAME";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(102, 269);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(82, 13);
            this.lblFees.TabIndex = 2;
            this.lblFees.Text = "COURSE FEES";
            // 
            // txtCOURSE_ID
            // 
            this.txtCOURSE_ID.Location = new System.Drawing.Point(272, 73);
            this.txtCOURSE_ID.Name = "txtCOURSE_ID";
            this.txtCOURSE_ID.Size = new System.Drawing.Size(100, 20);
            this.txtCOURSE_ID.TabIndex = 3;
            // 
            // txtCOURSE_NAME
            // 
            this.txtCOURSE_NAME.Location = new System.Drawing.Point(272, 148);
            this.txtCOURSE_NAME.Name = "txtCOURSE_NAME";
            this.txtCOURSE_NAME.Size = new System.Drawing.Size(100, 20);
            this.txtCOURSE_NAME.TabIndex = 4;
            // 
            // txtCOURSE_FEES
            // 
            this.txtCOURSE_FEES.Location = new System.Drawing.Point(272, 262);
            this.txtCOURSE_FEES.Name = "txtCOURSE_FEES";
            this.txtCOURSE_FEES.Size = new System.Drawing.Size(100, 20);
            this.txtCOURSE_FEES.TabIndex = 5;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(105, 320);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(297, 320);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtCOURSE_FEES);
            this.Controls.Add(this.txtCOURSE_NAME);
            this.Controls.Add(this.txtCOURSE_ID);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblid);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.TextBox txtCOURSE_ID;
        private System.Windows.Forms.TextBox txtCOURSE_NAME;
        private System.Windows.Forms.TextBox txtCOURSE_FEES;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
    }
}