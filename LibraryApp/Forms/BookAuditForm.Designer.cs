
namespace LibraryApp.Forms
{
    partial class BookAuditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAuditForm));
            this.bookGrid = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.publisherGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.authorGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bookGrid
            // 
            this.bookGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Location = new System.Drawing.Point(12, 36);
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.Size = new System.Drawing.Size(756, 613);
            this.bookGrid.TabIndex = 0;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(977, 615);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(196, 34);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Update Data";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Data";
            // 
            // publisherGrid
            // 
            this.publisherGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.publisherGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherGrid.Location = new System.Drawing.Point(977, 36);
            this.publisherGrid.Name = "publisherGrid";
            this.publisherGrid.Size = new System.Drawing.Size(195, 573);
            this.publisherGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(770, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author Data";
            // 
            // authorGrid
            // 
            this.authorGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.authorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorGrid.Location = new System.Drawing.Point(774, 36);
            this.authorGrid.Name = "authorGrid";
            this.authorGrid.Size = new System.Drawing.Size(197, 613);
            this.authorGrid.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(973, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Publisher Data";
            // 
            // BookAuditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publisherGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.bookGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BookAuditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Audit - MyLibrary";
            this.Load += new System.EventHandler(this.BookAuditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookGrid;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView publisherGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView authorGrid;
        private System.Windows.Forms.Label label3;
    }
}