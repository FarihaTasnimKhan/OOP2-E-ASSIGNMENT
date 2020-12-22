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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
           
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Event"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO Event(Date,Event,Importance) VALUES('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
          

         if (result > 0)
            {

                {
                    if (textBox1.Text == "")
                    {

                        MessageBox.Show("You have not written any event in the provided space");
                    }
                    else if (dateTimePicker1.Text == "")
                    {

                        MessageBox.Show("You have not set the date in the provided space");
                    }
                    else if (comboBox1.Text == "")
                    {

                        MessageBox.Show("You have not set your importance in the provided space");
                    }
                    
                    else
                    {
                        MessageBox.Show("Your event is successfully created!!!");
                    
                    }
                }

            }

            else
            {
                MessageBox.Show("Error!!!.\nEvent could not be saved.\nPlease try again.");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|ALL Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                pictureBox1.ImageLocation = picPath;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();

            fm3.Show();
            this.Hide();
        }

     
    }
}
