using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcChar1.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public int Ac { get; set; }
        public int Hp { get; set; }
        public int Str { get; set; }
        public int Con { get; set; }
        public int Dex { get; set; }
        public int Wis { get; set; }
        public int Ine { get; set; }
        public int Cha { get; set; }
    }
}
