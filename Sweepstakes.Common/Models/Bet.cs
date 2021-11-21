using Sweepstakes.Common.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("Bet")]
    public class Bet
    {
        public Bet(int id, decimal price, int currencyId, StatusBetEnum status, DateTime createdDate, int userId, int eventId, int teamId)
        {
            Id = id;
            Price = price;
            CurrencyId = currencyId;
            Status = status;
            CreatedDate = createdDate;
            UserId = userId;
            EventId = eventId;
            TeamId = teamId;
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
