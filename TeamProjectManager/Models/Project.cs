using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TeamProjectManager.Models
{
    public class Project
    {
        public int Id  { get; set; }
        public int Name { get; set; }
        public List<Skill> Skills{ get; set; }
        public virtual ApplicationUser Manager { get; set; }
        public DateTime DateCreated{ get; set; }
        public DateTime DateCompleted { get; set; }
        public int Status { get; set; }
        public List<ApplicationUser> Users { get; set; }

        public List<Chat> Chats { get; set; }

        public List<Task> Tasks { get; set; }
    }

    public class ProjectContext : ApplicationDbContext
    {
        public DbSet<Project> Projects;
    }
}