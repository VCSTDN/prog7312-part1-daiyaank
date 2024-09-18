namespace ST10090560_PROGPOE
{
    partial class ReportIssuesForm
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            richTextBoxDescription = new RichTextBox();
            button1 = new Button();
            label5 = new Label();
            labelFile = new Label();
            buttonSubmit = new Button();
            progressBar = new ProgressBar();
            buttonBack = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(199, 22);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 0;
            label1.Text = "Report Issues";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(39, 87);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Location";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(43, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(39, 158);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 3;
            label3.Text = "Select Category";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(43, 181);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(479, 49);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(43, 251);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 7;
            label4.Text = "Enter Description";
            label4.Click += label4_Click;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxDescription.Location = new Point(47, 273);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(475, 58);
            richTextBoxDescription.TabIndex = 8;
            richTextBoxDescription.Text = "";
            richTextBoxDescription.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(47, 374);
            button1.Name = "button1";
            button1.Size = new Size(475, 39);
            button1.TabIndex = 9;
            button1.Text = "Click to Attach Media";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(47, 356);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 10;
            label5.Text = "Attach Media";
            // 
            // labelFile
            // 
            labelFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelFile.AutoSize = true;
            labelFile.Location = new Point(47, 416);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(88, 15);
            labelFile.TabIndex = 11;
            labelFile.Text = "No file selected";
            labelFile.Click += labelFile_Click;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSubmit.Location = new Point(50, 492);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(472, 69);
            buttonSubmit.TabIndex = 12;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(50, 461);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(472, 23);
            progressBar.TabIndex = 13;
            progressBar.Click += progressBar1_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonBack.Location = new Point(41, 29);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(133, 30);
            buttonBack.TabIndex = 14;
            buttonBack.Text = "Back to Menu";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReportIssuesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(570, 587);
            Controls.Add(buttonBack);
            Controls.Add(progressBar);
            Controls.Add(buttonSubmit);
            Controls.Add(labelFile);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(richTextBoxDescription);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReportIssuesForm";
            Text = "Report Issues";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
        private RichTextBox richTextBoxDescription;
        private Button button1;
        private Label label5;
        private Label labelFile;
        private Button buttonSubmit;
        private ProgressBar progressBar;
        private Button buttonBack;
        private OpenFileDialog openFileDialog1;
    }
}