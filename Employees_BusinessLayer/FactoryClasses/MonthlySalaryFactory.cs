namespace Employees_BusinessLayer
{
    public class MonthlySalaryFactory : SalaryFactory
    {
        private decimal _monthlySalary;

        private decimal _hourlySalary;

        private decimal _annualSalary;


        public MonthlySalaryFactory(decimal hourlySalary, decimal monthlySalary)
        {
            _hourlySalary = hourlySalary;
            _monthlySalary = monthlySalary;
        }

        public override decimal GetSalary()
        {
            return new EmployeeMonthlySalary(_hourlySalary, _monthlySalary).AnnualSalary;
        }
    }
}
