using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruckTrax1.Models
{
    public class WorkStations
    {
        [Key]
        public int Id { get; set; }
        public string WSBrandName { get; set; }
        public int WSWidthInches { get; set; }
        public int WSHeightInches { get; set; }
        public string WSFunctionality { get; set; }
        public string WSDetails { get; set; }
        public string ItemNumber { get; set; }
        public float WorkStationPrice { get; set; }
    }
}
