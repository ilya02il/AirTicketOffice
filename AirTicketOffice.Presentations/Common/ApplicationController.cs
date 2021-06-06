using Model;
using Unity;

namespace AirTicketOffice.Presentations.Common
{
    public class ApplicationController : IApplicationController
    {
        private readonly IContainer _container;

        public ApplicationController(IContainer container)
        {
            _container = container;
            _container.RegisterInstance<IApplicationController>(this);
        }

        public void AddSingleton<TService>(TService service)
        {
            _container.RegisterInstance(service);
        }

        public void AddScoped<TService, TImplementation>()
	        where TImplementation : TService
        {
	        _container.Register<TService, TImplementation>(TypeLifetime.Hierarchical);
        }

        public void AddTransient<TService, TImplementation>()
	        where TImplementation : TService
        {
	        _container.Register<TService, TImplementation>(TypeLifetime.Transient);
        }

        public void AddScoped<TService>()
        {
            _container.Register<TService>(TypeLifetime.Hierarchical);
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();
            
            var presenter = _container.Resolve<TPresenter>();
            presenter.Run();
        }

        public void Run<TPresenter, TArgument>(TArgument argument) where TPresenter : class, IPresenter<TArgument>
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run(argument);
        }

        public void ShutDown<TPresenter>() where TPresenter : class, IPresenter
        {
	        if (!_container.IsRegistered<TPresenter>()) return;

	        var presenter = _container.Resolve<TPresenter>();
	        presenter.ShutDown();
        }

        public TService Resolve<TService>()
        {
	        return _container.Resolve<TService>();
        }
    }
}