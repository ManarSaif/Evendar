namespace evendar.Accounts
{
    partial class UserControlCheckEmail
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
            this.btnSendCode = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendCode
            // 
            this.btnSendCode.Location = new System.Drawing.Point(141, 262);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(137, 29);
            this.btnSendCode.TabIndex = 14;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(190, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 27);
            this.txtEmail.TabIndex = 13;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.SystemColors.Control;
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(52, 91);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(263, 20);
            this.labelWarning.TabIndex = 11;
            this.labelWarning.Text = "This Email Dosen\'t Exist In Our System!";
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWarning.Visible = false;
            this.labelWarning.Click += new System.EventHandler(this.labelWarning_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(89, 180);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 20);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "email";
            // 
            // UserControlCheckEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.labelEmail);
            this.Name = "UserControlCheckEmail";
            this.Size = new System.Drawing.Size(448, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSendCode;
        private TextBox txtEmail;
        private Label labelWarning;
        private Label labelEmail;
    }
}
