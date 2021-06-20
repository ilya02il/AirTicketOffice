using System;
using System.Collections.Generic;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;

namespace AirTicketOffice.Presentations.Views
{
	public interface IPassengerMainView : IView
	{
		event Action LoadFlights;
		event Action AddTicket;
		event Action PrintTicket;

		event Action SaveCurrentUserInfo;
		event Action ChangePassword;
		event Action ExitFromAccount;

		string HelloMessage { set; }
		UserEntity CurrentUser { get; set; }
		TicketEntity Ticket { get; }
		ICollection<FlightEntity> Flights { set; }

		void SendMessage(string message);
	}
}
