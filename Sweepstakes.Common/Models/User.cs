using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("User")]
    public class User
    {
        public User(int id, string fullName, string phone, string email, string password, int roleId)
        {
            Id = id;
            FullName = fullName;
            Phone = phone;
            Email = email;
            Password = password;
            RoleId = roleId;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
