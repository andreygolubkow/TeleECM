using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeleECM.Office.Models
{
    public class TaskUpdate
    {
        public string Id { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;

        public User User { get; set; }

        public string Details { get; set; }

        public override string ToString()
        {
            return $"{DateTime.ToString()} {User.ToString()} {Details}";
        }

    }
}
