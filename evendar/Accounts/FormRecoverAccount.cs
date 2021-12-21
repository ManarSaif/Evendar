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
namespace evendar
{
    public partial class FormRecoverAccount : Form
    {
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
            bool i= DataBase.checkEmail(txtEmail.Text);
            if (i==true)
            {
                //random number and send as email
            }
            else
            {
                labelWarning.Visible = true;   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            labelWarning.Visible = false;
        }
    }
}
