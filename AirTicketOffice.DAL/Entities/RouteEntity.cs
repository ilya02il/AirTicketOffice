using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
    public class RouteEntity : IEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }

        public int DepartureAirportId { get; set; }
        public virtual AirportEntity DepartureAirport { get; set; }

        public int ArrivalAirportId { get; set; }
        public virtual AirportEntity ArrivalAirport { get; set; }

        public virtual ICollection<FlightEntity> Flights { get; set; }
    }
}
