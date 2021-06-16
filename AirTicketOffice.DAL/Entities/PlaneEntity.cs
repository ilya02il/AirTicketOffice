using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
    public class PlaneEntity : IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<FlightEntity> Flights { get; set; }
        public virtual ICollection<CrewMemberEntity> Crew { get; set; }
        public virtual ICollection<SeatEntity> Seats { get; set; }
    }
}
