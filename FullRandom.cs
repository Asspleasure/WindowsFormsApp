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
    public partial class FullRandom : Form
    {
        public static int Amount { get; set; }

        public FullRandom()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                Amount = Convert.ToInt32(textBoxAmount.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Enter a value!", "Warning", MessageBoxButtons.OK);
                return;
            }
            if (Amount == 0) MessageBox.Show("Zero not match!", "Warning", MessageBoxButtons.OK);
            else
            {
                this.Close();
                Application.OpenForms["SettingLearn"].Close(); //
                writeCurrentWord wCW = new writeCurrentWord();
                wCW.ShowDialog();
            }
        }
    }
}
