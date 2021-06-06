using System;

namespace AirTicketOffice.DAL.Entities
{
    public class EventEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime EndingDate { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
    }
}
