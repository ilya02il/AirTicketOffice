using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
    public class PlaneEntity : IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }

        public ICollection<FlightEntity> Flights { get; set; }
        public ICollection<CrewMemberEntity> Crew { get; set; }

        public PlaneEntity()
        {
            Flights = new List<FlightEntity>();
            Crew = new List<CrewMemberEntity>();
        }
    }
}
