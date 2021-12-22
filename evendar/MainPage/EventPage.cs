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
namespace evendar.MainPage
{
    public partial class EventPage : Form
    {
        public EventPage()
        {
            InitializeComponent();
        }

        private void EventPage_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

       

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //get event name
            //get event description
            //get event location
            //get event start date
            //get event start time
            //get event end time
            //get event intersted in number
            //get event category
            //get event owner name
        }

        

        private void addToPanel()
        {
            int x = 0;
            int y = 0;
            int delta = 10;
                          
                Panel panel = new Panel();           
                //Button button = new Button ();
                Label labelName = new Label();
                labelName.AutoSize = true;
                labelName.Location = new Point( 40, y+33);
                labelName.Font = new Font(labelName.Font, FontStyle.Bold);
                labelName.Text = "Event Name "; //event name from database
                // Create mail label
                Label labelInteristedIn = new Label();
                labelInteristedIn.AutoSize = true;
                labelInteristedIn.Location = new Point(0 + 130, y + labelName.Height+40);
                labelInteristedIn.Text = "12345"; //Number of People interisted in the event From The DataBase
                // Create phone label
                Label labelCategories = new Label();
                labelCategories.AutoSize = true;
                labelCategories.Location = new Point(0 , y + labelName.Height + labelInteristedIn.Height+30);
                labelCategories.Text = "Categories"; //Categories From DataBase
                // Add controls
                //panel.Controls.Add(button);   
                panel.Controls.Add(labelName);
                panel.Controls.Add(labelInteristedIn);
                panel.Controls.Add(labelCategories);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.BackColor = Color.Blue;
                panel1.Controls.Add(panel);
                // Iterate
                int dy1 = labelName.Height + labelInteristedIn.Height + labelCategories.Height;
                int dy2 = 15;
                y += Math.Max(dy1, dy2) + delta;
                labelName.Click += new EventHandler(labelName_Click);

        }

        private void panel1_Paint_3(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <1; i++)
            {
                addToPanel();
            }
            
        }
        private void labelName_Click(object sender, EventArgs e)
        {
            
           
        }
        
        private void goToNextPage()
        {
            this.Hide();
            Form form = new FormLogin();
            form.ShowDialog(this);
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                      
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
