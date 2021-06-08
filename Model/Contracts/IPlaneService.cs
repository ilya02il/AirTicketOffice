using AirTicketOffice.DAL.Entities;
using System.Linq;

namespace Model.Contracts
{
	public interface IPlaneService
	{
		IQueryable<PlaneEntity> GetAllPlanes();
		IQueryable<FlightEntity> GetPlaneFlights(PlaneEntity plane);
		IQueryable<CrewMemberEntity> GetPlaneCrewMembers(PlaneEntity plane);

		void AddPlane(PlaneEntity newPlane);
		void DeletePlane(PlaneEntity plane);
		void EditPlaneInfo(PlaneEntity plane);
	}
}
