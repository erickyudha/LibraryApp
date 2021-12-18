
namespace LibraryApp.Forms
{
    partial class MainUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uidLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttlPanel = new System.Windows.Forms.Panel();
            this.ttlLabel1 = new System.Windows.Forms.Label();
            this.ttlLabel2 = new System.Windows.Forms.Label();
            this.ttlPictureBox = new System.Windows.Forms.PictureBox();
            this.authPanel = new System.Windows.Forms.Panel();
            this.authLabel1 = new System.Windows.Forms.Label();
            this.authLabel2 = new System.Windows.Forms.Label();
            this.authPictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.transactionGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ttlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttlPictureBox)).BeginInit();
            this.authPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.uidLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 97);
            this.panel1.TabIndex = 0;
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidLabel.Location = new System.Drawing.Point(96, 71);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.uidLabel.Size = new System.Drawing.Size(83, 18);
            this.uidLabel.TabIndex = 3;
            this.uidLabel.Text = "UserID: X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Erick Yudha Pratama Sukku";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibraryApp.Properties.Resources.account;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ttlPanel
            // 
            this.ttlPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.ttlPanel.Controls.Add(this.ttlLabel1);
            this.ttlPanel.Controls.Add(this.ttlLabel2);
            this.ttlPanel.Controls.Add(this.ttlPictureBox);
            this.ttlPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ttlPanel.Location = new System.Drawing.Point(416, 97);
            this.ttlPanel.Name = "ttlPanel";
            this.ttlPanel.Size = new System.Drawing.Size(314, 141);
            this.ttlPanel.TabIndex = 1;
            this.ttlPanel.Click += new System.EventHandler(this.ttlPanel_Click);
            // 
            // ttlLabel1
            // 
            this.ttlLabel1.AutoSize = true;
            this.ttlLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlLabel1.Location = new System.Drawing.Point(118, 46);
            this.ttlLabel1.Name = "ttlLabel1";
            this.ttlLabel1.Size = new System.Drawing.Size(109, 19);
            this.ttlLabel1.TabIndex = 1;
            this.ttlLabel1.Text = "Search catalog";
            this.ttlLabel1.Click += new System.EventHandler(this.ttlLabel1_Click);
            // 
            // ttlLabel2
            // 
            this.ttlLabel2.AutoSize = true;
            this.ttlLabel2.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlLabel2.Location = new System.Drawing.Point(114, 55);
            this.ttlLabel2.Name = "ttlLabel2";
            this.ttlLabel2.Size = new System.Drawing.Size(126, 42);
            this.ttlLabel2.TabIndex = 2;
            this.ttlLabel2.Text = "By Title";
            this.ttlLabel2.Click += new System.EventHandler(this.ttlLabel2_Click);
            // 
            // ttlPictureBox
            // 
            this.ttlPictureBox.BackgroundImage = global::LibraryApp.Properties.Resources.book_solid;
            this.ttlPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ttlPictureBox.Location = new System.Drawing.Point(26, 26);
            this.ttlPictureBox.Name = "ttlPictureBox";
            this.ttlPictureBox.Size = new System.Drawing.Size(85, 85);
            this.ttlPictureBox.TabIndex = 0;
            this.ttlPictureBox.TabStop = false;
            this.ttlPictureBox.Click += new System.EventHandler(this.ttlPictureBox_Click);
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.authPanel.Controls.Add(this.authLabel1);
            this.authPanel.Controls.Add(this.authLabel2);
            this.authPanel.Controls.Add(this.authPictureBox);
            this.authPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authPanel.Location = new System.Drawing.Point(416, 238);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(314, 145);
            this.authPanel.TabIndex = 2;
            this.authPanel.Click += new System.EventHandler(this.authPanel_Click);
            // 
            // authLabel1
            // 
            this.authLabel1.AutoSize = true;
            this.authLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authLabel1.Location = new System.Drawing.Point(121, 51);
            this.authLabel1.Name = "authLabel1";
            this.authLabel1.Size = new System.Drawing.Size(109, 19);
            this.authLabel1.TabIndex = 1;
            this.authLabel1.Text = "Search catalog";
            this.authLabel1.Click += new System.EventHandler(this.authLabel1_Click);
            // 
            // authLabel2
            // 
            this.authLabel2.AutoSize = true;
            this.authLabel2.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authLabel2.Location = new System.Drawing.Point(116, 59);
            this.authLabel2.Name = "authLabel2";
            this.authLabel2.Size = new System.Drawing.Size(161, 42);
            this.authLabel2.TabIndex = 2;
            this.authLabel2.Text = "By Author";
            this.authLabel2.Click += new System.EventHandler(this.authLabel2_Click);
            // 
            // authPictureBox
            // 
            this.authPictureBox.BackgroundImage = global::LibraryApp.Properties.Resources.id_card_alt_solid;
            this.authPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.authPictureBox.Location = new System.Drawing.Point(26, 29);
            this.authPictureBox.Name = "authPictureBox";
            this.authPictureBox.Size = new System.Drawing.Size(85, 85);
            this.authPictureBox.TabIndex = 0;
            this.authPictureBox.TabStop = false;
            this.authPictureBox.Click += new System.EventHandler(this.authPictureBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Deadline Pengembalian Buku";
            // 
            // transactionGridView
            // 
            this.transactionGridView.AllowUserToAddRows = false;
            this.transactionGridView.AllowUserToDeleteRows = false;
            this.transactionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transactionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGridView.Location = new System.Drawing.Point(12, 129);
            this.transactionGridView.Name = "transactionGridView";
            this.transactionGridView.ReadOnly = true;
            this.transactionGridView.Size = new System.Drawing.Size(389, 238);
            this.transactionGridView.TabIndex = 4;
            // 
            // MainUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 379);
            this.Controls.Add(this.transactionGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.authPanel);
            this.Controls.Add(this.ttlPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - MyLibrary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainUserForm_FormClosed);
            this.Load += new System.EventHandler(this.MainUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ttlPanel.ResumeLayout(false);
            this.ttlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttlPictureBox)).EndInit();
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ttlPanel;
        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.PictureBox ttlPictureBox;
        private System.Windows.Forms.PictureBox authPictureBox;
        private System.Windows.Forms.Label ttlLabel1;
        private System.Windows.Forms.Label ttlLabel2;
        private System.Windows.Forms.Label authLabel1;
        private System.Windows.Forms.Label authLabel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView transactionGridView;
        private System.Windows.Forms.Label uidLabel;
    }
}