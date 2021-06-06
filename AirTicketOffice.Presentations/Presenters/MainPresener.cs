using System;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;

namespace AirTicketOffice.Presentations.Presenters
{
    public class MainPresenter : BasePresenter<IMainView, UserEntity>
    {
        private UserEntity _user;
        
        public MainPresenter(IApplicationController controller, IMainView view) : base(controller, view)
        {
            //View.ChangeUsername += ChangeUsername;
        }

        public override void Run(UserEntity argument)
        {
            _user = argument;

            View.Show();

            if (_user.Proxy)
            {
	            View.InitializeAdminUi();
            }
            else
            {
	            View.InitializePassengerUi();
            }

            Hello();
        }

        public void Hello()
        {
            var gender = _user.Gender;
            var name = _user.Name;
            var hours = DateTime.Now.Hour;

            string dayTime, greating;

            if (hours >= 6 && hours < 12)
            {
                dayTime = @"Доброе утро";
            }
            else if (hours >= 12 && hours < 18)
            {
                dayTime = @"Добрый день";
            }
            else if (hours >= 18 && hours < 23)
            {
                dayTime = @"Добрый вечер";
            }
            else
            {
                dayTime = @"Доброй ночи";
            }

            switch (gender)
            {
	            case "Мужской":
		            greating = "уважаемый";
		            break;
	            case "Женский":
		            greating = "уважаемая";
		            break;
	            default:
		            greating = string.Empty;
		            break;
            }

            var helloMessage = $"{dayTime}, {greating} {name}.";

            View.HelloMessage = helloMessage;
        }

		//private void ChangeUsername()
		//{
		//    Controller.Run<ChangeUsernamePresenter, UserEntity>(_user);
		//    UpdateUserInfo();
		//}

		//private void UpdateUserInfo()
		//{
		//	View.SetUserInfo(_user.Name, new string('*', _user.HashedPassword.Length));
		//}
	}
}