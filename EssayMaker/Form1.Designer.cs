namespace Essay
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
            this.thesis = new System.Windows.Forms.RichTextBox();
            this.conclusion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.concludingSentence1 = new System.Windows.Forms.RichTextBox();
            this.examples1 = new System.Windows.Forms.RichTextBox();
            this.topicSentence1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.concludingSentence2 = new System.Windows.Forms.RichTextBox();
            this.examples2 = new System.Windows.Forms.RichTextBox();
            this.topicSentence2 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.concludingSentence3 = new System.Windows.Forms.RichTextBox();
            this.examples3 = new System.Windows.Forms.RichTextBox();
            this.topicSentence3 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // thesis
            // 
            this.thesis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.thesis.Location = new System.Drawing.Point(11, 82);
            this.thesis.Name = "thesis";
            this.thesis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.thesis.Size = new System.Drawing.Size(542, 80);
            this.thesis.TabIndex = 0;
            this.thesis.Text = "";
            // 
            // conclusion
            // 
            this.conclusion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conclusion.Location = new System.Drawing.Point(12, 409);
            this.conclusion.Name = "conclusion";
            this.conclusion.Size = new System.Drawing.Size(541, 96);
            this.conclusion.TabIndex = 10;
            this.conclusion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Essay Maker 0.4";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(418, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 22);
            this.name.TabIndex = 13;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(477, 59);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(46, 17);
            this.date.TabIndex = 14;
            this.date.Text = "{date}";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(418, 34);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(135, 22);
            this.teacherName.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.concludingSentence1);
            this.groupBox1.Controls.Add(this.examples1);
            this.groupBox1.Controls.Add(this.topicSentence1);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 234);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Topic 1";
            // 
            // concludingSentence1
            // 
            this.concludingSentence1.Location = new System.Drawing.Point(6, 187);
            this.concludingSentence1.Name = "concludingSentence1";
            this.concludingSentence1.Size = new System.Drawing.Size(162, 44);
            this.concludingSentence1.TabIndex = 2;
            this.concludingSentence1.Text = "";
            // 
            // examples1
            // 
            this.examples1.Location = new System.Drawing.Point(6, 76);
            this.examples1.Name = "examples1";
            this.examples1.Size = new System.Drawing.Size(162, 105);
            this.examples1.TabIndex = 1;
            this.examples1.Text = "";
            // 
            // topicSentence1
            // 
            this.topicSentence1.Location = new System.Drawing.Point(6, 21);
            this.topicSentence1.Name = "topicSentence1";
            this.topicSentence1.Size = new System.Drawing.Size(162, 49);
            this.topicSentence1.TabIndex = 0;
            this.topicSentence1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.concludingSentence2);
            this.groupBox2.Controls.Add(this.examples2);
            this.groupBox2.Controls.Add(this.topicSentence2);
            this.groupBox2.Location = new System.Drawing.Point(192, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 234);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Topic 2";
            // 
            // concludingSentence2
            // 
            this.concludingSentence2.Location = new System.Drawing.Point(6, 186);
            this.concludingSentence2.Name = "concludingSentence2";
            this.concludingSentence2.Size = new System.Drawing.Size(162, 44);
            this.concludingSentence2.TabIndex = 3;
            this.concludingSentence2.Text = "";
            // 
            // examples2
            // 
            this.examples2.Location = new System.Drawing.Point(6, 75);
            this.examples2.Name = "examples2";
            this.examples2.Size = new System.Drawing.Size(162, 105);
            this.examples2.TabIndex = 3;
            this.examples2.Text = "";
            // 
            // topicSentence2
            // 
            this.topicSentence2.Location = new System.Drawing.Point(6, 21);
            this.topicSentence2.Name = "topicSentence2";
            this.topicSentence2.Size = new System.Drawing.Size(162, 49);
            this.topicSentence2.TabIndex = 3;
            this.topicSentence2.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.concludingSentence3);
            this.groupBox3.Controls.Add(this.examples3);
            this.groupBox3.Controls.Add(this.topicSentence3);
            this.groupBox3.Location = new System.Drawing.Point(379, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 234);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Topic 3";
            // 
            // concludingSentence3
            // 
            this.concludingSentence3.Location = new System.Drawing.Point(6, 186);
            this.concludingSentence3.Name = "concludingSentence3";
            this.concludingSentence3.Size = new System.Drawing.Size(162, 44);
            this.concludingSentence3.TabIndex = 4;
            this.concludingSentence3.Text = "";
            // 
            // examples3
            // 
            this.examples3.Location = new System.Drawing.Point(6, 75);
            this.examples3.Name = "examples3";
            this.examples3.Size = new System.Drawing.Size(162, 105);
            this.examples3.TabIndex = 4;
            this.examples3.Text = "";
            // 
            // topicSentence3
            // 
            this.topicSentence3.Location = new System.Drawing.Point(6, 21);
            this.topicSentence3.Name = "topicSentence3";
            this.topicSentence3.Size = new System.Drawing.Size(162, 49);
            this.topicSentence3.TabIndex = 4;
            this.topicSentence3.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "docx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 20;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.date);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conclusion);
            this.Controls.Add(this.thesis);
            this.Name = "Form1";
            this.Text = "Essay Maker 0.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox thesis;
        private System.Windows.Forms.RichTextBox conclusion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox concludingSentence1;
        private System.Windows.Forms.RichTextBox examples1;
        private System.Windows.Forms.RichTextBox topicSentence1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox concludingSentence2;
        private System.Windows.Forms.RichTextBox examples2;
        private System.Windows.Forms.RichTextBox topicSentence2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox concludingSentence3;
        private System.Windows.Forms.RichTextBox examples3;
        private System.Windows.Forms.RichTextBox topicSentence3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

