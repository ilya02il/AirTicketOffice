using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
	public class ClassEntity : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsActive { get; set; }

		public virtual ICollection<SeatEntity> Seats { get; set; }
		public virtual ICollection<TicketPriceEntity> TicketPrices { get; set; }
	}
}
