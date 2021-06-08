using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;
using System.Linq;

namespace Model.Implementations
{
	public class PlaneService : IPlaneService
	{
		private readonly IDbRepository _dbRepository;

		public PlaneService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}

		public IQueryable<PlaneEntity> GetAllPlanes()
		{
			return _dbRepository.GetAll<PlaneEntity>();
		}

		public IQueryable<FlightEntity> GetPlaneFlights(PlaneEntity plane)
		{
			return _dbRepository.GetAll<FlightEntity>().Where(flight => flight.PlaneId == plane.Id);
		}

		public IQueryable<CrewMemberEntity> GetPlaneCrewMembers(PlaneEntity plane)
		{
			return _dbRepository.GetAll<CrewMemberEntity>().Where(crewMember => crewMember.PlaneId == plane.Id);
		}

		public void AddPlane(PlaneEntity newPlane)
		{
			_dbRepository.Add(newPlane);
		}

		public void DeletePlane(PlaneEntity plane)
		{
			_dbRepository.Delete<PlaneEntity>(plane.Id);
		}

		public void EditPlaneInfo(PlaneEntity plane)
		{
			_dbRepository.Update(plane);
		}
	}
}
