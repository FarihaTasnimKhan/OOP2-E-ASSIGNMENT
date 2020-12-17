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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
           
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Name = '" + NameTextBox.Text + "' AND [Password] = '" + PasswordTextBox.Text + "' ", sqlcon);
            sqlcon.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                Form1 fm1 = new Form1();
                this.Hide();
                fm1.Show();

            }
            else
            {
                MessageBox.Show("Error!!\nWrong name and password\nPlease try again!!");
            }


            if (NameTextBox.Text == "")
            {
                MessageBox.Show("You have not given your name in the provided space.");
            }
            else if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("You have not given your password in the provided space.");
            }
            else if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Error!!!\nThe passwords do not match!!");
            }
            else
            {
                Form3 fm3 = new Form3();
                fm3.Show();
                this.Hide();
            }
        }
    }
}
