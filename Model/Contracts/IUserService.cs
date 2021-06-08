using AirTicketOffice.DAL.Entities;
using System.Linq;

namespace Model.Contracts
{
	public interface IUserService
	{
		IQueryable<UserEntity> GetAllUsers();
		IQueryable<OrderEntity> GetUserOrders(UserEntity user);
		IQueryable<TicketEntity> GetUserTickets(UserEntity user);

		void AddUser(UserEntity newUser);
		void DeleteUser(UserEntity user);
		void EditUserInfo(UserEntity user);
	}
}
