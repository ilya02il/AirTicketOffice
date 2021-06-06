using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
    public class RouteEntity : IEntity
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public bool IsActive { get; set; }

        public int AirportId { get; set; }
        public AirportEntity Airport { get; set; }

        public ICollection<FlightEntity> Flights { get; set; }

        public RouteEntity()
        {
            Flights = new List<FlightEntity>();
        }
    }
}
