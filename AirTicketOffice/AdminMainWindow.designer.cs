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
			this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
			this.mainTabPage = new System.Windows.Forms.TabPage();
			this.mainTabPageTabControl = new MaterialSkin.Controls.MaterialTabControl();
			this.adTabPage = new System.Windows.Forms.TabPage();
			this.eventsDataGridView = new System.Windows.Forms.DataGridView();
			this.eventsNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventsImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.eventsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventsDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventsFinishDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventsPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventsStatusColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
			this.ordersTabPage = new System.Windows.Forms.TabPage();
			this.ordersDataGridView = new System.Windows.Forms.DataGridView();
			this.ordersNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ordersUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ordersFlightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ordersDesiredDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ordersRegistrationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ordersOfficeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketsTabPage = new System.Windows.Forms.TabPage();
			this.ticketsDataGridView = new System.Windows.Forms.DataGridView();
			this.ticketsNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketsPassengerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketsClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketsFlightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.planesTabPage = new System.Windows.Forms.TabPage();
			this.planesDataGridView = new System.Windows.Forms.DataGridView();
			this.planesNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planesNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planesTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.crewTabPage = new System.Windows.Forms.TabPage();
			this.crewsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airportsTabPage = new System.Windows.Forms.TabPage();
			this.airportsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.saveSingleToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveAllToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
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
			this.leaveAccountButton = new MaterialSkin.Controls.MaterialButton();
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
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.searchTypeComboBox = new MaterialSkin.Controls.MaterialComboBox();
			this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
			this.searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
			this.filterTabPage = new System.Windows.Forms.TabPage();
			this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
			this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
			this.materialTextBox8 = new MaterialSkin.Controls.MaterialTextBox();
			this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
			this.printTabPage = new System.Windows.Forms.TabPage();
			this.actionIconsImageList = new System.Windows.Forms.ImageList(this.components);
			this.mainTabControl.SuspendLayout();
			this.mainTabPage.SuspendLayout();
			this.mainTabPageTabControl.SuspendLayout();
			this.adTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).BeginInit();
			this.usersTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
			this.ordersTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
			this.ticketsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).BeginInit();
			this.routesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).BeginInit();
			this.flightsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
			this.planesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.planesDataGridView)).BeginInit();
			this.crewTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.crewsDataGridView)).BeginInit();
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
			this.materialTabControl1.SuspendLayout();
			this.panel2.SuspendLayout();
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
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
			this.mainTabControl.Size = new System.Drawing.Size(800, 428);
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
			this.mainTabPage.Size = new System.Drawing.Size(792, 385);
			this.mainTabPage.TabIndex = 0;
			this.mainTabPage.Text = "Главная";
			// 
			// mainTabPageTabControl
			// 
			this.mainTabPageTabControl.Controls.Add(this.adTabPage);
			this.mainTabPageTabControl.Controls.Add(this.usersTabPage);
			this.mainTabPageTabControl.Controls.Add(this.ordersTabPage);
			this.mainTabPageTabControl.Controls.Add(this.ticketsTabPage);
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
			this.mainTabPageTabControl.Size = new System.Drawing.Size(792, 301);
			this.mainTabPageTabControl.TabIndex = 12;
			// 
			// adTabPage
			// 
			this.adTabPage.Controls.Add(this.eventsDataGridView);
			this.adTabPage.Location = new System.Drawing.Point(4, 22);
			this.adTabPage.Margin = new System.Windows.Forms.Padding(0);
			this.adTabPage.Name = "adTabPage";
			this.adTabPage.Size = new System.Drawing.Size(784, 275);
			this.adTabPage.TabIndex = 0;
			this.adTabPage.Text = "Мероприятия";
			this.adTabPage.UseVisualStyleBackColor = true;
			// 
			// eventsDataGridView
			// 
			this.eventsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.eventsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.eventsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.eventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.eventsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventsNumberColumn,
            this.eventsImageColumn,
            this.eventsNameColumn,
            this.eventsDescriptionColumn,
            this.eventsFinishDateColumn,
            this.eventsPositionColumn,
            this.eventsStatusColumn});
			this.eventsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.eventsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.eventsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.eventsDataGridView.MultiSelect = false;
			this.eventsDataGridView.Name = "eventsDataGridView";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.eventsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.eventsDataGridView.RowHeadersVisible = false;
			this.eventsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.eventsDataGridView.Size = new System.Drawing.Size(784, 275);
			this.eventsDataGridView.TabIndex = 0;
			// 
			// eventsNumberColumn
			// 
			this.eventsNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.eventsNumberColumn.FillWeight = 4F;
			this.eventsNumberColumn.HeaderText = "№";
			this.eventsNumberColumn.Name = "eventsNumberColumn";
			this.eventsNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// eventsImageColumn
			// 
			this.eventsImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.eventsImageColumn.FillWeight = 15F;
			this.eventsImageColumn.HeaderText = "Изображение";
			this.eventsImageColumn.Name = "eventsImageColumn";
			this.eventsImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// eventsNameColumn
			// 
			this.eventsNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.eventsNameColumn.FillWeight = 14F;
			this.eventsNameColumn.HeaderText = "Название";
			this.eventsNameColumn.Name = "eventsNameColumn";
			this.eventsNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// eventsDescriptionColumn
			// 
			this.eventsDescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.eventsDescriptionColumn.FillWeight = 25F;
			this.eventsDescriptionColumn.HeaderText = "Описание";
			this.eventsDescriptionColumn.Name = "eventsDescriptionColumn";
			this.eventsDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// eventsFinishDateColumn
			// 
			this.eventsFinishDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.eventsFinishDateColumn.FillWeight = 10F;
			this.eventsFinishDateColumn.HeaderText = "Дата окончания";
			this.eventsFinishDateColumn.Name = "eventsFinishDateColumn";
			this.eventsFinishDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// eventsPositionColumn
			// 
			this.eventsPositionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.eventsPositionColumn.FillWeight = 10F;
			this.eventsPositionColumn.HeaderText = "Позиция";
			this.eventsPositionColumn.Name = "eventsPositionColumn";
			this.eventsPositionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// eventsStatusColumn
			// 
			this.eventsStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.eventsStatusColumn.FillWeight = 10F;
			this.eventsStatusColumn.HeaderText = "Активна";
			this.eventsStatusColumn.Name = "eventsStatusColumn";
			this.eventsStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// usersTabPage
			// 
			this.usersTabPage.Controls.Add(this.usersDataGridView);
			this.usersTabPage.Location = new System.Drawing.Point(4, 22);
			this.usersTabPage.Name = "usersTabPage";
			this.usersTabPage.Size = new System.Drawing.Size(784, 275);
			this.usersTabPage.TabIndex = 1;
			this.usersTabPage.Text = "Пользователи";
			this.usersTabPage.UseVisualStyleBackColor = true;
			// 
			// usersDataGridView
			// 
			this.usersDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.usersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.usersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.usersDataGridView.RowHeadersVisible = false;
			this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.usersDataGridView.Size = new System.Drawing.Size(784, 275);
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
			// ordersTabPage
			// 
			this.ordersTabPage.Controls.Add(this.ordersDataGridView);
			this.ordersTabPage.Location = new System.Drawing.Point(4, 22);
			this.ordersTabPage.Name = "ordersTabPage";
			this.ordersTabPage.Size = new System.Drawing.Size(784, 275);
			this.ordersTabPage.TabIndex = 2;
			this.ordersTabPage.Text = "Заявки";
			this.ordersTabPage.UseVisualStyleBackColor = true;
			// 
			// ordersDataGridView
			// 
			this.ordersDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.ordersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordersNumberColumn,
            this.ordersUserColumn,
            this.ordersFlightColumn,
            this.ordersDesiredDateColumn,
            this.ordersRegistrationDateColumn,
            this.ordersOfficeColumn});
			this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ordersDataGridView.Location = new System.Drawing.Point(0, 0);
			this.ordersDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.ordersDataGridView.MultiSelect = false;
			this.ordersDataGridView.Name = "ordersDataGridView";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ordersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.ordersDataGridView.RowHeadersVisible = false;
			this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.ordersDataGridView.Size = new System.Drawing.Size(784, 275);
			this.ordersDataGridView.TabIndex = 1;
			// 
			// ordersNumberColumn
			// 
			this.ordersNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ordersNumberColumn.FillWeight = 4F;
			this.ordersNumberColumn.HeaderText = "№";
			this.ordersNumberColumn.Name = "ordersNumberColumn";
			this.ordersNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// ordersUserColumn
			// 
			this.ordersUserColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ordersUserColumn.FillWeight = 20F;
			this.ordersUserColumn.HeaderText = "Пользователь";
			this.ordersUserColumn.Name = "ordersUserColumn";
			// 
			// ordersFlightColumn
			// 
			this.ordersFlightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ordersFlightColumn.FillWeight = 10F;
			this.ordersFlightColumn.HeaderText = "Рейс";
			this.ordersFlightColumn.Name = "ordersFlightColumn";
			// 
			// ordersDesiredDateColumn
			// 
			this.ordersDesiredDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ordersDesiredDateColumn.FillWeight = 15F;
			this.ordersDesiredDateColumn.HeaderText = "Желаемая дата";
			this.ordersDesiredDateColumn.Name = "ordersDesiredDateColumn";
			// 
			// ordersRegistrationDateColumn
			// 
			this.ordersRegistrationDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ordersRegistrationDateColumn.FillWeight = 15F;
			this.ordersRegistrationDateColumn.HeaderText = "Дата оформления";
			this.ordersRegistrationDateColumn.Name = "ordersRegistrationDateColumn";
			// 
			// ordersOfficeColumn
			// 
			this.ordersOfficeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ordersOfficeColumn.FillWeight = 15F;
			this.ordersOfficeColumn.HeaderText = "Касса";
			this.ordersOfficeColumn.Name = "ordersOfficeColumn";
			// 
			// ticketsTabPage
			// 
			this.ticketsTabPage.Controls.Add(this.ticketsDataGridView);
			this.ticketsTabPage.Location = new System.Drawing.Point(4, 22);
			this.ticketsTabPage.Name = "ticketsTabPage";
			this.ticketsTabPage.Size = new System.Drawing.Size(784, 275);
			this.ticketsTabPage.TabIndex = 3;
			this.ticketsTabPage.Text = "Билеты";
			this.ticketsTabPage.UseVisualStyleBackColor = true;
			// 
			// ticketsDataGridView
			// 
			this.ticketsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.ticketsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ticketsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ticketsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketsNumberColumn,
            this.ticketsPassengerColumn,
            this.ticketsClassColumn,
            this.ticketsFlightColumn});
			this.ticketsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ticketsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.ticketsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.ticketsDataGridView.MultiSelect = false;
			this.ticketsDataGridView.Name = "ticketsDataGridView";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ticketsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.ticketsDataGridView.RowHeadersVisible = false;
			this.ticketsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.ticketsDataGridView.Size = new System.Drawing.Size(784, 275);
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
			// ticketsClassColumn
			// 
			this.ticketsClassColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketsClassColumn.FillWeight = 10F;
			this.ticketsClassColumn.HeaderText = "Класс";
			this.ticketsClassColumn.Name = "ticketsClassColumn";
			// 
			// ticketsFlightColumn
			// 
			this.ticketsFlightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ticketsFlightColumn.FillWeight = 10F;
			this.ticketsFlightColumn.HeaderText = "Рейс";
			this.ticketsFlightColumn.Name = "ticketsFlightColumn";
			// 
			// routesTabPage
			// 
			this.routesTabPage.Controls.Add(this.routesDataGridView);
			this.routesTabPage.Location = new System.Drawing.Point(4, 22);
			this.routesTabPage.Name = "routesTabPage";
			this.routesTabPage.Size = new System.Drawing.Size(784, 275);
			this.routesTabPage.TabIndex = 4;
			this.routesTabPage.Text = "Маршруты";
			this.routesTabPage.UseVisualStyleBackColor = true;
			// 
			// routesDataGridView
			// 
			this.routesDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.routesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.routesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.routesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.routesDataGridView.RowHeadersVisible = false;
			this.routesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.routesDataGridView.Size = new System.Drawing.Size(784, 275);
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
			this.flightsTabPage.Size = new System.Drawing.Size(784, 275);
			this.flightsTabPage.TabIndex = 5;
			this.flightsTabPage.Text = "Рейсы";
			this.flightsTabPage.UseVisualStyleBackColor = true;
			// 
			// flightsDataGridView
			// 
			this.flightsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.flightsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.flightsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.flightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightsNumberColumn,
            this.flightsPlaneColumn,
            this.flightsRouteColumn});
			this.flightsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flightsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.flightsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.flightsDataGridView.MultiSelect = false;
			this.flightsDataGridView.Name = "flightsDataGridView";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.flightsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.flightsDataGridView.RowHeadersVisible = false;
			this.flightsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.flightsDataGridView.Size = new System.Drawing.Size(784, 275);
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
			// planesTabPage
			// 
			this.planesTabPage.Controls.Add(this.planesDataGridView);
			this.planesTabPage.Location = new System.Drawing.Point(4, 22);
			this.planesTabPage.Name = "planesTabPage";
			this.planesTabPage.Size = new System.Drawing.Size(784, 275);
			this.planesTabPage.TabIndex = 6;
			this.planesTabPage.Text = "Самолеты";
			this.planesTabPage.UseVisualStyleBackColor = true;
			// 
			// planesDataGridView
			// 
			this.planesDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.planesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.planesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.planesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.planesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planesNumberColumn,
            this.planesNumColumn,
            this.planesTypeColumn});
			this.planesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.planesDataGridView.Location = new System.Drawing.Point(0, 0);
			this.planesDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.planesDataGridView.MultiSelect = false;
			this.planesDataGridView.Name = "planesDataGridView";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.planesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.planesDataGridView.RowHeadersVisible = false;
			this.planesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.planesDataGridView.Size = new System.Drawing.Size(784, 275);
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
			// crewTabPage
			// 
			this.crewTabPage.Controls.Add(this.crewsDataGridView);
			this.crewTabPage.Location = new System.Drawing.Point(4, 22);
			this.crewTabPage.Name = "crewTabPage";
			this.crewTabPage.Size = new System.Drawing.Size(784, 275);
			this.crewTabPage.TabIndex = 7;
			this.crewTabPage.Text = "Экипажи";
			this.crewTabPage.UseVisualStyleBackColor = true;
			// 
			// crewsDataGridView
			// 
			this.crewsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.crewsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.crewsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
			this.crewsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.crewsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49});
			this.crewsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crewsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.crewsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.crewsDataGridView.MultiSelect = false;
			this.crewsDataGridView.Name = "crewsDataGridView";
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.crewsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.crewsDataGridView.RowHeadersVisible = false;
			this.crewsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.crewsDataGridView.Size = new System.Drawing.Size(784, 275);
			this.crewsDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn43
			// 
			this.dataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn43.FillWeight = 4F;
			this.dataGridViewTextBoxColumn43.HeaderText = "№";
			this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
			this.dataGridViewTextBoxColumn43.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn44
			// 
			this.dataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn44.FillWeight = 15F;
			this.dataGridViewTextBoxColumn44.HeaderText = "Изображение";
			this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
			// 
			// dataGridViewTextBoxColumn45
			// 
			this.dataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn45.FillWeight = 14F;
			this.dataGridViewTextBoxColumn45.HeaderText = "Название";
			this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
			// 
			// dataGridViewTextBoxColumn46
			// 
			this.dataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn46.FillWeight = 25F;
			this.dataGridViewTextBoxColumn46.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
			// 
			// dataGridViewTextBoxColumn47
			// 
			this.dataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn47.FillWeight = 10F;
			this.dataGridViewTextBoxColumn47.HeaderText = "Дата окончания";
			this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
			// 
			// dataGridViewTextBoxColumn48
			// 
			this.dataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn48.FillWeight = 10F;
			this.dataGridViewTextBoxColumn48.HeaderText = "Позиция";
			this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
			// 
			// dataGridViewTextBoxColumn49
			// 
			this.dataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn49.FillWeight = 10F;
			this.dataGridViewTextBoxColumn49.HeaderText = "Активна";
			this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
			// 
			// airportsTabPage
			// 
			this.airportsTabPage.Controls.Add(this.airportsDataGridView);
			this.airportsTabPage.Location = new System.Drawing.Point(4, 22);
			this.airportsTabPage.Name = "airportsTabPage";
			this.airportsTabPage.Size = new System.Drawing.Size(784, 275);
			this.airportsTabPage.TabIndex = 8;
			this.airportsTabPage.Text = "Аэропорты";
			this.airportsTabPage.UseVisualStyleBackColor = true;
			// 
			// airportsDataGridView
			// 
			this.airportsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.airportsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.airportsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.airportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.airportsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56});
			this.airportsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.airportsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.airportsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.airportsDataGridView.MultiSelect = false;
			this.airportsDataGridView.Name = "airportsDataGridView";
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.airportsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
			this.airportsDataGridView.RowHeadersVisible = false;
			this.airportsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.airportsDataGridView.Size = new System.Drawing.Size(784, 275);
			this.airportsDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn50
			// 
			this.dataGridViewTextBoxColumn50.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn50.FillWeight = 4F;
			this.dataGridViewTextBoxColumn50.HeaderText = "№";
			this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
			this.dataGridViewTextBoxColumn50.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn51
			// 
			this.dataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn51.FillWeight = 15F;
			this.dataGridViewTextBoxColumn51.HeaderText = "Изображение";
			this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
			// 
			// dataGridViewTextBoxColumn52
			// 
			this.dataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn52.FillWeight = 14F;
			this.dataGridViewTextBoxColumn52.HeaderText = "Название";
			this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
			// 
			// dataGridViewTextBoxColumn53
			// 
			this.dataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn53.FillWeight = 25F;
			this.dataGridViewTextBoxColumn53.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
			// 
			// dataGridViewTextBoxColumn54
			// 
			this.dataGridViewTextBoxColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn54.FillWeight = 10F;
			this.dataGridViewTextBoxColumn54.HeaderText = "Дата окончания";
			this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
			// 
			// dataGridViewTextBoxColumn55
			// 
			this.dataGridViewTextBoxColumn55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn55.FillWeight = 10F;
			this.dataGridViewTextBoxColumn55.HeaderText = "Позиция";
			this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
			// 
			// dataGridViewTextBoxColumn56
			// 
			this.dataGridViewTextBoxColumn56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn56.FillWeight = 10F;
			this.dataGridViewTextBoxColumn56.HeaderText = "Активна";
			this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
			// 
			// toolStrip2
			// 
			this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSingleToolStripButton,
            this.saveAllToolStripButton,
            this.addToolStripButton,
            this.deleteToolStripButton});
			this.toolStrip2.Location = new System.Drawing.Point(0, 30);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
			this.toolStrip2.Size = new System.Drawing.Size(792, 54);
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
			// addToolStripButton
			// 
			this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addToolStripButton.Image = global::AirTicketOffice.Properties.Resources.add_icon;
			this.addToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addToolStripButton.Margin = new System.Windows.Forms.Padding(3, 5, 2, 5);
			this.addToolStripButton.Name = "addToolStripButton";
			this.addToolStripButton.Size = new System.Drawing.Size(44, 44);
			this.addToolStripButton.Text = "Добавить запись";
			this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
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
			this.materialTabSelector1.Size = new System.Drawing.Size(792, 30);
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
			this.profileTabPage.Size = new System.Drawing.Size(792, 385);
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
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 332);
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
			this.panel4.Size = new System.Drawing.Size(387, 326);
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
			this.accountGenderComboBox.Size = new System.Drawing.Size(363, 35);
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
			this.accountPatronymicTextBox.Size = new System.Drawing.Size(363, 36);
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
			this.accountNameTextBox.Size = new System.Drawing.Size(363, 36);
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
			this.accountSurnameTextBox.Size = new System.Drawing.Size(363, 36);
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
			this.panel5.Location = new System.Drawing.Point(396, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(387, 326);
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
			this.changePasswordButton.Size = new System.Drawing.Size(362, 36);
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
			this.accountLoginTextBox.Size = new System.Drawing.Size(362, 36);
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
			this.accountPhoneTextBox.Size = new System.Drawing.Size(362, 36);
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
			this.accountPassportTextBox.Size = new System.Drawing.Size(362, 36);
			this.accountPassportTextBox.TabIndex = 24;
			this.accountPassportTextBox.Text = "";
			this.accountPassportTextBox.TrailingIcon = null;
			this.accountPassportTextBox.UseTallSize = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.leaveAccountButton);
			this.panel3.Controls.Add(this.saveAccountChangesButton);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(3, 335);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(786, 47);
			this.panel3.TabIndex = 0;
			// 
			// leaveAccountButton
			// 
			this.leaveAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.leaveAccountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.leaveAccountButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.leaveAccountButton.Depth = 0;
			this.leaveAccountButton.HighEmphasis = true;
			this.leaveAccountButton.Icon = null;
			this.leaveAccountButton.Location = new System.Drawing.Point(6, 5);
			this.leaveAccountButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.leaveAccountButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.leaveAccountButton.Name = "leaveAccountButton";
			this.leaveAccountButton.Size = new System.Drawing.Size(177, 36);
			this.leaveAccountButton.TabIndex = 5;
			this.leaveAccountButton.Text = "Выйти из аккаунта";
			this.leaveAccountButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
			this.leaveAccountButton.UseAccentColor = false;
			this.leaveAccountButton.UseVisualStyleBackColor = true;
			// 
			// saveAccountChangesButton
			// 
			this.saveAccountChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveAccountChangesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.saveAccountChangesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.saveAccountChangesButton.Depth = 0;
			this.saveAccountChangesButton.HighEmphasis = true;
			this.saveAccountChangesButton.Icon = null;
			this.saveAccountChangesButton.Location = new System.Drawing.Point(577, 5);
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
			this.searchTabPage.Size = new System.Drawing.Size(792, 385);
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
			this.searchTabControl.Size = new System.Drawing.Size(792, 301);
			this.searchTabControl.TabIndex = 4;
			// 
			// searchPassengersTabPage
			// 
			this.searchPassengersTabPage.BackColor = System.Drawing.Color.White;
			this.searchPassengersTabPage.Controls.Add(this.passengersDataGridView);
			this.searchPassengersTabPage.Location = new System.Drawing.Point(4, 22);
			this.searchPassengersTabPage.Margin = new System.Windows.Forms.Padding(0);
			this.searchPassengersTabPage.Name = "searchPassengersTabPage";
			this.searchPassengersTabPage.Size = new System.Drawing.Size(784, 275);
			this.searchPassengersTabPage.TabIndex = 0;
			this.searchPassengersTabPage.Text = "Пассажиры";
			// 
			// passengersDataGridView
			// 
			this.passengersDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.passengersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.passengersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
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
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.passengersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.passengersDataGridView.RowHeadersVisible = false;
			this.passengersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.passengersDataGridView.Size = new System.Drawing.Size(784, 275);
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
			this.vacantSeatsTabPage.Size = new System.Drawing.Size(784, 275);
			this.vacantSeatsTabPage.TabIndex = 1;
			this.vacantSeatsTabPage.Text = "Свободные места";
			// 
			// vacantSeatsDataGridView
			// 
			this.vacantSeatsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.vacantSeatsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.vacantSeatsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
			this.vacantSeatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vacantSeatsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
			this.vacantSeatsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vacantSeatsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.vacantSeatsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.vacantSeatsDataGridView.Name = "vacantSeatsDataGridView";
			dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.vacantSeatsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
			this.vacantSeatsDataGridView.RowHeadersVisible = false;
			this.vacantSeatsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.vacantSeatsDataGridView.Size = new System.Drawing.Size(784, 275);
			this.vacantSeatsDataGridView.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn8.FillWeight = 4F;
			this.dataGridViewTextBoxColumn8.HeaderText = "№";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn9.FillWeight = 40F;
			this.dataGridViewTextBoxColumn9.HeaderText = "Самолет";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn10.FillWeight = 40F;
			this.dataGridViewTextBoxColumn10.HeaderText = "Маршрут";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
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
			this.panel1.Size = new System.Drawing.Size(792, 54);
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
			this.searchTypeComboBox.Location = new System.Drawing.Point(467, 10);
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
			this.materialLabel8.Location = new System.Drawing.Point(380, 18);
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
			this.searchTextBox.Size = new System.Drawing.Size(356, 36);
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
			this.materialTabSelector2.Size = new System.Drawing.Size(792, 30);
			this.materialTabSelector2.TabIndex = 2;
			this.materialTabSelector2.TabIndicatorHeight = 5;
			this.materialTabSelector2.TabStop = false;
			// 
			// filterTabPage
			// 
			this.filterTabPage.BackColor = System.Drawing.Color.White;
			this.filterTabPage.Controls.Add(this.materialTabControl1);
			this.filterTabPage.Controls.Add(this.panel2);
			this.filterTabPage.Controls.Add(this.materialTabSelector3);
			this.filterTabPage.ImageKey = "filter_icon.png";
			this.filterTabPage.Location = new System.Drawing.Point(4, 39);
			this.filterTabPage.Name = "filterTabPage";
			this.filterTabPage.Size = new System.Drawing.Size(792, 385);
			this.filterTabPage.TabIndex = 3;
			this.filterTabPage.Text = "Фильтрация";
			// 
			// materialTabControl1
			// 
			this.materialTabControl1.Controls.Add(this.tabPage1);
			this.materialTabControl1.Controls.Add(this.tabPage2);
			this.materialTabControl1.Depth = 0;
			this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialTabControl1.Location = new System.Drawing.Point(0, 84);
			this.materialTabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Multiline = true;
			this.materialTabControl1.Name = "materialTabControl1";
			this.materialTabControl1.SelectedIndex = 0;
			this.materialTabControl1.Size = new System.Drawing.Size(792, 301);
			this.materialTabControl1.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(784, 275);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Билеты";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.White;
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(784, 275);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Рейсы";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.materialComboBox1);
			this.panel2.Controls.Add(this.materialLabel9);
			this.panel2.Controls.Add(this.materialTextBox8);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 30);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 54);
			this.panel2.TabIndex = 6;
			// 
			// materialComboBox1
			// 
			this.materialComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialComboBox1.AutoResize = false;
			this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialComboBox1.Depth = 0;
			this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.materialComboBox1.DropDownHeight = 118;
			this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.materialComboBox1.DropDownWidth = 121;
			this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialComboBox1.FormattingEnabled = true;
			this.materialComboBox1.IntegralHeight = false;
			this.materialComboBox1.ItemHeight = 29;
			this.materialComboBox1.Location = new System.Drawing.Point(467, 10);
			this.materialComboBox1.MaxDropDownItems = 4;
			this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
			this.materialComboBox1.Name = "materialComboBox1";
			this.materialComboBox1.Size = new System.Drawing.Size(317, 35);
			this.materialComboBox1.StartIndex = 0;
			this.materialComboBox1.TabIndex = 2;
			this.materialComboBox1.UseTallSize = false;
			// 
			// materialLabel9
			// 
			this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel9.AutoSize = true;
			this.materialLabel9.Depth = 0;
			this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel9.Location = new System.Drawing.Point(380, 18);
			this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel9.Name = "materialLabel9";
			this.materialLabel9.Size = new System.Drawing.Size(83, 19);
			this.materialLabel9.TabIndex = 1;
			this.materialLabel9.Text = "Фильтр по:";
			// 
			// materialTextBox8
			// 
			this.materialTextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.materialTextBox8.Depth = 0;
			this.materialTextBox8.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialTextBox8.Hint = "Фильтр...";
			this.materialTextBox8.LeadingIcon = null;
			this.materialTextBox8.Location = new System.Drawing.Point(8, 10);
			this.materialTextBox8.MaxLength = 50;
			this.materialTextBox8.MouseState = MaterialSkin.MouseState.OUT;
			this.materialTextBox8.Multiline = false;
			this.materialTextBox8.Name = "materialTextBox8";
			this.materialTextBox8.Size = new System.Drawing.Size(356, 36);
			this.materialTextBox8.TabIndex = 0;
			this.materialTextBox8.Text = "";
			this.materialTextBox8.TrailingIcon = null;
			this.materialTextBox8.UseTallSize = false;
			// 
			// materialTabSelector3
			// 
			this.materialTabSelector3.BaseTabControl = this.materialTabControl1;
			this.materialTabSelector3.Depth = 0;
			this.materialTabSelector3.Dock = System.Windows.Forms.DockStyle.Top;
			this.materialTabSelector3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialTabSelector3.Location = new System.Drawing.Point(0, 0);
			this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabSelector3.Name = "materialTabSelector3";
			this.materialTabSelector3.Size = new System.Drawing.Size(792, 30);
			this.materialTabSelector3.TabIndex = 5;
			this.materialTabSelector3.TabIndicatorHeight = 5;
			this.materialTabSelector3.TabStop = false;
			// 
			// printTabPage
			// 
			this.printTabPage.BackColor = System.Drawing.Color.White;
			this.printTabPage.ImageKey = "print_icon.png";
			this.printTabPage.Location = new System.Drawing.Point(4, 39);
			this.printTabPage.Name = "printTabPage";
			this.printTabPage.Size = new System.Drawing.Size(792, 385);
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
			// AdminMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainTabControl);
			this.Controls.Add(this.statusStrip1);
			this.DrawerShowIconsWhenHidden = true;
			this.DrawerTabControl = this.mainTabControl;
			this.Name = "AdminMainWindow";
			this.Padding = new System.Windows.Forms.Padding(0);
			this.Text = "Form1";
			this.mainTabControl.ResumeLayout(false);
			this.mainTabPage.ResumeLayout(false);
			this.mainTabPage.PerformLayout();
			this.mainTabPageTabControl.ResumeLayout(false);
			this.adTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).EndInit();
			this.usersTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
			this.ordersTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
			this.ticketsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).EndInit();
			this.routesTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).EndInit();
			this.flightsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
			this.planesTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.planesDataGridView)).EndInit();
			this.crewTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.crewsDataGridView)).EndInit();
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
			this.materialTabControl1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
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
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private Panel panel2;
		private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
		private MaterialSkin.Controls.MaterialLabel materialLabel9;
		private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
		private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
		private ImageList actionIconsImageList;
		private MaterialSkin.Controls.MaterialTabControl mainTabPageTabControl;
		private TabPage adTabPage;
		private DataGridView eventsDataGridView;
		private DataGridViewTextBoxColumn eventsNumberColumn;
		private DataGridViewImageColumn eventsImageColumn;
		private DataGridViewTextBoxColumn eventsNameColumn;
		private DataGridViewTextBoxColumn eventsDescriptionColumn;
		private DataGridViewTextBoxColumn eventsFinishDateColumn;
		private DataGridViewTextBoxColumn eventsPositionColumn;
		private DataGridViewCheckBoxColumn eventsStatusColumn;
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
		private TabPage ordersTabPage;
		private DataGridView ordersDataGridView;
		private DataGridViewTextBoxColumn ordersNumberColumn;
		private DataGridViewTextBoxColumn ordersUserColumn;
		private DataGridViewTextBoxColumn ordersFlightColumn;
		private DataGridViewTextBoxColumn ordersDesiredDateColumn;
		private DataGridViewTextBoxColumn ordersRegistrationDateColumn;
		private DataGridViewTextBoxColumn ordersOfficeColumn;
		private TabPage ticketsTabPage;
		private DataGridView ticketsDataGridView;
		private DataGridViewTextBoxColumn ticketsNumberColumn;
		private DataGridViewTextBoxColumn ticketsPassengerColumn;
		private DataGridViewTextBoxColumn ticketsClassColumn;
		private DataGridViewTextBoxColumn ticketsFlightColumn;
		private TabPage routesTabPage;
		private DataGridView routesDataGridView;
		private DataGridViewTextBoxColumn routesNumberColumn;
		private DataGridViewTextBoxColumn routesFromColumn;
		private DataGridViewTextBoxColumn routesToColumn;
		private TabPage flightsTabPage;
		private DataGridView flightsDataGridView;
		private DataGridViewTextBoxColumn flightsNumberColumn;
		private DataGridViewTextBoxColumn flightsPlaneColumn;
		private DataGridViewTextBoxColumn flightsRouteColumn;
		private TabPage planesTabPage;
		private DataGridView planesDataGridView;
		private DataGridViewTextBoxColumn planesNumberColumn;
		private DataGridViewTextBoxColumn planesNumColumn;
		private DataGridViewTextBoxColumn planesTypeColumn;
		private TabPage crewTabPage;
		private DataGridView crewsDataGridView;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
		private TabPage airportsTabPage;
		private DataGridView airportsDataGridView;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
		private ToolStrip toolStrip2;
		private ToolStripButton saveSingleToolStripButton;
		private ToolStripButton addToolStripButton;
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
		private MaterialSkin.Controls.MaterialButton leaveAccountButton;
		private MaterialSkin.Controls.MaterialButton saveAccountChangesButton;
	}
}

