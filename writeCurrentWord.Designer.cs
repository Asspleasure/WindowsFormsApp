
namespace WindowsFormsApp
{
    partial class writeCurrentWord
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
            this.fieldEnteredWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guessWord = new System.Windows.Forms.Label();
            this.buttonSkipWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fieldEnteredWord
            // 
            this.fieldEnteredWord.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldEnteredWord.Location = new System.Drawing.Point(294, 319);
            this.fieldEnteredWord.Name = "fieldEnteredWord";
            this.fieldEnteredWord.Size = new System.Drawing.Size(207, 22);
            this.fieldEnteredWord.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.back_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.check_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(226, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Write a translation of the word";
            // 
            // guessWord
            // 
            this.guessWord.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guessWord.Location = new System.Drawing.Point(294, 193);
            this.guessWord.Name = "guessWord";
            this.guessWord.Size = new System.Drawing.Size(207, 54);
            this.guessWord.TabIndex = 5;
            this.guessWord.Text = "guessWord";
            this.guessWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSkipWord
            // 
            this.buttonSkipWord.Location = new System.Drawing.Point(365, 393);
            this.buttonSkipWord.Name = "buttonSkipWord";
            this.buttonSkipWord.Size = new System.Drawing.Size(75, 23);
            this.buttonSkipWord.TabIndex = 6;
            this.buttonSkipWord.Text = "Skip";
            this.buttonSkipWord.UseVisualStyleBackColor = true;
            this.buttonSkipWord.Click += new System.EventHandler(this.buttonSkipWord_Click);
            // 
            // writeCurrentWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSkipWord);
            this.Controls.Add(this.guessWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fieldEnteredWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "writeCurrentWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "writeCurrentWord";
            this.Load += new System.EventHandler(this.writeCurrentWord_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.writeCurrentWord_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fieldEnteredWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label guessWord;
        private System.Windows.Forms.Button buttonSkipWord;
    }
}