using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp
{
    public partial class writeCurrentWord : Form
    {
        public writeCurrentWord()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        Dictionary<string, string> filesWord = new Dictionary<string, string>(); //
        string[] wordsEng = File.ReadAllLines("WordsENG.txt");
        string[] wordsRu = File.ReadAllLines("WordsRu22.txt");
        int currentWord;

        private void takingRandomWord()
        {
            if(FullRandom.Amount != 0)
            {
                for (int i = 0; i < FullRandom.Amount; i++)
                {
                    currentWord = rnd.Next(0, wordsEng.Length);
                    SettingLearn.wordsForLearning.Add(wordsEng[currentWord]);
                }
            }
            FullRandom.Amount = 0;
            currentWord = rnd.Next(0, SettingLearn.wordsForLearning.Count - 1);

            for (int i = 0; i < filesWord.Count; i++)
            {
                if (Equals(SettingLearn.wordsForLearning[currentWord], wordsEng[i]))
                {
                    guessWord.Text = filesWord[wordsEng[i]];
                    break;
                }
            }
        }

        private void writeCurrentWord_Load(object sender, EventArgs e)
        {
            string enteredWord = fieldEnteredWord.Text.Trim().ToLower();
            enteredWord = Regex.Replace(enteredWord, "[ ]+", " ");

            for (int i = 0; i < wordsEng.Length; i++)
            {
                filesWord.Add(wordsEng[i], wordsRu[i]); //Additing to the dictionary
            }

            takingRandomWord();
        }

        private void back_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            string enteredWordByUser = fieldEnteredWord.Text.Trim().ToLower();
            enteredWordByUser = Regex.Replace(enteredWordByUser, "[ ]+", " ");

            if (Equals(enteredWordByUser, SettingLearn.wordsForLearning[currentWord]))
            {
                SettingLearn.wordsForLearning.RemoveAt(currentWord);
                MessageBox.Show("CORRECT WORD", "СONGRADULATION", MessageBoxButtons.OK); fieldEnteredWord.Text = string.Empty;
                if(SettingLearn.wordsForLearning.Count != 0) takingRandomWord();
            }

            else if (string.IsNullOrEmpty(fieldEnteredWord.Text)) MessageBox.Show("Box is empty", "", MessageBoxButtons.OK);

            else { MessageBox.Show("INCORRECT WORD", "DONT GET UP SET", MessageBoxButtons.OK); fieldEnteredWord.Text = string.Empty; }

            if (SettingLearn.wordsForLearning.Count == 0) 
            { 
                this.Hide();
                SettingLearn sl = new SettingLearn();
                sl.Show(); 
                return; 
            }

            fieldEnteredWord.Focus();
        }

        Point lastPoint;

        private void buttonSkipWord_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{SettingLearn.wordsForLearning[currentWord]} - {guessWord.Text}", "Help", MessageBoxButtons.OK);
            SettingLearn.wordsForLearning.RemoveAt(currentWord);
            if (SettingLearn.wordsForLearning.Count != 0) takingRandomWord();
            else
            {
                this.Hide();
                SettingLearn sl = new SettingLearn();
                sl.Show();
                return;
            }
        }

        /*private void writeCurrentWord_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }*/

        private void writeCurrentWord_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

    }
}
