using NeinteenFlower.Model;
using System;

namespace NeinteenFlower.Factory
{
    public class EmployeeFactory
    {
        public static MsEmployee CreateEmployee(string name, DateTime dob, string gender,
            string address, string phonenumber, string email, string password, int salary)
        {
            MsEmployee employee = new MsEmployee();
            employee.EmployeeEmail = email;
            employee.EmployeePassword = password;
            employee.EmployeeName = name;
            employee.EmployeeDOB = dob;
            employee.EmployeeGender = gender;
            employee.EmployeePhone = phonenumber;
            employee.EmployeeAddress = address;
            employee.EmployeeSalary = salary;
            return employee;
        }
    }
}