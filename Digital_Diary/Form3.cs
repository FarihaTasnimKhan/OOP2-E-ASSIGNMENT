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
    public partial class Form3 : Form
    {
        int Id;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            connection.Open();


            SqlDataAdapter sq = new SqlDataAdapter("SELECT * FROM Event", connection);
            DataTable dt = new DataTable();
            sq.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.Show();
            this.Hide();


        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Event"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Event";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Dataload> list = new List<Dataload>();
            while (reader.Read()) 
            {
                Dataload user = new Dataload();
                user.Id = (int)reader["Id"];
                user.Date = reader["Date"].ToString();
                user.Event = reader["Event"].ToString();
                user.Picture = reader["Picture"].ToString();
                user.Importance = reader["Importance"].ToString();

                
                list.Add(user);
            }
            dataGridView1.DataSource = list;
        }

        private void Dltbutton2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Event"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM Event WHERE Id=" + Id;
            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();
            connection.Close();
            if (diary > 0)
            {
                MessageBox.Show("Diary Deleted");


            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

           SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Event"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Event SET Event ='" + textBox1.Text + "' WHERE Id = " + Id;
           
            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();
            connection.Close();
            if (diary > 0)
            {
                MessageBox.Show("Diary Updated");


            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
            MessageBox.Show("Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting.");
            Application.Exit();
        }
    }
}
