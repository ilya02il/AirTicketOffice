using AirTicketOffice.Adapters;
using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Implementations;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Presenters;
using AirTicketOffice.Presentations.Views;
using Model.Contracts;
using Model.Implementations;
using System;
using System.Windows.Forms;

namespace AirTicketOffice
{
	internal static class Program
	{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static readonly IApplicationController Controller = new ApplicationController(new UnityAdapter());

        [STAThread]
        private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Controller.AddTransient<ILoginView, AuthorizationWindow>();
			Controller.AddTransient<ICaptchaView, CaptchaWindow>();
			//Controller.AddTransient<IMainView, MainWindow>();
			Controller.AddTransient<IInitializationView, InitializeWindow>();
			Controller.AddTransient<IRegistrationView, RegistrationWindow>();
			Controller.AddScoped<DataContext>();
			Controller.AddTransient<IDbRepository, DbRepository>();
			Controller.AddScoped<ILoginService, LoginService>();
			Controller.AddScoped<ICaptchaService, CaptchaService>();
			Controller.AddScoped<IRegistrationService, RegistrationService>();
			Controller.AddSingleton(new ApplicationContext());

			Controller.Run<LoginPresenter>();

			//var dbContext = new DataContext();

			//var salt1 = Hasher.GenerateSalt(20);

			//var user1 = new UserEntity()
			//{
			//	Surname = "Ильиных",
			//	Name = "Илья",
			//	Patronymic = "Леонидович",
			//	Login = "ilya02il",
			//	HashedPassword = Hasher.HashPassword("admin", salt1),
			//	Salt = salt1,
			//	Proxy = true,
			//	Gender = "Мужской",
			//	PassportNumber = "0415 674345",
			//	PhoneNumber = "89452342345"
			//};

			//dbContext.Users.Add(user1);

			//var salt2 = Hasher.GenerateSalt(20);

			//var user2 = new UserEntity()
			//{
			//	Surname = "Мишин",
			//	Name = "Никита",
			//	Patronymic = "Андреевич",
			//	Login = "nikmixa",
			//	HashedPassword = Hasher.HashPassword("passenger", salt2),
			//	Salt = salt2,
			//	Proxy = false,
			//	Gender = "Мужской",
			//	PassportNumber = "0415 775335",
			//	PhoneNumber = "89452544355"
			//};

			//dbContext.Users.Add(user2);

			//dbContext.SaveChanges();
		}
    }
}
