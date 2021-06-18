﻿namespace AirTicketOffice.DAL.Entities
{
    public class TicketEntity : IEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }

        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }

        public int TicketPriceId { get; set; }
        public TicketPriceEntity TicketPrice { get; set; }
    }
}
