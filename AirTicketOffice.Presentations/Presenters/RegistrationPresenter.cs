using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Hashing;
using Model.Contracts;

namespace AirTicketOffice.Presentations.Presenters
{
	public class RegistrationPresenter : BasePresenter<IRegistrationView, UserEntity>
	{
		private UserEntity _currentUser;
		private readonly IRegistrationService _registrationService;

		public RegistrationPresenter(IApplicationController controller, IRegistrationView view, IRegistrationService registrationService)
		: base(controller, view)
		{
			_registrationService = registrationService;

			View.Register += () => Register(View.User);
			View.Back += Back;
		}

		public override void Run(UserEntity argument)
		{
			_currentUser = argument;
			View.User = argument;
			View.Show();
		}

		public void Back()
		{
			var user = View.User;
			user.Login = _currentUser.Login;
			user.HashedPassword = _currentUser.HashedPassword;

			Controller.Run<RegistrationStartPresenter, UserEntity>(user);
			View.Close();
		}

		public void Register(UserEntity user)
		{
			user.Login = _currentUser.Login;
			user.HashedPassword = _currentUser.HashedPassword;

			if (user.Surname == string.Empty)
			{
				View.GetMessage("Заполните поле с фамилией.");
				return;
			}
			if (user.Name == string.Empty)
			{
				View.GetMessage("Заполните поле с именем.");
				return;
			}
			if (user.Patronymic == string.Empty)
			{
				View.GetMessage("Заполните поле с отчеством.");
				return;
			}
			if (user.PassportNumber == string.Empty)
			{
				View.GetMessage("Заполните поле с номером паспорта.");
				return;
			}
			if (user.PhoneNumber == string.Empty)
			{
				View.GetMessage("Заполните поле с номером телефона.");
				return;
			}

			if (_registrationService.VerifyLogin(user.Login))
			{
				View.GetMessage("Введенный Вами логин уже занят.");

				Controller.Run<RegistrationStartPresenter, UserEntity>(user);
				View.Close();
				return;
			}

			user.Salt = Hasher.GenerateSalt(20);
			user.HashedPassword = Hasher.HashPassword(user.HashedPassword, user.Salt);
			user.Proxy = false;

			_registrationService.Register(user);

			Controller.Run<RegistrationFinishPresenter>();

			Controller.Run<LoginPresenter>();
			View.Close();
		}
	}
}
