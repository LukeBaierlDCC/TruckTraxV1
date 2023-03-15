using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruckTrax1.Models
{
    public class Saws
    {
        public int Id { get; set; }
        public string SawBrandName { get; set; }
        public int BladeInInches { get; set; }
        public string SawFunctionality { get; set; }
        public string SawDetails { get; set; }
        public string SawItemNumber { get; set; }
        public float SawPrice { get; set; }
    }
}
