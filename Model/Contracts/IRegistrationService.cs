using AirTicketOffice.DAL.Entities;

namespace Model.Contracts
{
	public interface IRegistrationService
	{
		void Register(UserEntity user);
	}
}
