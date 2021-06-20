using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
	public class TicketPriceEntity : IEntity
	{
		public int Id { get; set; }
		public int Price { get; set; }
		public bool IsActive { get; set; }

		public int ClassId { get; set; }
		public virtual ClassEntity Class { get; set; }

		public int FlightId { get; set; }
		public virtual FlightEntity Flight { get; set; }

		public virtual ICollection<TicketEntity> Tickets { get; set; }
	}
}
