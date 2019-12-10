namespace Employees_BusinessLayer
{
    public class HourlySalaryFactory : SalaryFactory
    {
        private decimal _monthlySalary;

        private decimal _hourlySalary;

        private decimal _annualSalary;


        public HourlySalaryFactory(decimal hourlySalary, decimal monthlySalary)
        {
            _hourlySalary = hourlySalary;
            _monthlySalary = monthlySalary;
        }

        public override decimal GetSalary()
        {
            return new EmployeeHourlySalary(_hourlySalary, _monthlySalary).AnnualSalary;
        }
    }
}
