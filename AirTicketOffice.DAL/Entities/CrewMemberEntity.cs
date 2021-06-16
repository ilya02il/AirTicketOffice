namespace AirTicketOffice.DAL.Entities
{
    public class CrewMemberEntity : IEntity
    {
        public int Id { get; set; }
        public string Initials { get; set; }
        public string Position { get; set; }
        public bool IsActive { get; set; }

        public int PlaneId { get; set; }
        public virtual PlaneEntity Plane { get; set; }
    }
}
