# Municipality Services Application - README

## Overview
This application aims to enhance citizen engagement for a South African municipality by enabling residents to report issues, request services, and access local events and announcements. Users can also receive updates on the status of their service requests. The application is built using C# with Windows Forms.

## Features
- **Report Issues**: Users can report municipal service issues like sanitation, roads, or utilities.
- **Category Selection**: A listbox allows users to select the type of issue.
- **Detailed Descriptions**: Users can provide detailed descriptions of the issue through a RichTextBox.
- **Attach Files**: Users can attach images or documents related to the issue.
- **Progress Indicator**: A progress bar guides users through the process as they input the required details.
- **Submit Report**: Once all details are completed, users can submit the report, which is added to a list.

## Installation

### Prerequisites
- Windows operating system
- .NET Framework (at least version 4.7.2 or higher)
- Visual Studio (for development and compilation)

### Steps
1. Clone or download the repository.
2. Open the solution file (.sln) in Visual Studio.
3. Restore any missing NuGet packages if needed.
4. Build the solution to compile the project.

## Running the Application
1. Run the compiled `.exe` file after building the solution in Visual Studio.
2. The application window will open, displaying a title and a back button to the left of the title.
3. Navigate through the application using the back button when necessary.
4. Follow the steps to report an issue:
   - Input the location in the provided textbox.
   - Select a category from the listbox.
   - Provide a detailed description in the RichTextBox.
   - Optionally, attach images or documents.
   - Monitor the progress indicator as you complete each step.
   - Submit your report once all steps are completed.

## Usage Guide

- **Back Button**: Located next to the title, it allows users to navigate back to previous pages.
- **Textbox**: Input the location of the reported issue.
- **Listbox**: Choose a category (sanitation, roads, utilities, etc.).
- **RichTextBox**: Provide more details about the issue.
- **Attach Button**: Add images or documents to enhance the report.
- **Progress Indicator**: Visualizes the completion of report details.
- **Submit Button**: Once everything is filled out, submit the report to be added to the list.

## Contributing
Feel free to open issues or submit pull requests for improvements and suggestions.

## License
This project is licensed under the [MIT License](LICENSE).

