using System.Windows.Forms;

namespace AirTicketOffice
{
	partial class AdminMainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainWindow));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.amountOfEmptySeatsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
			this.mainTabPage = new System.Windows.Forms.TabPage();
			this.mainTabPageTabControl = new MaterialSkin.Controls.MaterialTabControl();
			this.usersTabPage = new System.Windows.Forms.TabPage();
			this.usersDataGridView = new System.Windows.Forms.DataGridView();
			this.usersNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usersLoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usersSurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usersNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usersPatronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usersPassportColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usersPhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usersAdminRightsColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ticketsTabPage = new System.Windows.Forms.TabPage();
			this.ticketsDataGridView = new System.Windows.Forms.DataGridView();
			this.ticketsNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketsPassengerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketsTicketPriceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketPricesTabPage = new System.Windows.Forms.TabPage();
			this.ticketPricesDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketPricesClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketPricesFlightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketPricesPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.routesTabPage = new System.Windows.Forms.TabPage();
			this.routesDataGridView = new System.Windows.Forms.DataGridView();
			this.routesNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.routesFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.routesToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsTabPage = new System.Windows.Forms.TabPage();
			this.flightsDataGridView = new System.Windows.Forms.DataGridView();
			this.flightsNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsPlaneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsRouteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsDateFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsDateToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planesTabPage = new System.Windows.Forms.TabPage();
			this.planesDataGridView = new System.Windows.Forms.DataGridView();
			this.planesNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planesNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planesTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planesStClassSeatsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planesNdClassSeatsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planesRdClassSeatsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.crewTabPage = new System.Windows.Forms.TabPage();
			this.crewMembersDataGridView = new System.Windows.Forms.DataGridView();
			this.crewMembersNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.crewMembersPlaneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.crewMembersInitialsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.crewMembersPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airportsTabPage = new System.Windows.Forms.TabPage();
			this.airportsDataGridView = new System.Windows.Forms.DataGridView();
			this.airportsNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airportsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airportsCityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airportsImageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.saveSingleToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveAllToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
			this.profileTabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.accountGenderComboBox = new MaterialSkin.Controls.MaterialComboBox();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.accountPatronymicTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			this.accountNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.accountSurnameTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.changePasswordButton = new MaterialSkin.Controls.MaterialButton();
			this.accountLoginTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.accountPhoneTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			this.accountPassportTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.exitFromAccountButton = new MaterialSkin.Controls.MaterialButton();
			this.saveAccountChangesButton = new MaterialSkin.Controls.MaterialButton();
			this.searchTabPage = new System.Windows.Forms.TabPage();
			this.searchTabControl = new MaterialSkin.Controls.MaterialTabControl();
			this.searchPassengersTabPage = new System.Windows.Forms.TabPage();
			this.passengersDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.vacantSeatsTabPage = new System.Windows.Forms.TabPage();
			this.vacantSeatsDataGridView = new System.Windows.Forms.DataGridView();
			this.searchEmptySeatsPlaneNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.searchEmptySeatsFlightNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.searchEmptySeatsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.searchTypeComboBox = new MaterialSkin.Controls.MaterialComboBox();
			this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
			this.searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
			this.filterTabPage = new System.Windows.Forms.TabPage();
			this.filterTabControl = new MaterialSkin.Controls.MaterialTabControl();
			this.ticketFilterTabPage = new System.Windows.Forms.TabPage();
			this.ticketFilterDataGridView = new System.Windows.Forms.DataGridView();
			this.ticketFilterPassengerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketFilterFlightNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketFilterDepartureAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketFilterDepartureDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketFilterArrivalAirportColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketFilterArrivalDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketFilterClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightFilterTabPage = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.filterTypeComboBox = new MaterialSkin.Controls.MaterialComboBox();
			this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
			this.filterTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
			this.printTabPage = new System.Windows.Forms.TabPage();
			this.actionIconsImageList = new System.Windows.Forms.ImageList(this.components);
			this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
			this.printTicketButton = new MaterialSkin.Controls.MaterialButton();
			this.printTicketDataGridView = new System.Windows.Forms.DataGridView();
			this.ticketPrintNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
			this.statusStrip1.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			this.mainTabPage.SuspendLayout();
			this.mainTabPageTabControl.SuspendLayout();
			this.usersTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
			this.ticketsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).BeginInit();
			this.ticketPricesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ticketPricesDataGridView)).BeginInit();
			this.routesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).BeginInit();
			this.flightsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
			this.planesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.planesDataGridView)).BeginInit();
			this.crewTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.crewMembersDataGridView)).BeginInit();
			this.airportsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.airportsDataGridView)).BeginInit();
			this.toolStrip2.SuspendLayout();
			this.profileTabPage.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.searchTabPage.SuspendLayout();
			this.searchTabControl.SuspendLayout();
			this.searchPassengersTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.passengersDataGridView)).BeginInit();
			this.vacantSeatsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vacantSeatsDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.filterTabPage.SuspendLayout();
			this.filterTabControl.SuspendLayout();
			this.ticketFilterTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ticketFilterDataGridView)).BeginInit();
			this.panel2.SuspendLayout();
			this.printTabPage.SuspendLayout();
			this.materialCard1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.printTicketDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// mainTabControlImageList
			// 
			this.mainTabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainTabControlImageList.ImageStream")));
			this.mainTabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.mainTabControlImageList.Images.SetKeyName(0, "home_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(1, "user_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(2, "search_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(3, "filter_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(4, "print_icon.png");
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.amountOfEmptySeatsStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 578);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1066, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// StatusLabel
			// 
			this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(144, 17);
			this.StatusLabel.Text = "Число записей в таблице:";
			// 
			// amountOfEmptySeatsStatusLabel
			// 
			this.amountOfEmptySeatsStatusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.amountOfEmptySeatsStatusLabel.Name = "amountOfEmptySeatsStatusLabel";
			this.amountOfEmptySeatsStatusLabel.Size = new System.Drawing.Size(47, 17);
			this.amountOfEmptySeatsStatusLabel.Text = "amount";
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.mainTabPage);
			this.mainTabControl.Controls.Add(this.profileTabPage);
			this.mainTabControl.Controls.Add(this.searchTabPage);
			this.mainTabControl.Controls.Add(this.filterTabPage);
			this.mainTabControl.Controls.Add(this.printTabPage);
			this.mainTabControl.Depth = 0;
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.ImageList = this.mainTabControlImageList;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
			this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
			this.mainTabControl.Multiline = true;
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.Padding = new System.Drawing.Point(0, 0);
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(1066, 578);
			this.mainTabControl.TabIndex = 5;
			this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
			// 
			// mainTabPage
			// 
			this.mainTabPage.BackColor = System.Drawing.Color.White;
			this.mainTabPage.Controls.Add(this.mainTabPageTabControl);
			this.mainTabPage.Controls.Add(this.toolStrip2);
			this.mainTabPage.Controls.Add(this.materialTabSelector1);
			this.mainTabPage.ImageKey = "home_icon.png";
			this.mainTabPage.Location = new System.Drawing.Point(4, 39);
			this.mainTabPage.Margin = new System.Windows.Forms.Padding(0);
			this.mainTabPage.Name = "mainTabPage";
			this.mainTabPage.Size = new System.Drawing.Size(1058, 535);
			this.mainTabPage.TabIndex = 0;
			this.mainTabPage.Text = "Главная";
			// 
			// mainTabPageTabControl
			// 
			this.mainTabPageTabControl.Controls.Add(this.usersTabPage);
			this.mainTabPageTabControl.Controls.Add(this.ticketsTabPage);
			this.mainTabPageTabControl.Controls.Add(this.ticketPricesTabPage);
			this.mainTabPageTabControl.Controls.Add(this.routesTabPage);
			this.mainTabPageTabControl.Controls.Add(this.flightsTabPage);
			this.mainTabPageTabControl.Controls.Add(this.planesTabPage);
			this.mainTabPageTabControl.Controls.Add(this.crewTabPage);
			this.mainTabPageTabControl.Controls.Add(this.airportsTabPage);
			this.mainTabPageTabControl.Depth = 0;
			this.mainTabPageTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabPageTabControl.Location = new System.Drawing.Point(0, 84);
			this.mainTabPageTabControl.Margin = new System.Windows.Forms.Padding(0);
			this.mainTabPageTabControl.MouseState = MaterialSkin.MouseState.HOVER;
			this.mainTabPageTabControl.Multiline = true;
			this.mainTabPageTabControl.Name = "mainTabPageTabControl";
			this.mainTabPageTabControl.SelectedIndex = 0;
			this.mainTabPageTabControl.Size = new System.Drawing.Size(1058, 451);
			this.mainTabPageTabControl.TabIndex = 12;
			// 
			// usersTabPage
			// 
			this.usersTabPage.Controls.Add(this.usersDataGridView);
			this.usersTabPage.Location = new System.Drawing.Point(4, 22);
			this.usersTabPage.Name = "usersTabPage";
			this.usersTabPage.Size = new System.Drawing.Size(1050, 425);
			this.usersTabPage.TabIndex = 1;
			this.usersTabPage.Text = "Пользователи";
			this.usersTabPage.UseVisualStyleBackColor = true;
			// 
			// usersDataGridView
			// 
			this.usersDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.usersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersNumberColumn,
            this.usersLoginColumn,
            this.usersSurnameColumn,
            this.usersNameColumn,
            this.usersPatronymicColumn,
            this.usersPassportColumn,
            this.usersPhoneColumn,
            this.usersAdminRightsColumn});
			this.usersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.usersDataGridView.Location = new System.Drawing.Point(0, 0);
			this.usersDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.usersDataGridView.MultiSelect = false;
			this.usersDataGridView.Name = "usersDataGridView";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.usersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.usersDataGridView.RowHeadersVisible = false;
			this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.usersDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.usersDataGridView.TabIndex = 1;
			// 
			// usersNumberColumn
			// 
			this.usersNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.usersNumberColumn.FillWeight = 4F;
			this.usersNumberColumn.HeaderText = "№";
			this.usersNumberColumn.Name = "usersNumberColumn";
			this.usersNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// usersLoginColumn
			// 
			this.usersLoginColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.usersLoginColumn.FillWeight = 10F;
			this.usersLoginColumn.HeaderText = "Логин";
			this.usersLoginColumn.Name = "usersLoginColumn";
			this.usersLoginColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// usersSurnameColumn
			// 
			this.usersSurnameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.usersSurnameColumn.FillWeight = 15F;
			this.usersSurnameColumn.HeaderText = "Фамилия";
			this.usersSurnameColumn.Name = "usersSurnameColumn";
			this.usersSurnameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// usersNameColumn
			// 
			this.usersNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.usersNameColumn.FillWeight = 14F;
			this.usersNameColumn.HeaderText = "Имя";
			this.usersNameColumn.Name = "usersNameColumn";
			this.usersNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// usersPatronymicColumn
			// 
			this.usersPatronymicColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.usersPatronymicColumn.FillWeight = 14F;
			this.usersPatronymicColumn.HeaderText = "Отчество";
			this.usersPatronymicColumn.Name = "usersPatronymicColumn";
			this.usersPatronymicColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// usersPassportColumn
			// 
			this.usersPassportColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.usersPassportColumn.FillWeight = 15F;
			this.usersPassportColumn.HeaderText = "Номер паспорта";
			this.usersPassportColumn.Name = "usersPassportColumn";
			this.usersPassportColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// usersPhoneColumn
			// 
			this.usersPhoneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.usersPhoneColumn.FillWeight = 15F;
			this.usersPhoneColumn.HeaderText = "Номер телефона";
			this.usersPhoneColumn.Name = "usersPhoneColumn";
			this.usersPhoneColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// usersAdminRightsColumn
			// 
			this.usersAdminRightsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.usersAdminRightsColumn.FillWeight = 10F;
			this.usersAdminRightsColumn.HeaderText = "Права администратора";
			this.usersAdminRightsColumn.Name = "usersAdminRightsColumn";
			this.usersAdminRightsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// ticketsTabPage
			// 
			this.ticketsTabPage.Controls.Add(this.ticketsDataGridView);
			this.ticketsTabPage.Location = new System.Drawing.Point(4, 22);
			this.ticketsTabPage.Name = "ticketsTabPage";
			this.ticketsTabPage.Size = new System.Drawing.Size(1050, 425);
			this.ticketsTabPage.TabIndex = 3;
			this.ticketsTabPage.Text = "Билеты";
			this.ticketsTabPage.UseVisualStyleBackColor = true;
			// 
			// ticketsDataGridView
			// 
			this.ticketsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.ticketsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ticketsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ticketsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketsNumberColumn,
            this.ticketsPassengerColumn,
            this.ticketsTicketPriceId});
			this.ticketsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ticketsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.ticketsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.ticketsDataGridView.MultiSelect = false;
			this.ticketsDataGridView.Name = "ticketsDataGridView";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ticketsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.ticketsDataGridView.RowHeadersVisible = false;
			this.ticketsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.ticketsDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.ticketsDataGridView.TabIndex = 1;
			// 
			// ticketsNumberColumn
			// 
			this.ticketsNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketsNumberColumn.FillWeight = 4F;
			this.ticketsNumberColumn.HeaderText = "№";
			this.ticketsNumberColumn.Name = "ticketsNumberColumn";
			this.ticketsNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// ticketsPassengerColumn
			// 
			this.ticketsPassengerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketsPassengerColumn.FillWeight = 40F;
			this.ticketsPassengerColumn.HeaderText = "Пассажир";
			this.ticketsPassengerColumn.Name = "ticketsPassengerColumn";
			// 
			// ticketsTicketPriceId
			// 
			this.ticketsTicketPriceId.HeaderText = "Цена";
			this.ticketsTicketPriceId.Name = "ticketsTicketPriceId";
			// 
			// ticketPricesTabPage
			// 
			this.ticketPricesTabPage.Controls.Add(this.ticketPricesDataGridView);
			this.ticketPricesTabPage.Location = new System.Drawing.Point(4, 22);
			this.ticketPricesTabPage.Name = "ticketPricesTabPage";
			this.ticketPricesTabPage.Size = new System.Drawing.Size(1050, 425);
			this.ticketPricesTabPage.TabIndex = 9;
			this.ticketPricesTabPage.Text = "Цены на билеты";
			this.ticketPricesTabPage.UseVisualStyleBackColor = true;
			// 
			// ticketPricesDataGridView
			// 
			this.ticketPricesDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.ticketPricesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ticketPricesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.ticketPricesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ticketPricesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.ticketPricesClassColumn,
            this.ticketPricesFlightColumn,
            this.ticketPricesPriceColumn});
			this.ticketPricesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ticketPricesDataGridView.Location = new System.Drawing.Point(0, 0);
			this.ticketPricesDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.ticketPricesDataGridView.MultiSelect = false;
			this.ticketPricesDataGridView.Name = "ticketPricesDataGridView";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ticketPricesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.ticketPricesDataGridView.RowHeadersVisible = false;
			this.ticketPricesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.ticketPricesDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.ticketPricesDataGridView.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn8.FillWeight = 4F;
			this.dataGridViewTextBoxColumn8.HeaderText = "№";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// ticketPricesClassColumn
			// 
			this.ticketPricesClassColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketPricesClassColumn.FillWeight = 20F;
			this.ticketPricesClassColumn.HeaderText = "Класс";
			this.ticketPricesClassColumn.Name = "ticketPricesClassColumn";
			// 
			// ticketPricesFlightColumn
			// 
			this.ticketPricesFlightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketPricesFlightColumn.FillWeight = 20F;
			this.ticketPricesFlightColumn.HeaderText = "Рейс";
			this.ticketPricesFlightColumn.Name = "ticketPricesFlightColumn";
			// 
			// ticketPricesPriceColumn
			// 
			this.ticketPricesPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketPricesPriceColumn.FillWeight = 20F;
			this.ticketPricesPriceColumn.HeaderText = "Цена";
			this.ticketPricesPriceColumn.Name = "ticketPricesPriceColumn";
			// 
			// routesTabPage
			// 
			this.routesTabPage.Controls.Add(this.routesDataGridView);
			this.routesTabPage.Location = new System.Drawing.Point(4, 22);
			this.routesTabPage.Name = "routesTabPage";
			this.routesTabPage.Size = new System.Drawing.Size(1050, 425);
			this.routesTabPage.TabIndex = 4;
			this.routesTabPage.Text = "Маршруты";
			this.routesTabPage.UseVisualStyleBackColor = true;
			// 
			// routesDataGridView
			// 
			this.routesDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.routesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.routesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.routesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.routesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routesNumberColumn,
            this.routesFromColumn,
            this.routesToColumn});
			this.routesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.routesDataGridView.Location = new System.Drawing.Point(0, 0);
			this.routesDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.routesDataGridView.MultiSelect = false;
			this.routesDataGridView.Name = "routesDataGridView";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.routesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.routesDataGridView.RowHeadersVisible = false;
			this.routesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.routesDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.routesDataGridView.TabIndex = 1;
			// 
			// routesNumberColumn
			// 
			this.routesNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.routesNumberColumn.FillWeight = 4F;
			this.routesNumberColumn.HeaderText = "№";
			this.routesNumberColumn.Name = "routesNumberColumn";
			this.routesNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// routesFromColumn
			// 
			this.routesFromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.routesFromColumn.FillWeight = 40F;
			this.routesFromColumn.HeaderText = "Пункт отправления";
			this.routesFromColumn.Name = "routesFromColumn";
			// 
			// routesToColumn
			// 
			this.routesToColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.routesToColumn.FillWeight = 40F;
			this.routesToColumn.HeaderText = "Пункт прибытия";
			this.routesToColumn.Name = "routesToColumn";
			// 
			// flightsTabPage
			// 
			this.flightsTabPage.Controls.Add(this.flightsDataGridView);
			this.flightsTabPage.Location = new System.Drawing.Point(4, 22);
			this.flightsTabPage.Name = "flightsTabPage";
			this.flightsTabPage.Size = new System.Drawing.Size(1050, 425);
			this.flightsTabPage.TabIndex = 5;
			this.flightsTabPage.Text = "Рейсы";
			this.flightsTabPage.UseVisualStyleBackColor = true;
			// 
			// flightsDataGridView
			// 
			this.flightsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.flightsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.flightsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.flightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightsNumberColumn,
            this.flightsPlaneColumn,
            this.flightsRouteColumn,
            this.flightsDateFromColumn,
            this.flightsDateToColumn});
			this.flightsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flightsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.flightsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.flightsDataGridView.MultiSelect = false;
			this.flightsDataGridView.Name = "flightsDataGridView";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.flightsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.flightsDataGridView.RowHeadersVisible = false;
			this.flightsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.flightsDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.flightsDataGridView.TabIndex = 1;
			// 
			// flightsNumberColumn
			// 
			this.flightsNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsNumberColumn.FillWeight = 4F;
			this.flightsNumberColumn.HeaderText = "№";
			this.flightsNumberColumn.Name = "flightsNumberColumn";
			this.flightsNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// flightsPlaneColumn
			// 
			this.flightsPlaneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsPlaneColumn.FillWeight = 40F;
			this.flightsPlaneColumn.HeaderText = "Самолет";
			this.flightsPlaneColumn.Name = "flightsPlaneColumn";
			// 
			// flightsRouteColumn
			// 
			this.flightsRouteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsRouteColumn.FillWeight = 40F;
			this.flightsRouteColumn.HeaderText = "Маршрут";
			this.flightsRouteColumn.Name = "flightsRouteColumn";
			// 
			// flightsDateFromColumn
			// 
			this.flightsDateFromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsDateFromColumn.FillWeight = 20F;
			this.flightsDateFromColumn.HeaderText = "Дата и время отлета";
			this.flightsDateFromColumn.Name = "flightsDateFromColumn";
			// 
			// flightsDateToColumn
			// 
			this.flightsDateToColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsDateToColumn.FillWeight = 20F;
			this.flightsDateToColumn.HeaderText = "Дата и время прилета";
			this.flightsDateToColumn.Name = "flightsDateToColumn";
			// 
			// planesTabPage
			// 
			this.planesTabPage.Controls.Add(this.planesDataGridView);
			this.planesTabPage.Location = new System.Drawing.Point(4, 22);
			this.planesTabPage.Name = "planesTabPage";
			this.planesTabPage.Size = new System.Drawing.Size(1050, 425);
			this.planesTabPage.TabIndex = 6;
			this.planesTabPage.Text = "Самолеты";
			this.planesTabPage.UseVisualStyleBackColor = true;
			// 
			// planesDataGridView
			// 
			this.planesDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.planesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.planesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.planesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.planesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planesNumberColumn,
            this.planesNumColumn,
            this.planesTypeColumn,
            this.planesStClassSeatsColumn,
            this.planesNdClassSeatsColumn,
            this.planesRdClassSeatsColumn});
			this.planesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.planesDataGridView.Location = new System.Drawing.Point(0, 0);
			this.planesDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.planesDataGridView.MultiSelect = false;
			this.planesDataGridView.Name = "planesDataGridView";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.planesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.planesDataGridView.RowHeadersVisible = false;
			this.planesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.planesDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.planesDataGridView.TabIndex = 1;
			// 
			// planesNumberColumn
			// 
			this.planesNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.planesNumberColumn.FillWeight = 4F;
			this.planesNumberColumn.HeaderText = "№";
			this.planesNumberColumn.Name = "planesNumberColumn";
			this.planesNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// planesNumColumn
			// 
			this.planesNumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.planesNumColumn.FillWeight = 40F;
			this.planesNumColumn.HeaderText = "Номер";
			this.planesNumColumn.Name = "planesNumColumn";
			// 
			// planesTypeColumn
			// 
			this.planesTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.planesTypeColumn.FillWeight = 40F;
			this.planesTypeColumn.HeaderText = "Тип";
			this.planesTypeColumn.Name = "planesTypeColumn";
			// 
			// planesStClassSeatsColumn
			// 
			this.planesStClassSeatsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.planesStClassSeatsColumn.FillWeight = 20F;
			this.planesStClassSeatsColumn.HeaderText = "Кол-во мест 1 класс";
			this.planesStClassSeatsColumn.Name = "planesStClassSeatsColumn";
			// 
			// planesNdClassSeatsColumn
			// 
			this.planesNdClassSeatsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.planesNdClassSeatsColumn.FillWeight = 20F;
			this.planesNdClassSeatsColumn.HeaderText = "Кол-во мест 2 класс";
			this.planesNdClassSeatsColumn.Name = "planesNdClassSeatsColumn";
			// 
			// planesRdClassSeatsColumn
			// 
			this.planesRdClassSeatsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.planesRdClassSeatsColumn.FillWeight = 20F;
			this.planesRdClassSeatsColumn.HeaderText = "Кол-во мест 3 класс";
			this.planesRdClassSeatsColumn.Name = "planesRdClassSeatsColumn";
			// 
			// crewTabPage
			// 
			this.crewTabPage.Controls.Add(this.crewMembersDataGridView);
			this.crewTabPage.Location = new System.Drawing.Point(4, 22);
			this.crewTabPage.Name = "crewTabPage";
			this.crewTabPage.Size = new System.Drawing.Size(1050, 425);
			this.crewTabPage.TabIndex = 7;
			this.crewTabPage.Text = "Экипажи";
			this.crewTabPage.UseVisualStyleBackColor = true;
			// 
			// crewMembersDataGridView
			// 
			this.crewMembersDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.crewMembersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.crewMembersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.crewMembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.crewMembersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crewMembersNumberColumn,
            this.crewMembersPlaneColumn,
            this.crewMembersInitialsColumn,
            this.crewMembersPositionColumn});
			this.crewMembersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crewMembersDataGridView.Location = new System.Drawing.Point(0, 0);
			this.crewMembersDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.crewMembersDataGridView.MultiSelect = false;
			this.crewMembersDataGridView.Name = "crewMembersDataGridView";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.crewMembersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.crewMembersDataGridView.RowHeadersVisible = false;
			this.crewMembersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.crewMembersDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.crewMembersDataGridView.TabIndex = 1;
			// 
			// crewMembersNumberColumn
			// 
			this.crewMembersNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.crewMembersNumberColumn.FillWeight = 4F;
			this.crewMembersNumberColumn.HeaderText = "№";
			this.crewMembersNumberColumn.Name = "crewMembersNumberColumn";
			this.crewMembersNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// crewMembersPlaneColumn
			// 
			this.crewMembersPlaneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.crewMembersPlaneColumn.FillWeight = 20F;
			this.crewMembersPlaneColumn.HeaderText = "Самолет";
			this.crewMembersPlaneColumn.Name = "crewMembersPlaneColumn";
			// 
			// crewMembersInitialsColumn
			// 
			this.crewMembersInitialsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.crewMembersInitialsColumn.FillWeight = 30F;
			this.crewMembersInitialsColumn.HeaderText = "Инициалы";
			this.crewMembersInitialsColumn.Name = "crewMembersInitialsColumn";
			// 
			// crewMembersPositionColumn
			// 
			this.crewMembersPositionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.crewMembersPositionColumn.FillWeight = 15F;
			this.crewMembersPositionColumn.HeaderText = "Позиция";
			this.crewMembersPositionColumn.Name = "crewMembersPositionColumn";
			// 
			// airportsTabPage
			// 
			this.airportsTabPage.Controls.Add(this.airportsDataGridView);
			this.airportsTabPage.Location = new System.Drawing.Point(4, 22);
			this.airportsTabPage.Name = "airportsTabPage";
			this.airportsTabPage.Size = new System.Drawing.Size(1050, 425);
			this.airportsTabPage.TabIndex = 8;
			this.airportsTabPage.Text = "Аэропорты";
			this.airportsTabPage.UseVisualStyleBackColor = true;
			// 
			// airportsDataGridView
			// 
			this.airportsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.airportsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.airportsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
			this.airportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.airportsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airportsNumberColumn,
            this.airportsNameColumn,
            this.airportsCityColumn,
            this.airportsImageColumn});
			this.airportsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.airportsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.airportsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.airportsDataGridView.MultiSelect = false;
			this.airportsDataGridView.Name = "airportsDataGridView";
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.airportsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.airportsDataGridView.RowHeadersVisible = false;
			this.airportsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.airportsDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.airportsDataGridView.TabIndex = 1;
			// 
			// airportsNumberColumn
			// 
			this.airportsNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.airportsNumberColumn.FillWeight = 4F;
			this.airportsNumberColumn.HeaderText = "№";
			this.airportsNumberColumn.Name = "airportsNumberColumn";
			this.airportsNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// airportsNameColumn
			// 
			this.airportsNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.airportsNameColumn.FillWeight = 20F;
			this.airportsNameColumn.HeaderText = "Название";
			this.airportsNameColumn.Name = "airportsNameColumn";
			// 
			// airportsCityColumn
			// 
			this.airportsCityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.airportsCityColumn.FillWeight = 20F;
			this.airportsCityColumn.HeaderText = "Город";
			this.airportsCityColumn.Name = "airportsCityColumn";
			// 
			// airportsImageColumn
			// 
			this.airportsImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.airportsImageColumn.FillWeight = 20F;
			this.airportsImageColumn.HeaderText = "Изображение";
			this.airportsImageColumn.Name = "airportsImageColumn";
			this.airportsImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// toolStrip2
			// 
			this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSingleToolStripButton,
            this.saveAllToolStripButton,
            this.deleteToolStripButton});
			this.toolStrip2.Location = new System.Drawing.Point(0, 30);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
			this.toolStrip2.Size = new System.Drawing.Size(1058, 54);
			this.toolStrip2.TabIndex = 1;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// saveSingleToolStripButton
			// 
			this.saveSingleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveSingleToolStripButton.Image = global::AirTicketOffice.Properties.Resources.save_icon;
			this.saveSingleToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.saveSingleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveSingleToolStripButton.Margin = new System.Windows.Forms.Padding(5, 5, 2, 5);
			this.saveSingleToolStripButton.Name = "saveSingleToolStripButton";
			this.saveSingleToolStripButton.Size = new System.Drawing.Size(44, 44);
			this.saveSingleToolStripButton.Text = "Сохранить выделенную запись";
			this.saveSingleToolStripButton.Click += new System.EventHandler(this.saveSingleToolStripButton_Click);
			// 
			// saveAllToolStripButton
			// 
			this.saveAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveAllToolStripButton.Image = global::AirTicketOffice.Properties.Resources.save_all_icon;
			this.saveAllToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.saveAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveAllToolStripButton.Margin = new System.Windows.Forms.Padding(3, 5, 5, 5);
			this.saveAllToolStripButton.Name = "saveAllToolStripButton";
			this.saveAllToolStripButton.Size = new System.Drawing.Size(44, 44);
			this.saveAllToolStripButton.Text = "Сохранить все записи";
			this.saveAllToolStripButton.Click += new System.EventHandler(this.saveAllToolStripButton_Click);
			// 
			// deleteToolStripButton
			// 
			this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteToolStripButton.Image = global::AirTicketOffice.Properties.Resources.delete_icon;
			this.deleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteToolStripButton.Margin = new System.Windows.Forms.Padding(3, 5, 5, 5);
			this.deleteToolStripButton.Name = "deleteToolStripButton";
			this.deleteToolStripButton.Size = new System.Drawing.Size(44, 44);
			this.deleteToolStripButton.Text = "Удалить выделенную запись";
			this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
			// 
			// materialTabSelector1
			// 
			this.materialTabSelector1.BaseTabControl = this.mainTabPageTabControl;
			this.materialTabSelector1.Depth = 0;
			this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
			this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
			this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabSelector1.Name = "materialTabSelector1";
			this.materialTabSelector1.Size = new System.Drawing.Size(1058, 30);
			this.materialTabSelector1.TabIndex = 0;
			this.materialTabSelector1.TabIndicatorHeight = 5;
			this.materialTabSelector1.TabStop = false;
			// 
			// profileTabPage
			// 
			this.profileTabPage.BackColor = System.Drawing.Color.White;
			this.profileTabPage.Controls.Add(this.tableLayoutPanel1);
			this.profileTabPage.Controls.Add(this.panel3);
			this.profileTabPage.ImageKey = "user_icon.png";
			this.profileTabPage.Location = new System.Drawing.Point(4, 39);
			this.profileTabPage.Name = "profileTabPage";
			this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.profileTabPage.Size = new System.Drawing.Size(1058, 535);
			this.profileTabPage.TabIndex = 1;
			this.profileTabPage.Text = "Мой профиль";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 482F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1052, 482);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.accountGenderComboBox);
			this.panel4.Controls.Add(this.materialLabel2);
			this.panel4.Controls.Add(this.accountPatronymicTextBox);
			this.panel4.Controls.Add(this.materialLabel5);
			this.panel4.Controls.Add(this.accountNameTextBox);
			this.panel4.Controls.Add(this.materialLabel4);
			this.panel4.Controls.Add(this.accountSurnameTextBox);
			this.panel4.Controls.Add(this.materialLabel3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(520, 476);
			this.panel4.TabIndex = 2;
			// 
			// accountGenderComboBox
			// 
			this.accountGenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountGenderComboBox.AutoResize = false;
			this.accountGenderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.accountGenderComboBox.Depth = 0;
			this.accountGenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.accountGenderComboBox.DropDownHeight = 118;
			this.accountGenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.accountGenderComboBox.DropDownWidth = 121;
			this.accountGenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.accountGenderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.accountGenderComboBox.FormattingEnabled = true;
			this.accountGenderComboBox.IntegralHeight = false;
			this.accountGenderComboBox.ItemHeight = 29;
			this.accountGenderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.accountGenderComboBox.Location = new System.Drawing.Point(17, 260);
			this.accountGenderComboBox.MaxDropDownItems = 4;
			this.accountGenderComboBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountGenderComboBox.Name = "accountGenderComboBox";
			this.accountGenderComboBox.Size = new System.Drawing.Size(496, 35);
			this.accountGenderComboBox.StartIndex = 0;
			this.accountGenderComboBox.TabIndex = 24;
			this.accountGenderComboBox.UseTallSize = false;
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel2.Location = new System.Drawing.Point(7, 238);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(30, 19);
			this.materialLabel2.TabIndex = 23;
			this.materialLabel2.Text = "Пол";
			// 
			// accountPatronymicTextBox
			// 
			this.accountPatronymicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountPatronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountPatronymicTextBox.Depth = 0;
			this.accountPatronymicTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountPatronymicTextBox.LeadingIcon = null;
			this.accountPatronymicTextBox.Location = new System.Drawing.Point(17, 184);
			this.accountPatronymicTextBox.MaxLength = 50;
			this.accountPatronymicTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountPatronymicTextBox.Multiline = false;
			this.accountPatronymicTextBox.Name = "accountPatronymicTextBox";
			this.accountPatronymicTextBox.Size = new System.Drawing.Size(496, 36);
			this.accountPatronymicTextBox.TabIndex = 22;
			this.accountPatronymicTextBox.Text = "";
			this.accountPatronymicTextBox.TrailingIcon = null;
			this.accountPatronymicTextBox.UseTallSize = false;
			// 
			// materialLabel5
			// 
			this.materialLabel5.AutoSize = true;
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel5.Location = new System.Drawing.Point(7, 162);
			this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new System.Drawing.Size(71, 19);
			this.materialLabel5.TabIndex = 21;
			this.materialLabel5.Text = "Отчество";
			// 
			// accountNameTextBox
			// 
			this.accountNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountNameTextBox.Depth = 0;
			this.accountNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountNameTextBox.LeadingIcon = null;
			this.accountNameTextBox.Location = new System.Drawing.Point(17, 108);
			this.accountNameTextBox.MaxLength = 50;
			this.accountNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountNameTextBox.Multiline = false;
			this.accountNameTextBox.Name = "accountNameTextBox";
			this.accountNameTextBox.Size = new System.Drawing.Size(496, 36);
			this.accountNameTextBox.TabIndex = 20;
			this.accountNameTextBox.Text = "";
			this.accountNameTextBox.TrailingIcon = null;
			this.accountNameTextBox.UseTallSize = false;
			// 
			// materialLabel4
			// 
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel4.Location = new System.Drawing.Point(7, 86);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(33, 19);
			this.materialLabel4.TabIndex = 19;
			this.materialLabel4.Text = "Имя";
			// 
			// accountSurnameTextBox
			// 
			this.accountSurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountSurnameTextBox.Depth = 0;
			this.accountSurnameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountSurnameTextBox.LeadingIcon = null;
			this.accountSurnameTextBox.Location = new System.Drawing.Point(17, 32);
			this.accountSurnameTextBox.MaxLength = 50;
			this.accountSurnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountSurnameTextBox.Multiline = false;
			this.accountSurnameTextBox.Name = "accountSurnameTextBox";
			this.accountSurnameTextBox.Size = new System.Drawing.Size(496, 36);
			this.accountSurnameTextBox.TabIndex = 18;
			this.accountSurnameTextBox.Text = "";
			this.accountSurnameTextBox.TrailingIcon = null;
			this.accountSurnameTextBox.UseTallSize = false;
			// 
			// materialLabel3
			// 
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel3.Location = new System.Drawing.Point(7, 10);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(70, 19);
			this.materialLabel3.TabIndex = 17;
			this.materialLabel3.Text = "Фамилия";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.changePasswordButton);
			this.panel5.Controls.Add(this.accountLoginTextBox);
			this.panel5.Controls.Add(this.materialLabel1);
			this.panel5.Controls.Add(this.accountPhoneTextBox);
			this.panel5.Controls.Add(this.materialLabel7);
			this.panel5.Controls.Add(this.materialLabel6);
			this.panel5.Controls.Add(this.accountPassportTextBox);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(529, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(520, 476);
			this.panel5.TabIndex = 3;
			// 
			// changePasswordButton
			// 
			this.changePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.changePasswordButton.AutoSize = false;
			this.changePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.changePasswordButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.changePasswordButton.Depth = 0;
			this.changePasswordButton.HighEmphasis = true;
			this.changePasswordButton.Icon = null;
			this.changePasswordButton.Location = new System.Drawing.Point(21, 259);
			this.changePasswordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.changePasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.changePasswordButton.Name = "changePasswordButton";
			this.changePasswordButton.Size = new System.Drawing.Size(495, 36);
			this.changePasswordButton.TabIndex = 29;
			this.changePasswordButton.Text = "Сменить пароль";
			this.changePasswordButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.changePasswordButton.UseAccentColor = false;
			this.changePasswordButton.UseVisualStyleBackColor = true;
			// 
			// accountLoginTextBox
			// 
			this.accountLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountLoginTextBox.Depth = 0;
			this.accountLoginTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountLoginTextBox.LeadingIcon = null;
			this.accountLoginTextBox.Location = new System.Drawing.Point(21, 32);
			this.accountLoginTextBox.MaxLength = 50;
			this.accountLoginTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountLoginTextBox.Multiline = false;
			this.accountLoginTextBox.Name = "accountLoginTextBox";
			this.accountLoginTextBox.Size = new System.Drawing.Size(495, 36);
			this.accountLoginTextBox.TabIndex = 28;
			this.accountLoginTextBox.Text = "";
			this.accountLoginTextBox.TrailingIcon = null;
			this.accountLoginTextBox.UseTallSize = false;
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.Location = new System.Drawing.Point(11, 10);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(46, 19);
			this.materialLabel1.TabIndex = 27;
			this.materialLabel1.Text = "Логин";
			// 
			// accountPhoneTextBox
			// 
			this.accountPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountPhoneTextBox.Depth = 0;
			this.accountPhoneTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountPhoneTextBox.LeadingIcon = null;
			this.accountPhoneTextBox.Location = new System.Drawing.Point(21, 184);
			this.accountPhoneTextBox.MaxLength = 50;
			this.accountPhoneTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountPhoneTextBox.Multiline = false;
			this.accountPhoneTextBox.Name = "accountPhoneTextBox";
			this.accountPhoneTextBox.Size = new System.Drawing.Size(495, 36);
			this.accountPhoneTextBox.TabIndex = 26;
			this.accountPhoneTextBox.Text = "";
			this.accountPhoneTextBox.TrailingIcon = null;
			this.accountPhoneTextBox.UseTallSize = false;
			// 
			// materialLabel7
			// 
			this.materialLabel7.AutoSize = true;
			this.materialLabel7.Depth = 0;
			this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel7.Location = new System.Drawing.Point(11, 162);
			this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel7.Name = "materialLabel7";
			this.materialLabel7.Size = new System.Drawing.Size(126, 19);
			this.materialLabel7.TabIndex = 25;
			this.materialLabel7.Text = "Номер телефона";
			// 
			// materialLabel6
			// 
			this.materialLabel6.AutoSize = true;
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel6.Location = new System.Drawing.Point(13, 86);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(124, 19);
			this.materialLabel6.TabIndex = 23;
			this.materialLabel6.Text = "Номер паспорта";
			// 
			// accountPassportTextBox
			// 
			this.accountPassportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountPassportTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountPassportTextBox.Depth = 0;
			this.accountPassportTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountPassportTextBox.LeadingIcon = null;
			this.accountPassportTextBox.Location = new System.Drawing.Point(21, 108);
			this.accountPassportTextBox.MaxLength = 50;
			this.accountPassportTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountPassportTextBox.Multiline = false;
			this.accountPassportTextBox.Name = "accountPassportTextBox";
			this.accountPassportTextBox.Size = new System.Drawing.Size(495, 36);
			this.accountPassportTextBox.TabIndex = 24;
			this.accountPassportTextBox.Text = "";
			this.accountPassportTextBox.TrailingIcon = null;
			this.accountPassportTextBox.UseTallSize = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.exitFromAccountButton);
			this.panel3.Controls.Add(this.saveAccountChangesButton);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(3, 485);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1052, 47);
			this.panel3.TabIndex = 0;
			// 
			// exitFromAccountButton
			// 
			this.exitFromAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.exitFromAccountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.exitFromAccountButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.exitFromAccountButton.Depth = 0;
			this.exitFromAccountButton.HighEmphasis = true;
			this.exitFromAccountButton.Icon = null;
			this.exitFromAccountButton.Location = new System.Drawing.Point(6, 5);
			this.exitFromAccountButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.exitFromAccountButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.exitFromAccountButton.Name = "exitFromAccountButton";
			this.exitFromAccountButton.Size = new System.Drawing.Size(177, 36);
			this.exitFromAccountButton.TabIndex = 5;
			this.exitFromAccountButton.Text = "Выйти из аккаунта";
			this.exitFromAccountButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
			this.exitFromAccountButton.UseAccentColor = false;
			this.exitFromAccountButton.UseVisualStyleBackColor = true;
			// 
			// saveAccountChangesButton
			// 
			this.saveAccountChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveAccountChangesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.saveAccountChangesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.saveAccountChangesButton.Depth = 0;
			this.saveAccountChangesButton.HighEmphasis = true;
			this.saveAccountChangesButton.Icon = null;
			this.saveAccountChangesButton.Location = new System.Drawing.Point(843, 5);
			this.saveAccountChangesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.saveAccountChangesButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.saveAccountChangesButton.Name = "saveAccountChangesButton";
			this.saveAccountChangesButton.Size = new System.Drawing.Size(203, 36);
			this.saveAccountChangesButton.TabIndex = 3;
			this.saveAccountChangesButton.Text = "Сохранить изменения";
			this.saveAccountChangesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.saveAccountChangesButton.UseAccentColor = false;
			this.saveAccountChangesButton.UseVisualStyleBackColor = true;
			// 
			// searchTabPage
			// 
			this.searchTabPage.BackColor = System.Drawing.Color.White;
			this.searchTabPage.Controls.Add(this.searchTabControl);
			this.searchTabPage.Controls.Add(this.panel1);
			this.searchTabPage.Controls.Add(this.materialTabSelector2);
			this.searchTabPage.ImageKey = "search_icon.png";
			this.searchTabPage.Location = new System.Drawing.Point(4, 39);
			this.searchTabPage.Name = "searchTabPage";
			this.searchTabPage.Size = new System.Drawing.Size(1058, 535);
			this.searchTabPage.TabIndex = 2;
			this.searchTabPage.Text = "Поиск";
			// 
			// searchTabControl
			// 
			this.searchTabControl.Controls.Add(this.searchPassengersTabPage);
			this.searchTabControl.Controls.Add(this.vacantSeatsTabPage);
			this.searchTabControl.Depth = 0;
			this.searchTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchTabControl.Location = new System.Drawing.Point(0, 84);
			this.searchTabControl.Margin = new System.Windows.Forms.Padding(0);
			this.searchTabControl.MouseState = MaterialSkin.MouseState.HOVER;
			this.searchTabControl.Multiline = true;
			this.searchTabControl.Name = "searchTabControl";
			this.searchTabControl.SelectedIndex = 0;
			this.searchTabControl.Size = new System.Drawing.Size(1058, 451);
			this.searchTabControl.TabIndex = 4;
			// 
			// searchPassengersTabPage
			// 
			this.searchPassengersTabPage.BackColor = System.Drawing.Color.White;
			this.searchPassengersTabPage.Controls.Add(this.passengersDataGridView);
			this.searchPassengersTabPage.Location = new System.Drawing.Point(4, 22);
			this.searchPassengersTabPage.Margin = new System.Windows.Forms.Padding(0);
			this.searchPassengersTabPage.Name = "searchPassengersTabPage";
			this.searchPassengersTabPage.Size = new System.Drawing.Size(1050, 425);
			this.searchPassengersTabPage.TabIndex = 0;
			this.searchPassengersTabPage.Text = "Пассажиры";
			// 
			// passengersDataGridView
			// 
			this.passengersDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.passengersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.passengersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.passengersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.passengersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
			this.passengersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.passengersDataGridView.Location = new System.Drawing.Point(0, 0);
			this.passengersDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.passengersDataGridView.Name = "passengersDataGridView";
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.passengersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
			this.passengersDataGridView.RowHeadersVisible = false;
			this.passengersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.passengersDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.passengersDataGridView.TabIndex = 5;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.FillWeight = 4F;
			this.dataGridViewTextBoxColumn1.HeaderText = "№";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.FillWeight = 10F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.FillWeight = 15F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.FillWeight = 14F;
			this.dataGridViewTextBoxColumn4.HeaderText = "Имя";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.FillWeight = 14F;
			this.dataGridViewTextBoxColumn5.HeaderText = "Отчество";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.FillWeight = 15F;
			this.dataGridViewTextBoxColumn6.HeaderText = "Номер паспорта";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.FillWeight = 15F;
			this.dataGridViewTextBoxColumn7.HeaderText = "Номер телефона";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewCheckBoxColumn1.FillWeight = 10F;
			this.dataGridViewCheckBoxColumn1.HeaderText = "Права администратора";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// vacantSeatsTabPage
			// 
			this.vacantSeatsTabPage.BackColor = System.Drawing.Color.White;
			this.vacantSeatsTabPage.Controls.Add(this.vacantSeatsDataGridView);
			this.vacantSeatsTabPage.Location = new System.Drawing.Point(4, 22);
			this.vacantSeatsTabPage.Margin = new System.Windows.Forms.Padding(0);
			this.vacantSeatsTabPage.Name = "vacantSeatsTabPage";
			this.vacantSeatsTabPage.Size = new System.Drawing.Size(1050, 425);
			this.vacantSeatsTabPage.TabIndex = 1;
			this.vacantSeatsTabPage.Text = "Свободные места";
			// 
			// vacantSeatsDataGridView
			// 
			this.vacantSeatsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.vacantSeatsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.vacantSeatsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.vacantSeatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vacantSeatsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.searchEmptySeatsPlaneNumColumn,
            this.searchEmptySeatsFlightNumColumn,
            this.searchEmptySeatsColumn});
			this.vacantSeatsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vacantSeatsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.vacantSeatsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.vacantSeatsDataGridView.Name = "vacantSeatsDataGridView";
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.vacantSeatsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.vacantSeatsDataGridView.RowHeadersVisible = false;
			this.vacantSeatsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.vacantSeatsDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.vacantSeatsDataGridView.TabIndex = 2;
			// 
			// searchEmptySeatsPlaneNumColumn
			// 
			this.searchEmptySeatsPlaneNumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.searchEmptySeatsPlaneNumColumn.FillWeight = 40F;
			this.searchEmptySeatsPlaneNumColumn.HeaderText = "Самолет";
			this.searchEmptySeatsPlaneNumColumn.Name = "searchEmptySeatsPlaneNumColumn";
			// 
			// searchEmptySeatsFlightNumColumn
			// 
			this.searchEmptySeatsFlightNumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.searchEmptySeatsFlightNumColumn.FillWeight = 40F;
			this.searchEmptySeatsFlightNumColumn.HeaderText = "Рейс";
			this.searchEmptySeatsFlightNumColumn.Name = "searchEmptySeatsFlightNumColumn";
			// 
			// searchEmptySeatsColumn
			// 
			this.searchEmptySeatsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.searchEmptySeatsColumn.FillWeight = 20F;
			this.searchEmptySeatsColumn.HeaderText = "Свободные места";
			this.searchEmptySeatsColumn.Name = "searchEmptySeatsColumn";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.searchTypeComboBox);
			this.panel1.Controls.Add(this.materialLabel8);
			this.panel1.Controls.Add(this.searchTextBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 30);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1058, 54);
			this.panel1.TabIndex = 3;
			// 
			// searchTypeComboBox
			// 
			this.searchTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchTypeComboBox.AutoResize = false;
			this.searchTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.searchTypeComboBox.Depth = 0;
			this.searchTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.searchTypeComboBox.DropDownHeight = 118;
			this.searchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.searchTypeComboBox.DropDownWidth = 121;
			this.searchTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.searchTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.searchTypeComboBox.FormattingEnabled = true;
			this.searchTypeComboBox.IntegralHeight = false;
			this.searchTypeComboBox.ItemHeight = 29;
			this.searchTypeComboBox.Location = new System.Drawing.Point(733, 10);
			this.searchTypeComboBox.MaxDropDownItems = 4;
			this.searchTypeComboBox.MouseState = MaterialSkin.MouseState.OUT;
			this.searchTypeComboBox.Name = "searchTypeComboBox";
			this.searchTypeComboBox.Size = new System.Drawing.Size(317, 35);
			this.searchTypeComboBox.StartIndex = 0;
			this.searchTypeComboBox.TabIndex = 2;
			this.searchTypeComboBox.UseTallSize = false;
			// 
			// materialLabel8
			// 
			this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel8.AutoSize = true;
			this.materialLabel8.Depth = 0;
			this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel8.Location = new System.Drawing.Point(646, 18);
			this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel8.Name = "materialLabel8";
			this.materialLabel8.Size = new System.Drawing.Size(81, 19);
			this.materialLabel8.TabIndex = 1;
			this.materialLabel8.Text = "Искать по:";
			// 
			// searchTextBox
			// 
			this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchTextBox.Depth = 0;
			this.searchTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.searchTextBox.Hint = "Поиск...";
			this.searchTextBox.LeadingIcon = null;
			this.searchTextBox.Location = new System.Drawing.Point(8, 10);
			this.searchTextBox.MaxLength = 50;
			this.searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.searchTextBox.Multiline = false;
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(622, 36);
			this.searchTextBox.TabIndex = 0;
			this.searchTextBox.Text = "";
			this.searchTextBox.TrailingIcon = null;
			this.searchTextBox.UseTallSize = false;
			this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
			// 
			// materialTabSelector2
			// 
			this.materialTabSelector2.BaseTabControl = this.searchTabControl;
			this.materialTabSelector2.Depth = 0;
			this.materialTabSelector2.Dock = System.Windows.Forms.DockStyle.Top;
			this.materialTabSelector2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialTabSelector2.Location = new System.Drawing.Point(0, 0);
			this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabSelector2.Name = "materialTabSelector2";
			this.materialTabSelector2.Size = new System.Drawing.Size(1058, 30);
			this.materialTabSelector2.TabIndex = 2;
			this.materialTabSelector2.TabIndicatorHeight = 5;
			this.materialTabSelector2.TabStop = false;
			// 
			// filterTabPage
			// 
			this.filterTabPage.BackColor = System.Drawing.Color.White;
			this.filterTabPage.Controls.Add(this.filterTabControl);
			this.filterTabPage.Controls.Add(this.panel2);
			this.filterTabPage.Controls.Add(this.materialTabSelector3);
			this.filterTabPage.ImageKey = "filter_icon.png";
			this.filterTabPage.Location = new System.Drawing.Point(4, 39);
			this.filterTabPage.Name = "filterTabPage";
			this.filterTabPage.Size = new System.Drawing.Size(1058, 535);
			this.filterTabPage.TabIndex = 3;
			this.filterTabPage.Text = "Фильтрация";
			// 
			// filterTabControl
			// 
			this.filterTabControl.Controls.Add(this.ticketFilterTabPage);
			this.filterTabControl.Controls.Add(this.flightFilterTabPage);
			this.filterTabControl.Depth = 0;
			this.filterTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filterTabControl.Location = new System.Drawing.Point(0, 84);
			this.filterTabControl.Margin = new System.Windows.Forms.Padding(0);
			this.filterTabControl.MouseState = MaterialSkin.MouseState.HOVER;
			this.filterTabControl.Multiline = true;
			this.filterTabControl.Name = "filterTabControl";
			this.filterTabControl.SelectedIndex = 0;
			this.filterTabControl.Size = new System.Drawing.Size(1058, 451);
			this.filterTabControl.TabIndex = 7;
			// 
			// ticketFilterTabPage
			// 
			this.ticketFilterTabPage.BackColor = System.Drawing.Color.White;
			this.ticketFilterTabPage.Controls.Add(this.ticketFilterDataGridView);
			this.ticketFilterTabPage.Location = new System.Drawing.Point(4, 22);
			this.ticketFilterTabPage.Margin = new System.Windows.Forms.Padding(0);
			this.ticketFilterTabPage.Name = "ticketFilterTabPage";
			this.ticketFilterTabPage.Size = new System.Drawing.Size(1050, 425);
			this.ticketFilterTabPage.TabIndex = 0;
			this.ticketFilterTabPage.Text = "Билеты";
			// 
			// ticketFilterDataGridView
			// 
			this.ticketFilterDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.ticketFilterDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ticketFilterDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
			this.ticketFilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ticketFilterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketFilterPassengerColumn,
            this.ticketFilterFlightNumberColumn,
            this.ticketFilterDepartureAirport,
            this.ticketFilterDepartureDateColumn,
            this.ticketFilterArrivalAirportColumn,
            this.ticketFilterArrivalDateColumn,
            this.ticketFilterClassColumn});
			this.ticketFilterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ticketFilterDataGridView.Location = new System.Drawing.Point(0, 0);
			this.ticketFilterDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.ticketFilterDataGridView.Name = "ticketFilterDataGridView";
			dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ticketFilterDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
			this.ticketFilterDataGridView.RowHeadersVisible = false;
			this.ticketFilterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.ticketFilterDataGridView.Size = new System.Drawing.Size(1050, 425);
			this.ticketFilterDataGridView.TabIndex = 5;
			// 
			// ticketFilterPassengerColumn
			// 
			this.ticketFilterPassengerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketFilterPassengerColumn.FillWeight = 40F;
			this.ticketFilterPassengerColumn.HeaderText = "Пассажир";
			this.ticketFilterPassengerColumn.Name = "ticketFilterPassengerColumn";
			// 
			// ticketFilterFlightNumberColumn
			// 
			this.ticketFilterFlightNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketFilterFlightNumberColumn.FillWeight = 15F;
			this.ticketFilterFlightNumberColumn.HeaderText = "Номер рейса";
			this.ticketFilterFlightNumberColumn.Name = "ticketFilterFlightNumberColumn";
			// 
			// ticketFilterDepartureAirport
			// 
			this.ticketFilterDepartureAirport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketFilterDepartureAirport.FillWeight = 20F;
			this.ticketFilterDepartureAirport.HeaderText = "Аэропорт отправления";
			this.ticketFilterDepartureAirport.Name = "ticketFilterDepartureAirport";
			// 
			// ticketFilterDepartureDateColumn
			// 
			this.ticketFilterDepartureDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketFilterDepartureDateColumn.FillWeight = 20F;
			this.ticketFilterDepartureDateColumn.HeaderText = "Дата отправления";
			this.ticketFilterDepartureDateColumn.Name = "ticketFilterDepartureDateColumn";
			// 
			// ticketFilterArrivalAirportColumn
			// 
			this.ticketFilterArrivalAirportColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketFilterArrivalAirportColumn.FillWeight = 20F;
			this.ticketFilterArrivalAirportColumn.HeaderText = "Аэропорт прибытия";
			this.ticketFilterArrivalAirportColumn.Name = "ticketFilterArrivalAirportColumn";
			// 
			// ticketFilterArrivalDateColumn
			// 
			this.ticketFilterArrivalDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketFilterArrivalDateColumn.FillWeight = 20F;
			this.ticketFilterArrivalDateColumn.HeaderText = "Дата прибытия";
			this.ticketFilterArrivalDateColumn.Name = "ticketFilterArrivalDateColumn";
			// 
			// ticketFilterClassColumn
			// 
			this.ticketFilterClassColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketFilterClassColumn.FillWeight = 10F;
			this.ticketFilterClassColumn.HeaderText = "Класс";
			this.ticketFilterClassColumn.Name = "ticketFilterClassColumn";
			// 
			// flightFilterTabPage
			// 
			this.flightFilterTabPage.BackColor = System.Drawing.Color.White;
			this.flightFilterTabPage.Location = new System.Drawing.Point(4, 22);
			this.flightFilterTabPage.Margin = new System.Windows.Forms.Padding(0);
			this.flightFilterTabPage.Name = "flightFilterTabPage";
			this.flightFilterTabPage.Size = new System.Drawing.Size(1050, 425);
			this.flightFilterTabPage.TabIndex = 1;
			this.flightFilterTabPage.Text = "Рейсы";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.filterTypeComboBox);
			this.panel2.Controls.Add(this.materialLabel9);
			this.panel2.Controls.Add(this.filterTextBox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 30);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1058, 54);
			this.panel2.TabIndex = 6;
			// 
			// filterTypeComboBox
			// 
			this.filterTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.filterTypeComboBox.AutoResize = false;
			this.filterTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.filterTypeComboBox.Depth = 0;
			this.filterTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.filterTypeComboBox.DropDownHeight = 118;
			this.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.filterTypeComboBox.DropDownWidth = 121;
			this.filterTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.filterTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.filterTypeComboBox.FormattingEnabled = true;
			this.filterTypeComboBox.IntegralHeight = false;
			this.filterTypeComboBox.ItemHeight = 29;
			this.filterTypeComboBox.Location = new System.Drawing.Point(733, 10);
			this.filterTypeComboBox.MaxDropDownItems = 4;
			this.filterTypeComboBox.MouseState = MaterialSkin.MouseState.OUT;
			this.filterTypeComboBox.Name = "filterTypeComboBox";
			this.filterTypeComboBox.Size = new System.Drawing.Size(317, 35);
			this.filterTypeComboBox.StartIndex = 0;
			this.filterTypeComboBox.TabIndex = 2;
			this.filterTypeComboBox.UseTallSize = false;
			// 
			// materialLabel9
			// 
			this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel9.AutoSize = true;
			this.materialLabel9.Depth = 0;
			this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel9.Location = new System.Drawing.Point(646, 18);
			this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel9.Name = "materialLabel9";
			this.materialLabel9.Size = new System.Drawing.Size(83, 19);
			this.materialLabel9.TabIndex = 1;
			this.materialLabel9.Text = "Фильтр по:";
			// 
			// filterTextBox
			// 
			this.filterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.filterTextBox.Depth = 0;
			this.filterTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.filterTextBox.Hint = "Фильтр...";
			this.filterTextBox.LeadingIcon = null;
			this.filterTextBox.Location = new System.Drawing.Point(8, 10);
			this.filterTextBox.MaxLength = 50;
			this.filterTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.filterTextBox.Multiline = false;
			this.filterTextBox.Name = "filterTextBox";
			this.filterTextBox.Size = new System.Drawing.Size(622, 36);
			this.filterTextBox.TabIndex = 0;
			this.filterTextBox.Text = "";
			this.filterTextBox.TrailingIcon = null;
			this.filterTextBox.UseTallSize = false;
			this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterTextBox_KeyDown);
			// 
			// materialTabSelector3
			// 
			this.materialTabSelector3.BaseTabControl = this.filterTabControl;
			this.materialTabSelector3.Depth = 0;
			this.materialTabSelector3.Dock = System.Windows.Forms.DockStyle.Top;
			this.materialTabSelector3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialTabSelector3.Location = new System.Drawing.Point(0, 0);
			this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabSelector3.Name = "materialTabSelector3";
			this.materialTabSelector3.Size = new System.Drawing.Size(1058, 30);
			this.materialTabSelector3.TabIndex = 5;
			this.materialTabSelector3.TabIndicatorHeight = 5;
			this.materialTabSelector3.TabStop = false;
			// 
			// printTabPage
			// 
			this.printTabPage.BackColor = System.Drawing.Color.White;
			this.printTabPage.Controls.Add(this.materialCard1);
			this.printTabPage.ImageKey = "print_icon.png";
			this.printTabPage.Location = new System.Drawing.Point(4, 39);
			this.printTabPage.Name = "printTabPage";
			this.printTabPage.Padding = new System.Windows.Forms.Padding(14);
			this.printTabPage.Size = new System.Drawing.Size(1058, 535);
			this.printTabPage.TabIndex = 4;
			this.printTabPage.Text = "Печать";
			// 
			// actionIconsImageList
			// 
			this.actionIconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("actionIconsImageList.ImageStream")));
			this.actionIconsImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.actionIconsImageList.Images.SetKeyName(0, "add_icon.png");
			this.actionIconsImageList.Images.SetKeyName(1, "delete_icon.png");
			this.actionIconsImageList.Images.SetKeyName(2, "save_icon.png");
			// 
			// materialCard1
			// 
			this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard1.Controls.Add(this.printTicketButton);
			this.materialCard1.Controls.Add(this.printTicketDataGridView);
			this.materialCard1.Controls.Add(this.materialLabel10);
			this.materialCard1.Depth = 0;
			this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard1.Location = new System.Drawing.Point(14, 14);
			this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
			this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard1.Name = "materialCard1";
			this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
			this.materialCard1.Size = new System.Drawing.Size(1030, 507);
			this.materialCard1.TabIndex = 2;
			// 
			// printTicketButton
			// 
			this.printTicketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.printTicketButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.printTicketButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.printTicketButton.Depth = 0;
			this.printTicketButton.HighEmphasis = true;
			this.printTicketButton.Icon = null;
			this.printTicketButton.Location = new System.Drawing.Point(839, 456);
			this.printTicketButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.printTicketButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.printTicketButton.Name = "printTicketButton";
			this.printTicketButton.Size = new System.Drawing.Size(177, 36);
			this.printTicketButton.TabIndex = 7;
			this.printTicketButton.Text = "Распечатать билет";
			this.printTicketButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.printTicketButton.UseAccentColor = false;
			this.printTicketButton.UseVisualStyleBackColor = true;
			// 
			// printTicketDataGridView
			// 
			this.printTicketDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.printTicketDataGridView.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.printTicketDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
			this.printTicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.printTicketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketPrintNumberColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
			this.printTicketDataGridView.Location = new System.Drawing.Point(14, 49);
			this.printTicketDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.printTicketDataGridView.MultiSelect = false;
			this.printTicketDataGridView.Name = "printTicketDataGridView";
			dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.printTicketDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
			this.printTicketDataGridView.RowHeadersVisible = false;
			this.printTicketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.printTicketDataGridView.Size = new System.Drawing.Size(1002, 394);
			this.printTicketDataGridView.TabIndex = 6;
			// 
			// ticketPrintNumberColumn
			// 
			this.ticketPrintNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketPrintNumberColumn.FillWeight = 5F;
			this.ticketPrintNumberColumn.HeaderText = "№";
			this.ticketPrintNumberColumn.Name = "ticketPrintNumberColumn";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn9.FillWeight = 40F;
			this.dataGridViewTextBoxColumn9.HeaderText = "Пассажир";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn10.FillWeight = 15F;
			this.dataGridViewTextBoxColumn10.HeaderText = "Номер рейса";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn11.FillWeight = 20F;
			this.dataGridViewTextBoxColumn11.HeaderText = "Аэропорт отправления";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn12.FillWeight = 20F;
			this.dataGridViewTextBoxColumn12.HeaderText = "Дата отправления";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn13.FillWeight = 20F;
			this.dataGridViewTextBoxColumn13.HeaderText = "Аэропорт прибытия";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn14.FillWeight = 20F;
			this.dataGridViewTextBoxColumn14.HeaderText = "Дата прибытия";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			// 
			// dataGridViewTextBoxColumn15
			// 
			this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn15.FillWeight = 10F;
			this.dataGridViewTextBoxColumn15.HeaderText = "Класс";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			// 
			// materialLabel10
			// 
			this.materialLabel10.AutoSize = true;
			this.materialLabel10.Depth = 0;
			this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel10.Location = new System.Drawing.Point(17, 14);
			this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel10.Name = "materialLabel10";
			this.materialLabel10.Size = new System.Drawing.Size(270, 24);
			this.materialLabel10.TabIndex = 0;
			this.materialLabel10.Text = "Выберите билет для печати:";
			// 
			// AdminMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 600);
			this.Controls.Add(this.mainTabControl);
			this.Controls.Add(this.statusStrip1);
			this.DrawerShowIconsWhenHidden = true;
			this.DrawerTabControl = this.mainTabControl;
			this.Name = "AdminMainWindow";
			this.Padding = new System.Windows.Forms.Padding(0);
			this.Text = "Form1";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.mainTabControl.ResumeLayout(false);
			this.mainTabPage.ResumeLayout(false);
			this.mainTabPage.PerformLayout();
			this.mainTabPageTabControl.ResumeLayout(false);
			this.usersTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
			this.ticketsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).EndInit();
			this.ticketPricesTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ticketPricesDataGridView)).EndInit();
			this.routesTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).EndInit();
			this.flightsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
			this.planesTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.planesDataGridView)).EndInit();
			this.crewTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.crewMembersDataGridView)).EndInit();
			this.airportsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.airportsDataGridView)).EndInit();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.profileTabPage.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.searchTabPage.ResumeLayout(false);
			this.searchTabControl.ResumeLayout(false);
			this.searchPassengersTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.passengersDataGridView)).EndInit();
			this.vacantSeatsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vacantSeatsDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.filterTabPage.ResumeLayout(false);
			this.filterTabControl.ResumeLayout(false);
			this.ticketFilterTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ticketFilterDataGridView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.printTabPage.ResumeLayout(false);
			this.materialCard1.ResumeLayout(false);
			this.materialCard1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.printTicketDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ImageList mainTabControlImageList;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private MaterialSkin.Controls.MaterialTabControl mainTabControl;
		private System.Windows.Forms.TabPage mainTabPage;
		private System.Windows.Forms.TabPage searchTabPage;
		private System.Windows.Forms.TabPage filterTabPage;
		private System.Windows.Forms.TabPage printTabPage;
		private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
		private Panel panel1;
		private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
		private MaterialSkin.Controls.MaterialTabControl searchTabControl;
		private TabPage searchPassengersTabPage;
		private DataGridView passengersDataGridView;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private TabPage vacantSeatsTabPage;
		private MaterialSkin.Controls.MaterialComboBox searchTypeComboBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel8;
		private MaterialSkin.Controls.MaterialTextBox searchTextBox;
		private DataGridView vacantSeatsDataGridView;
		private MaterialSkin.Controls.MaterialTabControl filterTabControl;
		private TabPage ticketFilterTabPage;
		private TabPage flightFilterTabPage;
		private Panel panel2;
		private MaterialSkin.Controls.MaterialComboBox filterTypeComboBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel9;
		private MaterialSkin.Controls.MaterialTextBox filterTextBox;
		private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
		private ImageList actionIconsImageList;
		private MaterialSkin.Controls.MaterialTabControl mainTabPageTabControl;
		private TabPage usersTabPage;
		private DataGridView usersDataGridView;
		private DataGridViewTextBoxColumn usersNumberColumn;
		private DataGridViewTextBoxColumn usersLoginColumn;
		private DataGridViewTextBoxColumn usersSurnameColumn;
		private DataGridViewTextBoxColumn usersNameColumn;
		private DataGridViewTextBoxColumn usersPatronymicColumn;
		private DataGridViewTextBoxColumn usersPassportColumn;
		private DataGridViewTextBoxColumn usersPhoneColumn;
		private DataGridViewCheckBoxColumn usersAdminRightsColumn;
		private TabPage ticketsTabPage;
		private DataGridView ticketsDataGridView;
		private TabPage routesTabPage;
		private DataGridView routesDataGridView;
		private DataGridViewTextBoxColumn routesNumberColumn;
		private DataGridViewTextBoxColumn routesFromColumn;
		private DataGridViewTextBoxColumn routesToColumn;
		private TabPage flightsTabPage;
		private DataGridView flightsDataGridView;
		private TabPage planesTabPage;
		private DataGridView planesDataGridView;
		private TabPage crewTabPage;
		private DataGridView crewMembersDataGridView;
		private TabPage airportsTabPage;
		private DataGridView airportsDataGridView;
		private ToolStrip toolStrip2;
		private ToolStripButton saveSingleToolStripButton;
		private ToolStripButton deleteToolStripButton;
		private ToolStripButton saveAllToolStripButton;
		private TabPage profileTabPage;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel4;
		private MaterialSkin.Controls.MaterialComboBox accountGenderComboBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialTextBox accountPatronymicTextBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private MaterialSkin.Controls.MaterialTextBox accountNameTextBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MaterialSkin.Controls.MaterialTextBox accountSurnameTextBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private Panel panel5;
		private MaterialSkin.Controls.MaterialButton changePasswordButton;
		private MaterialSkin.Controls.MaterialTextBox accountLoginTextBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialTextBox accountPhoneTextBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel7;
		private MaterialSkin.Controls.MaterialLabel materialLabel6;
		private MaterialSkin.Controls.MaterialTextBox accountPassportTextBox;
		private Panel panel3;
		private MaterialSkin.Controls.MaterialButton exitFromAccountButton;
		private MaterialSkin.Controls.MaterialButton saveAccountChangesButton;
		private DataGridViewTextBoxColumn planesNumberColumn;
		private DataGridViewTextBoxColumn planesNumColumn;
		private DataGridViewTextBoxColumn planesTypeColumn;
		private DataGridViewTextBoxColumn planesStClassSeatsColumn;
		private DataGridViewTextBoxColumn planesNdClassSeatsColumn;
		private DataGridViewTextBoxColumn planesRdClassSeatsColumn;
		private DataGridViewTextBoxColumn crewMembersNumberColumn;
		private DataGridViewTextBoxColumn crewMembersPlaneColumn;
		private DataGridViewTextBoxColumn crewMembersInitialsColumn;
		private DataGridViewTextBoxColumn crewMembersPositionColumn;
		private DataGridViewTextBoxColumn airportsNumberColumn;
		private DataGridViewTextBoxColumn airportsNameColumn;
		private DataGridViewTextBoxColumn airportsCityColumn;
		private DataGridViewTextBoxColumn airportsImageColumn;
		private DataGridViewTextBoxColumn flightsNumberColumn;
		private DataGridViewTextBoxColumn flightsPlaneColumn;
		private DataGridViewTextBoxColumn flightsRouteColumn;
		private DataGridViewTextBoxColumn flightsDateFromColumn;
		private DataGridViewTextBoxColumn flightsDateToColumn;
		private DataGridViewTextBoxColumn ticketsNumberColumn;
		private DataGridViewTextBoxColumn ticketsPassengerColumn;
		private DataGridViewTextBoxColumn ticketsTicketPriceId;
		private TabPage ticketPricesTabPage;
		private DataGridView ticketPricesDataGridView;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private DataGridViewTextBoxColumn ticketPricesClassColumn;
		private DataGridViewTextBoxColumn ticketPricesFlightColumn;
		private DataGridViewTextBoxColumn ticketPricesPriceColumn;
		private ToolStripStatusLabel StatusLabel;
		private ToolStripStatusLabel amountOfEmptySeatsStatusLabel;
		private DataGridViewTextBoxColumn searchEmptySeatsPlaneNumColumn;
		private DataGridViewTextBoxColumn searchEmptySeatsFlightNumColumn;
		private DataGridViewTextBoxColumn searchEmptySeatsColumn;
		private DataGridView ticketFilterDataGridView;
		private DataGridViewTextBoxColumn ticketFilterPassengerColumn;
		private DataGridViewTextBoxColumn ticketFilterFlightNumberColumn;
		private DataGridViewTextBoxColumn ticketFilterDepartureAirport;
		private DataGridViewTextBoxColumn ticketFilterDepartureDateColumn;
		private DataGridViewTextBoxColumn ticketFilterArrivalAirportColumn;
		private DataGridViewTextBoxColumn ticketFilterArrivalDateColumn;
		private DataGridViewTextBoxColumn ticketFilterClassColumn;
		private MaterialSkin.Controls.MaterialCard materialCard1;
		private MaterialSkin.Controls.MaterialButton printTicketButton;
		private DataGridView printTicketDataGridView;
		private DataGridViewTextBoxColumn ticketPrintNumberColumn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private MaterialSkin.Controls.MaterialLabel materialLabel10;
	}
}

