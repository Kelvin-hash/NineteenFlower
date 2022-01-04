using NeinteenFlower.Factory;
using NeinteenFlower.Model;
using NeinteenFlower.Repository;
using System;
using System.Collections.Generic;

namespace NeinteenFlower.Handler
{
    public class MemberHandler
    {
        public static MsMember Login(string email, string password)
        {
            MsMember members = MemberRepository.Login(email, password);
            return members ?? null;
        }

        public static bool CheckUser(string email, string password)
        {
            MsMember members = MemberRepository.Login(email, password);
            return (members != null);
        }

        public static string Register(string name, DateTime dob, string gender,
            string address, string phonenumber, string email, string password)
        {
            bool checkemail = MemberRepository.checkUnique(email);
            if (checkemail == false)
            {
                return "Email already Exist";
            }
            MsMember members = MemberFactory.CreateMember(name, dob, gender, address, phonenumber, email, password);
            MemberRepository.Register(members);
            return "";
        }

        public static string Update(int id, string name, DateTime dob, string gender,
            string address, string phonenumber, string email, string password)
        {
            bool checkemail = MemberRepository.checkUnique(email);
            if (checkemail == false)
            {
                return "Email must be unique";
            }
            MemberRepository.UpdatebyID(id, email, password, name, dob, gender, phonenumber, address);
            return "";
        }

        public static string ChangePassword(string email, string newpassword)
        {
            bool checkemail = MemberRepository.checkEmail(email);
            if (checkemail == false)
            {
                return "Email doesn't Exist";
            }
            else
            {
                MemberRepository.updatePassword(email, newpassword);
                return "";
            }
        }

        public static List<MsMember> GetAllMembers()
        {
            return MemberRepository.GetAllMembers();
        }

        public static MsMember GetMemberID(int id)
        {
            return MemberRepository.GetMemberID(id);
        }

        public static void DeleteMemberID(int id)
        {
            MemberRepository.DeletebyID(id);
        }
    }
}