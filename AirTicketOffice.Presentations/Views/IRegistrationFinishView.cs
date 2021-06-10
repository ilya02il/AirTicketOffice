using System;
using AirTicketOffice.Presentations.Common;

namespace AirTicketOffice.Presentations.Views
{
	public interface IRegistrationFinishView : IView
	{
		event Action FinishRegistration;
	}
}
