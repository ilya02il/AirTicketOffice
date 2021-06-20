using System;
using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
    public class FlightEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateFrom { get; set; }
        public bool IsActive { get; set; }


        public int PlaneId { get; set; }
        public virtual PlaneEntity Plane { get; set; }

        public int RouteId { get; set; }
        public virtual RouteEntity Route { get; set; }

        public virtual ICollection<TicketPriceEntity> TicketPrices { get; set; }
        public virtual ICollection<OrderEntity> Orders { get; set; }
        
    }
}
