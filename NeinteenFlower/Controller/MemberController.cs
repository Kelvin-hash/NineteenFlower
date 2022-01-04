using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;

namespace NeinteenFlower.Controller
{
    public class MemberController
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
            if (email == "admin@shop.com")
            {
                if(password == "admin123")
                {
                    return "ADMIN";
                }
                return "Wrong Email / Password";
            }
            if (MemberHandler.CheckUser(email, password) == false)
            {
                return "Wrong Email / Password";
            }
            
            return "";
        }

        public static string ChangePassword(string email, string newpassword, string captcha)
        {
            if (email.Equals("") || newpassword.Equals(""))
            {
                return "All fields must be filled";
            }
            if (!email.Contains("@") || !email.EndsWith(".com"))
            {
                return "Wrong Email Format";
            }
            if (!newpassword.Equals(captcha))
            {
                return "New password must be same with captcha";
            }

            if (MemberHandler.ChangePassword(email, newpassword).Equals(""))
            {
                return "";
            }
            else
            {
                return "Member with this Email doesn't Exist";
            }
        }

        public static string Register(string name, DateTime dob, string gender,
           string address, string phonenumber, string email, string password)
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
            if (!gender.Equals("male") && !gender.Equals("female"))
            {
                return "Gender must be between Male or Female";
            }
            if (phonenumber.Length != 12)
            {
                return "Phone number must be 12 characters";
            }
            if (!address.Contains("Street"))
            {
                return " Address must contains 'street' ";
            }

            return MemberHandler.Register(name, dob, gender, address, phonenumber, email, password);
        }

        public static string Update(int id, string name, DateTime dob, string gender,
          string address, string phonenumber, string email, string password)
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

            return MemberHandler.Update(id, name, dob, gender, address, phonenumber, email, password);
        }

        public static List<MsMember> GetAllMembers()
        {
            return MemberHandler.GetAllMembers();
        }

        public static MsMember GetMemberID(int id)
        {
            return MemberHandler.GetMemberID(id);
        }

        public static void DeleteMemberID(int id)
        {
            MemberHandler.DeleteMemberID(id);
        }
    }
}