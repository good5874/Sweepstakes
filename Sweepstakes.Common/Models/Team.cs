using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("Team")]
    public class Team
    {
        public Team(int id, string name, string country, string pictureURL)
        {
            Id = id;
            Name = name;
            Country = country;
            PictureURL = pictureURL;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string PictureURL { get; set; }
    }
}
