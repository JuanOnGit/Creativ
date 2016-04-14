using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Creativ.Models
{
    public class Project
    {

        [Key]
        public int ProjectID { get; set; }
        [Required]    
        public string ProjectName { get; set; }
        public ProjectType ProjectType { get; set; }
        public string ProjectOwner { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PublishDate { get; set; }
    }

    public class ProjectDBContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
    }
}