using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evender
{
    public partial class AccountForm : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void showcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showcheckBox.Checked)
            {
                passwordtextBox.PasswordChar = '\0';
            }
            else
            {
                passwordtextBox.PasswordChar = '*';

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtUsername.Text != "" && txtPassword.Text != "")
                {

                    cn.Open();
                    string query = "select username,password from user WHERE username ='" + TextBoxName.Text + "' AND password ='" + TextBoxpassword.Text + "'";
                    MySqlDataReader row;
                    row = cn.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {

                            username = row["username"].ToString();
                            password = row["password"].ToString();

                        }

                        MessageBox.Show("Data found you ");
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect");
                        cn.close();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }
    }
}