using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TeamProjectManager.Models
{
    public class ChatModel
    {
    }

    public class Chat
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string AttachmentUrl { get; set; }
        public DateTime DateSent { get; set; }
        public ApplicationUser Sender { get; set; }

        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
    }

    public class ChatContext : ApplicationDbContext
    {
        public DbSet<Chat> Chats { get; set; }
    }
}