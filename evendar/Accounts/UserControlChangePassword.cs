﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using evendar.DB;
using evendar.MainPage;
namespace evendar
{
    public partial class UserControlChangePassword : UserControl
    {
        public UserControlChangePassword()
        {
            InitializeComponent();
        }

        private void UserControlChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            try
            {
              //  accounts.changePassword(txtNewPassword.Text);
            }
            catch
            {

            }
        }
    }
}