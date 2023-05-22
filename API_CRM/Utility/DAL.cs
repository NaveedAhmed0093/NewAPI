using API_CRM.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace API_CRM.Utility
{
    public class DAL
    {

        public static string CNString = "";
        public DAL()
        {
            var builder = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            CNString = _configuration.GetConnectionString("DefaultConnection");
        }


        public DataTable GetData(string SpName)
        {
            SqlConnection con = new SqlConnection();
            string dbTyper = "";
            try
            {
                con.ConnectionString = CNString;
                DataTable dt = new DataTable();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = SpName;
                cmd.CommandTimeout = 999999999;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();
                da.Dispose();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        //public DataTable CreateEmployee(string fullName, string lastName, DateTime dob, string email, string phoneNo, string address, string city, string province, string zipCode)
        public DataTable CreateEmployee(CreateEmployeeDTO employee)
        {
            SqlConnection con = new SqlConnection();
            string dbTyper = "";
            try
            {
                con.ConnectionString = CNString;
                DataTable dt = new DataTable();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = "SP_CreateEmployee";
                cmd.Parameters.AddWithValue("FullName", employee.FullName);
                cmd.Parameters.AddWithValue("LastName", employee.LastName);
                cmd.Parameters.AddWithValue("DateOfBirth", employee.DateOfBirth);
                cmd.Parameters.AddWithValue("Email", employee.Email);
                cmd.Parameters.AddWithValue("PhoneNumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("Address", employee.Address);
                cmd.Parameters.AddWithValue("City", employee.City);
                cmd.Parameters.AddWithValue("Province", employee.Province);
                cmd.Parameters.AddWithValue("ZipCode", employee.ZipCode);
                cmd.CommandTimeout = 999999999;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();
                da.Dispose();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        internal DataTable DeleteEmployee(DeleteEmployeeDTO employee)
        {
            throw new NotImplementedException();
        }

        public DataTable UpdateEmployee(UpdateEmployeeDTO employee)
        {
            SqlConnection con = new SqlConnection();
            string dbTyper = "";
            try
            {
                con.ConnectionString = CNString;
                DataTable dt = new DataTable();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = "SP_CreateEmployee";
                cmd.Parameters.AddWithValue("EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("FullName", employee.FullName);
                cmd.Parameters.AddWithValue("LastName", employee.LastName);
                cmd.Parameters.AddWithValue("DateOfBirth", employee.DateOfBirth);
                cmd.Parameters.AddWithValue("Email", employee.Email);
                cmd.Parameters.AddWithValue("PhoneNumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("Address", employee.Address);
                cmd.Parameters.AddWithValue("City", employee.City);
                cmd.Parameters.AddWithValue("Province", employee.Province);
                cmd.Parameters.AddWithValue("ZipCode", employee.ZipCode);
                cmd.CommandTimeout = 999999999;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();
                da.Dispose();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public DataTable DeleteEmployee(int EmployeeId)
        {
            SqlConnection con = new SqlConnection();
            string dbTyper = "";
            try
            {
                con.ConnectionString = CNString;
                DataTable dt = new DataTable();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = "SP_DeleteEmployee";
                cmd.Parameters.AddWithValue("EmployeeId", EmployeeId);
                cmd.CommandTimeout = 999999999;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();
                da.Dispose();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
