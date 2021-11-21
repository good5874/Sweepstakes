using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("User")]
    public class User
    {
        public User()
        {

        }

        public User(int Id)
        {
            this.Id = Id;
        }

        public User(int Id, string FullName, string Phone, string Email, string Password, int RoleId)
        {
            this.Id = Id;
            this.FullName = FullName;
            this.Phone = Phone;
            this.Email = Email;
            this.Password = Password;
            this.RoleId = RoleId;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
