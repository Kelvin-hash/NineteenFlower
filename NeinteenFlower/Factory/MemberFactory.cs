using NeinteenFlower.Model;
using System;

namespace NeinteenFlower.Factory
{
    public class MemberFactory
    {
        public static MsMember CreateMember(string name, DateTime dob, string gender,
            string address, string phonenumber, string email, string password)
        {
            MsMember members = new MsMember
            {
                MemberEmail = email,
                MemberPassword = password,
                MemberName = name,
                MemberDOB = dob,
                MemberGender = gender,
                MemberPhone = phonenumber,
                MemberAddress = address
            };
            return members;
        }
    }
}