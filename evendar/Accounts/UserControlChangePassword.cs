using System;
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
            if (txtConfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("You Must Enter a Password");
                return;
            }
            else if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                labelNoMatch.Visible = true;
                return;
            }
            else if (txtConfirmPassword.Text.Length >= 8)
            {
                labelEasyPassword.Visible = true;
                return;
            }
            try
            {
                DataBase.changePass(Name, txtNewPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            labelConfirmPassword.Visible = false;
            labelEasyPassword.Visible = false;
            labelNoMatch.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
