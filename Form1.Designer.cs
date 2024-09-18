namespace ST10090560_PROGPOE
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonReportIssues = new Button();
            buttonLocalEventsAnnoucements = new Button();
            buttonServiceRequestStatus = new Button();
            SuspendLayout();
            // 
            // buttonReportIssues
            // 
            buttonReportIssues.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonReportIssues.Location = new Point(28, 26);
            buttonReportIssues.Name = "buttonReportIssues";
            buttonReportIssues.Size = new Size(449, 67);
            buttonReportIssues.TabIndex = 0;
            buttonReportIssues.Text = "Report Issues";
            buttonReportIssues.UseVisualStyleBackColor = true;
            buttonReportIssues.Click += buttonReportIssues_Click;
            // 
            // buttonLocalEventsAnnoucements
            // 
            buttonLocalEventsAnnoucements.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonLocalEventsAnnoucements.Location = new Point(28, 111);
            buttonLocalEventsAnnoucements.Name = "buttonLocalEventsAnnoucements";
            buttonLocalEventsAnnoucements.Size = new Size(449, 64);
            buttonLocalEventsAnnoucements.TabIndex = 1;
            buttonLocalEventsAnnoucements.Text = "Local Events and Annoucements";
            buttonLocalEventsAnnoucements.UseVisualStyleBackColor = true;
            buttonLocalEventsAnnoucements.Click += buttonLocalEventsAnnoucements_Click;
            // 
            // buttonServiceRequestStatus
            // 
            buttonServiceRequestStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonServiceRequestStatus.Location = new Point(28, 193);
            buttonServiceRequestStatus.Name = "buttonServiceRequestStatus";
            buttonServiceRequestStatus.Size = new Size(449, 64);
            buttonServiceRequestStatus.TabIndex = 2;
            buttonServiceRequestStatus.Text = "Service Request Status";
            buttonServiceRequestStatus.UseVisualStyleBackColor = true;
            buttonServiceRequestStatus.Click += buttonServiceRequestStatus_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(503, 288);
            Controls.Add(buttonServiceRequestStatus);
            Controls.Add(buttonLocalEventsAnnoucements);
            Controls.Add(buttonReportIssues);
            Name = "MainMenu";
            Text = "Main Menu";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonReportIssues;
        private Button buttonLocalEventsAnnoucements;
        private Button buttonServiceRequestStatus;
    }
}
