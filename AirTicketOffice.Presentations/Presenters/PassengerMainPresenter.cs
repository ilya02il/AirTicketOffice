using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Model.Contracts;
using System;
using System.Linq;

namespace AirTicketOffice.Presentations.Presenters
{
	public class PassengerMainPresenter : BasePresenter<IPassengerMainView, UserEntity>
	{
		private UserEntity _user;
		//private IPassengerService _service;

		public PassengerMainPresenter(IApplicationController controller, IPassengerMainView view, IPassengerService service) : base(controller, view)
		{
			//_service = service;

			View.LoadFlights += () => View.Flights = service.GetAll<FlightEntity>().ToList();
		}

		public override void Run(UserEntity argument)
		{
			_user = argument;
			View.CurrentUser = argument;


			View.Show();

			Hello();
		}

		private void Hello()
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
    }
}
