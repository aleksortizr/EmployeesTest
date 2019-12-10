using Employees_Common;

namespace Employees_BusinessLayer
{
    public abstract class Salary
    {
        public abstract ContractTypes ContractType { get; }

        public abstract decimal MonthlySalary { get; set; }

        public abstract decimal HourlySalary { get; set; }

        public abstract decimal AnnualSalary { get; }
    }
}
