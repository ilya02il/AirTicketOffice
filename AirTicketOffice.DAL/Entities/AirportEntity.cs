using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
    public class AirportEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<RouteEntity> DepartureRoutes { get; set; }
        public virtual ICollection<RouteEntity> ArrivalRoutes { get; set; }
    }
}
