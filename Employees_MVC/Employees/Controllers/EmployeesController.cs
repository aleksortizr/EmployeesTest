using Employees.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Employees.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IConfiguration _configuration;
        public EmployeesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Initializes a blank collection
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var employeeResults = new EmployeeQuery { Employees = new List<Employee>() };
            return View(employeeResults);
        }

        
        /// <summary>
        /// Invokes the Empoyees API to show the calculated results
        /// </summary>
        /// <param name="employeeQuery"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("EmployeeId")] EmployeeQuery employeeQuery)
        {
            string getEmployeesURL = _configuration.GetSection("Settings").GetSection("WebAPI").GetValue<string>("Url");
            string queryString = string.Empty;

            if (!string.IsNullOrEmpty(employeeQuery.EmployeeId))
            {
                queryString = $"?id={employeeQuery.EmployeeId}";
            }

            getEmployeesURL += $"/api/Employees{queryString}"; 
            using HttpClient client = new HttpClient();

            try
            {
                var result = await client.GetStringAsync(getEmployeesURL);
                var apiResult = JsonConvert.DeserializeObject<List<Employee>>(result);
                var employeeResults = new EmployeeQuery { Employees = apiResult };
                return View(employeeResults);
            }
            catch
            {
                return View(new EmployeeQuery());
            }
        }
    }
}
