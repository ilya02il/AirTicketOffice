using System.Linq;
using AirTicketOffice.DAL.Entities;

namespace Model.Contracts
{
	public interface IRouteService
	{
		IQueryable<RouteEntity> GetAllRoutes();
		IQueryable<FlightEntity> GetRouteFlights(RouteEntity route);

		void AddRoute(RouteEntity newRoute);
		void DeleteRoute(RouteEntity route);
		void EditRouteInfo(RouteEntity route);
	}
}
