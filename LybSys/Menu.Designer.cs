
namespace LybSys
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem1,
            this.borrowerToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // booksToolStripMenuItem1
            // 
            this.booksToolStripMenuItem1.Name = "booksToolStripMenuItem1";
            this.booksToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.booksToolStripMenuItem1.Text = "Books";
            this.booksToolStripMenuItem1.Click += new System.EventHandler(this.booksToolStripMenuItem1_Click);
            // 
            // borrowerToolStripMenuItem
            // 
            this.borrowerToolStripMenuItem.Name = "borrowerToolStripMenuItem";
            this.borrowerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.borrowerToolStripMenuItem.Text = "Borrower";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnedToolStripMenuItem,
            this.returnedToolStripMenuItem1});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.booksToolStripMenuItem.Text = "Transaction";
            // 
            // returnedToolStripMenuItem
            // 
            this.returnedToolStripMenuItem.Name = "returnedToolStripMenuItem";
            this.returnedToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.returnedToolStripMenuItem.Text = "Borrow";
            this.returnedToolStripMenuItem.Click += new System.EventHandler(this.returnedToolStripMenuItem_Click);
            // 
            // returnedToolStripMenuItem1
            // 
            this.returnedToolStripMenuItem1.Name = "returnedToolStripMenuItem1";
            this.returnedToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.returnedToolStripMenuItem1.Text = "Return";
            this.returnedToolStripMenuItem1.Click += new System.EventHandler(this.returnedToolStripMenuItem1_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.transactionToolStripMenuItem.Text = "Reports";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome \r\n      to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 75);
            this.label2.TabIndex = 2;
            this.label2.Text = "Library of Heaven\'s Path";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(223, 202);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 23);
            this.lblUser.TabIndex = 3;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 340);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem returnedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
    }
}