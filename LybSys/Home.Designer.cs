
namespace LybSys
{
    partial class Home
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
            this.si = new System.Windows.Forms.Button();
            this.su = new System.Windows.Forms.Button();
            this.gb = new System.Windows.Forms.GroupBox();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // si
            // 
            this.si.Location = new System.Drawing.Point(62, 22);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(75, 23);
            this.si.TabIndex = 2;
            this.si.Text = "Sign In";
            this.si.UseVisualStyleBackColor = true;
            this.si.Click += new System.EventHandler(this.si_Click);
            // 
            // su
            // 
            this.su.Location = new System.Drawing.Point(62, 51);
            this.su.Name = "su";
            this.su.Size = new System.Drawing.Size(75, 23);
            this.su.TabIndex = 3;
            this.su.Text = "Sign Up";
            this.su.UseVisualStyleBackColor = true;
            this.su.Click += new System.EventHandler(this.su_Click);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.su);
            this.gb.Controls.Add(this.si);
            this.gb.Location = new System.Drawing.Point(43, 144);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(198, 99);
            this.gb.TabIndex = 4;
            this.gb.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 338);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button si;
        private System.Windows.Forms.Button su;
        private System.Windows.Forms.GroupBox gb;
    }
}

