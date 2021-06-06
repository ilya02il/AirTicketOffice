using AirTicketOffice.DAL.Entities;

namespace Model.Contracts
{
	public interface ILoginService
	{
		UserEntity Login(UserEntity user);
		void LoadUsers();
	}
}
