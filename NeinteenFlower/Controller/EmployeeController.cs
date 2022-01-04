using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;

namespace NeinteenFlower.Controller
{
    public class EmployeeController
    {
        public static string Login(string email, string password)
        {
            if (email.Equals("") || password.Equals(""))
            {
                return "All fields must be filled";
            }
            if (!email.Contains("@") || !email.EndsWith(".com"))
            {
                return "Wrong Email Format";
            }
            if (EmployeeHandler.CheckUser(email, password) == false)
            {
                return "Wrong Email / Password";
            }
            return "";
        }
        public static string InsertEmployee(string name, DateTime dob, string gender,
          string address, string phonenumber, string email, string password, int salary)
        {
            if (email.Equals("") || password.Equals("") || name.Equals("") || dob.Equals("") ||
                  gender.Equals("") || phonenumber.Equals("") || address.Equals(""))
            {
                return "All fields must be filled";
            }
            if (!email.Contains("@") || !email.EndsWith(".com"))
            {
                return "Wrong Email Format";
            }
            if (password.Length < 3 || password.Length > 20)
            {
                return "Password length must be between 3 - 20 characters";
            }
            if (name.Length < 3 || name.Length > 20)
            {
                return "Name length must be between 3 - 20 characters";
            }
            if (dob.Year > 2004)
            {
                return "Minimal age is 17 years old";
            }
            if (!gender.Equals("male") && !gender.Equals("female") && !gender.Equals("Male") && !gender.Equals("Memale"))
            {
                return "Gender must be between Male or Female";
            }
            if (phonenumber.Length != 12)
            {
                return "Phone number must be 12 characters";
            }
            if (!address.Contains("Street") && !address.Contains("street"))
            {
                return " Address must contains 'street' ";
            }
            if (salary < 100 || salary > 1000)
            {
                return "Salary must be betweeen 100 - 1000";
            }

            return EmployeeHandler.InsertEmployee(name, dob, gender, address, phonenumber, email, password, salary);
        }
        public static string Update(int id, string name, DateTime dob, string gender,
          string address, string phonenumber, string email, string password, int salary)
        {
            if (email.Equals("") || password.Equals("") || name.Equals("") || dob.Equals("") ||
                  gender.Equals("") || phonenumber.Equals("") || address.Equals(""))
            {
                return "All fields must be filled";
            }
            if (!email.Contains("@") || !email.EndsWith(".com"))
            {
                return "Wrong Email Format";
            }
            if (password.Length < 3 || password.Length > 20)
            {
                return "Password length must be between 3 - 20 characters";
            }
            if (name.Length < 3 || name.Length > 20)
            {
                return "Name length must be between 3 - 20 characters";
            }
            if (dob.Year > 2004)
            {
                return "Minimal age is 17 years old";
            }
            if (!gender.Equals("male") && !gender.Equals("female") && !gender.Equals("Male") && !gender.Equals("Memale"))
            {
                return "Gender must be between Male or Female";
            }
            if (phonenumber.Length != 12)
            {
                return "Phone number must be 12 characters";
            }
            if (!address.Contains("Street") && !address.Contains("street"))
            {
                return " Address must contains 'street' ";
            }
            if (salary < 100 || salary > 1000)
            {
                return "Salary must be betweeen 100 - 1000";
            }

            return EmployeeHandler.UpdateEmployee(id, name, dob, gender, address, phonenumber, email, password, salary);
        }

        public static List<MsEmployee> GetAllEmployees()
        {
            return EmployeeHandler.GetAllEmployees();
        }

        public static MsEmployee GetEmployeeID(int id)
        {
            return EmployeeHandler.GetEmployeeID(id);
        }

        public static void DeleteEmployeeID(int id)
        {
            EmployeeHandler.DeleteEmployeeID(id);
        }
    }
}