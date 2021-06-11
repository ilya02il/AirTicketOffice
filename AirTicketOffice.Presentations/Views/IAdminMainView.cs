using System;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using System.Collections.Generic;

namespace AirTicketOffice.Presentations.Views
{
	public interface IAdminMainView : IView
	{
		event Action GetAllUsers;

	    string HelloMessage { set; }

	    void SetUsers(ICollection<UserEntity> users);

	    void SetUserInfo(UserEntity userInfo);
    }
}