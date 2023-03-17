using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruckTrax1.Models
{
    public class ToolCabinets
    {
        [Key]
        public int Id { get; set; }
        public string TCBrandName { get; set; }
        public int TCWidthInches { get; set; }
        public int TCHeightInches { get; set; }
        public string TCFunctionality { get; set; }
        public string TCDetails { get; set; }
        public string TCItemNumber { get; set; }
        public float CabinetPrice { get; set; }
    }
}
