using System;
namespace Crowd_Funding.Models
{
    public class DonationsModel
    {
        public double amount { get; set; }
        public string date { get; set; }
        public string goal { get; set; }
        public string reward { get; set; }
        public int customerid { get; set; }
    }
}
