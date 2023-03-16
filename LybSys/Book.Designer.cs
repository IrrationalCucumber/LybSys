
namespace LybSys
{
    partial class Book
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBookId = new System.Windows.Forms.TextBox();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.tbBookAuthor = new System.Windows.Forms.TextBox();
            this.tbBookGenre = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heavenly Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genre";
            // 
            // tbBookId
            // 
            this.tbBookId.Location = new System.Drawing.Point(161, 76);
            this.tbBookId.Name = "tbBookId";
            this.tbBookId.Size = new System.Drawing.Size(100, 20);
            this.tbBookId.TabIndex = 5;
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Location = new System.Drawing.Point(161, 113);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(320, 20);
            this.tbBookTitle.TabIndex = 6;
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Location = new System.Drawing.Point(160, 149);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(221, 20);
            this.tbBookAuthor.TabIndex = 7;
            // 
            // tbBookGenre
            // 
            this.tbBookGenre.Location = new System.Drawing.Point(160, 185);
            this.tbBookGenre.Name = "tbBookGenre";
            this.tbBookGenre.Size = new System.Drawing.Size(100, 20);
            this.tbBookGenre.TabIndex = 8;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(538, 68);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(115, 42);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(538, 116);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(115, 42);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(538, 163);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(115, 42);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbBookGenre);
            this.Controls.Add(this.tbBookAuthor);
            this.Controls.Add(this.tbBookTitle);
            this.Controls.Add(this.tbBookId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Book";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBookId;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.TextBox tbBookAuthor;
        private System.Windows.Forms.TextBox tbBookGenre;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
    }
}