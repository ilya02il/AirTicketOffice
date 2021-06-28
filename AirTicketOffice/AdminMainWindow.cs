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
		//public event GetAllEntitiesEventHandler<IEntity> GetAllEntities;
		//public event DeleteEntityEventHandler<IEntity> DeleteEntity;
		//public event SaveEntityEventHandler<IEntity> SaveEntity;
		//public event SaveAllEntitiesEventHandler<IEntity> SaveAllEntities;

		public event Action GetAllUsers;
		public event Action GetAllTickets;
		public event Action GetAllTicketPrices;
		public event Action GetAllRoutes;
		public event Action GetAllFlights;
		public event Action GetAllPlanes;
		public event Action GetAllCrewMembers;
		public event Action GetAllAirports;

		public event Action DeleteUser;
		public event Action DeleteTicket;
		public event Action DeleteTicketPrice;
		public event Action DeleteRoute;
		public event Action DeleteFlight;
		public event Action DeletePlane;
		public event Action DeleteCrewMember;
		public event Action DeleteAirport;

		public event Action SaveAllUsersChanges;
		public event Action SaveAllTicketsChanges;
		public event Action SaveAllTicketPricesChanges;
		public event Action SaveAllRoutesChanges;
		public event Action SaveAllFlightsChanges;
		public event Action SaveAllPlanesChanges;
		public event Action SaveAllCrewMembersChanges;
		public event Action SaveAllAirportsChanges;

		public event Action SaveUserChanges;
		public event Action SaveTicketChanges;
		public event Action SaveTicketPriceChanges;
		public event Action SaveRouteChanges;
		public event Action SaveFlightChanges;
		public event Action SavePlaneChanges;
		public event Action SaveCrewMemberChanges;
		public event Action SaveAirportChanges;

		public event Action SaveCurrentUserInfo;
		public event Action ChangePassword;
		public event Action ExitFromAccount;

		public event Action PrintTicket;
		//public event Action PrintReport;

		private ICollection<TicketEntity> _tickets;
		//private ICollection<FlightEntity> _flights;
		private readonly ApplicationContext _context;

		public AdminMainWindow(ApplicationContext context, MaterialSkinManager manager)
		{
			_context = context;
			//_tickets = new List<TicketEntity>();
			//_flights = new List<FlightEntity>();

			InitializeComponent();

			manager.AddFormToManage(this);

			mainTabControl.SelectedIndex = 0;
			Text = @"	 " + mainTabControl.SelectedTab.Text;

			Load += (sender, args) =>
			{
				GetAllUsers?.Invoke();
				amountOfEmptySeatsStatusLabel.Text = usersDataGridView.RowCount.ToString();
			};

			usersTabPage.Enter += (sender, args) =>
			{
				GetAllUsers?.Invoke();
				amountOfEmptySeatsStatusLabel.Text = usersDataGridView.RowCount.ToString();
			};
			searchPassengersTabPage.Enter += (sender, args) =>
			{
				GetAllUsers?.Invoke();
				amountOfEmptySeatsStatusLabel.Text = passengersDataGridView.RowCount.ToString();

				searchTypeComboBox.Items.Clear();
				searchTypeComboBox.Items.Add("ФИО");
				searchTypeComboBox.Items.Add("номеру паспорта");
			};
			ticketsTabPage.Enter += (sender, args) =>
			{
				GetAllTickets?.Invoke();
				amountOfEmptySeatsStatusLabel.Text = ticketsDataGridView.RowCount.ToString();
			};
			ticketFilterTabPage.Enter += (sender, args) =>
			{
				GetAllTickets?.Invoke();

				ticketFilterDataGridView.Rows.Clear();

				foreach (var ticket in _tickets)
				{
					ticketFilterDataGridView.Rows.Add(
						ticket.User.Surname + " " + ticket.User.Name + " " + ticket.User.Patronymic,
						ticket.TicketPrice.FlightId,
						ticket.TicketPrice.Flight.Route.DepartureAirport.Name,
						ticket.TicketPrice.Flight.DateFrom,
						ticket.TicketPrice.Flight.Route.ArrivalAirport.Name,
						ticket.TicketPrice.Flight.DateTo,
						ticket.TicketPrice.Class.Name
					);
				}

				amountOfEmptySeatsStatusLabel.Text = ticketFilterDataGridView.RowCount.ToString();

				filterTypeComboBox.Items.Clear();
				filterTypeComboBox.Items.Add("номеру рейса");
				filterTypeComboBox.Items.Add("дате вылета");
				filterTypeComboBox.Items.Add("аэропорту прибытия");
				filterTypeComboBox.Items.Add("классу авиабилета");
			};
			printTabPage.Enter += (sender, args) =>
			{
				GetAllTickets?.Invoke();

				printTicketDataGridView.Rows.Clear();

				foreach (var ticket in _tickets)
				{
					printTicketDataGridView.Rows.Add(
						ticket.Id,
						ticket.User.Surname + " " + ticket.User.Name + " " + ticket.User.Patronymic,
						ticket.TicketPrice.FlightId,
						ticket.TicketPrice.Flight.Route.DepartureAirport.Name,
						ticket.TicketPrice.Flight.DateFrom,
						ticket.TicketPrice.Flight.Route.ArrivalAirport.Name,
						ticket.TicketPrice.Flight.DateTo,
						ticket.TicketPrice.Class.Name
					);
				}
			};
			ticketPricesTabPage.Enter += (sender, args) =>
			{
				GetAllTicketPrices?.Invoke();
				amountOfEmptySeatsStatusLabel.Text = ticketPricesDataGridView.RowCount.ToString();
			};
			routesTabPage.Enter += (sender, args) =>
			{
				GetAllRoutes?.Invoke();
				amountOfEmptySeatsStatusLabel.Text = routesDataGridView.RowCount.ToString();
			};
			flightsTabPage.Enter += (sender, args) =>
			{
				GetAllFlights?.Invoke();
				amountOfEmptySeatsStatusLabel.Text = flightsDataGridView.RowCount.ToString();
			};
			planesTabPage.Enter += (sender, args) =>
			{
				GetAllPlanes?.Invoke();
				amountOfEmptySeatsStatusLabel.Text = planesDataGridView.RowCount.ToString();
			};
			crewTabPage.Enter += (sender, args) =>
			{
				GetAllCrewMembers?.Invoke();
				amountOfEmptySeatsStatusLabel.Text = crewMembersDataGridView.RowCount.ToString();
			};
			airportsTabPage.Enter += (sender, args) =>
			{
				GetAllAirports?.Invoke();
				amountOfEmptySeatsStatusLabel.Text = airportsDataGridView.RowCount.ToString();
			};

			saveAccountChangesButton.Click += (sender, args) => SaveCurrentUserInfo?.Invoke();
			changePasswordButton.Click += (sender, args) => ChangePassword?.Invoke();
			exitFromAccountButton.Click += (sender, args) => ExitFromAccount?.Invoke();

			printTicketButton.Click += (sender, args) => PrintTicket?.Invoke();
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

		public TicketEntity Ticket
		{
			get
			{
				var selectedRowIndex = printTicketDataGridView.CurrentCell.RowIndex;
				var selectedId = Convert.ToInt32(printTicketDataGridView.Rows[selectedRowIndex].Cells[0].Value);

				return _tickets.FirstOrDefault(ticket => ticket.Id == selectedId);
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

		public ICollection<TicketEntity> Tickets
		{
			get
			{
				var ticketList = new List<TicketEntity>();

				for (int i = 0; i < ticketsDataGridView.RowCount - 1; i++)
				{
					var id = Convert.ToInt32(ticketsDataGridView.Rows[i].Cells[0].Value);
					var userId = Convert.ToInt32(ticketsDataGridView.Rows[i].Cells[1].Value);
					var ticketPriceId = Convert.ToInt32(ticketsDataGridView.Rows[i].Cells[3].Value);

					var ticket = new TicketEntity()
					{
						Id = id,
						UserId = userId,
						TicketPriceId = ticketPriceId
					};

					ticketList.Add(ticket);
				}

				return ticketList;
			}
			set
			{
				_tickets = value;

				ticketsDataGridView.Rows.Clear();

				foreach (var ticket in value)
				{
					ticketsDataGridView.Rows.Add(
						ticket.Id,
						ticket.UserId,
						ticket.TicketPriceId
					);
				}
			}
		}

		public ICollection<TicketPriceEntity> TicketPrices
		{
			get
			{
				var ticketPricesList = new List<TicketPriceEntity>();

				for (int i = 0; i < ticketPricesDataGridView.RowCount - 1; i++)
				{
					var id = Convert.ToInt32(ticketPricesDataGridView.Rows[i].Cells[0].Value);
					var classId = Convert.ToInt32(ticketPricesDataGridView.Rows[i].Cells[1].Value);
					var flightId = Convert.ToInt32(ticketPricesDataGridView.Rows[i].Cells[2].Value);
					var price = Convert.ToInt32(ticketPricesDataGridView.Rows[i].Cells[3].Value);

					var ticketPrice = new TicketPriceEntity()
					{
						Id = id,
						ClassId = classId,
						FlightId = flightId,
						Price = price
					};

					ticketPricesList.Add(ticketPrice);
				}

				return ticketPricesList;
			}
			set
			{
				ticketPricesDataGridView.Rows.Clear();

				foreach (var ticket in value)
				{
					ticketPricesDataGridView.Rows.Add(
						ticket.Id,
						ticket.ClassId,
						ticket.FlightId,
						ticket.Price
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
				//_flights = value;

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

		private void filterTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;


			var filterText = filterTextBox.Text;

			if (filterTabControl.SelectedTab == ticketFilterTabPage)
			{
				ticketFilterDataGridView.CurrentCell = null;

				for (int i = 0; i < ticketFilterDataGridView.Rows.Count - 1; i++)
				{
					if (filterTypeComboBox.StartIndex == 0)
					{
						ticketFilterDataGridView.Rows[i].Visible =
							ticketFilterDataGridView[1, i].Value.ToString().ToLower().Contains(filterText.ToLower())
							|| ticketFilterDataGridView[1, i].Value.ToString() == filterText;
					}
					else if (filterTypeComboBox.StartIndex == 0)
					{
						ticketFilterDataGridView.Rows[i].Visible =
							ticketFilterDataGridView[3, i].Value.ToString().ToLower().Contains(filterText.ToLower())
							|| ticketFilterDataGridView[3, i].Value.ToString() == filterText;
					}
					else if (filterTypeComboBox.StartIndex == 0)
					{
						ticketFilterDataGridView.Rows[i].Visible =
							ticketFilterDataGridView[4, i].Value.ToString().ToLower().Contains(filterText.ToLower())
							|| ticketFilterDataGridView[4, i].Value.ToString() == filterText;
					}
					else
					{
						ticketFilterDataGridView.Rows[i].Visible =
							ticketFilterDataGridView[6, i].Value.ToString().ToLower().Contains(filterText.ToLower())
							|| ticketFilterDataGridView[6, i].Value.ToString() == filterText;
					}
				}
			}
		}

		private void saveSingleToolStripButton_Click(object sender, EventArgs e)
		{
			switch (mainTabPageTabControl.SelectedTab.Name)
			{
				case "usersTabPage":
					SelectedId = GetSelectedId(usersDataGridView);
					SaveUserChanges?.Invoke();
					break;
				case "ticketsTabPage":
					SelectedId = GetSelectedId(ticketsDataGridView);
					SaveTicketChanges?.Invoke();
					break;
				case "ticketPricesTabPage":
					SelectedId = GetSelectedId(ticketPricesDataGridView);
					SaveTicketPriceChanges?.Invoke();
					break;
				case "routesTabPage":
					SelectedId = GetSelectedId(routesDataGridView);
					SaveRouteChanges?.Invoke();
					break;
				case "flightsTabPage":
					SelectedId = GetSelectedId(flightsDataGridView);
					SaveFlightChanges?.Invoke();
					break;
				case "planesTabPage":
					SelectedId = GetSelectedId(planesDataGridView);
					SavePlaneChanges?.Invoke();
					break;
				case "crewTabPage":
					SelectedId = GetSelectedId(crewMembersDataGridView);
					SaveCrewMemberChanges?.Invoke();
					break;
				case "airportsTabPage":
					SelectedId = GetSelectedId(airportsDataGridView);
					SaveAirportChanges?.Invoke();
					break;
			}
		}

		private void saveAllToolStripButton_Click(object sender, EventArgs e)
		{
			switch (mainTabPageTabControl.SelectedTab.Name)
			{
				case "usersTabPage":
					SaveAllUsersChanges?.Invoke();
					break;
				case "ticketsTabPage":
					SaveAllTicketsChanges?.Invoke();
					break;
				case "ticketPricesTabPage":
					SaveAllTicketPricesChanges?.Invoke();
					break;
				case "routesTabPage":
					SaveAllRoutesChanges?.Invoke();
					break;
				case "flightsTabPage":
					SaveAllFlightsChanges?.Invoke();
					break;
				case "planesTabPage":
					SaveAllPlanesChanges?.Invoke();
					break;
				case "crewTabPage":
					SaveAllCrewMembersChanges?.Invoke();
					break;
				case "airportsTabPage":
					SaveAllAirportsChanges?.Invoke();
					break;
			}
		}

		private void deleteToolStripButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(@"Вы действительно хотите удалить запись?", @"Удаление", MessageBoxButtons.YesNo) == DialogResult.No) 
				return;

			int selectedRowIndex;

			switch (mainTabPageTabControl.SelectedTab.Name)
			{
				case "usersTabPage":
					selectedRowIndex = usersDataGridView.CurrentCell.RowIndex;
					SelectedId = (int)usersDataGridView.Rows[selectedRowIndex].Cells[0].Value;

					usersDataGridView.Rows.Remove(usersDataGridView.Rows[selectedRowIndex]);
					DeleteUser?.Invoke();
					break;
				case "ticketsTabPage":
					selectedRowIndex = ticketsDataGridView.CurrentCell.RowIndex;
					SelectedId = (int)ticketsDataGridView.Rows[selectedRowIndex].Cells[0].Value;

					ticketsDataGridView.Rows.Remove(ticketsDataGridView.Rows[selectedRowIndex]);
					DeleteTicket?.Invoke();
					break;
				case "ticketPricesTabPage":
					selectedRowIndex = ticketPricesDataGridView.CurrentCell.RowIndex;
					SelectedId = (int)ticketPricesDataGridView.Rows[selectedRowIndex].Cells[0].Value;

					ticketsDataGridView.Rows.Remove(ticketPricesDataGridView.Rows[selectedRowIndex]);
					DeleteTicketPrice?.Invoke();
					break;
				case "routesTabPage":
					selectedRowIndex = routesDataGridView.CurrentCell.RowIndex;
					SelectedId = (int)routesDataGridView.Rows[selectedRowIndex].Cells[0].Value;

					routesDataGridView.Rows.Remove(routesDataGridView.Rows[selectedRowIndex]);
					DeleteRoute?.Invoke();
					break;
				case "flightsTabPage":
					selectedRowIndex = flightsDataGridView.CurrentCell.RowIndex;
					SelectedId = (int)flightsDataGridView.Rows[selectedRowIndex].Cells[0].Value;

					flightsDataGridView.Rows.Remove(flightsDataGridView.Rows[selectedRowIndex]);
					DeleteFlight?.Invoke();
					break;
				case "planesTabPage":
					selectedRowIndex = planesDataGridView.CurrentCell.RowIndex;
					SelectedId = (int)planesDataGridView.Rows[selectedRowIndex].Cells[0].Value;

					planesDataGridView.Rows.Remove(planesDataGridView.Rows[selectedRowIndex]);
					DeletePlane?.Invoke();
					break;
				case "crewTabPage":
					selectedRowIndex = crewMembersDataGridView.CurrentCell.RowIndex;
					SelectedId = (int)crewMembersDataGridView.Rows[selectedRowIndex].Cells[0].Value;

					crewMembersDataGridView.Rows.Remove(crewMembersDataGridView.Rows[selectedRowIndex]);
					DeleteCrewMember?.Invoke();
					break;
				case "airportsTabPage":
					selectedRowIndex = airportsDataGridView.CurrentCell.RowIndex;
					SelectedId = (int)airportsDataGridView.Rows[selectedRowIndex].Cells[0].Value;

					airportsDataGridView.Rows.Remove(airportsDataGridView.Rows[selectedRowIndex]);
					DeleteAirport?.Invoke();
					break;
			}
		}
	}
}
