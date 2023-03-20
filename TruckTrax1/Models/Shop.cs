using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Linq;
using System.Threading.Tasks;

namespace TruckTrax1.Models
{
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }
    }
}
