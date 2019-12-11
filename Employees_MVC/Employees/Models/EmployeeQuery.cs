using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class EmployeeQuery
    {
        public string EmployeeId { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}
