using Unity.Lifetime;

namespace Model
{
	public interface IContainer
    {
        void Register<TService, TImplementation>() where TImplementation : TService;
        void Register<TService, TImplementation>(ITypeLifetimeManager typeLifetime)
	        where TImplementation : TService;
        void Register<TService>();
        void Register<TService>(ITypeLifetimeManager typeLifetimeManager);
        void RegisterInstance<T>(T instance);
        TService Resolve<TService>();
        bool IsRegistered<TService>();
        //void Register<TService, TArgument>(Expression<Func<TArgument, TService>> factory);
    }
}