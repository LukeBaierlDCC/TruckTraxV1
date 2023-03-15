using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruckTrax1.Models
{
    public class ExtensionCords
    {
        public int Id { get; set; }
        public string ECBrandName { get; set; }
        public int ECLengthInFeet { get; set; }
        public string ECFunctionality { get; set; }
        public string ECDetails { get; set; }
        public string ECItemNumber { get; set; }
        public float CordPrice { get; set; }
    }
}
