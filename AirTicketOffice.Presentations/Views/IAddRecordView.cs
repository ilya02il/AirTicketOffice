using AirTicketOffice.Presentations.Common;
using System;
using AirTicketOffice.DAL.Entities;

namespace AirTicketOffice.Presentations.Views
{
	public interface IAddRecordView : IView
	{
		event Action Add;

		IEntity Record { get; set; }

		void GetMessage(string message);
	}
}
