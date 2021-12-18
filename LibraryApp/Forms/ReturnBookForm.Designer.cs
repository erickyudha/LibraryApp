
namespace LibraryApp.Forms
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.transactionGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.penaltyLabel = new System.Windows.Forms.Label();
            this.lateByLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).BeginInit();
            this.summaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionGrid
            // 
            this.transactionGrid.AllowUserToAddRows = false;
            this.transactionGrid.AllowUserToDeleteRows = false;
            this.transactionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGrid.Location = new System.Drawing.Point(13, 13);
            this.transactionGrid.Name = "transactionGrid";
            this.transactionGrid.ReadOnly = true;
            this.transactionGrid.Size = new System.Drawing.Size(462, 299);
            this.transactionGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Return Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(485, 56);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(225, 20);
            this.idBox.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(485, 83);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(225, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // summaryPanel
            // 
            this.summaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summaryPanel.Controls.Add(this.confirmBtn);
            this.summaryPanel.Controls.Add(this.penaltyLabel);
            this.summaryPanel.Controls.Add(this.lateByLabel);
            this.summaryPanel.Controls.Add(this.titleLabel);
            this.summaryPanel.Controls.Add(this.isbnLabel);
            this.summaryPanel.Controls.Add(this.userNameLabel);
            this.summaryPanel.Controls.Add(this.userIdLabel);
            this.summaryPanel.Controls.Add(this.label9);
            this.summaryPanel.Controls.Add(this.label8);
            this.summaryPanel.Controls.Add(this.label7);
            this.summaryPanel.Controls.Add(this.label6);
            this.summaryPanel.Controls.Add(this.label5);
            this.summaryPanel.Controls.Add(this.label4);
            this.summaryPanel.Controls.Add(this.label3);
            this.summaryPanel.Location = new System.Drawing.Point(485, 113);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(225, 197);
            this.summaryPanel.TabIndex = 5;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(7, 167);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(213, 25);
            this.confirmBtn.TabIndex = 13;
            this.confirmBtn.Text = "Confirm Return";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // penaltyLabel
            // 
            this.penaltyLabel.AutoSize = true;
            this.penaltyLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic);
            this.penaltyLabel.Location = new System.Drawing.Point(78, 142);
            this.penaltyLabel.Name = "penaltyLabel";
            this.penaltyLabel.Size = new System.Drawing.Size(47, 15);
            this.penaltyLabel.TabIndex = 12;
            this.penaltyLabel.Text = "label15";
            // 
            // lateByLabel
            // 
            this.lateByLabel.AutoSize = true;
            this.lateByLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic);
            this.lateByLabel.Location = new System.Drawing.Point(78, 127);
            this.lateByLabel.Name = "lateByLabel";
            this.lateByLabel.Size = new System.Drawing.Size(47, 15);
            this.lateByLabel.TabIndex = 11;
            this.lateByLabel.Text = "label14";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic);
            this.titleLabel.Location = new System.Drawing.Point(78, 94);
            this.titleLabel.MaximumSize = new System.Drawing.Size(136, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(47, 15);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "label13";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic);
            this.isbnLabel.Location = new System.Drawing.Point(78, 79);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(47, 15);
            this.isbnLabel.TabIndex = 9;
            this.isbnLabel.Text = "label12";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic);
            this.userNameLabel.Location = new System.Drawing.Point(78, 47);
            this.userNameLabel.MaximumSize = new System.Drawing.Size(136, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(47, 15);
            this.userNameLabel.TabIndex = 8;
            this.userNameLabel.Text = "label11";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(78, 32);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(47, 15);
            this.userIdLabel.TabIndex = 7;
            this.userIdLabel.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Penalty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Late By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Transaction Summary";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 324);
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transactionGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return Book - MyLibrary";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).EndInit();
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label penaltyLabel;
        private System.Windows.Forms.Label lateByLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}