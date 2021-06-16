using System;

namespace AirTicketOffice.DAL.Entities
{
    public class OrderEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime DesiredDate { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsActive { get; set; }

        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }

        public int OfficeId { get; set; }
        public virtual OfficeEntity Office { get; set; }

        public int FlightId { get; set; }
        public virtual FlightEntity Flight { get; set; }
    }
}
