using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public int Active { get; set; }
    }
}
