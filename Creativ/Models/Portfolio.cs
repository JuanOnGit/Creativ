using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Creativ.Models
{
    [Table("Portfolio")]
    public class Portfolio
    {
        [Key]       
        public int PorfolioID { get; set; }
        [Required]
        public string PorfolioName { get; set; }
        public ProjectType PorfolioType { get; set; }
        public string PorfolioOwner { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PublishDate { get; set; }

    }

   

    public class ProjectType
    {
        public int ProjectItems { get; set; }
        public string Type { get; set; }
    }

    enum Type
    {
        Drawing,
        Photo,
        Code,
        Animation,
        Writing

    }

   public class PortfolioDBContext : DbContext
    {
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}