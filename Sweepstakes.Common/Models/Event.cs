using Sweepstakes.Common.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("Event")]
    public class Event
    {
        public Event()
        {

        }

        public Event(int Id, int Status, DateTime CreatedDate, int Sportid, int WinningTeamId)
        {
            this.Id = Id;
            this.CreatedDate = CreatedDate;
            this.Sportid = Sportid;
            this.Status = (StatusEventEnum)Status;
            this.WinningTeamId = WinningTeamId;
        }

        public int Id { get; set; }
        public StatusEventEnum Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Sportid { get; set; }
        public int WinningTeamId { get; set; }
    }
}
