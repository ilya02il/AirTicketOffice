using System;
using System.Linq;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Model.Contracts;

namespace AirTicketOffice.Presentations.Presenters
{
    public class AdminMainPresenter : BasePresenter<IAdminMainView, UserEntity>
    {
        private UserEntity _user;
        private readonly IUserService _userService;
        
        public AdminMainPresenter(IApplicationController controller, IAdminMainView view, IUserService userService) : base(controller, view)
        {
	        _userService = userService;

	        View.GetAllUsers += GetAllUsers;
        }

        public override void Run(UserEntity argument)
        {
            _user = argument;

            View.Show();

            Hello();
        }

        public void Hello()
        {
            var gender = _user.Gender;
            var name = _user.Name;
            var hours = DateTime.Now.Hour;

            string dayTime, greeting;

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
		            greeting = "уважаемый";
		            break;
	            case "Женский":
		            greeting = "уважаемая";
		            break;
	            default:
		            greeting = string.Empty;
		            break;
            }

            var helloMessage = $"{dayTime}, {greeting} {name}.";

            View.HelloMessage = helloMessage;
        }

        public void GetAllUsers()
        {
	        View.SetUsers(_userService.GetAllUsers().ToList());
        }

        public void GetAllEvents()
        {

        }
	}
}