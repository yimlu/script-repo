using System;

namespace ScriptRepository.Models
{
    public class Project
    {
        public Guid ProjectGuid { get; set; }

        public string ProjectCode { get; set; }
    }

    public class Script
    {
        public Guid ScriptGuid { get; set; }

        public string ScriptLanguage { get; set; }

        public string Content { get; set; }

        public string IssueTrackNumber { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public string Author { get; set; }

        public string Comments { get; set; }

        public virtual Project Project { get; set; }
    }
}