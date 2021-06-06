using System;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;

namespace AirTicketOffice.Presentations.Views
{
	public interface IRegistrationView : IView
	{
		event Action Register;
		UserEntity User { get; }
	}
}
