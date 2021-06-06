using Model;
using Unity;
using Unity.Lifetime;

namespace AirTicketOffice.Adapters
{
	public class UnityAdapter : IContainer
	{
		private readonly IUnityContainer _container = new UnityContainer();

		public void Register<TService>()
		{
			_container.RegisterType<TService>();
		}

		public void Register<TService>(ITypeLifetimeManager typeLifetime)
		{
			_container.RegisterType<TService>(typeLifetime);
		}

		public void Register<TService, TImplementation>() where TImplementation : TService
		{
			_container.RegisterType<TService, TImplementation>();
		}

		public void Register<TService, TImplementation>(ITypeLifetimeManager typeLifetime)
			where TImplementation : TService
		{
			_container.RegisterType<TService, TImplementation>(typeLifetime);
		}

		public void RegisterInstance<T>(T instance)
		{
			_container.RegisterInstance(instance);
		}

		//public void Register<TService, TArgument>(Expression<Func<TArgument, TService>> factory)
		//{
		//	//_container.Register(serviceFactory => factory);
		//	//_container.rEG
		//}

		public TService Resolve<TService>()
		{
			return _container.Resolve<TService>();
		}

		public bool IsRegistered<TService>()
		{
			return _container.IsRegistered<TService>();
		}
	}
}