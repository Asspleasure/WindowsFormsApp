using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userSignIn = SqlServer.SelectAllUsers();
            foreach (var i in userSignIn)
            {
                if (textBox1.Text.Equals(i.Key) && textBox2.Text.Equals(i.Value))
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                    return;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
            MessageBox.Show("Uncorrect password or login");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }

        private void exitFromProgramm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
