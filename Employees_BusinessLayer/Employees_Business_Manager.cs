using Employees_Common;
using Employees_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_BusinessLayer
{
    public class Employees_Business_Manager
    {
        private readonly EmployeesDAL _employeesDAL;

        public Employees_Business_Manager()
        {
            _employeesDAL = new EmployeesDAL();
        }

        public async Task<List<EmployeesDTO>> GetEmployeesAsync(int? id)
        {
            List <EmployeesDTO> filteredEmployees = new List<EmployeesDTO>();
            List <EmployeesDTO> allEmployees = await GetAllEmployees();

            if(id.HasValue)
            {
                filteredEmployees.Add(allEmployees.Find(e => e.Id == id.Value));
            }
            else
                filteredEmployees = allEmployees;

            // llops through the resulting employees and calculates the annual salary using factory method
            foreach(var emp in filteredEmployees)
            {
                GetAnnualSalary(emp);
            }

            return filteredEmployees;
        }

        private Task<List<EmployeesDTO>> GetAllEmployees()
        {
            return _employeesDAL.GetAllEmployees();
        }

        /// <summary>
        /// Dummy FactoryMethod Implementation
        /// Not using DI, just geting a salary object to pull the annual salary
        /// </summary>
        /// <param name="employee"></param>
        private void GetAnnualSalary(EmployeesDTO employee)
        {
            SalaryFactory salaryFactory = null;
                    _ = Enum.TryParse(employee.ContractTypeName, out ContractTypes contractType);

            switch(contractType)
            {
                case ContractTypes.HourlySalaryEmployee:
                    salaryFactory = new HourlySalaryFactory(employee.HourlySalary, employee.MonthlySalary);
                    break;

                case ContractTypes.MonthlySalaryEmployee:
                    salaryFactory = new MonthlySalaryFactory(employee.HourlySalary, employee.MonthlySalary);
                    break;
            }

            employee.AnnualSalary = salaryFactory.GetSalary();
        }
    }
}
