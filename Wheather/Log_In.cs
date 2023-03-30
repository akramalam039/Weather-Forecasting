using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Wheather
{
    public partial class Log_In : Form
    {
        
        public Log_In()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Please Fill the Username and Password Text Box First it is Blank...", "Blank Text Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("Please Fill the Password Text Box it is Blank...", "Blank Text Box",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if(textBox1.Text == "")
            {
                MessageBox.Show("Please Fill the Username Text Box it is Blank...", "Blank Text Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                 string cssw = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
                    // string path = Path.GetFullPath(Environment.CurrentDirectory);
                    //  string database = "Weather.mdf";
                    // SqlConnection sqlConnection = new SqlConnection(@"data source=localhost; AttachDbFilename=" + path+@"\"+database+"; integrated security=true;");
                    //SqlConnection sqlConnection = new SqlConnection("data source=localhost; database=Weather; integrated security=true;");
                    SqlConnection sqlConnection = new SqlConnection(cssw);
                    SqlCommand sqlCommand = new SqlCommand("select *from Registration_tbl where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'", sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    
                    if (sqlDataReader.HasRows)
                    {
                        Weather_Form weather = new Weather_Form();
                        weather.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User Not Found...", "Log In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }catch(Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Form registration_Form = new Registration_Form();
            registration_Form.Show();
            this.Hide();
        }
    }
}
