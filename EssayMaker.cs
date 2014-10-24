using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class EssayMaker : Form
    {
        public EssayMaker()
        {
            InitializeComponent();
            label20.Hide();
        }

        public void ButtonCopyClick()
        {
            label20.Show();
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, e) =>
            {
                label20.Hide();
                t.Stop();
            };
            t.Start();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region DateTime
            string path = Environment.CurrentDirectory + "/" + "Essay.txt";
            if (!File.Exists(path))     //check if file exist or not
                File.Create(path);      //create file if not exis
            #endregion
            #region Copy to Clipboard
            string copyToClipboard = (introductionParagraph.Text + Environment.NewLine + topicSentence1.Text + " " + analysis1.Text + " " + evidence1.Text + " " + analysisTransition1.Text + Environment.NewLine + topicSentence2.Text + " " + analysis2.Text + " " + evidence2.Text + " " +  analysisTransition2.Text + Environment.NewLine + topicSentence3.Text + " " + analysis3.Text + " " + evidence3.Text + " " + analysisTransition3.Text + Environment.NewLine + conclusionParagraph.Text);
            Clipboard.Clear();
            Clipboard.SetText(copyToClipboard);
            #endregion
            ButtonCopyClick();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
