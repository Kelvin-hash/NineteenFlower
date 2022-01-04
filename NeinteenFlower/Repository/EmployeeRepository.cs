using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Repository
{
    public class EmployeeRepository
    {
        public static MsEmployee Login(string email, string password)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsEmployee members = (from x in db.MsEmployees where x.EmployeeEmail.Equals(email) && x.EmployeePassword.Equals(password) select x).FirstOrDefault();
            return members;
        }

        public static List<MsEmployee> GetAllEmployees()
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return (from x in db.MsEmployees select x).ToList();
        }

        public static void InsertEmployee(MsEmployee employee)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            db.MsEmployees.Add(employee);
            db.SaveChanges();
        }

        public static bool checkUnique(string email)
        {
            if (email == "admin@shop.com") return false;
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsEmployee check = (from data in db.MsEmployees where data.EmployeeEmail.Equals(email) select data).FirstOrDefault();
            return check == null;
        }

        public static MsEmployee GetEmployeeID(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsEmployee employees = (from x in db.MsEmployees where x.EmployeeID == id select x).FirstOrDefault();
            return employees;
        }

        public static void DeletebyID(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsEmployee employee = (from x in db.MsEmployees where x.EmployeeID == id select x).FirstOrDefault();
            db.MsEmployees.Remove(employee);
            db.SaveChanges();
        }

        public static void UpdatebyID(int id, string email, string password, string name, DateTime dob, string gender, string phone, string address, int salary)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsEmployee employee = (from x in db.MsEmployees where x.EmployeeID == id select x).FirstOrDefault();
            employee.EmployeeEmail = email;
            employee.EmployeePassword = password;
            employee.EmployeeName = name;
            employee.EmployeeDOB = dob;
            employee.EmployeeGender = gender;
            employee.EmployeePhone = phone;
            employee.EmployeeAddress = address;
            employee.EmployeeSalary = salary;
            db.SaveChanges();
        }
    }
}