using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeinteenFlower.Repository
{
    public class MemberRepository
    {
        public static MsMember Login(string email, string password)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsMember members = (from x in db.MsMembers where x.MemberEmail.Equals(email) && x.MemberPassword.Equals(password) select x).FirstOrDefault();
            return members;
        }
        public static void Register(MsMember members)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            db.MsMembers.Add(members);
            db.SaveChanges();
        }

        public static bool checkUnique(string email)
        {
            if (email == "admin@shop.com") return false;
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsMember check = (from data in db.MsMembers where data.MemberEmail.Equals(email) select data).FirstOrDefault();
            return check == null;
        }

        public static bool checkEmail(string email)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsMember check = (from data in db.MsMembers where data.MemberEmail.Equals(email) select data).FirstOrDefault();
            return check == null;
        }

        public static void updatePassword(string email, string newpassword)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsMember members = (from x in db.MsMembers where x.MemberEmail.Equals(email) select x).FirstOrDefault();
            members.MemberPassword = newpassword;
            db.SaveChanges();
        }

        public static List<MsMember> GetAllMembers()
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return (from x in db.MsMembers select x).ToList();
        }

        public static MsMember GetMemberID(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsMember members = (from x in db.MsMembers where x.MemberID == id select x).FirstOrDefault();
            return members;
        }

        public static void DeletebyID(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsMember members = (from x in db.MsMembers where x.MemberID == id select x).FirstOrDefault();
            db.MsMembers.Remove(members);
            db.SaveChanges();
        }

        public static void UpdatebyID(int id, string email, string password, string name, DateTime dob, string gender, string phone, string address)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsMember members = (from x in db.MsMembers where x.MemberID == id select x).FirstOrDefault();
            members.MemberEmail = email;
            members.MemberPassword = password;
            members.MemberName = name;
            members.MemberDOB = dob;
            members.MemberGender = gender;
            members.MemberPhone = phone;
            members.MemberAddress = address;
            db.SaveChanges();
        }
    }
}