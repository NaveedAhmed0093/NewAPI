using API_CRM.Model;
using API_CRM.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API_CRM.Services
{
    public class EmployeeService
    {
        DAL dal = new DAL();

        public DataTable GetAllEmployee()
        {
            string Result = "";
            DataTable dt = new DataTable();
            bool IsSuccess = false;
            try
            {
                dt = dal.GetData("SP_GetData");

                IsSuccess = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            return dt;
        }
        public DataTable CreateEmployee(CreateEmployeeDTO employee)
        //public WebApiResponse CreateEmployee(string fullName, string lastName, DateTime dob, string email, string phoneNo, string address, string city, string province, string zipCode)
        {
            string Result = "";
            DataTable dt = new DataTable();
            bool IsSuccess = false;
            try
            {
                dt = dal.CreateEmployee(employee);

                IsSuccess = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            //return new WebApiResponse
            //{
            //    IsSuccess = IsSuccess,
            //    Result = dt
            //};
            return dt;
        }
        public DataTable UpdateEmployee(UpdateEmployeeDTO employee)
        {
            string Result = "";
            DataTable dt = new DataTable();
            bool IsSuccess = false;
            try
            {
                dt = dal.UpdateEmployee(employee);

                IsSuccess = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            //return new WebApiResponse
            //{
            //    IsSuccess = IsSuccess,
            //    Result = dt
            //};
            return dt;
        }
        public WebApiResponse DeleteEmployee(int EmployeeId)
        {
            string Result = "";
            DataTable dt = new DataTable();
            bool IsSuccess = false;
            try
            {
                dt = dal.DeleteEmployee(EmployeeId);

                IsSuccess = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            return new WebApiResponse
            {
                IsSuccess = IsSuccess,
                Result = dt
            };
        }
    }
}
