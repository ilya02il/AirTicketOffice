using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using System;

namespace AirTicketOffice.Presentations.Views
{
	public interface IRegistrationView : IView
	{
		event Action Register;
		event Action Back;
		UserEntity User { get; set; }

		void GetMessage(string message);
	}
}
