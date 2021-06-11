using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryLog2.Models
{
    public class Groceries
    {
        [Key]
        public int GroceryId { get; set; }
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }



    }
}
