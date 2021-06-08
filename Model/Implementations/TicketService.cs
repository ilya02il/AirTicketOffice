using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;
using System.Linq;

namespace Model.Implementations
{
	public class TicketService : ITicketService
	{
		private readonly IDbRepository _dbRepository;

		public TicketService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}

		public IQueryable<TicketEntity> GetAllTickets()
		{
			return _dbRepository.GetAll<TicketEntity>();
		}

		public void AddTicket(TicketEntity newTicket)
		{
			_dbRepository.Add(newTicket);
		}

		public void DeleteTicket(TicketEntity ticket)
		{
			_dbRepository.Delete<TicketEntity>(ticket.Id);
		}

		public void EditTicketInfo(TicketEntity ticket)
		{
			_dbRepository.Update(ticket);
		}
	}
}
