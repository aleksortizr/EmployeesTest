using Employees_Common;

namespace Employees_BusinessLayer
{
    public class EmployeeMonthlySalary : Salary
    {
        private readonly ContractTypes _contractType;

        private decimal _annualSalary;

        public override decimal MonthlySalary { get; set; }

        public override decimal HourlySalary { get; set; }

        public override decimal AnnualSalary { 
            get
            {
                return this._annualSalary;
            }
        }

        public override ContractTypes ContractType
        {
            get { return _contractType; }
        }


        /// <summary>
        /// COntructor, applies the annual salary formula
        /// </summary>
        /// <param name="hourlySalary"></param>
        /// <param name="monthlySalary"></param>
        public EmployeeMonthlySalary(decimal hourlySalary, decimal monthlySalary)
        {
            _contractType = ContractTypes.MonthlySalaryEmployee;
            HourlySalary = hourlySalary;
            MonthlySalary = monthlySalary;
            _annualSalary = MonthlySalary * 12;
        }
    }
}
