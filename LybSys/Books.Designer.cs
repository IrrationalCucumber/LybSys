
namespace LybSys
{
    partial class Books
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.tbBookTItle = new System.Windows.Forms.TextBox();
            this.tbBookAuthor = new System.Windows.Forms.TextBox();
            this.tbBookGenre = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new LybSys.Database1DataSet();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter = new LybSys.Database1DataSetTableAdapters.BOOKSTableAdapter();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btMenu = new System.Windows.Forms.Button();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heavenly Records";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genre";
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(147, 97);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(100, 20);
            this.tbBookID.TabIndex = 5;
            // 
            // tbBookTItle
            // 
            this.tbBookTItle.Location = new System.Drawing.Point(147, 130);
            this.tbBookTItle.Name = "tbBookTItle";
            this.tbBookTItle.Size = new System.Drawing.Size(298, 20);
            this.tbBookTItle.TabIndex = 6;
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Location = new System.Drawing.Point(147, 163);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(201, 20);
            this.tbBookAuthor.TabIndex = 7;
            // 
            // tbBookGenre
            // 
            this.tbBookGenre.Location = new System.Drawing.Point(147, 196);
            this.tbBookGenre.Name = "tbBookGenre";
            this.tbBookGenre.Size = new System.Drawing.Size(100, 20);
            this.tbBookGenre.TabIndex = 8;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btAdd.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btAdd.Location = new System.Drawing.Point(535, 86);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(106, 39);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(535, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(535, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bOOKSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 192);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.database1DataSet;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "bookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "bookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            // 
            // bookStatusDataGridViewTextBoxColumn
            // 
            this.bookStatusDataGridViewTextBoxColumn.DataPropertyName = "bookStatus";
            this.bookStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.bookStatusDataGridViewTextBoxColumn.Name = "bookStatusDataGridViewTextBoxColumn";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowerToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // borrowerToolStripMenuItem
            // 
            this.borrowerToolStripMenuItem.Name = "borrowerToolStripMenuItem";
            this.borrowerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.borrowerToolStripMenuItem.Text = "Borrower";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowedToolStripMenuItem,
            this.returnedToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // borrowedToolStripMenuItem
            // 
            this.borrowedToolStripMenuItem.Name = "borrowedToolStripMenuItem";
            this.borrowedToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.borrowedToolStripMenuItem.Text = "Borrow";
            this.borrowedToolStripMenuItem.Click += new System.EventHandler(this.borrowedToolStripMenuItem_Click);
            // 
            // returnedToolStripMenuItem
            // 
            this.returnedToolStripMenuItem.Name = "returnedToolStripMenuItem";
            this.returnedToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.returnedToolStripMenuItem.Text = "Return";
            this.returnedToolStripMenuItem.Click += new System.EventHandler(this.returnedToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btMenu.FlatAppearance.BorderSize = 5;
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btMenu.Location = new System.Drawing.Point(618, 12);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(75, 23);
            this.btMenu.TabIndex = 14;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = false;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 477);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbBookGenre);
            this.Controls.Add(this.tbBookAuthor);
            this.Controls.Add(this.tbBookTItle);
            this.Controls.Add(this.tbBookID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.TextBox tbBookTItle;
        private System.Windows.Forms.TextBox tbBookAuthor;
        private System.Windows.Forms.TextBox tbBookGenre;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private Database1DataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnedToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
    }
}