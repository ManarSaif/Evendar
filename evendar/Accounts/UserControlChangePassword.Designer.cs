namespace evendar
{
    partial class UserControlChangePassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelEasyPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelNoMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Location = new System.Drawing.Point(150, 230);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(94, 29);
            this.btnSavePassword.TabIndex = 0;
            this.btnSavePassword.Text = "Save";
            this.btnSavePassword.UseVisualStyleBackColor = true;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(174, 99);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(125, 27);
            this.txtNewPassword.TabIndex = 1;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(43, 102);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(104, 20);
            this.labelNewPassword.TabIndex = 2;
            this.labelNewPassword.Text = "New Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(174, 152);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(125, 27);
            this.txtConfirmPassword.TabIndex = 1;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(20, 152);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(127, 20);
            this.labelConfirmPassword.TabIndex = 2;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // labelEasyPassword
            // 
            this.labelEasyPassword.AutoSize = true;
            this.labelEasyPassword.BackColor = System.Drawing.SystemColors.Control;
            this.labelEasyPassword.ForeColor = System.Drawing.Color.Red;
            this.labelEasyPassword.Location = new System.Drawing.Point(81, 326);
            this.labelEasyPassword.Name = "labelEasyPassword";
            this.labelEasyPassword.Size = new System.Drawing.Size(239, 20);
            this.labelEasyPassword.TabIndex = 2;
            this.labelEasyPassword.Text = "Your Password isn\'t Strong Enough ";
            this.labelEasyPassword.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Password Must Contain Atleast One Capital Letter";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelNoMatch
            // 
            this.labelNoMatch.AutoSize = true;
            this.labelNoMatch.ForeColor = System.Drawing.Color.Red;
            this.labelNoMatch.Location = new System.Drawing.Point(103, 31);
            this.labelNoMatch.Name = "labelNoMatch";
            this.labelNoMatch.Size = new System.Drawing.Size(240, 20);
            this.labelNoMatch.TabIndex = 4;
            this.labelNoMatch.Text = "Password Dosent Match each other";
            // 
            // UserControlChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNoMatch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEasyPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnSavePassword);
            this.Name = "UserControlChangePassword";
            this.Size = new System.Drawing.Size(438, 437);
            this.Load += new System.EventHandler(this.UserControlChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSavePassword;
        private TextBox txtNewPassword;
        private Label labelNewPassword;
        private TextBox txtConfirmPassword;
        private Label labelConfirmPassword;
        private Label labelEasyPassword;
        private Label label1;
        private Button btnClear;
        private Label labelNoMatch;
    }
}
