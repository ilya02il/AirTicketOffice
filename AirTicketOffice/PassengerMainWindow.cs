using System;
using System.Collections.Generic;
using System.Drawing;
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

		public event Action SaveCurrentUserInfo;
		public event Action ChangePassword;
		public event Action ExitFromAccount;

		private readonly Dictionary<int, PictureBox> _tiles;
		private ICollection<FlightEntity> _flights;
		private int _topTileId;
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
				accountSurnameTextBox.Text = value.Surname;
				accountNameTextBox.Text = value.Name;
				accountPatronymicTextBox.Text = value.Patronymic;
				accountGenderComboBox.SelectedItem = value.Gender;
				accountLoginTextBox.Text = value.Login;
				accountPassportTextBox.Text = value.PassportNumber;
				accountPhoneTextBox.Text = value.PhoneNumber;
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
			timer1.Interval = 10;
			timer1.Enabled = true;
			timer1.Tick += timer1_Tick;

			LoadFlights?.Invoke();

			foreach (var flight in _flights)
			{
				var id = flight.Id;
				var image = Image.FromFile(Application.StartupPath + "\\Images\\" + flight.Route.ArrivalAirport.Image);

				_tiles.Add(id, new PictureBox()
				{
					Image = image,
					//BackColor = Color.Black,
					Size = new Size(170, 140),
					Location = new Point(3, 144 * _tiles.Count + 7),
					Anchor = AnchorStyles.None
				});

				carouselCard.Controls.Add(_tiles[id]);

				if (_tiles.Count == 1)
				{
					_topTileId = id;
				}
			}

			foreach (var tile in _tiles)
			{
				tile.Value.Click += (o, args) =>
				{
					for (int i = 0; i < flightsDataGridView.RowCount - 1; i++)
					{
						foreach (var t in _tiles)
						{
							//if (Convert.ToInt32(flightsDataGridView.Rows[i].Cells[0].Value) != t.Key) continue;

							flightsDataGridView.Rows[i].Selected = true;
							break;
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
				if (tile.Value.Location.Y >= -147)
				{
					tile.Value.Location = new Point(tile.Value.Location.X, tile.Value.Location.Y - 1);
				}
				else
				{
					tile.Value.Location = new Point(tile.Value.Location.X, _tiles[_topTileId].Location.Y + (tile.Value.Size.Height + 7));
					_topTileId = tile.Key;
				}
			}
		}
	}
}
