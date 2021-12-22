namespace evendar
{
    partial class FormRecoverAccount
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
            this.userControlChangePassword1 = new evendar.UserControlChangePassword();
            this.userControlCode1 = new evendar.UserControlCode();
            this.userControlGetUsername1 = new evendar.UserControlGetUsername();
            this.userControlCheckEmail1 = new evendar.Accounts.UserControlCheckEmail();
            this.SuspendLayout();
            // 
            // userControlChangePassword1
            // 
            this.userControlChangePassword1.Location = new System.Drawing.Point(-4, 0);
            this.userControlChangePassword1.Name = "userControlChangePassword1";
            this.userControlChangePassword1.Size = new System.Drawing.Size(548, 546);
            this.userControlChangePassword1.TabIndex = 11;
            // 
            // userControlCode1
            // 
            this.userControlCode1.Location = new System.Drawing.Point(-4, 0);
            this.userControlCode1.Name = "userControlCode1";
            this.userControlCode1.Size = new System.Drawing.Size(488, 534);
            this.userControlCode1.TabIndex = 12;
            // 
            // userControlGetUsername1
            // 
            this.userControlGetUsername1.Location = new System.Drawing.Point(-4, 0);
            this.userControlGetUsername1.Name = "userControlGetUsername1";
            this.userControlGetUsername1.Size = new System.Drawing.Size(540, 534);
            this.userControlGetUsername1.TabIndex = 13;
            // 
            // userControlCheckEmail1
            // 
            this.userControlCheckEmail1.Location = new System.Drawing.Point(0, 0);
            this.userControlCheckEmail1.Name = "userControlCheckEmail1";
            this.userControlCheckEmail1.Size = new System.Drawing.Size(560, 538);
            this.userControlCheckEmail1.TabIndex = 14;
            this.userControlCheckEmail1.Load += new System.EventHandler(this.userControlCheckEmail1_Load);
            // 
            // FormRecoverAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 537);
            this.Controls.Add(this.userControlCheckEmail1);
            this.Controls.Add(this.userControlGetUsername1);
            this.Controls.Add(this.userControlCode1);
            this.Controls.Add(this.userControlChangePassword1);
            this.Name = "FormRecoverAccount";
            this.Text = "FormRecoverAccount";
            this.Load += new System.EventHandler(this.FormRecoverAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControlChangePassword userControlChangePassword1;
        private UserControlCode userControlCode1;
        private UserControlGetUsername userControlGetUsername1;
        private Accounts.UserControlCheckEmail userControlCheckEmail1;
    }
}