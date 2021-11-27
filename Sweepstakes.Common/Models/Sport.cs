using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("Sport")]
    public class Sport
    {
        public Sport(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
