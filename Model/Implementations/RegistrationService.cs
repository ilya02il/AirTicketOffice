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

		public async void Register(UserEntity user)
		{
			_dbRepository.Add(user);
			await _dbRepository.SaveChangesAsync();
		}

		public bool VerifyLogin(string login)
		{
			return _dbRepository.Get<UserEntity>(u => u.Login == login).Any();
		}
	}
}
