using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Model
{
    public class SellItem
    {
        public int Id { get; set; }
        public string Category { get; set; }

        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string SellerName { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
