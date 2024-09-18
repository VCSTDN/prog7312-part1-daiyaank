namespace ST10090560_PROGPOE
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            // Set the form's start position to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Button for Service Request Status
        private void buttonServiceRequestStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature To Be Implemented Later");
        }

        // Button for Local Events Annoucments
        private void buttonLocalEventsAnnoucements_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature To Be Implemented Later");
        }

        // Button for repoted Issues
        private void buttonReportIssues_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            // Show the second form
            reportIssuesForm.Show();
            // Hide the previous form
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}
    }
}
