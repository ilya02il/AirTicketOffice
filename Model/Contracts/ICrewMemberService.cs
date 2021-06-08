using AirTicketOffice.DAL.Entities;
using System.Linq;

namespace Model.Contracts
{
	public interface ICrewMemberService
	{
		IQueryable<CrewMemberEntity> GetAllCrewMembers();

		void AddCrewMember(CrewMemberEntity newCrewMember);
		void DeleteCrewMember(CrewMemberEntity crewMember);
		void EditCrewMemberInfo(CrewMemberEntity crewMember);
	}
}
