using System;
using AirTicketOffice.Presentations.Common;

namespace AirTicketOffice.Presentations.Views
{
    public interface IMainView : IView
    {
        //void SetUserInfo(string username, string password);

        string HelloMessage { get; set; }

        void InitializeAdminUi();

        void InitializePassengerUi();
    }
}