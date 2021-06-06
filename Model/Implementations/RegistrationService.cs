using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;

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
		}
	}
}
