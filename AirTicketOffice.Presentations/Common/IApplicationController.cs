namespace AirTicketOffice.Presentations.Common
{
	public interface IApplicationController
    {
	    void AddSingleton<TService>(TService service);

	    void AddScoped<TService, TImplementation>()
		    where TImplementation : TService;

	    void AddTransient<TService, TImplementation>()
		    where TImplementation : TService;

	    void AddScoped<TService>();

        void Run<TPresenter>()
            where TPresenter : class, IPresenter;

        void Run<TPresenter, TArgument>(TArgument argument)
            where TPresenter : class, IPresenter<TArgument>;

        void ShutDown<TPresenter>()
	        where TPresenter : class, IPresenter;
        TService Resolve<TService>();
    }
}