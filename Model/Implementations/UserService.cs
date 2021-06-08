using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;
using System.Linq;

namespace Model.Implementations
{
	public class UserService : IUserService
	{
		private readonly IDbRepository _dbRepository;

		public UserService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}


		public IQueryable<UserEntity> GetAllUsers()
		{
			return _dbRepository.GetAll<UserEntity>();
		}

		public IQueryable<OrderEntity> GetUserOrders(UserEntity user)
		{
			return _dbRepository.GetAll<OrderEntity>().Where(order => order.UserId == user.Id);
		}

		public IQueryable<TicketEntity> GetUserTickets(UserEntity user)
		{
			return _dbRepository.GetAll<TicketEntity>().Where(ticket => ticket.UserId == user.Id);
		}

		public void AddUser(UserEntity newUser)
		{
			_dbRepository.Add(newUser);
		}

		public void DeleteUser(UserEntity user)
		{
			_dbRepository.Delete<UserEntity>(user.Id);
		}

		public void EditUserInfo(UserEntity user)
		{
			_dbRepository.Update(user);
		}
	}
}
