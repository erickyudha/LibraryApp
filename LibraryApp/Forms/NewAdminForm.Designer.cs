
namespace LibraryApp.Forms
{
    partial class NewAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.unameBox = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.password2 = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Admin Account";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(17, 76);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(175, 20);
            this.fName.TabIndex = 1;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(197, 76);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(175, 20);
            this.lName.TabIndex = 2;
            // 
            // unameBox
            // 
            this.unameBox.Location = new System.Drawing.Point(17, 127);
            this.unameBox.Name = "unameBox";
            this.unameBox.Size = new System.Drawing.Size(355, 20);
            this.unameBox.TabIndex = 3;
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(17, 178);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(355, 20);
            this.password1.TabIndex = 4;
            this.password1.UseSystemPasswordChar = true;
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(17, 230);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(355, 20);
            this.password2.TabIndex = 5;
            this.password2.UseSystemPasswordChar = true;
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.createBtn.Location = new System.Drawing.Point(243, 267);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(128, 35);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Create Account";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(197, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label5.Location = new System.Drawing.Point(17, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "New Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label6.Location = new System.Drawing.Point(17, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Insert Password Again";
            // 
            // NewAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 364);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.unameBox);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Admin - MyLibrary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox unameBox;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}