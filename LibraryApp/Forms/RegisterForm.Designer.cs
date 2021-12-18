
namespace LibraryApp.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibraryApp.Properties.Resources.library;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 454);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.regBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.password2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.uname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.fName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(409, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 364);
            this.panel1.TabIndex = 1;
            // 
            // regBtn
            // 
            this.regBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.regBtn.Location = new System.Drawing.Point(180, 282);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(97, 31);
            this.regBtn.TabIndex = 11;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F);
            this.label6.Location = new System.Drawing.Point(27, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Insert Password Again";
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(31, 246);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(246, 20);
            this.password2.TabIndex = 9;
            this.password2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F);
            this.label5.Location = new System.Drawing.Point(27, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "New Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(31, 192);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(246, 20);
            this.password.TabIndex = 7;
            this.password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F);
            this.label4.Location = new System.Drawing.Point(27, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(31, 138);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(246, 20);
            this.uname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.Location = new System.Drawing.Point(154, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(157, 86);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(120, 20);
            this.lName.TabIndex = 2;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(31, 86);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(120, 20);
            this.fName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register New Account";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register - MyLibrary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label3;
    }
}