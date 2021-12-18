
namespace LibraryApp.Forms
{
    partial class MainAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transPanel = new System.Windows.Forms.Panel();
            this.transLabel = new System.Windows.Forms.Label();
            this.transLogo = new System.Windows.Forms.PictureBox();
            this.userAuditPanel = new System.Windows.Forms.Panel();
            this.userAuditLabel = new System.Windows.Forms.Label();
            this.userAuditPic = new System.Windows.Forms.PictureBox();
            this.bookAuditPanel = new System.Windows.Forms.Panel();
            this.bookAuditLabel = new System.Windows.Forms.Label();
            this.bookAuditPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.transPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transLogo)).BeginInit();
            this.userAuditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAuditPic)).BeginInit();
            this.bookAuditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookAuditPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.roleLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 122);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!";
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(264, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(256, 327);
            this.panel6.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 324);
            this.panel2.TabIndex = 4;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(126, 79);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.roleLabel.Size = new System.Drawing.Size(72, 25);
            this.roleLabel.TabIndex = 3;
            this.roleLabel.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
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
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // transPanel
            // 
            this.transPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.transPanel.Controls.Add(this.transLabel);
            this.transPanel.Controls.Add(this.transLogo);
            this.transPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transPanel.Location = new System.Drawing.Point(0, 121);
            this.transPanel.Name = "transPanel";
            this.transPanel.Size = new System.Drawing.Size(266, 321);
            this.transPanel.TabIndex = 1;
            this.transPanel.Click += new System.EventHandler(this.transPanel_Click);
            // 
            // transLabel
            // 
            this.transLabel.AutoSize = true;
            this.transLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transLabel.Location = new System.Drawing.Point(77, 200);
            this.transLabel.Name = "transLabel";
            this.transLabel.Size = new System.Drawing.Size(110, 52);
            this.transLabel.TabIndex = 1;
            this.transLabel.Text = "Transaction\r\nMenu";
            this.transLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transLabel.Click += new System.EventHandler(this.transLabel_Click);
            // 
            // transLogo
            // 
            this.transLogo.BackColor = System.Drawing.Color.RoyalBlue;
            this.transLogo.BackgroundImage = global::LibraryApp.Properties.Resources.exchange_alt_solid;
            this.transLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transLogo.Location = new System.Drawing.Point(69, 62);
            this.transLogo.Name = "transLogo";
            this.transLogo.Size = new System.Drawing.Size(120, 120);
            this.transLogo.TabIndex = 0;
            this.transLogo.TabStop = false;
            this.transLogo.Click += new System.EventHandler(this.transLogo_Click);
            // 
            // userAuditPanel
            // 
            this.userAuditPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.userAuditPanel.Controls.Add(this.userAuditLabel);
            this.userAuditPanel.Controls.Add(this.userAuditPic);
            this.userAuditPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userAuditPanel.Location = new System.Drawing.Point(519, 121);
            this.userAuditPanel.Name = "userAuditPanel";
            this.userAuditPanel.Size = new System.Drawing.Size(266, 322);
            this.userAuditPanel.TabIndex = 2;
            this.userAuditPanel.Click += new System.EventHandler(this.userAuditPanel_Click);
            // 
            // userAuditLabel
            // 
            this.userAuditLabel.AutoSize = true;
            this.userAuditLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAuditLabel.Location = new System.Drawing.Point(87, 200);
            this.userAuditLabel.Name = "userAuditLabel";
            this.userAuditLabel.Size = new System.Drawing.Size(97, 52);
            this.userAuditLabel.TabIndex = 1;
            this.userAuditLabel.Text = "User Data\r\nAudit";
            this.userAuditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userAuditLabel.Click += new System.EventHandler(this.userAuditLabel_Click);
            // 
            // userAuditPic
            // 
            this.userAuditPic.BackgroundImage = global::LibraryApp.Properties.Resources.users_solid;
            this.userAuditPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userAuditPic.Location = new System.Drawing.Point(74, 62);
            this.userAuditPic.Name = "userAuditPic";
            this.userAuditPic.Size = new System.Drawing.Size(120, 120);
            this.userAuditPic.TabIndex = 0;
            this.userAuditPic.TabStop = false;
            this.userAuditPic.Click += new System.EventHandler(this.userAuditPic_Click);
            // 
            // bookAuditPanel
            // 
            this.bookAuditPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bookAuditPanel.Controls.Add(this.bookAuditLabel);
            this.bookAuditPanel.Controls.Add(this.bookAuditPic);
            this.bookAuditPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookAuditPanel.Location = new System.Drawing.Point(266, 121);
            this.bookAuditPanel.Name = "bookAuditPanel";
            this.bookAuditPanel.Size = new System.Drawing.Size(253, 321);
            this.bookAuditPanel.TabIndex = 3;
            this.bookAuditPanel.Click += new System.EventHandler(this.bookAuditPanel_Click);
            // 
            // bookAuditLabel
            // 
            this.bookAuditLabel.AutoSize = true;
            this.bookAuditLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuditLabel.Location = new System.Drawing.Point(78, 200);
            this.bookAuditLabel.Name = "bookAuditLabel";
            this.bookAuditLabel.Size = new System.Drawing.Size(101, 52);
            this.bookAuditLabel.TabIndex = 1;
            this.bookAuditLabel.Text = "Book Data\r\nAudit";
            this.bookAuditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bookAuditLabel.Click += new System.EventHandler(this.bookAuditLabel_Click);
            // 
            // bookAuditPic
            // 
            this.bookAuditPic.BackgroundImage = global::LibraryApp.Properties.Resources.book_solid;
            this.bookAuditPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookAuditPic.Location = new System.Drawing.Point(70, 62);
            this.bookAuditPic.Name = "bookAuditPic";
            this.bookAuditPic.Size = new System.Drawing.Size(120, 120);
            this.bookAuditPic.TabIndex = 0;
            this.bookAuditPic.TabStop = false;
            this.bookAuditPic.Click += new System.EventHandler(this.bookAuditPic_Click);
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.bookAuditPanel);
            this.Controls.Add(this.userAuditPanel);
            this.Controls.Add(this.transPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page - MyLibrary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainAdminForm_FormClosed);
            this.Load += new System.EventHandler(this.MainAdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.transPanel.ResumeLayout(false);
            this.transPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transLogo)).EndInit();
            this.userAuditPanel.ResumeLayout(false);
            this.userAuditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAuditPic)).EndInit();
            this.bookAuditPanel.ResumeLayout(false);
            this.bookAuditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookAuditPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel transPanel;
        private System.Windows.Forms.PictureBox transLogo;
        private System.Windows.Forms.Panel userAuditPanel;
        private System.Windows.Forms.Panel bookAuditPanel;
        private System.Windows.Forms.PictureBox userAuditPic;
        private System.Windows.Forms.PictureBox bookAuditPic;
        private System.Windows.Forms.Label transLabel;
        private System.Windows.Forms.Label bookAuditLabel;
        private System.Windows.Forms.Label userAuditLabel;
    }
}