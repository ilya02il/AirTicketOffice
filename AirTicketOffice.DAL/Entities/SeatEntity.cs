namespace AirTicketOffice.DAL.Entities
{
	public class SeatEntity : IEntity
	{
		public int Id { get; set; }
		public int Amount { get; set; }
		public bool IsActive { get; set; }

		public int PlaneId { get; set; }
		public virtual PlaneEntity Plane { get; set; }

		public int ClassId { get; set; }
		public virtual ClassEntity Class { get; set; }
	}
}
