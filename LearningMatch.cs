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
    public partial class LearningMatch : Form
    {
        public LearningMatch()
        {
            InitializeComponent();
        }

        private void LearningMatch_Load(object sender, EventArgs e)
        {
            
        }
        Point lastPoint;

        private void LearningMatch_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LearningMatch_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void back_Click(object sender, EventArgs e)
        {
            DialogResult res =  MessageBox.Show("Are you sure", "Warning", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
        }

        private void takePicturesGroup_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
