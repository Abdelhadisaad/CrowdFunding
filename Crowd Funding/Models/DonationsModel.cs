using System;
namespace Crowd_Funding.Models
{
    public class DonationsModel
    {
        public double amount { get; set; }
        public string date { get; set; }
        public int goal_id { get; set; }
        public int reward_id { get; set; }
        public int user_id { get; set; }
    }
}
