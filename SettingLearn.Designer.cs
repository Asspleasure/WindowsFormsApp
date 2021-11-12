namespace WindowsFormsApp
{
    partial class SettingLearn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnteredWords = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFullRandom = new System.Windows.Forms.Button();
            this.appearingList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a word (the words) you want to learn";
            // 
            // textBoxEnteredWords
            // 
            this.textBoxEnteredWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnteredWords.Location = new System.Drawing.Point(34, 55);
            this.textBoxEnteredWords.Multiline = true;
            this.textBoxEnteredWords.Name = "textBoxEnteredWords";
            this.textBoxEnteredWords.Size = new System.Drawing.Size(608, 60);
            this.textBoxEnteredWords.TabIndex = 1;
            this.textBoxEnteredWords.TextChanged += new System.EventHandler(this.textBoxEnteredWords_TextChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Snow;
            this.back.Location = new System.Drawing.Point(15, 384);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(130, 44);
            this.back.TabIndex = 2;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Snow;
            this.next.Location = new System.Drawing.Point(660, 384);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(128, 44);
            this.next.TabIndex = 3;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFullRandom
            // 
            this.buttonFullRandom.BackColor = System.Drawing.Color.White;
            this.buttonFullRandom.Location = new System.Drawing.Point(338, 384);
            this.buttonFullRandom.Name = "buttonFullRandom";
            this.buttonFullRandom.Size = new System.Drawing.Size(141, 44);
            this.buttonFullRandom.TabIndex = 5;
            this.buttonFullRandom.Text = "FULL RANDOM";
            this.buttonFullRandom.UseVisualStyleBackColor = false;
            this.buttonFullRandom.Click += new System.EventHandler(this.buttonFullRandom_Click);
            // 
            // appearingList
            // 
            this.appearingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appearingList.FormattingEnabled = true;
            this.appearingList.ItemHeight = 24;
            this.appearingList.Location = new System.Drawing.Point(640, 55);
            this.appearingList.Name = "appearingList";
            this.appearingList.Size = new System.Drawing.Size(148, 28);
            this.appearingList.TabIndex = 6;
            this.appearingList.Visible = false;
            this.appearingList.DoubleClick += new System.EventHandler(this.appearingList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(34, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 112);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(744, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 9;
            // 
            // SettingLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appearingList);
            this.Controls.Add(this.buttonFullRandom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.textBoxEnteredWords);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingLearn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingLearn";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingLearn_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingLearn_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnteredWords;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFullRandom;
        private System.Windows.Forms.ListBox appearingList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}