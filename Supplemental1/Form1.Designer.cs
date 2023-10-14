namespace Supplemental1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Stage = new System.Windows.Forms.ImageList(this.components);
            this.HangMan = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.UnderLine = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.HintText = new System.Windows.Forms.Label();
            this.GenWord = new System.Windows.Forms.Button();
            this.GAMEOVER = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HangMan)).BeginInit();
            this.SuspendLayout();
            // 
            // Stage
            // 
            this.Stage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Stage.ImageStream")));
            this.Stage.TransparentColor = System.Drawing.Color.Transparent;
            this.Stage.Images.SetKeyName(0, "hang-1.png");
            this.Stage.Images.SetKeyName(1, "hang-2.png");
            this.Stage.Images.SetKeyName(2, "hang-3.png");
            this.Stage.Images.SetKeyName(3, "hang-4.png");
            this.Stage.Images.SetKeyName(4, "hang-5.png");
            this.Stage.Images.SetKeyName(5, "hang-6.png");
            this.Stage.Images.SetKeyName(6, "hang-7.png");
            // 
            // HangMan
            // 
            this.HangMan.Cursor = System.Windows.Forms.Cursors.Default;
            this.HangMan.Image = global::Supplemental1.Properties.Resources.hang_1;
            this.HangMan.Location = new System.Drawing.Point(444, 87);
            this.HangMan.Name = "HangMan";
            this.HangMan.Size = new System.Drawing.Size(109, 166);
            this.HangMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HangMan.TabIndex = 0;
            this.HangMan.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(178, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "E";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(97, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "F";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(138, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "G";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(178, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "H";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(57, 116);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "I";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(98, 116);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(34, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "J";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(138, 116);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(34, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "K";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(178, 116);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(34, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "L";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(57, 145);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(34, 23);
            this.button13.TabIndex = 13;
            this.button13.Text = "M";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(98, 145);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(34, 23);
            this.button14.TabIndex = 14;
            this.button14.Text = "N";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(138, 145);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(34, 23);
            this.button15.TabIndex = 15;
            this.button15.Text = "O";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(178, 145);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(34, 23);
            this.button16.TabIndex = 16;
            this.button16.Text = "P";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(57, 174);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(34, 23);
            this.button17.TabIndex = 17;
            this.button17.Text = "R";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(137, 174);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(34, 23);
            this.button18.TabIndex = 18;
            this.button18.Text = "S";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(178, 174);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(34, 23);
            this.button19.TabIndex = 19;
            this.button19.Text = "T";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(97, 203);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(34, 23);
            this.button20.TabIndex = 20;
            this.button20.Text = "U";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(57, 203);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(34, 23);
            this.button21.TabIndex = 21;
            this.button21.Text = "V";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(137, 203);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(34, 23);
            this.button22.TabIndex = 22;
            this.button22.Text = "W";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(177, 203);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(34, 23);
            this.button23.TabIndex = 23;
            this.button23.Text = "X";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(57, 232);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(34, 23);
            this.button24.TabIndex = 24;
            this.button24.Text = "Y";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(98, 232);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(34, 23);
            this.button25.TabIndex = 25;
            this.button25.Text = "Z";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(97, 174);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(32, 23);
            this.button27.TabIndex = 27;
            this.button27.Text = "Q";
            this.button27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.CommonButtonClickHandler);
            // 
            // UnderLine
            // 
            this.UnderLine.AutoSize = true;
            this.UnderLine.Location = new System.Drawing.Point(424, 256);
            this.UnderLine.Name = "UnderLine";
            this.UnderLine.Size = new System.Drawing.Size(0, 15);
            this.UnderLine.TabIndex = 28;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(441, 66);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 15);
            this.answer.TabIndex = 29;
            // 
            // HintText
            // 
            this.HintText.AutoSize = true;
            this.HintText.Location = new System.Drawing.Point(54, 294);
            this.HintText.Name = "HintText";
            this.HintText.Size = new System.Drawing.Size(39, 15);
            this.HintText.TabIndex = 30;
            this.HintText.Text = "Hint";
            // 
            // GenWord
            // 
            this.GenWord.Location = new System.Drawing.Point(607, 145);
            this.GenWord.Name = "GenWord";
            this.GenWord.Size = new System.Drawing.Size(141, 23);
            this.GenWord.TabIndex = 31;
            this.GenWord.Text = "Get A New Word!";
            this.GenWord.UseVisualStyleBackColor = true;
            this.GenWord.Click += new System.EventHandler(this.GenWord_Click);
            // 
            // GAMEOVER
            // 
            this.GAMEOVER.AutoSize = true;
            this.GAMEOVER.Location = new System.Drawing.Point(604, 194);
            this.GAMEOVER.Name = "GAMEOVER";
            this.GAMEOVER.Size = new System.Drawing.Size(87, 15);
            this.GAMEOVER.TabIndex = 32;
            this.GAMEOVER.Text = "GAME OVER!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GAMEOVER);
            this.Controls.Add(this.GenWord);
            this.Controls.Add(this.HintText);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.UnderLine);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HangMan);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HangMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList Stage;
        private System.Windows.Forms.PictureBox HangMan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label UnderLine;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label HintText;
        private System.Windows.Forms.Button GenWord;
        private System.Windows.Forms.Label GAMEOVER;
    }
}

