using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Types { get; set; }

        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime CreatedAt { get; set; }


    }
}
