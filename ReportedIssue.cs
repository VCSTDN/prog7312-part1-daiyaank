using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090560_PROGPOE
{
    public class ReportedIssue
    {
        // Variables
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MediaAttachment { get; set; }

        // Constructor
        public ReportedIssue(string location, string category, string description, string mediaAttachment)
        {
            Location = location;
            Category = category;
            Description = description;
            MediaAttachment = mediaAttachment;
        }

    }
}
