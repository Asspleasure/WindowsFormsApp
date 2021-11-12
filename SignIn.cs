using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private async void CheckFields()
        {
            await Task.Run(() =>
            {
                bool CHECK = true;
                while(CHECK)
                {
                    if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
                    {
                        emptyLogin.Invoke(new Action(() => emptyLogin.Visible = true));
                        emptyPass.Invoke(new Action(() => emptyPass.Visible = true));
                        CHECK = false;
                    }
                    else
                    {
                        emptyLogin.Invoke(new Action(() => emptyLogin.Visible = false));
                        emptyPass.Invoke(new Action(() => emptyPass.Visible = false));
                    }

                    if (textBoxLogin.Text == "")
                    {
                        emptyLogin.Invoke(new Action(() => emptyLogin.Visible = true));
                        CHECK = false;
                    }
                    else emptyLogin.Invoke(new Action(() => emptyLogin.Visible = false));

                    if (textBoxPassword.Text == "")
                    {
                        emptyPass.Invoke(new Action(() => emptyPass.Visible = true));
                        CHECK = false;
                    }
                    else emptyPass.Invoke(new Action(() => emptyPass.Visible = false));
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckFields();

            if (textBoxLogin.Text == "" || textBoxPassword.Text == "") return;

            try
            {
                var userSignIn = SqlServer.SelectAllUsers();
                foreach (var i in userSignIn)
                {
                    if (textBoxLogin.Text.Equals(i.Key) && textBoxPassword.Text.Equals(i.Value))
                    {
                        this.Hide();
                        Menu menu = new Menu();
                        menu.Show();
                        return;
                    }
                }

                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxLogin.Focus();
                MessageBox.Show("Uncorrect password or login");
            }
            catch(Exception)
            {
                
            }
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
