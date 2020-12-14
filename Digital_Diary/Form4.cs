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
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Events"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO Events(Date,Event,Importance) VALUES('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result > 0) 
                {
                    if (textBox1.Text == "")
                        MessageBox.Show("Your has not written any event yet!!");
                }
              else if (dateTimePicker1.Text == "")
                {
                    MessageBox.Show("You have not given any date.");
                }
                else
                {
                
                    MessageBox.Show("The event you created has been saved.");
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
    }
}
