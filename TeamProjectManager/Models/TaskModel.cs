using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeamProjectManager.Models
{
    public class TaskModel
    {
    }

    public class Task
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Status { get; set; }
        public List<Skill> Skills { get; set; }
    }
}