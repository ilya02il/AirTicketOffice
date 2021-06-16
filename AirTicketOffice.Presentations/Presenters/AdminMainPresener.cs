using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Model.Contracts;
using System;
using System.Linq;

namespace AirTicketOffice.Presentations.Presenters
{
	public class AdminMainPresenter : BasePresenter<IAdminMainView, UserEntity>
    {
        private UserEntity _user;

        public AdminMainPresenter(IApplicationController controller, IAdminMainView view, IAdminService service) : base(controller, view)
        {
	        View.GetAllUsers += () => View.Users = service.GetAll<UserEntity>().ToList();
	        View.GetAllEvents += () => View.Events = service.GetAll<EventEntity>().ToList();
	        View.GetAllOrders += () => View.Orders = service.GetAll<OrderEntity>().ToList();
	        View.GetAllTickets += () => View.Tickets = service.GetAll<TicketEntity>().ToList();
	        View.GetAllRoutes += () => View.Routes = service.GetAll<RouteEntity>().ToList();
	        View.GetAllFlights += () => View.Flights = service.GetAll<FlightEntity>().ToList();
	        View.GetAllPlanes += () => View.Planes = service.GetAll<PlaneEntity>().ToList();
	        View.GetAllCrewMembers += () => View.Crew = service.GetAll<CrewMemberEntity>().ToList();
	        View.GetAllAirports += () => View.Airports = service.GetAll<AirportEntity>().ToList();

	        View.AddEvent += () =>
	        {

	        };
	        View.AddUser += () =>
	        {

	        };
	        View.AddOrder += () =>
	        {

	        };
	        View.AddTicket += () =>
	        {

	        };
	        View.AddRoute += () =>
	        {

	        };
	        View.AddFlight += () =>
	        {

	        };
	        View.AddPlane += () =>
	        {

	        };
	        View.AddCrewMember += () =>
	        {

	        };
	        View.AddAirport += () =>
	        {

	        };

			View.DeleteEvent += () => service.Delete<EventEntity>(View.SelectedId);
	        View.DeleteUser += () => service.Delete<UserEntity>(View.SelectedId);
	        View.DeleteOrder += () => service.Delete<OrderEntity>(View.SelectedId);
	        View.DeleteTicket += () => service.Delete<TicketEntity>(View.SelectedId);
	        View.DeleteRoute += () => service.Delete<RouteEntity>(View.SelectedId);
	        View.DeleteFlight += () => service.Delete<FlightEntity>(View.SelectedId);
	        View.DeletePlane += () => service.Delete<PlaneEntity>(View.SelectedId);
	        View.DeleteCrewMember += () => service.Delete<CrewMemberEntity>(View.SelectedId);
	        View.DeleteAirport += () => service.Delete<AirportEntity>(View.SelectedId);

	        View.SaveAllEventsChanges += () => service.EditAllAsync(View.Events);
	        View.SaveAllUsersChanges += () => service.EditAllAsync(View.Users);
	        View.SaveAllOrdersChanges += () => service.EditAllAsync(View.Orders);
	        View.SaveAllTicketsChanges += () => service.EditAllAsync(View.Tickets);
	        View.SaveAllRoutesChanges += () => service.EditAllAsync(View.Routes);
	        View.SaveAllFlightsChanges += () => service.EditAllAsync(View.Flights);
	        View.SaveAllPlanesChanges += () => service.EditAllAsync(View.Planes);
	        View.SaveAllCrewMembersChanges += () => service.EditAllAsync(View.Crew);
	        View.SaveAllAirportsChanges += () => service.EditAllAsync(View.Airports);

	        View.SaveEventChanges += () => service.Edit(View.Events.FirstOrDefault(e => e.Id == View.SelectedId));
	        View.SaveUserChanges += () => service.Edit(View.Users.FirstOrDefault(u => u.Id == View.SelectedId));
	        View.SaveOrderChanges += () => service.Edit(View.Orders.FirstOrDefault(o => o.Id == View.SelectedId));
	        View.SaveTicketChanges += () => service.Edit(View.Tickets.FirstOrDefault(t => t.Id == View.SelectedId));
	        View.SaveRouteChanges += () => service.Edit(View.Routes.FirstOrDefault(r => r.Id == View.SelectedId));
	        View.SaveFlightChanges += () => service.Edit(View.Flights.FirstOrDefault(f => f.Id == View.SelectedId));
	        View.SavePlaneChanges += () => service.Edit(View.Planes.FirstOrDefault(p => p.Id == View.SelectedId));
	        View.SaveCrewMemberChanges += () => service.Edit(View.Crew.FirstOrDefault(cm => cm.Id == View.SelectedId));
	        View.SaveAirportChanges += () => service.Edit(View.Airports.FirstOrDefault(a => a.Id == View.SelectedId));

			View.SaveCurrentUserInfo += () =>
			{
				var user = View.CurrentUser;
				user.Id = _user.Id;

				service.Edit(user);
			};
			View.ExitFromAccount += ExitFromAccount;
			View.ChangePassword += () => 
				ChangePassword(_user);
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