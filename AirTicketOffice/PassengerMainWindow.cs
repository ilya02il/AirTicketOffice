using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using AirTicketOffice.DAL.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using AirTicketOffice.Presentations.Views;

namespace AirTicketOffice
{
	public partial class PassengerMainWindow : MaterialForm, IPassengerMainView
	{
		public event Action LoadFlights;
		public event Action AddTicket;
		public event Action PrintTicket;

		public event Action SaveCurrentUserInfo;
		public event Action ChangePassword;
		public event Action ExitFromAccount;

		private UserEntity _currentUser;
		private readonly Dictionary<int, PictureBox> _tiles;
		private ICollection<FlightEntity> _flights;
		private int _topTileKey;
		private readonly ApplicationContext _context;

		public PassengerMainWindow(ApplicationContext context, MaterialSkinManager manager)
		{
			_context = context;
			_tiles = new Dictionary<int, PictureBox>();

			InitializeComponent();

			manager.AddFormToManage(this);

			mainTabControl.SelectedIndex = 0;
			Text = @"	 " + mainTabControl.SelectedTab.Text;

			saveAccountChangesButton.Click += (sender, args) => SaveCurrentUserInfo?.Invoke();
			changePasswordButton.Click += (sender, args) => ChangePassword?.Invoke();
			exitFromAccountButton.Click += (sender, args) => ExitFromAccount?.Invoke();

			pictureBox2.Parent = pictureBox1;
			pictureBox3.Parent = pictureBox1;
			pictureBox4.Parent = pictureBox1;
			pictureBox5.Parent = pictureBox1;
			pictureBox6.Parent = pictureBox1;

			pictureBox2.BackColor = Color.Transparent;
			pictureBox3.BackColor = Color.Transparent;
			pictureBox4.BackColor = Color.Transparent;
			pictureBox5.BackColor = Color.Transparent;
			pictureBox6.BackColor = Color.Transparent;
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
				_currentUser = value;

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
				string selectedClassName;

				if (materialRadioButton1.Checked)
					selectedClassName = "A";
				else if (materialRadioButton2.Checked)
					selectedClassName = "B";
				else
					selectedClassName = "C";

				var selectedFlightId = Convert.ToInt32(flightNumberLabel.Text);

				var ticketPriceId = _flights.FirstOrDefault(flight => flight.Id == selectedFlightId)?.TicketPrices
					.FirstOrDefault(tp => tp.Class.Name == selectedClassName)?.Id ?? 0;

				return new TicketEntity()
				{
					UserId = _currentUser.Id,
					TicketPriceId = ticketPriceId,
					OrderDate = DateTime.Now
				};
			}
		}
		public ICollection<FlightEntity> Flights
		{
			set
			{
				_flights = value;

				flightsDataGridView.Rows.Clear();

				foreach (var flight in value)
				{
					flightsDataGridView.Rows.Add(
						flight.Id,
						flight.Plane.Number,
						flight.Route.DepartureAirport.City + " - " + flight.Route.ArrivalAirport.City,
						flight.DateFrom,
						flight.DateTo
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

		private void PassengerMainWindow_Load(object sender, EventArgs e)
		{
			timer1.Interval = 50;
			timer1.Enabled = true;
			timer1.Tick += timer1_Tick;

			LoadFlights?.Invoke();

			foreach (var flight in _flights)
			{
				var arrivalAirportId = flight.Route.ArrivalAirportId;
				var image = Image.FromFile(Application.StartupPath + "\\Images\\" + flight.Route.ArrivalAirport.Image);

				if (_tiles.Keys.Any(key => key == arrivalAirportId))
					continue;

				_tiles.Add(arrivalAirportId, new PictureBox()
				{
					Image = image,
					Size = new Size(170, 140),
					Location = new Point((carouselCard.Size.Width - 170) / 2, 148 * _tiles.Count + 7),
					Anchor = AnchorStyles.None
				});

				carouselCard.Controls.Add(_tiles[arrivalAirportId]);

				if (_tiles.Count == _flights.Count)
				{
					_topTileKey = arrivalAirportId;
				}
			}

			foreach (var tile in _tiles)
			{
				tile.Value.Click += (o, args) =>
				{
					flightsDataGridView.ClearSelection();

					for (int i = 0; i < flightsDataGridView.RowCount - 1; i++)
					{
						var flightId = Convert.ToInt32(flightsDataGridView.Rows[i].Cells[0].Value);
						var flight = _flights.FirstOrDefault(f => f.Id == flightId);
						var arrAirportId = flight?.Route.ArrivalAirportId ?? 0;

						foreach (var t in _tiles)
						{
							if (t.Value == o && t.Key == arrAirportId)
								flightsDataGridView.Rows[i].Selected = true;
						}
					}
				};
			}
		}

		private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedTabText = @"	 " + mainTabControl.SelectedTab.Text;

			Text = selectedTabText;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			foreach (var tile in _tiles)
			{
				if (tile.Value.Location.Y >= -tile.Value.Size.Height + 7)
				{
					tile.Value.Location = new Point(tile.Value.Location.X, tile.Value.Location.Y - 1);
				}
				else
				{
					tile.Value.Location = new Point(tile.Value.Location.X, _tiles[_topTileKey].Location.Y + (tile.Value.Size.Height + 7));
					_topTileKey = tile.Key;
				}
			}
		}

		private void flightsDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (flightsDataGridView.SelectedRows.Count == 0) return;

			flightNumberLabel.Text = flightsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
			flightRouteLabel.Text = flightsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
			flightDepartureDateLabel.Text = flightsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
			flightArrivalDateLabel.Text = flightsDataGridView.SelectedRows[0].Cells[4].Value.ToString();

			var id = Convert.ToInt32(flightsDataGridView.SelectedRows[0].Cells[0].Value);

			flightStClassEmptySeatsLabel.Text = GetEmptySeatsForClass(id, "A") + @" свободных мест.";
			flightNdClassEmptySeatsLabel.Text = GetEmptySeatsForClass(id, "B") + @" свободных мест.";
			flightRdClassEmptySeatsLabel.Text = GetEmptySeatsForClass(id, "C") + @" свободных мест.";

			materialRadioButton1.Checked = true;
			radioButton_CheckedChanged(null, null);
		}

		private int GetEmptySeatsForClass(int flightId, string className)
		{
			var generalPlaneSeatsAmount = _flights.FirstOrDefault(flight => flight.Id == flightId)?.Plane.Seats
				.FirstOrDefault(seat => seat.Class.Name == className)?.Amount ?? 0;

			var ticketsAmount = _flights.FirstOrDefault(flight => flight.Id == flightId)?.TicketPrices
				.FirstOrDefault(tp => tp.Class.Name == className)
				?.Tickets.Count() ?? 0;

			return generalPlaneSeatsAmount - ticketsAmount;
		}

		private int GetTicketPrice(int flightId, string className)
		{ 
			var flight = _flights.FirstOrDefault(f => f.Id == flightId); 
			var ticketPrice = flight?.TicketPrices.FirstOrDefault(tp => tp.Class.Name == className)?.Price ?? 0;

			return ticketPrice;
		}

		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			var id = Convert.ToInt32(flightsDataGridView.SelectedRows[0].Cells[0].Value);
			string selectedClassName;

			if (materialRadioButton1.Checked)
				selectedClassName = "A";
			else if (materialRadioButton2.Checked)
				selectedClassName = "B";
			else
				selectedClassName = "C";

			ticketPriceLabel.Text = GetTicketPrice(id, selectedClassName).ToString();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			materialCard2.Visible = !materialCard2.Visible;
		}

		private void orderTicketButton_Click(object sender, EventArgs e)
		{
			var id = Convert.ToInt32(flightsDataGridView.SelectedRows[0].Cells[0].Value);
			int amountOfEmptySeats;

			if (materialRadioButton1.Checked)
				amountOfEmptySeats = GetEmptySeatsForClass(id, "A");
			else if (materialRadioButton2.Checked)
				amountOfEmptySeats = GetEmptySeatsForClass(id, "B");
			else
				amountOfEmptySeats = GetEmptySeatsForClass(id, "C");

			if (!(amountOfEmptySeats > 0))
			{
				MessageBox.Show(@"Свободных мест данного класса на этом рейсе не осталось.");
				return;
			}

			var dialogResult = MessageBox.Show(@"Распечатать билет?", @"Печать",
				MessageBoxButtons.YesNo);

			AddTicket?.Invoke();

			if (dialogResult == DialogResult.No)
				return;

			PrintTicket?.Invoke();
		}
	}
}
