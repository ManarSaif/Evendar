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
using AE.Net.Mail;
using MailMessage = System.Net.Mail.MailMessage;
using MailPriority = System.Net.Mail.MailPriority;

namespace evendar
{
    public partial class FormRecoverAccount : Form
    {
        public string code="";
        public FormRecoverAccount()
        {
            InitializeComponent();
        }

        private void FormRecoverAccount_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSendCode_Click(object sender, EventArgs e)
        {
           
           
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControlCheckEmail1_Load(object sender, EventArgs e)
        {

        }
    }
}

