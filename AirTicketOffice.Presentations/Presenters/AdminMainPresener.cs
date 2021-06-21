using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Model.Contracts;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Loading;
using Aspose.Words.Replacing;

namespace AirTicketOffice.Presentations.Presenters
{
	public class AdminMainPresenter : BasePresenter<IAdminMainView, UserEntity>
    {
        private UserEntity _user;

        public AdminMainPresenter(IApplicationController controller, IAdminMainView view, IAdminService service) : base(controller, view)
        {
			View.GetAllUsers += () => View.Users = service.GetAll<UserEntity>().ToList();
			View.GetAllTickets += () => View.Tickets = service.GetAll<TicketEntity>().ToList();
			View.GetAllTicketPrices += () => View.TicketPrices = service.GetAll<TicketPriceEntity>().ToList();
			View.GetAllRoutes += () => View.Routes = service.GetAll<RouteEntity>().ToList();
			View.GetAllFlights += () => View.Flights = service.GetAll<FlightEntity>().ToList();
			View.GetAllPlanes += () => View.Planes = service.GetAll<PlaneEntity>().ToList();
			View.GetAllCrewMembers += () => View.CrewMembers = service.GetAll<CrewMemberEntity>().ToList();
			View.GetAllAirports += () => View.Airports = service.GetAll<AirportEntity>().ToList();

			View.DeleteUser += () => service.Delete<UserEntity>(View.SelectedId);
			View.DeleteTicket += () => service.Delete<TicketEntity>(View.SelectedId);
			View.DeleteTicketPrice += () => service.Delete<TicketPriceEntity>(View.SelectedId);
			View.DeleteRoute += () => service.Delete<RouteEntity>(View.SelectedId);
			View.DeleteFlight += () => service.Delete<FlightEntity>(View.SelectedId);
			View.DeletePlane += () => service.Delete<PlaneEntity>(View.SelectedId);
			View.DeleteCrewMember += () => service.Delete<CrewMemberEntity>(View.SelectedId);
			View.DeleteAirport += () => service.Delete<AirportEntity>(View.SelectedId);

			View.SaveAllUsersChanges += () => service.EditAllAsync(View.Users);
			View.SaveAllTicketsChanges += () => service.EditAllAsync(View.Tickets);
			View.SaveAllTicketPricesChanges += () => service.EditAllAsync(View.TicketPrices);
			View.SaveAllRoutesChanges += () => service.EditAllAsync(View.Routes);
			View.SaveAllFlightsChanges += () => service.EditAllAsync(View.Flights);
			View.SaveAllPlanesChanges += () => service.EditAllAsync(View.Planes);
			View.SaveAllCrewMembersChanges += () => service.EditAllAsync(View.CrewMembers);
			View.SaveAllAirportsChanges += () => service.EditAllAsync(View.Airports);

			View.SaveUserChanges += () => service.Edit(View.Users.FirstOrDefault(u => u.Id == View.SelectedId));
	        View.SaveTicketChanges += () => service.Edit(View.Tickets.FirstOrDefault(t => t.Id == View.SelectedId));
	        View.SaveTicketPriceChanges += () => service.Edit(View.TicketPrices.FirstOrDefault(t => t.Id == View.SelectedId));
			View.SaveRouteChanges += () => service.Edit(View.Routes.FirstOrDefault(r => r.Id == View.SelectedId));
			View.SaveFlightChanges += () => service.Edit(View.Flights.FirstOrDefault(f => f.Id == View.SelectedId));
			View.SavePlaneChanges += () => service.Edit(View.Planes.FirstOrDefault(p => p.Id == View.SelectedId));
			View.SaveCrewMemberChanges += () => service.Edit(View.CrewMembers.FirstOrDefault(cm => cm.Id == View.SelectedId));
			View.SaveAirportChanges += () => service.Edit(View.Airports.FirstOrDefault(a => a.Id == View.SelectedId));

			View.SaveCurrentUserInfo += () =>
			{
				var user = View.CurrentUser;
				user.Id = _user.Id;

				service.Edit(user);
			};
			View.ExitFromAccount += ExitFromAccount;
			View.ChangePassword += () => ChangePassword(_user);

			View.PrintTicket += PrintTicket;
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
				var ticket = View.Ticket;

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
				var orderDate = ticket.OrderDate.ToLongDateString();
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
				document.Range.Replace("[order_date]", orderDate, findReplaceOptions);
				document.Range.Replace("[price]", price, findReplaceOptions);

				var myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

				if (Directory.Exists(myDocPath + "\\AirTicketOffice\\tickets") == false)
				{
					Directory.CreateDirectory(myDocPath + "\\AirTicketOffice\\tickets");
				}

				var fileName = myDocPath + "\\AirTicketOffice\\tickets\\ticket_number_" + ticket.Id + ".doc";

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