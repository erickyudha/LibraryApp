
namespace LibraryApp.Forms
{
    partial class UserAuditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAuditForm));
            this.accountGrid = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // accountGrid
            // 
            this.accountGrid.AllowUserToAddRows = false;
            this.accountGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.accountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountGrid.Location = new System.Drawing.Point(13, 12);
            this.accountGrid.Name = "accountGrid";
            this.accountGrid.Size = new System.Drawing.Size(343, 537);
            this.accountGrid.TabIndex = 0;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(363, 76);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(110, 35);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Update Data";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.Location = new System.Drawing.Point(362, 35);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(110, 35);
            this.changeBtn.TabIndex = 2;
            this.changeBtn.Text = "Admin Data";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(362, 117);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(110, 35);
            this.newBtn.TabIndex = 4;
            this.newBtn.Text = "New Account";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(362, 12);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(75, 19);
            this.stateLabel.TabIndex = 5;
            this.stateLabel.Text = "User Data";
            // 
            // UserAuditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.accountGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserAuditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Audit - MyLibrary";
            this.Load += new System.EventHandler(this.UserAuditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView accountGrid;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Label stateLabel;
    }
}