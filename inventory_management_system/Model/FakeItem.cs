using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Model
{
    public class FakeItem
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Category { get; set; }

        public string Type {  get; set; }

        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
