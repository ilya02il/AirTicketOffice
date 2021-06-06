using System;
using System.Collections.Generic;
using System.Linq;
using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Hashing;
using Model.Contracts;

namespace Model.Implementations
{
	public class LoginService : ILoginService
	{
		private ICollection<UserEntity> _users;
		private readonly IDbRepository _dbRepository;

		public LoginService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}

		public void LoadUsers()
		{
			_users = _dbRepository.GetAll<UserEntity>().ToList();
		}

		public UserEntity Login(UserEntity user)
		{
			if (_users == null)
				throw new NullReferenceException("The users were not loaded.");

			var userFromDb = _users.FirstOrDefault(u => u.Login == user.Login);

			if (userFromDb == null)
				return null;

			var salt = userFromDb.Salt;
			var hashedPassword = Hasher.HashPassword(user.HashedPassword, salt);

			return hashedPassword == userFromDb.HashedPassword ? userFromDb : null;
		}
	}
}
