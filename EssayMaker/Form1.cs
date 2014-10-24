using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Essay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            string d = DateTime.Now.ToString("M/d/yyyy");
            date.Text = d;
            
        }
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
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string[] topright = {
                                    name.Text + Environment.NewLine + 
                                    teacherName.Text + Environment.NewLine + 
                                    date.Text + Environment.NewLine};
            string[] alltextboxes = {topright + topicSentence1.Text + Environment.NewLine + examples1.Text + Environment.NewLine + concludingSentence1.Text + Environment.NewLine + topicSentence2.Text + Environment.NewLine + examples2.Text + Environment.NewLine + concludingSentence2.Text + Environment.NewLine + topicSentence3.Text + Environment.NewLine + examples3.Text + Environment.NewLine + concludingSentence3.Text + Environment.NewLine + conclusion.Text};
            
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "Rich Text Format (.rtf)|*.rtf";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFileDialog1.FileName.Length > 0)
            {
                string path = saveFileDialog1.FileName;
                System.IO.File.WriteAllLines(path, alltextboxes);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string alltextboxes = (name.Text + Environment.NewLine + teacherName.Text + Environment.NewLine + date.Text + Environment.NewLine + topicSentence1.Text + Environment.NewLine + examples1.Text + Environment.NewLine + concludingSentence1.Text + Environment.NewLine + topicSentence2.Text + Environment.NewLine + examples2.Text + Environment.NewLine + concludingSentence2.Text + Environment.NewLine + topicSentence3.Text + Environment.NewLine + examples3.Text + Environment.NewLine + concludingSentence3.Text + Environment.NewLine + conclusion.Text);
            Clipboard.SetText(alltextboxes, TextDataFormat.Rtf);
        }
    }
}
