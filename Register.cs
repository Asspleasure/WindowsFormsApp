using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void backToSignUn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn sign = new SignIn();
            sign.Show();
        }

        private bool checkUser()
        {
            string query = $"SELECT * FROM `data_users` WHERE `login` = @uL";
            MySqlCommand command = new MySqlCommand(query, SqlServer.mySqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox1.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("The user has been signed up!");
                return true;
            }
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO data_users(login, pass) VALUES (@login, @pass)";
            MySqlCommand command = new MySqlCommand(query,SqlServer.mySqlConnection);

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text;

            if (checkUser()) return;

            SqlServer.OpenServer();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Account has been created!");
            else
                MessageBox.Show("Not created");
            SqlServer.CloseServer();
        }
    }
}
