using System;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using System.Collections.Generic;

namespace AirTicketOffice.Presentations.Views
{
	public interface IAdminMainView : IView
	{
		event Action GetAllEvents;
		event Action GetAllUsers;
		event Action GetAllOrders;
		event Action GetAllTickets;
		event Action GetAllRoutes;
		event Action GetAllFlights;
		event Action GetAllPlanes;
		event Action GetAllCrewMembers;
		event Action GetAllAirports;

		event Action DeleteEvent;
		event Action DeleteUser;
		event Action DeleteOrder;
		event Action DeleteTicket;
		event Action DeleteRoute;
		event Action DeleteFlight;
		event Action DeletePlane;
		event Action DeleteCrewMember;
		event Action DeleteAirport;

		event Action SaveAllEventsChanges;
		event Action SaveAllUsersChanges;
		event Action SaveAllOrdersChanges;
		event Action SaveAllTicketsChanges;
		event Action SaveAllRoutesChanges;
		event Action SaveAllFlightsChanges;
		event Action SaveAllPlanesChanges;
		event Action SaveAllCrewMembersChanges;
		event Action SaveAllAirportsChanges;

		event Action SaveEventChanges;
		event Action SaveUserChanges;
		event Action SaveOrderChanges;
		event Action SaveTicketChanges;
		event Action SaveRouteChanges;
		event Action SaveFlightChanges;
		event Action SavePlaneChanges;
		event Action SaveCrewMemberChanges;
		event Action SaveAirportChanges;

		int SelectedId { get; set; }

		ICollection<UserEntity> Users { get; set; }
		ICollection<EventEntity> Events { get; set; }
		ICollection<OrderEntity> Orders { get; set; }
		ICollection<TicketEntity> Tickets { get; set; }
		ICollection<RouteEntity> Routes { get; set; }
		ICollection<FlightEntity> Flights { get; set; }
		ICollection<PlaneEntity> Planes { get; set; }
		ICollection<CrewMemberEntity> Crew { get; set; }
		ICollection<AirportEntity> Airports { get; set; }
	    string HelloMessage { set; }

	    void SendMessage(string message);

	    //void SetUsers(ICollection<UserEntity> users);

	    //void SetUserInfo(UserEntity userInfo);
	}
}