using AirTicketOffice.Presentations.Views;
using System.Windows.Forms;

namespace AirTicketOffice
{
	public partial class MainWindow : Form, IMainView
	{
		private readonly ApplicationContext _context;

        public string HelloMessage
        {
            get => string.Empty;
            set => toolStripStatusLabel1.Text = value;
        }

		public MainWindow(ApplicationContext context)
		{
			_context = context;

			InitializeComponent();
		}

		public new void Show()
		{
			_context.MainForm = this;
			base.Show();
		}

		public void InitializeAdminUi()
		{
			//label1.Text = @"Добро пожаловать, администратор.";
		}

		public void InitializePassengerUi()
		{
			//label1.Text = @"Добро пожаловать, пассажир.";
		}
	}
}
