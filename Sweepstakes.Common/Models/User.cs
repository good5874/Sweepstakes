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

        public User(int Id, string Name, string Phone, string Email, string Password, int RoleId)
        {
            this.Id = Id;
            this.Name = Name;
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
