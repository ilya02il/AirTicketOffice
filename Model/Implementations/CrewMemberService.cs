using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;
using System.Linq;

namespace Model.Implementations
{
	public class CrewMemberService : ICrewMemberService
	{
		private readonly IDbRepository _dbRepository;

		public CrewMemberService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}

		public IQueryable<CrewMemberEntity> GetAllCrewMembers()
		{
			return _dbRepository.GetAll<CrewMemberEntity>();
		}

		public void AddCrewMember(CrewMemberEntity newCrewMember)
		{
			_dbRepository.Add(newCrewMember);
		}

		public void DeleteCrewMember(CrewMemberEntity crewMember)
		{
			_dbRepository.Delete<CrewMemberEntity>(crewMember.Id);
		}

		public void EditCrewMemberInfo(CrewMemberEntity crewMember)
		{
			_dbRepository.Update(crewMember);
		}
	}
}
