using Sweepstakes.Common.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("Event")]
    public class Event
    {
        public Event(int id, StatusEvent status, DateTime createdDate, int sportid, int winningTeamId)
        {
            Id = id;
            Status = status;
            CreatedDate = createdDate;
            Sportid = sportid;
            WinningTeamId = winningTeamId;
        }

        public int Id { get; set; }
        public StatusEvent Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Sportid { get; set; }
        public int WinningTeamId { get; set; }
    }
}
