namespace AirTicketOffice.DAL.Entities
{
	public interface IEntity
	{
		int Id { get; set; }
		bool IsActive { get; set; }
	}
}
