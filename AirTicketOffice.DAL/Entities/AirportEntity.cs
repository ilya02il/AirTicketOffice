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

        public ICollection<RouteEntity> Routes { get; set; }

        public AirportEntity()
        {
            Routes = new List<RouteEntity>();
        }
    }
}
