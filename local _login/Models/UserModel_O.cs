using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace local__login.Models
{
    public class UserModel_O
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime dateOfBirth { get; set; }

    }
}