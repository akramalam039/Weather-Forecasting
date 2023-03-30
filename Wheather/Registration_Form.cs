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
using System.Text.RegularExpressions;
using System.Configuration;

namespace Wheather
{
    public partial class Registration_Form : Form
    {
        string cssw = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        public Registration_Form()
        {
            InitializeComponent();
            Country_List country_List = new Country_List();
            var sourse = country_List.Co_List();

            countrycomboBox.DataSource = sourse;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gendercomboBox.SelectedIndex == 0)
            {
                //MessageBox.Show("Please Select Gender...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(passowrdtextBox1.UseSystemPasswordChar==true && passowrdtextBox2.UseSystemPasswordChar == true)
            {
                passowrdtextBox1.UseSystemPasswordChar = false;
                passowrdtextBox2.UseSystemPasswordChar = false;
            }
            else if (passowrdtextBox1.UseSystemPasswordChar == false && passowrdtextBox2.UseSystemPasswordChar == false)
            {
                passowrdtextBox1.UseSystemPasswordChar = true;
                passowrdtextBox2.UseSystemPasswordChar = true;

            }
        }

        private void passowrdtextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log_In log_In = new Log_In();
            log_In.Show();
            this.Hide();
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {
            string email = usernamebox.Text;
            string regex = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
            if (Regex.Match(email, regex).Success)
            {
                button2.Visible = true;
                button3.Visible = false;
                button2.Location = button3.Location;
            }
            else
            {
                button2.Visible = false;
                button3.Visible = true;
                button3.Location = button2.Location;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fname.Text = "";
            lname.Text = "";
            usernamebox.Text = "";
            passowrdtextBox1.Text = "";
            passowrdtextBox2.Text = "";
            dbotextbox.Text = "";
            countrycomboBox.SelectedIndex = 0;
            gendercomboBox.SelectedIndex=0;
            contact_no.Text = "";
            paswordmatchlable.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            radioButton1.Checked = false;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (fname.Text == "" || lname.Text=="" || usernamebox.Text=="" ||passowrdtextBox1.Text==""||passowrdtextBox2.Text=="" || gendercomboBox.SelectedIndex==0|| countrycomboBox.SelectedIndex==0)
                {
                    MessageBox.Show("Blank Field are not Allowed...");
                }
                else {
                   // SqlConnection sqlConnection = new SqlConnection("data source=localhost; database=Weather; integrated security=true;");
                    SqlConnection sqlConnection = new SqlConnection(cssw);
                    SqlCommand sqlCommand = new SqlCommand("insert into Registration_tbl (fname,lname,username,password,gender,date_brth,country,phone_number)  values('" + fname.Text + "','" + lname.Text + "','" + usernamebox.Text + "','" + passowrdtextBox1.Text + "','" + gendercomboBox.Text + "','" + dbotextbox.Text + "','" + countrycomboBox.Text + "','" + contact_no.Text + "') ", sqlConnection);
                    sqlConnection.Open();
                    int a = sqlCommand.ExecuteNonQuery();
                    if (a > 0)
                    {
                        DialogResult dialogResult = new DialogResult();
                        dialogResult = MessageBox.Show("Registration Sucessfully Do you want to Log In......", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Log_In log_In = new Log_In();
                            log_In.Show();
                            this.Hide();
                        }
                        else
                        {
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
                }
                


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Term_C term_C = new Term_C();
            term_C.Show();

        }

        private void contact_no_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < contact_no.TextLength; i++)
            {


                if (!char.IsDigit(contact_no.Text[i]))
                {
                    MessageBox.Show("Only Numbers Are Allowed");
                }
            }
        }

        private void passowrdtextBox2_TextChanged_1(object sender, EventArgs e)
        {
            paswordmatchlable.Visible = true;
            if (((passowrdtextBox1.Text.Length<8 && passowrdtextBox2.Text.Length<8) || (passowrdtextBox2.Text.Length > 20 && passowrdtextBox1.Text.Length>20)))
            {
                paswordmatchlable.Text = "Password Should be in 8 to 20 Letters";
             }
            else
            {
                if (passowrdtextBox1.Text.Equals(passowrdtextBox2.Text))
                {
                    paswordmatchlable.Text = "Password Match Succusfully";
                }
                else if (!passowrdtextBox1.Text.Equals(passowrdtextBox2.Text))
                {
                    paswordmatchlable.Text = "Password Did't Match";
                    paswordmatchlable.ForeColor = Color.Red;
                }
                else if (passowrdtextBox1.Text == "" || passowrdtextBox2.Text == "")
                {
                    paswordmatchlable.Text = "";
                }
            }
        }
    }
}
