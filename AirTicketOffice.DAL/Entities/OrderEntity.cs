using System;
using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
    public class OrderEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime DesiredDate { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsActive { get; set; }

        public int? UserId { get; set; }
        public UserEntity User { get; set; }

        public int? OfficeId { get; set; }
        public OfficeEntity Office { get; set; }

        public ICollection<FlightEntity> Flights { get; set; }

        public OrderEntity()
        {
            Flights = new List<FlightEntity>();
        }
    }
}
