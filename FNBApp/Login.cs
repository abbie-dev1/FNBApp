using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNBApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DB Location connect
            string dbConnect = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banking;Integrated Security=True";

            //Connect and open DB
            SqlConnection connect = new SqlConnection(dbConnect);
            connect.Open();

            //Query DB table
            string query = "SELECT * FROM loginTbl WHERE username = '" + txtUsername.Text +
                           "'and password = '" + txtPassword.Text + "'";

            //Values entered from the form
            SqlCommand command = new SqlCommand(query, connect);

            //Execute our query
            SqlDataReader readData;
            readData = command.ExecuteReader();

            int check = 0;
            //Check if the user is there then you should login
            while(readData.Read())
            {
                //check += 1;
                check = check + 1;
                MessageBox.Show("User successfully logged in");
            }

            //If the user exist then show me Form1 - which is our homepage
            if(check ==1)
            {
                //show Form1
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                //MessageBox.Show("User does not exist");
                MessageBox.Show("Enter valid email or password");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
