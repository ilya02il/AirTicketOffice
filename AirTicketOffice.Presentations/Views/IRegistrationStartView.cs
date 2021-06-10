using System;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;

namespace AirTicketOffice.Presentations.Views
{
	public interface IRegistrationStartView : IView
	{
		event Action NextStep;
		event Action Back;
		UserEntity User { get; set; }

		void GetMessage(string message);
	}
}
