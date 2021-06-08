using AirTicketOffice.DAL.Entities;
using System.Linq;

namespace Model.Contracts
{
	public interface ITicketService
	{
		IQueryable<TicketEntity> GetAllTickets();

		void AddTicket(TicketEntity newTicket);
		void DeleteTicket(TicketEntity ticket);
		void EditTicketInfo(TicketEntity ticket);
	}
}
