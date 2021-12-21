namespace evendar
{
    partial class UserControlGetUsername
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnGoToMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Username is ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(158, 167);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(125, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // btnGoToMainPage
            // 
            this.btnGoToMainPage.Location = new System.Drawing.Point(109, 250);
            this.btnGoToMainPage.Name = "btnGoToMainPage";
            this.btnGoToMainPage.Size = new System.Drawing.Size(140, 29);
            this.btnGoToMainPage.TabIndex = 2;
            this.btnGoToMainPage.Text = "Go To Main Page";
            this.btnGoToMainPage.UseVisualStyleBackColor = true;
            // 
            // UserControlGetUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGoToMainPage);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGetUsername";
            this.Size = new System.Drawing.Size(432, 445);
            this.Load += new System.EventHandler(this.UserControlGetUsername_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Button btnGoToMainPage;
    }
}
