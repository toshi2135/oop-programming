using System;
namespace HDT.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime NgayTao { get; set; }

        public User()
        {
        }
    }
}
