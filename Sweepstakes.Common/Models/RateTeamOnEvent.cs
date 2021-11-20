using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepstakes.Common.Models
{
    [Table("RateTeamOnEvent")]
    public class RateTeamOnEvent
    {
        public RateTeamOnEvent()
        {

        }

        public RateTeamOnEvent(int EventId, int TeamId, float Coefficient)
        {
            this.EventId = EventId;
            this.TeamId = TeamId;
            this.Coefficient = Coefficient;
        }

        public int EventId { get; set; }
        public int TeamId { get; set; }
        public float Coefficient { get; set; }
    }
}
