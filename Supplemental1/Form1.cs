    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

    namespace Supplemental1
    {
        public partial class Form1 : Form
        { 
        private string hint;
        private string word;
        private ArrayList Answer = new ArrayList();
        private int StageCount = 0;
        private Random random = new Random();
        private int index;
        private string[] words = {
                "apple", "banana", "chocolate", "dog", "elephant",
                "football", "guitar", "happiness", "internet", "jazz"
            };

        private string[] hints = {
                "a fruit", "a fruit", "a sweet treat", "a pet", "a large animal",
                "a sport", "a musical instrument", "a feeling", "a network", "a music genre"
            };
        public Form1()
            {
                InitializeComponent();
                index = random.Next(0, words.Length);
                word = words[index].ToString();
                hint = hints[index].ToString();
                this.answer.Text = word;
                for (int i = 0; i < word.Length; i++)
                {
                    Answer.Add("_");
                }
                this.UnderLine.Text = string.Join("  ", Answer.ToArray());
                HintText.Text = "hint = "+ hint;
                GenWord.Visible = false;
                GAMEOVER.Visible = false;
        }
            private void CommonButtonClickHandler(object sender, EventArgs e)
            {
                Button clickedButton = sender as Button;
   
            if (clickedButton != null)
                {
                string buttonTXT = clickedButton.Text.ToLower();
                if (word.Contains(buttonTXT))
                {
                    for (int i = 0; i < word.Length; i++)
                    {

                        if (String.Equals(buttonTXT, word[i].ToString()))
                        {

                            Answer[i] = buttonTXT;
                            this.UnderLine.Text = string.Join("  ", Answer.ToArray());
                        }
                    }
                }
                else {
                    if (StageCount < Stage.Images.Count - 1)
                    {
                        StageCount += 1;
                        HangMan.Image = Stage.Images[StageCount];
                    }
                    else {
                        GenWord.Visible = true;
                        GAMEOVER.Visible = true;
                    }
                }

                }
            }

        private void GenWord_Click(object sender, EventArgs e)
        {
            GenWord.Visible = false;
            GAMEOVER.Visible = false;
            StageCount = 0;
            HangMan.Image = Stage.Images[0];
            index = random.Next(0, words.Length);
            ArrayList Answer = new ArrayList();
            word = words[index].ToString();
            hint = hints[index].ToString();
            this.answer.Text = word;
            for (int i = 0; i < word.Length; i++)
            {
                Answer.Add("_");
            }
            this.UnderLine.Text = string.Join("  ", Answer.ToArray());
            HintText.Text = "hint = " + hint;
        }
    }
    }
