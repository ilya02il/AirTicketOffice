using System;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using System.Collections.Generic;

namespace AirTicketOffice.Presentations.Views
{
	public interface IAdminMainView : IView
	{
		//event GetAllEntitiesEventHandler<IEntity> GetAllEntities;
		//event DeleteEntityEventHandler<IEntity> DeleteEntity;
		//event SaveEntityEventHandler<IEntity> SaveEntity;
		//event SaveAllEntitiesEventHandler<IEntity> SaveAllEntities;

		event Action GetAllUsers;
		event Action GetAllTickets;
		event Action GetAllTicketPrices;
		event Action GetAllRoutes;
		event Action GetAllFlights;
		event Action GetAllPlanes;
		event Action GetAllCrewMembers;
		event Action GetAllAirports;

		event Action DeleteUser;
		event Action DeleteTicket;
		event Action DeleteTicketPrice;
		event Action DeleteRoute;
		event Action DeleteFlight;
		event Action DeletePlane;
		event Action DeleteCrewMember;
		event Action DeleteAirport;

		event Action SaveAllUsersChanges;
		event Action SaveAllTicketsChanges;
		event Action SaveAllTicketPricesChanges;
		event Action SaveAllRoutesChanges;
		event Action SaveAllFlightsChanges;
		event Action SaveAllPlanesChanges;
		event Action SaveAllCrewMembersChanges;
		event Action SaveAllAirportsChanges;

		event Action SaveUserChanges;
		event Action SaveTicketChanges;
		event Action SaveTicketPriceChanges;
		event Action SaveRouteChanges;
		event Action SaveFlightChanges;
		event Action SavePlaneChanges;
		event Action SaveCrewMemberChanges;
		event Action SaveAirportChanges;

		event Action SaveCurrentUserInfo;
		event Action ChangePassword;
		event Action ExitFromAccount;

		event Action PrintTicket;
		//event Action PrintReport;

		int SelectedId { get; set; }
		string HelloMessage { set; }
		UserEntity CurrentUser { get; set; }
		TicketEntity Ticket { get; }

		ICollection<UserEntity> Users { get; set; }
		ICollection<TicketEntity> Tickets { get; set; }
		ICollection<TicketPriceEntity> TicketPrices { get; set; }
		ICollection<RouteEntity> Routes { get; set; }
		ICollection<FlightEntity> Flights { get; set; }
		ICollection<PlaneEntity> Planes { get; set; }
		ICollection<CrewMemberEntity> CrewMembers { get; set; }
		ICollection<AirportEntity> Airports { get; set; }

		void SendMessage(string message);
	}
}