using Sweepstakes.Common.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("Bet")]
    public class Bet
    {
        public Bet(int Id, decimal Price, int CurrencyId, int Status, DateTime CreatedDate, int UserId, int EventId, int TeamId)
        {
            this.Id = Id;
            this.Price = Price;
            this.CurrencyId = CurrencyId;
            this.Status = (StatusBetEnum)Status;
            this.CreatedDate = CreatedDate;
            this.UserId = UserId;
            this.EventId = EventId;
            this.TeamId = TeamId;
        }

        public int Id { get; set; }
        public decimal Price { get; set; }
        public int CurrencyId { get; set; }
        public StatusBetEnum Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public int TeamId { get; set; }
    }
}
