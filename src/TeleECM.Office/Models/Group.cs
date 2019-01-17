using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeleECM.Office.Models
{
    public class Group
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
}
