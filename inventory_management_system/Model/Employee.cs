using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Model
{
    public class Employee
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string EmployeeRole{ get; set; }
        public decimal Salary { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }



    }
}
