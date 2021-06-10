using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;

namespace AirTicketOffice.Presentations.Presenters
{
	public class RegistrationStartPresenter : BasePresenter<IRegistrationStartView, UserEntity>
	{
		private UserEntity _user;
		public RegistrationStartPresenter(IApplicationController controller, IRegistrationStartView view)
			: base(controller, view)
		{
			View.NextStep += () => NextStep(View.User);
			View.Back += Back;
		}

		public override void Run(UserEntity argument)
		{
			_user = argument;
			View.User = argument;
			View.Show();
		}

		public void NextStep(UserEntity user)
		{
			user.Surname = _user.Surname;
			user.Name = _user.Name;
			user.Patronymic = _user.Patronymic;
			user.Gender = _user.Gender;
			user.PassportNumber = _user.PassportNumber;
			user.PhoneNumber = _user.PhoneNumber;

			if (user.Login == string.Empty)
			{
				View.GetMessage("Заполните поле с логином.");
				return;
			}
			if (user.HashedPassword == string.Empty)
			{
				View.GetMessage("Заполните поле с паролем.");
				return;
			}

			Controller.Run<RegistrationPresenter, UserEntity>(user);
			View.Close();
		}

		public void Back()
		{
			Controller.Run<LoginPresenter>();
			View.Close();
		}
	}
}
