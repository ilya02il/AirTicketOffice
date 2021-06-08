using AirTicketOffice.DAL.Entities;
using System.Linq;

namespace Model.Contracts
{
	public interface IFlightService
	{
		IQueryable<FlightEntity> GetAllFlights();
		IQueryable<TicketEntity> GetFlightTickets(FlightEntity flight);

		void AddFlight(FlightEntity newFlight);
		void DeleteFlight(FlightEntity flight);
		void EditFlightInfo(FlightEntity flight);
	}
}
