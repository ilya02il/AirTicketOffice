using System;
using AirTicketOffice.DAL.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AirTicketOffice.Presentations.Views;

namespace AirTicketOffice
{
	public partial class AdminMainWindow : MaterialForm, IAdminMainView
	{
		public event Action GetAllUsers;
		public event Action GetAllOrders;
		public event Action GetAllTickets;
		public event Action GetAllRoutes;
		public event Action GetAllFlights;
		public event Action GetAllPlanes;
		public event Action GetAllCrewMembers;
		public event Action GetAllAirports;

		public event Action DeleteUser;
		public event Action DeleteOrder;
		public event Action DeleteTicket;
		public event Action DeleteRoute;
		public event Action DeleteFlight;
		public event Action DeletePlane;
		public event Action DeleteCrewMember;
		public event Action DeleteAirport;

		public event Action SaveAllUsersChanges;
		public event Action SaveAllOrdersChanges;
		public event Action SaveAllTicketsChanges;
		public event Action SaveAllRoutesChanges;
		public event Action SaveAllFlightsChanges;
		public event Action SaveAllPlanesChanges;
		public event Action SaveAllCrewMembersChanges;
		public event Action SaveAllAirportsChanges;

		public event Action SaveUserChanges;
		public event Action SaveOrderChanges;
		public event Action SaveTicketChanges;
		public event Action SaveRouteChanges;
		public event Action SaveFlightChanges;
		public event Action SavePlaneChanges;
		public event Action SaveCrewMemberChanges;
		public event Action SaveAirportChanges;

		public event Action SaveCurrentUserInfo;
		public event Action ChangePassword;
		public event Action ExitFromAccount;

		private readonly ApplicationContext _context;

		public AdminMainWindow(ApplicationContext context, MaterialSkinManager manager)
		{
			_context = context;

			InitializeComponent();

			manager.AddFormToManage(this);

			mainTabControl.SelectedIndex = 0;
			Text = @"	 " + mainTabControl.SelectedTab.Text;

			usersTabPage.Enter += (sender, args) => GetAllUsers?.Invoke();
			searchPassengersTabPage.Enter += (sender, args) =>
			{
				GetAllUsers?.Invoke();
				searchTypeComboBox.Items.Clear();
				searchTypeComboBox.Items.Add("ФИО");
				searchTypeComboBox.Items.Add("номеру паспорта");
			};
			ordersTabPage.Enter += (sender, args) => GetAllOrders?.Invoke();
			ticketsTabPage.Enter += (sender, args) => GetAllTickets?.Invoke();
			routesTabPage.Enter += (sender, args) => GetAllRoutes?.Invoke();
			flightsTabPage.Enter += (sender, args) => GetAllFlights?.Invoke();
			planesTabPage.Enter += (sender, args) => GetAllPlanes?.Invoke();
			crewTabPage.Enter += (sender, args) => GetAllCrewMembers?.Invoke();
			airportsTabPage.Enter += (sender, args) => GetAllAirports?.Invoke();

			saveAccountChangesButton.Click += (sender, args) => SaveCurrentUserInfo?.Invoke();
			changePasswordButton.Click += (sender, args) => ChangePassword?.Invoke();
			exitFromAccountButton.Click += (sender, args) => ExitFromAccount?.Invoke();
		}

		public sealed override string Text
		{
			get => base.Text;
			set => base.Text = value;
		}

		public int SelectedId { get; set; }

		public string HelloMessage
		{
			set => Text += @" | " + value;
		}

		public UserEntity CurrentUser
		{
			get =>
				new UserEntity()
				{
					Surname = accountSurnameTextBox.Text,
					Name = accountNameTextBox.Text,
					Patronymic = accountPatronymicTextBox.Text,
					Gender = accountGenderComboBox.SelectedItem.ToString(),
					Login = accountLoginTextBox.Text,
					PassportNumber = accountPassportTextBox.Text,
					PhoneNumber = accountPhoneTextBox.Text
				};
			set
			{
				accountSurnameTextBox.Text = value.Surname;
				accountNameTextBox.Text = value.Name;
				accountPatronymicTextBox.Text = value.Patronymic;
				accountGenderComboBox.SelectedItem = value.Gender;
				accountLoginTextBox.Text = value.Login;
				accountPassportTextBox.Text = value.PassportNumber;
				accountPhoneTextBox.Text = value.PhoneNumber;
			}
		}

		public ICollection<UserEntity> Users
		{
			get
			{
				var userList = new List<UserEntity>();

				for (int i = 0; i < usersDataGridView.RowCount - 1; i++)
				{
					var id = Convert.ToInt32(usersDataGridView.Rows[i].Cells[0].Value);
					var login = Convert.ToString(usersDataGridView.Rows[i].Cells[1].Value);
					var surname = Convert.ToString(usersDataGridView.Rows[i].Cells[2].Value);
					var name = Convert.ToString(usersDataGridView.Rows[i].Cells[3].Value);
					var patronymic = Convert.ToString(usersDataGridView.Rows[i].Cells[4].Value);
					var passport = Convert.ToString(usersDataGridView.Rows[i].Cells[5].Value);
					var phone = Convert.ToString(usersDataGridView.Rows[i].Cells[6].Value);
					var proxy = Convert.ToBoolean(usersDataGridView.Rows[i].Cells[7].Value);

					var user = new UserEntity()
					{
						Id = id,
						Login = login,
						Surname = surname,
						Name = name,
						Patronymic = patronymic,
						PassportNumber = passport,
						PhoneNumber = phone,
						Proxy = proxy
					};

					userList.Add(user);
				}

				return userList;
			}
			set
			{
				DataGridView dataGridView;

				if (mainTabControl.SelectedTab == mainTabPage)
					dataGridView = usersDataGridView;

				else if (mainTabControl.SelectedTab == searchTabPage)
					dataGridView = passengersDataGridView;

				else
					return;

				dataGridView.Rows.Clear();

				foreach (var user in value)
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
		}

		public ICollection<OrderEntity> Orders
		{
			get
			{
				var orderList = new List<OrderEntity>();

				for (int i = 0; i < ordersDataGridView.RowCount - 1; i++)
				{
					var id = Convert.ToInt32(ordersDataGridView.Rows[i].Cells[0].Value);
					var userId = Convert.ToInt32(ordersDataGridView.Rows[i].Cells[1].Value);
					var flightId = Convert.ToInt32(ordersDataGridView.Rows[i].Cells[2].Value);
					var desiredDate = Convert.ToDateTime(ordersDataGridView.Rows[i].Cells[3].Value);
					var orderDate = Convert.ToDateTime(ordersDataGridView.Rows[i].Cells[4].Value);
					var officeId = Convert.ToInt32(ordersDataGridView.Rows[i].Cells[5].Value);

					var order = new OrderEntity()
					{
						Id = id,
						UserId = userId,
						FlightId = flightId,
						DesiredDate = desiredDate,
						OrderDate = orderDate,
						OfficeId = officeId
					};

					orderList.Add(order);
				}

				return orderList;
			}
			set
			{
				ordersDataGridView.Rows.Clear();

				foreach (var order in value)
				{
					ordersDataGridView.Rows.Add(
						order.Id,
						order.UserId,
						order.FlightId,
						order.DesiredDate,
						order.OrderDate,
						order.OfficeId
					);
				}
			}
		}

		public ICollection<TicketEntity> Tickets
		{
			get
			{
				var ticketList = new List<TicketEntity>();

				for (int i = 0; i < ticketsDataGridView.RowCount - 1; i++)
				{
					var id = Convert.ToInt32(ticketsDataGridView.Rows[i].Cells[0].Value);
					var userId = Convert.ToInt32(ticketsDataGridView.Rows[i].Cells[1].Value);
					var classId = Convert.ToInt32(ticketsDataGridView.Rows[i].Cells[2].Value);
					var flightId = Convert.ToInt32(ticketsDataGridView.Rows[i].Cells[3].Value);
					var cost = Convert.ToInt32(ticketsDataGridView.Rows[i].Cells[4].Value);

					var ticket = new TicketEntity()
					{
						Id = id,
						UserId = userId,
						FlightId = flightId,
						ClassId = classId,
						Cost = cost
					};

					ticketList.Add(ticket);
				}

				return ticketList;
			}
			set
			{
				ticketsDataGridView.Rows.Clear();

				foreach (var ticket in value)
				{
					ticketsDataGridView.Rows.Add(
						ticket.Id,
						ticket.UserId,
						ticket.FlightId,
						ticket.ClassId,
						ticket.Cost
					);
				}
			}
		}

		public ICollection<RouteEntity> Routes
		{
			get
			{
				var routeList = new List<RouteEntity>();

				for (int i = 0; i < routesDataGridView.RowCount - 1; i++)
				{
					var id = Convert.ToInt32(routesDataGridView.Rows[i].Cells[0].Value);
					var departureAirportId = Convert.ToInt32(routesDataGridView.Rows[i].Cells[1].Value);
					var arrivalAirportId = Convert.ToInt32(routesDataGridView.Rows[i].Cells[2].Value);

					var route = new RouteEntity()
					{
						Id = id,
						DepartureAirportId = departureAirportId,
						ArrivalAirportId = arrivalAirportId
					};

					routeList.Add(route);
				}

				return routeList;
			}
			set
			{
				routesDataGridView.Rows.Clear();

				foreach (var route in value)
				{
					routesDataGridView.Rows.Add(
						route.Id,
						route.DepartureAirportId,
						route.ArrivalAirportId
					);
				}
			}
		}

		public ICollection<FlightEntity> Flights
		{
			get
			{
				var flightList = new List<FlightEntity>();

				for (int i = 0; i < flightsDataGridView.RowCount - 1; i++)
				{
					var id = Convert.ToInt32(flightsDataGridView.Rows[i].Cells[0].Value);
					var planeId = Convert.ToInt32(flightsDataGridView.Rows[i].Cells[1].Value);
					var routeId = Convert.ToInt32(flightsDataGridView.Rows[i].Cells[2].Value);
					var dateFrom = Convert.ToDateTime(flightsDataGridView.Rows[i].Cells[3].Value);
					var dateTo = Convert.ToDateTime(flightsDataGridView.Rows[i].Cells[4].Value);

					var flight = new FlightEntity()
					{
						Id = id,
						PlaneId = planeId,
						RouteId = routeId,
						DateFrom = dateFrom,
						DateTo = dateTo
					};

					flightList.Add(flight);
				}

				return flightList;
			}
			set
			{
				flightsDataGridView.Rows.Clear();

				foreach (var flight in value)
				{
					flightsDataGridView.Rows.Add(
						flight.Id,
						flight.PlaneId,
						flight.RouteId,
						flight.DateFrom,
						flight.DateTo
					);
				}
			}
		}

		public ICollection<PlaneEntity> Planes
		{
			get
			{
				var planeList = new List<PlaneEntity>();

				for (int i = 0; i < planesDataGridView.RowCount - 1; i++)
				{
					var id = Convert.ToInt32(planesDataGridView.Rows[i].Cells[0].Value);
					var number = Convert.ToInt32(planesDataGridView.Rows[i].Cells[1].Value);
					var type = Convert.ToString(planesDataGridView.Rows[i].Cells[2].Value);
					var stClassSeats = Convert.ToInt32(planesDataGridView.Rows[i].Cells[3].Value);
					var ndClassSeats = Convert.ToInt32(planesDataGridView.Rows[i].Cells[4].Value);
					var rdClassSeats = Convert.ToInt32(planesDataGridView.Rows[i].Cells[5].Value);

					var plane = new PlaneEntity()
					{
						Id = id,
						Number = number,
						Type = type,
						Seats = new List<SeatEntity>()
						{
							new SeatEntity() { ClassId = 2, PlaneId = id, Amount = stClassSeats},
							new SeatEntity() { ClassId = 3, PlaneId = id, Amount = ndClassSeats},
							new SeatEntity() { ClassId = 4, PlaneId = id, Amount = rdClassSeats}
						}
					};

					planeList.Add(plane);
				}

				return planeList;
			}
			set
			{
				planesDataGridView.Rows.Clear();

				foreach (var plane in value)
				{
					planesDataGridView.Rows.Add(
						plane.Id,
						plane.Number,
						plane.Type,
						plane.Seats.ToList()[0].Amount,
						plane.Seats.ToList()[1].Amount,
						plane.Seats.ToList()[2].Amount
					);
				}
			}
		}

		public ICollection<CrewMemberEntity> CrewMembers
		{
			get
			{
				var crewList = new List<CrewMemberEntity>();

				for (int i = 0; i < crewMembersDataGridView.RowCount - 1; i++)
				{
					var id = Convert.ToInt32(crewMembersDataGridView.Rows[i].Cells[0].Value);
					var planeId = Convert.ToInt32(crewMembersDataGridView.Rows[i].Cells[1].Value);
					var initials = Convert.ToString(crewMembersDataGridView.Rows[i].Cells[2].Value);
					var position = Convert.ToString(crewMembersDataGridView.Rows[i].Cells[3].Value);

					var crewMember = new CrewMemberEntity()
					{
						Id = id,
						PlaneId = planeId,
						Initials = initials,
						Position = position
					};

					crewList.Add(crewMember);
				}

				return crewList;
			}
			set
			{
				crewMembersDataGridView.Rows.Clear();

				foreach (var crewMember in value)
				{
					crewMembersDataGridView.Rows.Add(
						crewMember.Id,
						crewMember.PlaneId,
						crewMember.Initials,
						crewMember.Position
					);
				}
			}
		}

		public ICollection<AirportEntity> Airports
		{
			get
			{
				var airportsList = new List<AirportEntity>();

				for (int i = 0; i < airportsDataGridView.RowCount - 1; i++)
				{
					var id = Convert.ToInt32(airportsDataGridView.Rows[i].Cells[0].Value);
					var name = Convert.ToString(airportsDataGridView.Rows[i].Cells[1].Value);
					var city = Convert.ToString(airportsDataGridView.Rows[i].Cells[2].Value);
					var image = Convert.ToString(airportsDataGridView.Rows[i].Cells[3].Value);

					var airport = new AirportEntity()
					{
						Id = id,
						Name = name,
						City = city,
						Image = image
					};

					airportsList.Add(airport);
				}

				return airportsList;
			}
			set
			{
				airportsDataGridView.Rows.Clear();

				foreach (var airport in value)
				{
					airportsDataGridView.Rows.Add(
						airport.Id,
						airport.Name,
						airport.City,
						airport.Image
					);
				}
			}
		}

		public new void Show()
		{
			_context.MainForm = this;
			base.Show();
		}

		public void SendMessage(string message)
		{
			MessageBox.Show(message);
		}

		private int GetSelectedId(DataGridView dataGridView)
		{
			var selectedRowIndex = dataGridView.CurrentCell.RowIndex;
			return (int)dataGridView.Rows[selectedRowIndex].Cells[0].Value;
		}
		private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedTabText = @"	 " + mainTabControl.SelectedTab.Text;

			Text = selectedTabText;
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

		private void saveSingleToolStripButton_Click(object sender, EventArgs e)
		{
			if (mainTabPageTabControl.SelectedTab == usersTabPage)
			{
				SelectedId = GetSelectedId(usersDataGridView);

				SaveUserChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == ordersTabPage)
			{
				SelectedId = GetSelectedId(ordersDataGridView);

				SaveOrderChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == ticketsTabPage)
			{
				SelectedId = GetSelectedId(ticketsDataGridView);

				SaveTicketChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == routesTabPage)
			{
				SelectedId = GetSelectedId(routesDataGridView);

				SaveRouteChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == flightsTabPage)
			{
				SelectedId = GetSelectedId(flightsDataGridView);

				SaveFlightChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == planesTabPage)
			{
				SelectedId = GetSelectedId(planesDataGridView);

				SavePlaneChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == crewTabPage)
			{
				SelectedId = GetSelectedId(crewMembersDataGridView);

				SaveCrewMemberChanges?.Invoke();
			}
			else
			{
				SelectedId = GetSelectedId(airportsDataGridView);

				SaveAirportChanges?.Invoke();
			}
		}

		private void saveAllToolStripButton_Click(object sender, EventArgs e)
		{

			if (mainTabPageTabControl.SelectedTab == usersTabPage)
			{
				SaveAllUsersChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == ordersTabPage)
			{
				SaveAllOrdersChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == ticketsTabPage)
			{
				SaveAllTicketsChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == routesTabPage)
			{
				SaveAllRoutesChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == flightsTabPage)
			{
				SaveAllFlightsChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == planesTabPage)
			{
				SaveAllPlanesChanges?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == crewTabPage)
			{
				SaveAllCrewMembersChanges?.Invoke();
			}
			else
			{
				SaveAllAirportsChanges?.Invoke();
			}
		}
		private void deleteToolStripButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(@"Вы действительно хотите удалить запись?", @"Удаление", MessageBoxButtons.YesNo) == DialogResult.No) 
				return;

			int selectedRowIndex;

			if (mainTabPageTabControl.SelectedTab == usersTabPage)
			{
				selectedRowIndex = usersDataGridView.CurrentCell.RowIndex;
				SelectedId = (int)usersDataGridView.Rows[selectedRowIndex].Cells[0].Value;

				usersDataGridView.Rows.Remove(usersDataGridView.Rows[selectedRowIndex]);
				DeleteUser?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == ordersTabPage)
			{
				selectedRowIndex = ordersDataGridView.CurrentCell.RowIndex;
				SelectedId = (int)ordersDataGridView.Rows[selectedRowIndex].Cells[0].Value;

				ordersDataGridView.Rows.Remove(ordersDataGridView.Rows[selectedRowIndex]);
				DeleteOrder?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == ticketsTabPage)
			{
				selectedRowIndex = ticketsDataGridView.CurrentCell.RowIndex;
				SelectedId = (int)ticketsDataGridView.Rows[selectedRowIndex].Cells[0].Value;

				ticketsDataGridView.Rows.Remove(ticketsDataGridView.Rows[selectedRowIndex]);
				DeleteTicket?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == routesTabPage)
			{
				selectedRowIndex = routesDataGridView.CurrentCell.RowIndex;
				SelectedId = (int)routesDataGridView.Rows[selectedRowIndex].Cells[0].Value;

				routesDataGridView.Rows.Remove(routesDataGridView.Rows[selectedRowIndex]);
				DeleteRoute?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == flightsTabPage)
			{
				selectedRowIndex = flightsDataGridView.CurrentCell.RowIndex;
				SelectedId = (int)flightsDataGridView.Rows[selectedRowIndex].Cells[0].Value;

				flightsDataGridView.Rows.Remove(flightsDataGridView.Rows[selectedRowIndex]);
				DeleteFlight?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == planesTabPage)
			{
				selectedRowIndex = planesDataGridView.CurrentCell.RowIndex;
				SelectedId = (int)planesDataGridView.Rows[selectedRowIndex].Cells[0].Value;

				planesDataGridView.Rows.Remove(planesDataGridView.Rows[selectedRowIndex]);
				DeletePlane?.Invoke();
			}
			else if (mainTabPageTabControl.SelectedTab == crewTabPage)
			{
				selectedRowIndex = crewMembersDataGridView.CurrentCell.RowIndex;
				SelectedId = (int)crewMembersDataGridView.Rows[selectedRowIndex].Cells[0].Value;

				crewMembersDataGridView.Rows.Remove(crewMembersDataGridView.Rows[selectedRowIndex]);
				DeleteCrewMember?.Invoke();
			}
			else
			{
				selectedRowIndex = airportsDataGridView.CurrentCell.RowIndex;
				SelectedId = (int)airportsDataGridView.Rows[selectedRowIndex].Cells[0].Value;

				airportsDataGridView.Rows.Remove(airportsDataGridView.Rows[selectedRowIndex]);
				DeleteAirport?.Invoke();
			}
		}
	}
}
