using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using evendar.MainPage;
using evendar.DB;
using FluentEmail.Smtp;
using System.Net;
using System.Net.Mail;
//using AE.Net.Mail;
//using MailMessage = System.Net.Mail.MailMessage;
//using MailPriority = System.Net.Mail.MailPriority;
namespace evendar.Accounts
{
    
    public partial class UserControlCheckEmail : UserControl
    {   
        public string code="";
        public UserControlCheckEmail()
        {
            InitializeComponent();
        }        
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkEmail(txtEmail.Text) == true)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Random rd = new Random();
                        int rand_num = rd.Next(0, 9);
                        code += rand_num.ToString();
                    }
                    string username = DataBase.getUsername(txtEmail.Text);
                    string bodyMsg = "We've received a password change request for your Evendar Account. @ And This is The code please dont share it with any one @ " + code + "@ Yours, Evender Team. ";
                    bodyMsg = bodyMsg.Replace("@", "@" + System.Environment.NewLine);
                    string smtpAddress = "smtp.gmail.com";
                    int portNumber = 587;
                    bool enableSSL = true;
                    string emailFromAddress = "evendar3@gmail.com"; //Sender Email Address  
                    string password = "bvgeaxfxdgnotvok"; //Sender Password  
                    string emailToAddress = txtEmail.Text; //Receiver Email Address  
                    string subject = "Hello " + username;
                    string body = bodyMsg;
                    MailMessage mail = new MailMessage();                   
                        mail.From = new MailAddress(emailFromAddress);
                        mail.To.Add(emailToAddress);
                        mail.Subject = subject;
                        mail.Body = body;
                        mail.IsBodyHtml = true;                     
                        using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                        {
                            smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                            smtp.EnableSsl = enableSSL;
                            smtp.Send(mail);

                        }
                    
                }

            }
            catch
            {
                labelWarning.Visible = true;
            }
        }

        private void labelWarning_Click(object sender, EventArgs e)
        {

        }
    }
}
