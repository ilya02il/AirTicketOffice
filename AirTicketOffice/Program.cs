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
using MaterialSkin;

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
			var manager = MaterialSkinManager.Instance;
			manager.EnforceBackcolorOnAllComponents = true;
			manager.Theme = MaterialSkinManager.Themes.LIGHT;
			manager.ColorScheme = new ColorScheme(
				Primary.Indigo400,
				Primary.Indigo500,
				Primary.Indigo100,
				Accent.Blue100,
				TextShade.WHITE
			);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Controller.AddTransient<ILoginView, AuthorizationWindow>();
			Controller.AddTransient<ICaptchaView, CaptchaWindow>();
			//Controller.AddTransient<IMainView, MainWindow>();
			Controller.AddTransient<IInitializationView, InitializeWindow>();
			Controller.AddTransient<IRegistrationView, RegistrationWindow>();
			Controller.AddTransient<IRegistrationStartView, RegistrationStartWindow>();
			Controller.AddTransient<IRegistrationFinishView, RegistrationFinishWindow>();
			Controller.AddTransient<IDbRepository, DbRepository>();
			Controller.AddScoped<DataContext>();
			Controller.AddScoped<ILoginService, LoginService>();
			Controller.AddScoped<ICaptchaService, CaptchaService>();
			Controller.AddScoped<IRegistrationService, RegistrationService>();
			Controller.AddSingleton(new ApplicationContext());
			Controller.AddSingleton(manager);

			Controller.Run<LoginPresenter>();
		}
    }
}
