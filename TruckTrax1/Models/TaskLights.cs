using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruckTrax1.Models
{
    public class TaskLights
    {
        public int Id { get; set; }
        public string TLBrandName { get; set; }
        public int TLWatts { get; set; }
        public string TLFunctionality { get; set; }
        public string TLDetails { get; set; }
        public string TLItemNumber { get; set; }
        public float TaskLightsPrice { get; set; }
    }
}
