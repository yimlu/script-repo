using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ScriptRepository.Models
{
    [Table("Projects")]
    public class Project
    {
        private ICollection<Script> _scripts;

        public Project()
        {
            ProjectGuid = Guid.NewGuid();
        }

        public int Id { get; set; }

        public Guid ProjectGuid { get; set; }

        public string ProjectCode { get; set; }

        public virtual ICollection<Script> Scripts
        {
            get { return _scripts ?? (_scripts = new List<Script>()); }
            set { _scripts = value; }
        }
    }

    [Table("Scripts")]
    public class Script
    {
        public Script()
        {
            ScriptGuid = Guid.NewGuid();
        }

        public Guid ScriptGuid { get; set; }

        [Required]
        public string ScriptLanguage { get; set; }

        public string Content { get; set; }

        public string IssueTrackNumber { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public string Comments { get; set; }

        public virtual Project Project { get; set; }
    }

    public class RepoDbContext : DbContext
    {
        public RepoDbContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Script> Scripts { get; set; }
    }

    //TODO: Move these manager class to separeated files,but to make things simpler,I put it here.
    public class ProjectManager
    {
        public ProjectManager()
        {

        }

        public void AddProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void RemoveProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }
    }
}