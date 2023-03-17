using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruckTrax1.Models
{
    public class Hammers
    {
        [Key]
        public int Id { get; set; }
        public string HammerBrandName { get; set; }
        public int HammerLengthInInches { get; set; }
        public string HammerFunctionality { get; set; }
        public string HammerDetails { get; set; }
        public string HammerItemNumber { get; set; }
        public float HammerPrice { get; set; }
    }
}
