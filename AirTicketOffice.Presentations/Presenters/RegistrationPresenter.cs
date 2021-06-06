using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Hashing;
using Model.Contracts;

namespace AirTicketOffice.Presentations.Presenters
{
	public class RegistrationPresenter : BasePresenter<IRegistrationView>
	{
		private readonly IRegistrationService _service;
		public RegistrationPresenter(IApplicationController controller, IRegistrationView view, IRegistrationService service)
			: base(controller, view)
		{
			_service = service;

			View.Register += () => Register(View.User);
		}

		public void Register(UserEntity user)
		{
			user.Salt = Hasher.GenerateSalt(20);
			user.HashedPassword = Hasher.HashPassword(user.HashedPassword, user.Salt);
			user.Proxy = false;

			_service.Register(user);

			View.Close();
		}
	}
}
