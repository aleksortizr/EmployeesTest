using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Employees.Models
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext (DbContextOptions<EmployeesContext> options)
            : base(options)
        {
        }

        public DbSet<Employees.Models.Employee> Employee { get; set; }
    }
}
