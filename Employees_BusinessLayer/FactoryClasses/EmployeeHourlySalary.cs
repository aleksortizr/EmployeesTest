using Employees_Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees_BusinessLayer
{
    public class EmployeeHourlySalary : Salary
    {
        private readonly ContractTypes _contractType;

        private readonly decimal _annualSalary;

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
        public EmployeeHourlySalary(decimal hourlySalary, decimal monthlySalary)
        {
            _contractType = ContractTypes.HourlySalaryEmployee;
            HourlySalary = hourlySalary;
            MonthlySalary = monthlySalary;
            _annualSalary = 120 * HourlySalary * 12;
        }
    }
}
