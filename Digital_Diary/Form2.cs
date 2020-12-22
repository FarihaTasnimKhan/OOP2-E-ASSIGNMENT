using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Diary
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        { 
                string gen = null;
            if (radioButton1.Checked)
            {
                gen ="Female";
            }
            else
            {
                gen = "Male";
            }

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO Users(Name,Password,Email,DateOfBirth,Gender,BloodGroup) VALUES('"+NameTextBox.Text+"','"+PasswordTextBox.Text+"','"+EmailTextBox.Text+"','"+dateTimePicker1.Text+"','"+gen+"','"+comboBox1.Text+"')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
               
                {
                    if (NameTextBox.Text == "")
                    {
                           
                        MessageBox.Show("You have not given any name in the provided space");
                    }
                    else if (PasswordTextBox.Text == "")
                    {
                           
                        MessageBox.Show("You have not given any passsword in the provided space");
                    }
                    else if (ConfirmPasswordTextBox.Text == "")
                    {
                           
                        MessageBox.Show("You have not confirmed your password in the provided space");
                    }
                    else if (EmailTextBox.Text == "")
                    {
                        MessageBox.Show("You have not given your email in the provided space");
                    }
                    else if (radioButton1.Checked == false && radioButton2.Checked == false)
                    {
                        MessageBox.Show("Error!!\nThe password you have typed does not match with the password you have confirmed.\nPlease type again.");
                    }
                    else if (checkBox1.Checked == false)
                    {
                        MessageBox.Show("You have not agreed to the terms and conditions!!!!");
                    }
                    else
                    {
                        MessageBox.Show("Your sign up is successfully done!!!");
                        Form3 fm3 = new Form3();
                        
                        fm3.Show();
                        this.Hide();
                    }
                }
                
            }

            else
            {
                MessageBox.Show("Error!!!\nYour sign up was not successful.\nPlease try again.");
                Form2 fm2 = new Form2();
                fm2.Show();
                this.Hide();
            }

        }
    }
}
