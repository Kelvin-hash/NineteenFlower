using NeinteenFlower.Factory;
using NeinteenFlower.Model;
using NeinteenFlower.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Handler
{
    public class EmployeeHandler
    {
        public static MsEmployee Login(string email, string password)
        {
            MsEmployee members = EmployeeRepository.Login(email, password);
            return members ?? null;
        }

        public static bool CheckUser(string email, string password)
        {
            MsEmployee members = EmployeeRepository.Login(email, password);
            return (members != null);
        }

        public static string InsertEmployee(string name, DateTime dob, string gender,
            string address, string phonenumber, string email, string password, int salary)
        {
            bool unique = EmployeeRepository.checkUnique(email);
            if (!unique)
            {
                return "Email already Exist";
            }
            MsEmployee employee = EmployeeFactory.CreateEmployee(name, dob, gender, address, phonenumber, email, password, salary);
            EmployeeRepository.InsertEmployee(employee);
            return "";
        }

        public static string UpdateEmployee(int id, string name, DateTime dob, string gender,
            string address, string phonenumber, string email, string password, int salary)
        {
            bool unique = EmployeeRepository.checkUnique(email);
            if (!unique)
            {
                return "Email must be unique";
            }
            EmployeeRepository.UpdatebyID(id, email, password, name, dob, gender, phonenumber, address, salary);
            return "";
        }

        public static List<MsEmployee> GetAllEmployees()
        {
            return EmployeeRepository.GetAllEmployees();
        }

        public static MsEmployee GetEmployeeID(int id)
        {
            return EmployeeRepository.GetEmployeeID(id);
        }

        public static void DeleteEmployeeID(int id)
        {
            EmployeeRepository.DeletebyID(id);
        }
    }
}