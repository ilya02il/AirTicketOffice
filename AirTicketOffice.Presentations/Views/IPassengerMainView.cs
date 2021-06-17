using System;
using System.Collections.Generic;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;

namespace AirTicketOffice.Presentations.Views
{
	public interface IPassengerMainView : IView
	{
		event Action LoadFlights;

		event Action SaveCurrentUserInfo;
		event Action ChangePassword;
		event Action ExitFromAccount;

		string HelloMessage { set; }
		UserEntity CurrentUser { get; set; }
		ICollection<FlightEntity> Flights { set; }

		void SendMessage(string message);
	}
}
