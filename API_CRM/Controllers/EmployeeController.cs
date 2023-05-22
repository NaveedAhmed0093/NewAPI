using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_CRM.Services;
using API_CRM.Utility;
using Microsoft.AspNetCore.Http;
using API_CRM.Model;
using System.Data;
using Newtonsoft.Json;
using Nancy.Json;
using Polly;




namespace API_CRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeService EmployeeService;
        public EmployeeController()
        {
            this.EmployeeService = new EmployeeService();
        }
        // GET: api/Employee
        [HttpGet]
        public string Get()
        {
            string JSONString = string.Empty;
            DataTable dt = new DataTable();
            dt= EmployeeService.GetAllEmployee();
            JSONString = JsonConvert.SerializeObject(dt);
            return JSONString;
           
        }
      

  
        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        [HttpPost]
        public string Post(CreateEmployeeDTO employee)
        // public void Post(string fullName, string lastName, string dob, string email, string phoneNo, string address, string city, string province, string zipCode)
        {
            //DateTime dateOfBirth = DateTime.Now;
            // employee.DateOfBirth = dateOfBirth;

            //EmployeeService.CreateEmployee(employee);

            string JSONString = string.Empty;
            DataTable dt = new DataTable();
            dt = EmployeeService.CreateEmployee(employee);
            JSONString = JsonConvert.SerializeObject(dt);
            return JSONString;
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public string Put(UpdateEmployeeDTO employee)
        {
            //DateTime dateOfBirth = DateTime.Now;
            //DateTime.TryParse(dob, out dateOfBirth);
            // employee.DateOfBirth = dateOfBirth;

            // EmployeeService.UpdateEmployee(employee);
            string JSONString = string.Empty;
            DataTable dt = new DataTable();
            dt = EmployeeService.UpdateEmployee(employee);
            JSONString = JsonConvert.SerializeObject(dt);
            return JSONString;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            EmployeeService.DeleteEmployee(id);
        }
    }
}
