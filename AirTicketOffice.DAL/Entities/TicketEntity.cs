namespace AirTicketOffice.DAL.Entities
{
    public class TicketEntity : IEntity
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public bool IsActive { get; set; }

        public int FlightId { get; set; }
        public virtual FlightEntity Flight { get; set; }

        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }

        public int ClassId { get; set; }
        public virtual ClassEntity Class { get; set; }
    }
}
