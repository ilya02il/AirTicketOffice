using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;

namespace Model.Implementations
{
	public class FlightService : IFlightService
	{
		private readonly IDbRepository _dbRepository;

		public FlightService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}

		public IQueryable<FlightEntity> GetAllFlights()
		{
			return _dbRepository.GetAll<FlightEntity>();
		}

		public IQueryable<TicketEntity> GetFlightTickets(FlightEntity flight)
		{
			return _dbRepository.GetAll<TicketEntity>().Where(ticket => ticket.FlightId == flight.Id);
		}

		public void AddFlight(FlightEntity newFlight)
		{
			_dbRepository.Add(newFlight);
		}

		public void DeleteFlight(FlightEntity flight)
		{
			_dbRepository.Delete<FlightEntity>(flight.Id);
		}

		public void EditFlightInfo(FlightEntity flight)
		{
			_dbRepository.Update(flight);
		}
	}
}
