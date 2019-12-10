using Employees_BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Employees_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        Employees_Business_Manager _employeesManager;
        protected readonly ILogger _logger;

        public EmployeesController(ILoggerFactory loggerFactory)
        {
            _employeesManager = new Employees_Business_Manager();
            _logger = loggerFactory.CreateLogger(this.GetType().Name);
        }
        // GET: api/Employees
        [HttpGet]
        public async Task<IActionResult> GetAsync(int? id)
        {
            try
            {
                var result = await _employeesManager.GetEmployeesAsync(id);
                return Ok(JsonConvert.SerializeObject(result));
            }
            catch(Exception ex)
            {
                _logger.LogError($"There was a problem fetching the employees list or The employee {id} does not exist. Error: { ex.Message }");
                return Conflict($"There was a problem fetching the employees list or The employee {id} does not exist");
            }
        }

    }
}
