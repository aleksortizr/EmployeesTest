using Newtonsoft.Json;
using System;

namespace Employees_Common
{
    public class EmployeesDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contractTypeName")]
        public string ContractTypeName { get; set; }

        [JsonProperty("roleId")]
        public int RoleId { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("roleDescription")]
        public string RoleDescription { get; set; }

        [JsonProperty("hourlySalary")]
        public decimal HourlySalary { get; set; }

        [JsonProperty("monthlySalary")]
        public decimal MonthlySalary { get; set; }

        public decimal AnnualSalary { get; set; }
    }
}
