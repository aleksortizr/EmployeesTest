﻿using Employees_Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Employees_DataAccess
{
    public class EmployeesDAL
    {
        public string APIAddress { get; set; }

        public async Task<List<EmployeesDTO>> GetAllEmployees()
        {
            using var client = new HttpClient();
            string result = await client.GetStringAsync("http://masglobaltestapi.azurewebsites.net/api/Employees");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<EmployeesDTO>>(result); 
        }
    }
}
