using System;
using AirTicketOffice.DAL.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Windows.Forms;
using AirTicketOffice.Presentations.Views;

namespace AirTicketOffice
{
	public partial class AdminMainWindow : MaterialForm, IAdminMainView
	{
		public event Action GetAllEvents;
		public event Action GetAllUsers;

		private readonly ApplicationContext _context;

		public AdminMainWindow(ApplicationContext context, MaterialSkinManager manager)
		{
			_context = context;

			InitializeComponent();

			manager.AddFormToManage(this);

			mainTabControl.SelectedIndex = 0;
			Text = @"	 " + mainTabControl.SelectedTab.Text;

			adTabPage.Enter += (sender, args) => GetAllEvents?.Invoke();
			usersTabPage.Enter += (sender, args) => GetAllUsers?.Invoke();
			searchPassengersTabPage.Enter += (sender, args) =>
			{
				GetAllUsers?.Invoke();

				searchTypeComboBox.Items.Clear();
				searchTypeComboBox.Items.Add("ФИО");
				searchTypeComboBox.Items.Add("номеру паспорта");
			};
		}

		public sealed override string Text
		{
			get => base.Text;
			set => base.Text = value;
		}

		public string HelloMessage
		{
			set => Text += @" | " + value;
		}

		public new void Show()
		{
			_context.MainForm = this;
			base.Show();
		}

		private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedTabText = @"	 " + mainTabControl.SelectedTab.Text;

			Text = selectedTabText;
		}

		public void SetUserInfo(UserEntity userInfo)
		{

		}

		public void SetEvents(ICollection<EventEntity> events)
		{
			eventsDataGridView.Rows.Clear();

			foreach (var e in events)
			{
				eventsDataGridView.Rows.Add(
					e.Id,
					null,
					e.Name,
					e.Description,
					e.EndingDate,
					e.Position,
					e.IsActive
					);
			}
		}

		public void SetUsers(ICollection<UserEntity> users)
		{
			DataGridView dataGridView;

			if (mainTabControl.SelectedTab == mainTabPage)
				dataGridView = usersDataGridView;

			else if (mainTabControl.SelectedTab == searchTabPage)
				dataGridView = passengersDataGridView;

			else
				return;

			dataGridView.Rows.Clear();

			foreach (var user in users)
			{
				dataGridView.Rows.Add(
					user.Id,
					user.Login,
					user.Surname,
					user.Name,
					user.Patronymic,
					user.PassportNumber,
					user.PhoneNumber,
					user.Proxy
					);
			}
		}

		public void GetOrders(ICollection<OrderEntity> orders)
		{
			//foreach (var order in orders)
			//{
			//	ordersDataGridView.Rows.Add(
			//		order.UserId,
			//		order.F
			//		);
			//}
		}

		private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;


			var searchedText = searchTextBox.Text;

			if (searchTabControl.SelectedTab == searchPassengersTabPage)
			{
				passengersDataGridView.CurrentCell = null;

				for (int i = 0; i < passengersDataGridView.Rows.Count - 1; i++)
				{ 
					if (searchTypeComboBox.SelectedIndex == 0)
					{
						passengersDataGridView.Rows[i].Selected = 
							passengersDataGridView[2, i].Value.ToString().ToLower().Contains(searchedText.ToLower()) 
							|| passengersDataGridView[2, i].Value.ToString() == searchedText 
							|| passengersDataGridView[3, i].Value.ToString().ToLower().Contains(searchedText.ToLower())
							|| passengersDataGridView[3, i].Value.ToString() == searchedText
							|| passengersDataGridView[4, i].Value.ToString().ToLower().Contains(searchedText.ToLower())
							|| passengersDataGridView[4, i].Value.ToString() == searchedText;
					}
					else
					{
						passengersDataGridView.Rows[i].Selected =
							passengersDataGridView[5, i].Value.ToString().ToLower().Contains(searchedText.ToLower())
							|| passengersDataGridView[5, i].Value.ToString() == searchedText;
					}
				}
			}
		}
	}
}
