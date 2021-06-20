using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Aspose.Words.Loading;
using Aspose.Words.Replacing;
using Model.Contracts;
using System;
using System.Linq;
using System.Windows.Forms;
using Document = Aspose.Words.Document;

namespace AirTicketOffice.Presentations.Presenters
{
	public class PassengerMainPresenter : BasePresenter<IPassengerMainView, UserEntity>
	{
		private UserEntity _user;
		private IPassengerService _service;

		public PassengerMainPresenter(IApplicationController controller, IPassengerMainView view, IPassengerService service) : base(controller, view)
		{
			_service = service;

			View.LoadFlights += () => View.Flights = service.GetAll<FlightEntity>().ToList();

			View.AddTicket += () => _service.Add(View.Ticket);
			View.PrintTicket += PrintTicket;

			View.SaveCurrentUserInfo += () =>
			{
				var user = View.CurrentUser;
				user.Id = _user.Id;

				service.Edit(user);
			};
			View.ExitFromAccount += ExitFromAccount;
			View.ChangePassword += () => ChangePassword(_user);
		}

		public override void Run(UserEntity argument)
		{
			_user = argument;
			View.CurrentUser = argument;


			View.Show();

			Hello();
		}

		private void ExitFromAccount()
		{
			Controller.Run<LoginPresenter>();
			View.Close();
		}

		private void ChangePassword(UserEntity user)
		{
			//change password
		}

		private void PrintTicket()
		{
			try
			{
				var ticket = _service.GetAll<TicketEntity>().ToList().LastOrDefault();

				if (ticket == null)
					throw new NullReferenceException("Ticket is null.");

				var refFileName = Application.StartupPath + @"\ticket_template.docx";

				var document = new Document(refFileName, new LoadOptions());
				var findReplaceOptions = new FindReplaceOptions();

				var ticketNumber = ticket.Id.ToString();
				var passengerInitials = ticket.User.Surname + " " + ticket.User.Name + " " + ticket.User.Patronymic;
				var ticketClass = ticket.TicketPrice.Class.Name;
				var passengerPassport = ticket.User.PassportNumber;
				var passengerPhone = ticket.User.PhoneNumber;
				var flightNumber = ticket.TicketPrice.FlightId.ToString();
				var departureCity = ticket.TicketPrice.Flight.Route.DepartureAirport.City;
				var departureAirport = ticket.TicketPrice.Flight.Route.DepartureAirport.Name;
				var departureDate = ticket.TicketPrice.Flight.DateFrom.ToLongDateString();
				var arrivalCity = ticket.TicketPrice.Flight.Route.ArrivalAirport.City;
				var arrivalAirport = ticket.TicketPrice.Flight.Route.ArrivalAirport.Name;
				var arrivalDate = ticket.TicketPrice.Flight.DateTo.ToLongDateString();
				//var orderDate = ticket.Date.ToLongDateString();
				var price = ticket.TicketPrice.Price.ToString();


				document.Range.Replace("[ticket_number]", ticketNumber, findReplaceOptions);
				document.Range.Replace("[initials]", passengerInitials, findReplaceOptions);
				document.Range.Replace("[class_name]", ticketClass, findReplaceOptions);
				document.Range.Replace("[passport_number]", passengerPassport, findReplaceOptions);
				document.Range.Replace("[phone_number]", passengerPhone, findReplaceOptions);
				document.Range.Replace("[flight_number]", flightNumber, findReplaceOptions);
				document.Range.Replace("[departure_city]", departureCity, findReplaceOptions);
				document.Range.Replace("[departure_airport]", departureAirport, findReplaceOptions);
				document.Range.Replace("[departure_date]", departureDate, findReplaceOptions);
				document.Range.Replace("[arrival_city]", arrivalCity, findReplaceOptions);
				document.Range.Replace("[arrival_airport]", arrivalAirport, findReplaceOptions);
				document.Range.Replace("[arrival_date]", arrivalDate, findReplaceOptions);
				//document.Range.Replace("[order_date]", orderDate, findReplaceOptions);
				document.Range.Replace("[price]", price, findReplaceOptions);

				var fileName = Application.StartupPath + @"\tickets\ticket_number_" + ticket.Id + ".doc";

				document.Save(fileName);

				var app = new Microsoft.Office.Interop.Word.Application();

				app.Documents.Open(fileName);
				app.Visible = true;
			}
			catch (Exception exp)
			{
				View.SendMessage(exp.Message);
			}
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
