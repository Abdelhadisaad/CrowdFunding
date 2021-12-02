using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowd_Funding.Models
{
    public class UsersModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phonenumber { get; set; }
        public string role { get; set; }
    }

    public class DonationsModel {
        public double amount { get; set; }
        public string date { get; set; }
        public string goal { get; set; }
        public string reward { get; set; }
        public int customerid { get; set; }
    }
}
