using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ST10090560_PROGPOE
{
    public partial class ReportIssuesForm : Form
    {
        // List to store the reported issues
        private List<ReportedIssue> reportedIssuesList = new List<ReportedIssue>();

        // Variables
        bool locationEngaged = false;
        bool categoryEngaged = false;
        bool descriptionEngaged = false;
        bool mediaEngaged = false;
        string selectedFilePath = string.Empty;

        // Constructor
        public ReportIssuesForm()
        {
            InitializeComponent();
            // Set the form's start position to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Add values to the ComboBox
            listBox1.Items.AddRange(new[] { "Sanitation", "Roads", "Utilities" });
        }

        // Back button
        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of Main Menu
            MainMenu mainWindow = new MainMenu();
            // Show main window
            mainWindow.Show();
            // Remove previous window
            this.Hide();
        }

        // Location text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Add to the progress bar on first engagement
            if (!locationEngaged)
                progressBar.Value = progressBar.Value + 25;
            locationEngaged = true;
        }

        // Category list box
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add to the progress bar on first engagement
            if (!categoryEngaged)
                progressBar.Value = progressBar.Value + 25;
            categoryEngaged = true;
        }

        // Description rich text box
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Add to the progress bar on first engagement
            if (!descriptionEngaged)
                progressBar.Value = progressBar.Value + 25;
            descriptionEngaged = true;
        }

        // Media attachement button
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png"
                openFileDialog.Title = "Select a file to attach";

                openFileDialog.Multiselect = false;

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    selectedFilePath = openFileDialog.FileName;

                    // Display confirmation to user:
                    MessageBox.Show("Selected File: " + selectedFilePath, "File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    labelFile.Text = "Attached: " + selectedFilePath;

                    //Add to the progress bar on first engagement
                    if (!mediaEngaged)
                        progressBar.Value = progressBar.Value + 25;
                    mediaEngaged = true;
                }
            }
        }

        // Submit button
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Validation: Ensure required fields are filled
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation: Ensure the list box has a selection
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category from the list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Validation: Ensure the description is given
            if (string.IsNullOrWhiteSpace(richTextBoxDescription.Text))
            {
                MessageBox.Show("Please provide a description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new reported issue from the user
            var newReportedIssue = new ReportedIssue
            (
                // Location
                textBox1.Text, 
                // Category
                listBox1.SelectedItem.ToString(),
                // Description
                richTextBoxDescription.Text,
                // Media Attachement
                selectedFilePath
            );

            // Add the new reported issue to the list
            reportedIssuesList.Add( newReportedIssue );

            // Clear location text box
            textBox1.Clear();
            // Reset list box
            listBox1.ClearSelected();
            // Clear description box
            richTextBoxDescription.Clear();
            // Reset file label text
            labelFile.Text = "No file selected";
            // Reset progress bar
            progressBar.Value = 0;

            // Show success message
            MessageBox.Show("Successfully Reported Issue. Good job!");

            // Reset Engagement variables 
            locationEngaged = false;
            categoryEngaged = false;
            descriptionEngaged = false;
            mediaEngaged = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        { 
        
        }

        private void label1_Click(object sender, EventArgs e)
        { 
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        
        }

        private void label4_Click(object sender, EventArgs e)
        { 
        
        }

        private void labelFile_Click(object sender, EventArgs e)
        {

        }
    }
}
