using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Essay
{
    public partial class Form1 : Form
    {
        //INITIALIZE
        public Form1()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = new Size(517, 469);
            MinimizeBox = false;
            string d = DateTime.Now.ToString("M/d/yyyy");
            date.Text = d;
            label3.Hide();
            label3.Text = "Saved!";
            
        }
        //TOOLTIPS
        private void Form1_Load(object sender, EventArgs e)
        {
            // Tooltips
            ToolTip everyExplanation = new ToolTip();
            everyExplanation.ShowAlways = true;

            // Topic Sentences
            everyExplanation.SetToolTip(this.topicSentence1, "Topic Sentence: Say what your paragraph will be about.");
            everyExplanation.SetToolTip(this.topicSentence2, "Topic Sentence: Say what your paragraph will be about.");
            everyExplanation.SetToolTip(this.topicSentence3, "Topic Sentence: Say what your paragraph will be about.");

            // Top and Bottom Paragraph
            everyExplanation.SetToolTip(this.thesis, "Thesis Paragraph: This paragraph should include a topic sentence, 3 examples (that will tie back to your body paragraph's topics about your topic, and a concluding sentence that repeats the main idea.");
            everyExplanation.SetToolTip(this.conclusion, "Concluding Paragraph: This paragraph should conclude your subject. e.g. using words like 'as you can see'. Tie back to your body paragraphs and use 3 sentences about them.");

            // Examples
            everyExplanation.SetToolTip(this.examples1, "Examples: Give examples about why your topic sentence is true.");
            everyExplanation.SetToolTip(this.examples2, "Examples: Give examples about why your topic sentence is true.");
            everyExplanation.SetToolTip(this.examples3, "Examples: Give examples about why your topic sentence is true.");

            // Concluding Sentences
            everyExplanation.SetToolTip(this.concludingSentence1, "Concluding Sentence: Conclude your paragraph and repeat the topic sentence.");
            everyExplanation.SetToolTip(this.concludingSentence2, "Concluding Sentence: Conclude your paragraph and repeat the topic sentence.");
            everyExplanation.SetToolTip(this.concludingSentence3, "Concluding Sentence: Conclude your paragraph and repeat the topic sentence.");

            everyExplanation.SetToolTip(this.comboBox1, "Change the font. This will change the saved and copied file font.");
        }
        //SAVE
        public void button1_Click(object sender, EventArgs e)
        {
            #region SetText
            
            richTextBox2.AppendText(name.Text + Environment.NewLine +
                                    teacherName.Text + Environment.NewLine + date.Text + Environment.NewLine);
            richTextBox1.AppendText(richTextBox2.Text + Environment.NewLine + thesis.Text + Environment.NewLine +
                                    topicSentence1.Text + Environment.NewLine +
                                    examples1.Text + Environment.NewLine + concludingSentence1.Text + Environment.NewLine + topicSentence2.Text + Environment.NewLine + examples2.Text + Environment.NewLine + concludingSentence2.Text + Environment.NewLine + topicSentence3.Text + Environment.NewLine + examples3.Text + Environment.NewLine + concludingSentence3.Text + Environment.NewLine + conclusion.Text);
                                    
            #endregion
            int fontSelection = comboBox1.SelectedIndex;
            int fontSize = Convert.ToInt32(numericUpDown1.Value);
            int line1start = richTextBox1.GetFirstCharIndexFromLine(0);
            int line3end = richTextBox1.GetFirstCharIndexFromLine(4);
            richTextBox1.Select(line1start, line3end);
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            switch (fontSelection)
            {
                case 0:
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionFont = new Font("Times New Roman", fontSize);
                    richTextBox1.DeselectAll();
                    break;
                case 1:
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionFont = new Font("Arial", fontSize);
                    richTextBox1.DeselectAll();
                    break;
                case 2:
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionFont = new Font("Courier New", fontSize);
                    richTextBox1.DeselectAll();
                    break;
                case 3:
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionFont = new Font("Comic Sans MS", fontSize);
                    richTextBox1.DeselectAll();
                    break;
                case 4:
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionFont = new Font("Cambria", fontSize);
                    richTextBox1.DeselectAll();
                    break;
            }
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "Rich Text Format (.rtf)|*.rtf";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFileDialog1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox1.SaveFile(saveFileDialog1.FileName);

            }
            warning2();
        }
        //COPY
        private void button2_Click(object sender, EventArgs e)
        {
            #region SetText

            richTextBox1.Text = (name.Text + Environment.NewLine +
                                    teacherName.Text + Environment.NewLine +
                                    date.Text + Environment.NewLine + thesis.Text + Environment.NewLine +
                                    topicSentence1.Text + Environment.NewLine +
                                    examples1.Text + Environment.NewLine + concludingSentence1.Text + Environment.NewLine + topicSentence2.Text + Environment.NewLine + examples2.Text + Environment.NewLine + concludingSentence2.Text + Environment.NewLine + topicSentence3.Text + Environment.NewLine + examples3.Text + Environment.NewLine + concludingSentence3.Text + Environment.NewLine + conclusion.Text);
            #endregion
            int fontSelection = comboBox1.SelectedIndex;
            int fontSize = Convert.ToInt32(numericUpDown1.Value);
            switch (fontSelection)
            {
                case 0:
                    richTextBox1.Font = new Font("Times New Roman", fontSize);
                    break;
                case 1:
                    richTextBox1.Font = new Font("Arial", fontSize);
                    break;
                case 2:
                    richTextBox1.Font = new Font("Courier New", fontSize);
                    break;
                case 3:
                    richTextBox1.Font = new Font("Comic Sans MS", fontSize);
                    break;
                case 4:
                    richTextBox1.Font = new Font("Cambria", fontSize);
                    break;
            }
            
            Clipboard.SetText(richTextBox1.Rtf, TextDataFormat.Rtf);
            warning1();
        }
        //FONT
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fontSize = Convert.ToInt32(topicSentence1.Font.Size);
            if(comboBox1.SelectedIndex == 0)
            {
                topicSentence1.Font = new Font("Times New Roman", fontSize);
                topicSentence2.Font = new Font("Times New Roman", fontSize);
                topicSentence3.Font = new Font("Times New Roman", fontSize);

                examples1.Font = new Font("Times New Roman", fontSize);
                examples2.Font = new Font("Times New Roman", fontSize);
                examples3.Font = new Font("Times New Roman", fontSize);

                concludingSentence1.Font = new Font("Times New Roman", fontSize);
                concludingSentence1.Font = new Font("Times New Roman", fontSize);
                concludingSentence1.Font = new Font("Times New Roman", fontSize);

                conclusion.Font = new Font("Times New Roman", fontSize);
                thesis.Font = new Font("Times New Roman", fontSize);
                name.Font = new Font("Times New Roman", fontSize);
                teacherName.Font = new Font("Times New Roman", fontSize);
                date.Font = new Font("Times New Roman", fontSize);
                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                topicSentence1.Font = new Font("Arial", fontSize);
                topicSentence2.Font = new Font("Arial", fontSize);
                topicSentence3.Font = new Font("Arial", fontSize);

                examples1.Font = new Font("Arial", fontSize);
                examples2.Font = new Font("Arial", fontSize);
                examples3.Font = new Font("Arial", fontSize);

                concludingSentence1.Font = new Font("Arial", fontSize);
                concludingSentence1.Font = new Font("Arial", fontSize);
                concludingSentence1.Font = new Font("Arial", fontSize);

                conclusion.Font = new Font("Arial", fontSize);
                thesis.Font = new Font("Arial", fontSize);
                
                

            }
            if (comboBox1.SelectedIndex == 2)
            {
                topicSentence1.Font = new Font("Courier New", fontSize);
                topicSentence2.Font = new Font("Courier New", fontSize);
                topicSentence3.Font = new Font("Courier New", fontSize);

                examples1.Font = new Font("Courier New", fontSize);
                examples2.Font = new Font("Courier New", fontSize);
                examples3.Font = new Font("Courier New", fontSize);

                concludingSentence1.Font = new Font("Courier New", fontSize);
                concludingSentence1.Font = new Font("Courier New", fontSize);
                concludingSentence1.Font = new Font("Courier New", fontSize);

                conclusion.Font = new Font("Courier New", fontSize);
                thesis.Font = new Font("Courier New", fontSize);
                
            }
            if (comboBox1.SelectedIndex == 3)
            {
                topicSentence1.Font = new Font("Comic Sans MS", fontSize);
                topicSentence2.Font = new Font("Comic Sans MS", fontSize);
                topicSentence3.Font = new Font("Comic Sans MS", fontSize);

                examples1.Font = new Font("Comic Sans MS", fontSize);
                examples2.Font = new Font("Comic Sans MS", fontSize);
                examples3.Font = new Font("Comic Sans MS", fontSize);

                concludingSentence1.Font = new Font("Comic Sans MS", fontSize);
                concludingSentence1.Font = new Font("Comic Sans MS", fontSize);
                concludingSentence1.Font = new Font("Comic Sans MS", fontSize);

                conclusion.Font = new Font("Comic Sans MS", fontSize);
                thesis.Font = new Font("Comic Sans MS", fontSize);
                
            }
            if (comboBox1.SelectedIndex == 4)
            {
                topicSentence1.Font = new Font("Cambria", fontSize);
                topicSentence2.Font = new Font("Cambria", fontSize);
                topicSentence3.Font = new Font("Cambria", fontSize);

                examples1.Font = new Font("Cambria", fontSize);
                examples2.Font = new Font("Cambria", fontSize);
                examples3.Font = new Font("Cambria", fontSize);

                concludingSentence1.Font = new Font("Cambria", fontSize);
                concludingSentence1.Font = new Font("Cambria", fontSize);
                concludingSentence1.Font = new Font("Cambria", fontSize);

                conclusion.Font = new Font("Cambria", fontSize);
                thesis.Font = new Font("Cambria", fontSize);
                
            }
        }
        //TABS
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Top and Bottom
                thesis.AcceptsTab = true;
                conclusion.AcceptsTab = true;

                // Topic Sentences
                topicSentence1.AcceptsTab = true;
                topicSentence2.AcceptsTab = true;
                topicSentence3.AcceptsTab = true;

                // Examples
                examples1.AcceptsTab = true;
                examples2.AcceptsTab = true;
                examples3.AcceptsTab = true;

                // Concluding Sentence
                concludingSentence1.AcceptsTab = true;
                concludingSentence2.AcceptsTab = true;
                concludingSentence3.AcceptsTab = true;

            }
            else
            {
                // Top and Bottom
                thesis.AcceptsTab = false;
                conclusion.AcceptsTab = false;

                // Topic Sentences
                topicSentence1.AcceptsTab = false;
                topicSentence2.AcceptsTab = false;
                topicSentence3.AcceptsTab = false;

                // Examples
                examples1.AcceptsTab = false;
                examples2.AcceptsTab = false;
                examples3.AcceptsTab = false;

                // Concluding Sentence
                concludingSentence1.AcceptsTab = false;
                concludingSentence2.AcceptsTab = false;
                concludingSentence3.AcceptsTab = false;
            }
        }
        //NIGHTMODE
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                this.ForeColor = Color.DarkGray;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = Color.Black;
            }
        }
        //CONFIRMATIONS
        public void warning1()
        {
            label3.Text = "Copied!";
            label3.Show();
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, e) =>
            {
                label3.Hide();
                t.Stop();
            };
            t.Start();
        }
        public void warning2()
        {
            label3.Text = "Saved!";
            label3.Show();
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, e) =>
            {
                label3.Hide();
                t.Stop();
            };
            t.Start();
        }
        //FONTSIZE
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = Convert.ToInt32(numericUpDown1.Value);
            topicSentence1.Font = new Font(topicSentence1.Font.FontFamily, fontSize);
            topicSentence2.Font = new Font(topicSentence1.Font.FontFamily, fontSize);
            topicSentence3.Font = new Font(topicSentence1.Font.FontFamily, fontSize);

            examples1.Font = new Font(topicSentence1.Font.FontFamily, fontSize);
            examples2.Font = new Font(topicSentence1.Font.FontFamily, fontSize);
            examples3.Font = new Font(topicSentence1.Font.FontFamily, fontSize);

            concludingSentence1.Font = new Font(topicSentence1.Font.FontFamily, fontSize);
            concludingSentence1.Font = new Font(topicSentence1.Font.FontFamily, fontSize);
            concludingSentence1.Font = new Font(topicSentence1.Font.FontFamily, fontSize);

            conclusion.Font = new Font(topicSentence1.Font.FontFamily, fontSize);
            thesis.Font = new Font(topicSentence1.Font.FontFamily, fontSize);

        }
        
    }
}
