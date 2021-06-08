using System.Linq;
using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;

namespace Model.Implementations
{
	public class RouteService : IRouteService
	{
		private readonly IDbRepository _dbRepository;

		public RouteService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}

		public IQueryable<RouteEntity> GetAllRoutes()
		{
			return _dbRepository.GetAll<RouteEntity>();
		}

		public IQueryable<FlightEntity> GetRouteFlights(RouteEntity route)
		{
			return _dbRepository.GetAll<FlightEntity>().Where(flight => flight.RouteId == route.Id);
		}

		public void AddRoute(RouteEntity newRoute)
		{
			_dbRepository.Add(newRoute);
		}

		public void DeleteRoute(RouteEntity route)
		{
			_dbRepository.Delete<RouteEntity>(route.Id);
		}

		public void EditRouteInfo(RouteEntity route)
		{
			_dbRepository.Update(route);
		}
	}
}
