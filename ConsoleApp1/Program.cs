using Employees_DataAccess;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var service = new EmployeesDAL();
            string URL = "http://masglobaltestapi.azurewebsites.net/";
            var result = await service.GetAllEmployees();
        }
    }
}
