namespace AirTicketOffice.DAL.Entities
{
    public class TicketEntity : IEntity
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public int Cost { get; set; }
        public bool IsActive { get; set; }

        public int FlightId { get; set; }
        public FlightEntity Flight { get; set; }

        public int? UserId { get; set; }
        public UserEntity User { get; set; }


    }
}
