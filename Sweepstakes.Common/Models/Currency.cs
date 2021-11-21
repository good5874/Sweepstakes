using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("Currency")]
    public class Currency
    {
        public Currency(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
