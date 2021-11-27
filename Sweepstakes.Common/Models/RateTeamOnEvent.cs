using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("RateTeamOnEvent")]
    public class RateTeamOnEvent
    {
        public RateTeamOnEvent(int eventId, int teamId, float coefficient)
        {
            EventId = eventId;
            TeamId = teamId;
            Coefficient = coefficient;
        }

        public int EventId { get; set; }
        public int TeamId { get; set; }
        public float Coefficient { get; set; }
    }
}
