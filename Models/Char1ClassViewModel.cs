using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace MvcChar1.Models
{
    public class Char1ClassViewModel
    {
        public List<Char1> Char1s { get; set; }
        public SelectList Classes { get; set; }
        public string Char1Class { get; set; }
        public string SearchString { get; set; }
    }
}
