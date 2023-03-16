
namespace LybSys
{
    partial class SignUp
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
            this.btnSumbit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkSI = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(144, 273);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(75, 23);
            this.btnSumbit.TabIndex = 0;
            this.btnSumbit.Text = "Sumbit";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(77, 81);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(239, 20);
            this.tbUsername.TabIndex = 4;
            // 
            // tbPassword1
            // 
            this.tbPassword1.Location = new System.Drawing.Point(77, 146);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.Size = new System.Drawing.Size(239, 20);
            this.tbPassword1.TabIndex = 5;
            this.tbPassword1.UseSystemPasswordChar = true;
            // 
            // tbPassword2
            // 
            this.tbPassword2.Location = new System.Drawing.Point(77, 210);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.Size = new System.Drawing.Size(239, 20);
            this.tbPassword2.TabIndex = 6;
            this.tbPassword2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Already have an Account?";
            // 
            // lnkSI
            // 
            this.lnkSI.AutoSize = true;
            this.lnkSI.Location = new System.Drawing.Point(225, 312);
            this.lnkSI.Name = "lnkSI";
            this.lnkSI.Size = new System.Drawing.Size(56, 13);
            this.lnkSI.TabIndex = 8;
            this.lnkSI.TabStop = true;
            this.lnkSI.Text = "Click Here";
            this.lnkSI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSI_LinkClicked);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 378);
            this.Controls.Add(this.lnkSI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword2);
            this.Controls.Add(this.tbPassword1);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSumbit);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword1;
        private System.Windows.Forms.TextBox tbPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkSI;
    }
}