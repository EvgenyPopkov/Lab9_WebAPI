using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_WebAPI
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public string date { get; set; }
    }

    public static class UserData
    {
        public static List<User> users = new List<User>();
    }
}
