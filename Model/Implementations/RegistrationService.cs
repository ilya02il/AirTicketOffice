using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;
using System.Linq;

namespace Model.Implementations
{
	public class RegistrationService : IRegistrationService
	{
		private readonly IDbRepository _dbRepository;

		public RegistrationService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}

		public void Register(UserEntity user)
		{
			_dbRepository.Add(user);
			_dbRepository.SaveChangesAsync();
		}

		public bool VerifyLogin(string login)
		{
			var registeredUser = _dbRepository.Get<UserEntity>(u => u.Login == login).ToList().Count;

			return registeredUser == 0;
		}
	}
}
