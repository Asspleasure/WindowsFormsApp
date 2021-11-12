using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace WindowsFormsApp
{
    public partial class SettingLearn : Form
    {
        int height = 0;
        int width = 0;
        int widthSecondRow = 0;
        Point lastPoint;
        [DllImport("user32")]
        private extern static int GetCaretPos(out Point p);

        public static List<string> wordsForLearning = new List<string>(); //

        public SettingLearn()
        {
            InitializeComponent();
        }

        List<Button> buttonsAdded = new List<Button>();

        private void showAddedWord(string word)
        {
            Button btn = new Button();
            btn.Text = word;

            for (int i = 0; i < buttonsAdded.Count; i++)
            {
                if (panel1.Controls.Count == 0) break;
                if(btn.Text.Equals(buttonsAdded[i].Text))
                {
                    MessageBox.Show("You can't add same word!", "WARNING", MessageBoxButtons.OK);
                    return;
                }
            }
            panel1.Controls.Add(btn);

            if (panel1.Width < width + btn.Width + 10) { height = 40; width = 0; }

            btn.AutoSize = true;
            btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn.BackColor = Color.White;
            btn.TabStop = false;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.MouseOverBackColor = Color.White;
            btn.Font = new Font(btn.Font.FontFamily, 12);
            btn.Height = 30;
            btn.Location = new Point(width, height);
            width += btn.Width + 10;
            widthSecondRow += btn.Width + 10;
            btn.MouseUp += new MouseEventHandler(btn_MouseClick);
            buttonsAdded.Add(btn);
            //panel1.Controls.Add(btn); //добавляем на форму

            if(panel1.Width*2 < widthSecondRow + btn.Width + 10)
            {
                MessageBox.Show("You can't add one more a word for learning!", "WARNING", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            int i = 0;
            Control ctrl = sender as Control;
            if (e.Button == MouseButtons.Right) //
            {
                if (MessageBox.Show(ctrl.Text + " !!! Dispose !!!", " !!! Dispose !!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    panel1.Controls.Remove(ctrl);
                    ctrl.Dispose();
                    if (width > 0)
                    {
                        for (i = 0; i < buttonsAdded.Count; i++)
                        {
                            if (ctrl.Text.Equals(buttonsAdded[i].Text))
                            {
                                for (; i < buttonsAdded.Count; i++)
                                {
                                    buttonsAdded[i].Left = buttonsAdded[i].Left - ctrl.Width - 10;
                                }
                            }
                        }
                    }
                    buttonsAdded.Remove(ctrl as Button);
                }
                width -= ctrl.Width + 10;
            }
        }

        private void appearTips()
        {
            if (appearingList.Items.Count != 0) appearingList.Items.Clear();

            string query = $"SELECT englishWord FROM words WHERE englishWord LIKE '{textBoxEnteredWords.Text}%'";
            SqlServer.OpenServer();

            MySqlCommand command = new MySqlCommand(query, SqlServer.mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                appearingList.Items.Add(reader[0].ToString());
                if (appearingList.Items.Count > 7) break;
            }

            appearingList.Height = appearingList.PreferredHeight;

            //string text = appearingList.GetItemText(appearingList.SelectedItem);
            //textBoxEnteredWords.Text = text;

            SqlServer.CloseServer();
            if (textBoxEnteredWords.Text == "")
            {
                appearingList.Items.Clear();
                appearingList.Visible = false;
            }
            else appearingList.Visible = true;

            if (appearingList.Items.Count == 0)
            {
                appearingList.Visible = false;
            }

            /*Point caret;
            GetCaretPos(out caret);
            int index = textBoxEnteredWords.GetCharIndexFromPosition(caret);
            label2.Text = index.ToString();*/
        }

        private void isCheckingProcess<T>(bool rusOrEng, List<T> array)
        {
            var wordsFromDataBase = new Dictionary<string, string>();
            wordsFromDataBase  = SqlServer.SelectAllWords();
            string[] english = wordsFromDataBase.Keys.ToArray();

            var incorrectWrittenWords = new List<string>();

            int count = 0, accept = 0, j = 0;

            //char[] symbol = phrase.ToCharArray(); //Casting into separate symbol from string

            for (int i = 0; i < wordsForLearning.Count; i++)
            {
                for (j = 0; j < english.Length; j++)
                {
                    if (String.Equals(wordsForLearning[i], english[j])) { accept++; count++; }

                    if (accept == 1)
                    {
                        accept--;
                        break;
                    }
                }
                if (j == english.Length) incorrectWrittenWords.Add(wordsForLearning[i]);
            }

            if (wordsForLearning.Count != count)
            {
                string incorrectWords = string.Join(", ", incorrectWrittenWords);
                MessageBox.Show($"You've written some following wrong words: {incorrectWords}", "WARNING", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                writeCurrentWord lm = new writeCurrentWord();
                lm.Show();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void next_Click(object sender, EventArgs e)
        {
            var phrase = buttonsAdded.Select(i => i.Text).ToArray(); //Data was entered by user

            wordsForLearning = phrase.ToList(); //Words have been written by user some count

            if (wordsForLearning.Count == 0)
            {
                MessageBox.Show($"The leabel is empty", "WARNING", MessageBoxButtons.OK);
                return;
            }

            bool languageRusOrEng = Regex.IsMatch(textBoxEnteredWords.Text, @"[a-zA-Z]");
            if (languageRusOrEng) isCheckingProcess(languageRusOrEng, wordsForLearning);
            else isCheckingProcess(languageRusOrEng, wordsForLearning);
        }

        private void SettingLearn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SettingLearn_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxEnteredWords.Text = string.Empty;
        }

        private void buttonFullRandom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEnteredWords.Text))
            {
                MessageBox.Show("Clear the text field!", "Warning", MessageBoxButtons.OK);
                return;
            }
            /*DialogResult res = MessageBox.Show($"Write a number of words", "", MessageBoxButtons.OKCancel);
            if(res == DialogResult.OK)
            {

            }*/
            FullRandom fullRandom = new FullRandom();
            
            fullRandom.Show();
            
            
            //testDialog.Dispose();
        }

        private void appearingList_DoubleClick(object sender, EventArgs e)
        {
            showAddedWord(appearingList.GetItemText(appearingList.SelectedItem)); //After writing the word, we can look added word which we will learn
            textBoxEnteredWords.Text =  appearingList.GetItemText(appearingList.SelectedItem);
            appearingList.Visible = false;
            appearingList.Items.Clear();
            //textBoxEnteredWords.Select(textBoxEnteredWords.Text.Length, textBoxEnteredWords.Text.Length);
            textBoxEnteredWords.Text = "";
        }

        private void textBoxEnteredWords_TextChanged(object sender, EventArgs e)
        {
            appearTips();
        }

        
        /*private void appearingList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush b = (e.Index == ((ListBox)sender).SelectedIndex ? Brushes.White : Brushes.Black);
            e.DrawBackground();
            e.DrawFocusRectangle();
            //e.Graphics.DrawString(data[e.Index], new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold), new SolidBrush(color[e.Index]), e.Bounds);
            e.Graphics.DrawString(appearingList.Items[e.Index].ToString(), e.Font, b, new Rectangle(new Point(e.Bounds.X, e.Bounds.Y + 2), e.Bounds.Size));
        }*/

        //private int ItemMargin = 5;

        /*private void appearingList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            //e.ItemHeight = 22;
            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;
            string txt = (string)lst.Items[e.Index];

            // Measure the string.
            SizeF txt_size = e.Graphics.MeasureString(txt, this.Font);

            // Set the required size.
            e.ItemHeight = (int)txt_size.Height + 2 * ItemMargin;
            e.ItemWidth = (int)txt_size.Width;
        }*/
    }
}
