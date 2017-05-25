using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamProjectManager.Models
{
    public class SkillModel
    {
    }

    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Required { get; set; }
        public int Importance { get; set; }
        public int Strength { get; set; }
    }
}