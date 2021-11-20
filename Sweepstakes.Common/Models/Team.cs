using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("Team")]
    public class Team
    {
        public Team()
        {

        }

        public Team(int Id, string Name, string Country, string PictureURL)
        {
            this.Id = Id;
            this.Name = Name;
            this.Country = Country;
            this.PictureURL = PictureURL;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string PictureURL { get; set; }
    }
}
