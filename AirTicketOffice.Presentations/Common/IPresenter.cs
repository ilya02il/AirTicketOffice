namespace AirTicketOffice.Presentations.Common
{
    public interface IPresenter
    {
        void Run();
        void ShutDown();
    }

    public interface IPresenter<in TArg>
    {
        void Run(TArg argument);
    }
}