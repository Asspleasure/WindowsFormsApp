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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Totally close main form
        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn sign = new SignIn();
            sign.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingLearn sl = new SettingLearn();
            sl.Show();
        }

        /*This chunk of code moving the form by mouse*/

        Point lastPoint; //For moving forms

        //Store cordinates when user leave a mouse
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Let moving the form
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameLearning gl = new GameLearning();
            gl.Show();
        }
    }
}
