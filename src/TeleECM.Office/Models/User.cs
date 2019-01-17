using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeleECM.Office.Models
{
    public class User
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public List<Group> Groups { get; set; } = new List<Group>();

        public override string ToString()
        {
            return $"{Name}({String.Join(",", Groups.Select(g=>g.Name))})";
        }
    }
}
