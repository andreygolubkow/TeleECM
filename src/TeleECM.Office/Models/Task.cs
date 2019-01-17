using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeleECM.Office.Models
{
    public class Task
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public Status Status { get; set; }

        public List<TaskUpdate> Updates { get; set; } = new List<TaskUpdate>();

        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        public User Author { get; set; }

        public List<User> Users { get; set; } = new List<User>();

    }
}
