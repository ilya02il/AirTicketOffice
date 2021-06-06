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


        public int? PlaneId { get; set; }
        public PlaneEntity Plane { get; set; }

        public int? RouteId { get; set; }
        public RouteEntity Route { get; set; }

        public int? OrderId { get; set; }
        public OrderEntity Order { get; set; }

        public ICollection<TicketEntity> Tickets { get; set; }

        public FlightEntity()
        {
            Tickets = new List<TicketEntity>();
        }
    }
}
