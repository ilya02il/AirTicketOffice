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
        private readonly IAdminService _service;
        
        public AdminMainPresenter(IApplicationController controller, IAdminMainView view, IAdminService service) : base(controller, view)
        {
	        _service = service;

	        View.GetAllUsers += () => View.Users = _service.GetAll<UserEntity>().ToList();
	        View.GetAllEvents += () => View.Events = _service.GetAll<EventEntity>().ToList();
	        View.GetAllOrders += () => View.Orders = _service.GetAll<OrderEntity>().ToList();
	        View.GetAllTickets += () => View.Tickets = _service.GetAll<TicketEntity>().ToList();
	        View.GetAllRoutes += () => View.Routes = _service.GetAll<RouteEntity>().ToList();
	        View.GetAllFlights += () => View.Flights = _service.GetAll<FlightEntity>().ToList();
	        View.GetAllPlanes += () => View.Planes = _service.GetAll<PlaneEntity>().ToList();
	        View.GetAllCrewMembers += () => View.Crew = _service.GetAll<CrewMemberEntity>().ToList();
	        View.GetAllAirports += () => View.Airports = _service.GetAll<AirportEntity>().ToList();

	        View.DeleteEvent += () => _service.Delete<EventEntity>(View.SelectedId);
	        View.DeleteUser += () => _service.Delete<UserEntity>(View.SelectedId);
	        View.DeleteOrder += () => _service.Delete<OrderEntity>(View.SelectedId);
	        View.DeleteTicket += () => _service.Delete<TicketEntity>(View.SelectedId);
	        View.DeleteRoute += () => _service.Delete<RouteEntity>(View.SelectedId);
	        View.DeleteFlight += () => _service.Delete<FlightEntity>(View.SelectedId);
	        View.DeletePlane += () => _service.Delete<PlaneEntity>(View.SelectedId);
	        View.DeleteCrewMember += () => _service.Delete<CrewMemberEntity>(View.SelectedId);
	        View.DeleteAirport += () => _service.Delete<AirportEntity>(View.SelectedId);

	        View.SaveAllEventsChanges += () => _service.EditAllAsync(View.Events);
	        View.SaveAllUsersChanges += () => _service.EditAllAsync(View.Users);
	        View.SaveAllOrdersChanges += () => _service.EditAllAsync(View.Orders);
	        View.SaveAllTicketsChanges += () => _service.EditAllAsync(View.Tickets);
	        View.SaveAllRoutesChanges += () => _service.EditAllAsync(View.Routes);
	        View.SaveAllFlightsChanges += () => _service.EditAllAsync(View.Flights);
	        View.SaveAllPlanesChanges += () => _service.EditAllAsync(View.Planes);
	        View.SaveAllCrewMembersChanges += () => _service.EditAllAsync(View.Crew);
	        View.SaveAllAirportsChanges += () => _service.EditAllAsync(View.Airports);

	        View.SaveEventChanges += () => _service.Edit(View.Events.FirstOrDefault(e => e.Id == View.SelectedId));
	        View.SaveUserChanges += () => _service.Edit(View.Users.FirstOrDefault(u => u.Id == View.SelectedId));
	        View.SaveOrderChanges += () => _service.Edit(View.Orders.FirstOrDefault(o => o.Id == View.SelectedId));
	        View.SaveTicketChanges += () => _service.Edit(View.Tickets.FirstOrDefault(t => t.Id == View.SelectedId));
	        View.SaveRouteChanges += () => _service.Edit(View.Routes.FirstOrDefault(r => r.Id == View.SelectedId));
	        View.SaveFlightChanges += () => _service.Edit(View.Flights.FirstOrDefault(f => f.Id == View.SelectedId));
	        View.SavePlaneChanges += () => _service.Edit(View.Planes.FirstOrDefault(p => p.Id == View.SelectedId));
	        View.SaveCrewMemberChanges += () => _service.Edit(View.Crew.FirstOrDefault(cm => cm.Id == View.SelectedId));
	        View.SaveAirportChanges += () => _service.Edit(View.Airports.FirstOrDefault(a => a.Id == View.SelectedId));
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
    }
}