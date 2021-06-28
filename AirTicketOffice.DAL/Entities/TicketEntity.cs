using System;

namespace AirTicketOffice.DAL.Entities
{
    public class TicketEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsActive { get; set; }

        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }

        public int TicketPriceId { get; set; }
        public virtual TicketPriceEntity TicketPrice { get; set; }

    }
}
