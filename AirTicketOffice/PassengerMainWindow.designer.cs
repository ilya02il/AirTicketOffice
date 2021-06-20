using System.Windows.Forms;

namespace AirTicketOffice
{
	partial class PassengerMainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerMainWindow));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
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
			this.orderTabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridViewCard = new MaterialSkin.Controls.MaterialCard();
			this.flightsDataGridView = new System.Windows.Forms.DataGridView();
			this.flightsNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsPlaneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsRouteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsDateFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsDateToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.propertiesCard = new MaterialSkin.Controls.MaterialCard();
			this.flightRdClassEmptySeatsLabel = new MaterialSkin.Controls.MaterialLabel();
			this.flightNdClassEmptySeatsLabel = new MaterialSkin.Controls.MaterialLabel();
			this.flightStClassEmptySeatsLabel = new MaterialSkin.Controls.MaterialLabel();
			this.orderTicketButton = new MaterialSkin.Controls.MaterialButton();
			this.ticketPriceLabel = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
			this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
			this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
			this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
			this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
			this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
			this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
			this.flightArrivalDateLabel = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
			this.flightDepartureDateLabel = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
			this.flightRouteLabel = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
			this.flightNumberLabel = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
			this.carouselCard = new MaterialSkin.Controls.MaterialCard();
			this.mapTabPage = new System.Windows.Forms.TabPage();
			this.actionIconsImageList = new System.Windows.Forms.ImageList(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
			this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.mainTabControl.SuspendLayout();
			this.profileTabPage.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.orderTabPage.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.dataGridViewCard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
			this.propertiesCard.SuspendLayout();
			this.mapTabPage.SuspendLayout();
			this.materialCard2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.mainTabControlImageList.Images.SetKeyName(5, "map_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(6, "order_icon.png");
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 578);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new System.Drawing.Size(1066, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.profileTabPage);
			this.mainTabControl.Controls.Add(this.orderTabPage);
			this.mainTabControl.Controls.Add(this.mapTabPage);
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
			this.accountPatronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
			this.accountNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
			this.accountSurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
			this.accountLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
			this.accountPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
			this.accountPassportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
			// orderTabPage
			// 
			this.orderTabPage.Controls.Add(this.tableLayoutPanel2);
			this.orderTabPage.ImageKey = "order_icon.png";
			this.orderTabPage.Location = new System.Drawing.Point(4, 39);
			this.orderTabPage.Name = "orderTabPage";
			this.orderTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.orderTabPage.Size = new System.Drawing.Size(1058, 535);
			this.orderTabPage.TabIndex = 2;
			this.orderTabPage.Text = "Заявка";
			this.orderTabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.Controls.Add(this.dataGridViewCard, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.propertiesCard, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.carouselCard, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1052, 529);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// dataGridViewCard
			// 
			this.dataGridViewCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dataGridViewCard.Controls.Add(this.flightsDataGridView);
			this.dataGridViewCard.Depth = 0;
			this.dataGridViewCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.dataGridViewCard.Location = new System.Drawing.Point(277, 14);
			this.dataGridViewCard.Margin = new System.Windows.Forms.Padding(14);
			this.dataGridViewCard.MouseState = MaterialSkin.MouseState.HOVER;
			this.dataGridViewCard.Name = "dataGridViewCard";
			this.dataGridViewCard.Padding = new System.Windows.Forms.Padding(14);
			this.dataGridViewCard.Size = new System.Drawing.Size(445, 501);
			this.dataGridViewCard.TabIndex = 4;
			// 
			// flightsDataGridView
			// 
			this.flightsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.flightsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.flightsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.flightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightsNumberColumn,
            this.flightsPlaneColumn,
            this.flightsRouteColumn,
            this.flightsDateFromColumn,
            this.flightsDateToColumn});
			this.flightsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flightsDataGridView.Location = new System.Drawing.Point(14, 14);
			this.flightsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.flightsDataGridView.Name = "flightsDataGridView";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.flightsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.flightsDataGridView.RowHeadersVisible = false;
			this.flightsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.flightsDataGridView.Size = new System.Drawing.Size(417, 473);
			this.flightsDataGridView.TabIndex = 3;
			this.flightsDataGridView.SelectionChanged += new System.EventHandler(this.flightsDataGridView_SelectionChanged);
			// 
			// flightsNumberColumn
			// 
			this.flightsNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsNumberColumn.FillWeight = 10F;
			this.flightsNumberColumn.HeaderText = "№";
			this.flightsNumberColumn.Name = "flightsNumberColumn";
			this.flightsNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// flightsPlaneColumn
			// 
			this.flightsPlaneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsPlaneColumn.FillWeight = 22.5F;
			this.flightsPlaneColumn.HeaderText = "Самолет";
			this.flightsPlaneColumn.Name = "flightsPlaneColumn";
			// 
			// flightsRouteColumn
			// 
			this.flightsRouteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsRouteColumn.FillWeight = 22.5F;
			this.flightsRouteColumn.HeaderText = "Маршрут";
			this.flightsRouteColumn.Name = "flightsRouteColumn";
			// 
			// flightsDateFromColumn
			// 
			this.flightsDateFromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsDateFromColumn.FillWeight = 22.5F;
			this.flightsDateFromColumn.HeaderText = "Дата и время отлета";
			this.flightsDateFromColumn.Name = "flightsDateFromColumn";
			// 
			// flightsDateToColumn
			// 
			this.flightsDateToColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsDateToColumn.FillWeight = 22.5F;
			this.flightsDateToColumn.HeaderText = "Дата и время прилета";
			this.flightsDateToColumn.Name = "flightsDateToColumn";
			// 
			// propertiesCard
			// 
			this.propertiesCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.propertiesCard.Controls.Add(this.flightRdClassEmptySeatsLabel);
			this.propertiesCard.Controls.Add(this.flightNdClassEmptySeatsLabel);
			this.propertiesCard.Controls.Add(this.flightStClassEmptySeatsLabel);
			this.propertiesCard.Controls.Add(this.orderTicketButton);
			this.propertiesCard.Controls.Add(this.ticketPriceLabel);
			this.propertiesCard.Controls.Add(this.materialLabel18);
			this.propertiesCard.Controls.Add(this.materialDivider2);
			this.propertiesCard.Controls.Add(this.materialRadioButton3);
			this.propertiesCard.Controls.Add(this.materialRadioButton2);
			this.propertiesCard.Controls.Add(this.materialRadioButton1);
			this.propertiesCard.Controls.Add(this.materialLabel17);
			this.propertiesCard.Controls.Add(this.materialDivider1);
			this.propertiesCard.Controls.Add(this.flightArrivalDateLabel);
			this.propertiesCard.Controls.Add(this.materialLabel16);
			this.propertiesCard.Controls.Add(this.flightDepartureDateLabel);
			this.propertiesCard.Controls.Add(this.materialLabel13);
			this.propertiesCard.Controls.Add(this.flightRouteLabel);
			this.propertiesCard.Controls.Add(this.materialLabel11);
			this.propertiesCard.Controls.Add(this.flightNumberLabel);
			this.propertiesCard.Controls.Add(this.materialLabel9);
			this.propertiesCard.Controls.Add(this.materialLabel8);
			this.propertiesCard.Depth = 0;
			this.propertiesCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertiesCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.propertiesCard.Location = new System.Drawing.Point(750, 14);
			this.propertiesCard.Margin = new System.Windows.Forms.Padding(14);
			this.propertiesCard.MouseState = MaterialSkin.MouseState.HOVER;
			this.propertiesCard.Name = "propertiesCard";
			this.propertiesCard.Padding = new System.Windows.Forms.Padding(14);
			this.propertiesCard.Size = new System.Drawing.Size(288, 501);
			this.propertiesCard.TabIndex = 5;
			// 
			// flightRdClassEmptySeatsLabel
			// 
			this.flightRdClassEmptySeatsLabel.AutoSize = true;
			this.flightRdClassEmptySeatsLabel.Depth = 0;
			this.flightRdClassEmptySeatsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.flightRdClassEmptySeatsLabel.Location = new System.Drawing.Point(114, 324);
			this.flightRdClassEmptySeatsLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.flightRdClassEmptySeatsLabel.Name = "flightRdClassEmptySeatsLabel";
			this.flightRdClassEmptySeatsLabel.Size = new System.Drawing.Size(116, 19);
			this.flightRdClassEmptySeatsLabel.TabIndex = 20;
			this.flightRdClassEmptySeatsLabel.Text = "materialLabel14";
			// 
			// flightNdClassEmptySeatsLabel
			// 
			this.flightNdClassEmptySeatsLabel.AutoSize = true;
			this.flightNdClassEmptySeatsLabel.Depth = 0;
			this.flightNdClassEmptySeatsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.flightNdClassEmptySeatsLabel.Location = new System.Drawing.Point(114, 287);
			this.flightNdClassEmptySeatsLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.flightNdClassEmptySeatsLabel.Name = "flightNdClassEmptySeatsLabel";
			this.flightNdClassEmptySeatsLabel.Size = new System.Drawing.Size(116, 19);
			this.flightNdClassEmptySeatsLabel.TabIndex = 19;
			this.flightNdClassEmptySeatsLabel.Text = "materialLabel12";
			// 
			// flightStClassEmptySeatsLabel
			// 
			this.flightStClassEmptySeatsLabel.AutoSize = true;
			this.flightStClassEmptySeatsLabel.Depth = 0;
			this.flightStClassEmptySeatsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.flightStClassEmptySeatsLabel.Location = new System.Drawing.Point(114, 250);
			this.flightStClassEmptySeatsLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.flightStClassEmptySeatsLabel.Name = "flightStClassEmptySeatsLabel";
			this.flightStClassEmptySeatsLabel.Size = new System.Drawing.Size(116, 19);
			this.flightStClassEmptySeatsLabel.TabIndex = 18;
			this.flightStClassEmptySeatsLabel.Text = "materialLabel10";
			// 
			// orderTicketButton
			// 
			this.orderTicketButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.orderTicketButton.AutoSize = false;
			this.orderTicketButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.orderTicketButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.orderTicketButton.Depth = 0;
			this.orderTicketButton.HighEmphasis = true;
			this.orderTicketButton.Icon = null;
			this.orderTicketButton.Location = new System.Drawing.Point(18, 445);
			this.orderTicketButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.orderTicketButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.orderTicketButton.Name = "orderTicketButton";
			this.orderTicketButton.Size = new System.Drawing.Size(252, 36);
			this.orderTicketButton.TabIndex = 17;
			this.orderTicketButton.Text = "Заказать билет";
			this.orderTicketButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.orderTicketButton.UseAccentColor = false;
			this.orderTicketButton.UseVisualStyleBackColor = true;
			// 
			// ticketPriceLabel
			// 
			this.ticketPriceLabel.AutoSize = true;
			this.ticketPriceLabel.Depth = 0;
			this.ticketPriceLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.ticketPriceLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			this.ticketPriceLabel.Location = new System.Drawing.Point(113, 367);
			this.ticketPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.ticketPriceLabel.Name = "ticketPriceLabel";
			this.ticketPriceLabel.Size = new System.Drawing.Size(56, 24);
			this.ticketPriceLabel.TabIndex = 16;
			this.ticketPriceLabel.Text = "15255";
			// 
			// materialLabel18
			// 
			this.materialLabel18.AutoSize = true;
			this.materialLabel18.Depth = 0;
			this.materialLabel18.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel18.Location = new System.Drawing.Point(17, 367);
			this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel18.Name = "materialLabel18";
			this.materialLabel18.Size = new System.Drawing.Size(90, 24);
			this.materialLabel18.TabIndex = 15;
			this.materialLabel18.Text = "К оплате:";
			// 
			// materialDivider2
			// 
			this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialDivider2.Depth = 0;
			this.materialDivider2.Location = new System.Drawing.Point(17, 357);
			this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialDivider2.Name = "materialDivider2";
			this.materialDivider2.Size = new System.Drawing.Size(253, 1);
			this.materialDivider2.TabIndex = 14;
			this.materialDivider2.Text = "materialDivider2";
			// 
			// materialRadioButton3
			// 
			this.materialRadioButton3.AutoSize = true;
			this.materialRadioButton3.Depth = 0;
			this.materialRadioButton3.Location = new System.Drawing.Point(14, 314);
			this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
			this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRadioButton3.Name = "materialRadioButton3";
			this.materialRadioButton3.Ripple = true;
			this.materialRadioButton3.Size = new System.Drawing.Size(93, 37);
			this.materialRadioButton3.TabIndex = 13;
			this.materialRadioButton3.TabStop = true;
			this.materialRadioButton3.Text = "Класс C";
			this.materialRadioButton3.UseVisualStyleBackColor = true;
			this.materialRadioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// materialRadioButton2
			// 
			this.materialRadioButton2.AutoSize = true;
			this.materialRadioButton2.Depth = 0;
			this.materialRadioButton2.Location = new System.Drawing.Point(14, 277);
			this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
			this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRadioButton2.Name = "materialRadioButton2";
			this.materialRadioButton2.Ripple = true;
			this.materialRadioButton2.Size = new System.Drawing.Size(93, 37);
			this.materialRadioButton2.TabIndex = 12;
			this.materialRadioButton2.TabStop = true;
			this.materialRadioButton2.Text = "Класс B";
			this.materialRadioButton2.UseVisualStyleBackColor = true;
			this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// materialRadioButton1
			// 
			this.materialRadioButton1.AutoSize = true;
			this.materialRadioButton1.Depth = 0;
			this.materialRadioButton1.Location = new System.Drawing.Point(14, 240);
			this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
			this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRadioButton1.Name = "materialRadioButton1";
			this.materialRadioButton1.Ripple = true;
			this.materialRadioButton1.Size = new System.Drawing.Size(93, 37);
			this.materialRadioButton1.TabIndex = 11;
			this.materialRadioButton1.TabStop = true;
			this.materialRadioButton1.Text = "Класс A";
			this.materialRadioButton1.UseVisualStyleBackColor = true;
			this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// materialLabel17
			// 
			this.materialLabel17.AutoSize = true;
			this.materialLabel17.Depth = 0;
			this.materialLabel17.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel17.Location = new System.Drawing.Point(17, 216);
			this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel17.Name = "materialLabel17";
			this.materialLabel17.Size = new System.Drawing.Size(138, 24);
			this.materialLabel17.TabIndex = 10;
			this.materialLabel17.Text = "Выбор класса:";
			// 
			// materialDivider1
			// 
			this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialDivider1.Depth = 0;
			this.materialDivider1.Location = new System.Drawing.Point(17, 207);
			this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialDivider1.Name = "materialDivider1";
			this.materialDivider1.Size = new System.Drawing.Size(253, 1);
			this.materialDivider1.TabIndex = 9;
			this.materialDivider1.Text = "materialDivider1";
			// 
			// flightArrivalDateLabel
			// 
			this.flightArrivalDateLabel.AutoSize = true;
			this.flightArrivalDateLabel.Depth = 0;
			this.flightArrivalDateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.flightArrivalDateLabel.Location = new System.Drawing.Point(18, 175);
			this.flightArrivalDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.flightArrivalDateLabel.Name = "flightArrivalDateLabel";
			this.flightArrivalDateLabel.Size = new System.Drawing.Size(116, 19);
			this.flightArrivalDateLabel.TabIndex = 8;
			this.flightArrivalDateLabel.Text = "materialLabel15";
			// 
			// materialLabel16
			// 
			this.materialLabel16.AutoSize = true;
			this.materialLabel16.Depth = 0;
			this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel16.Location = new System.Drawing.Point(18, 150);
			this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel16.Name = "materialLabel16";
			this.materialLabel16.Size = new System.Drawing.Size(185, 19);
			this.materialLabel16.TabIndex = 7;
			this.materialLabel16.Text = "Дата и время прибытия:";
			// 
			// flightDepartureDateLabel
			// 
			this.flightDepartureDateLabel.AutoSize = true;
			this.flightDepartureDateLabel.Depth = 0;
			this.flightDepartureDateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.flightDepartureDateLabel.Location = new System.Drawing.Point(18, 124);
			this.flightDepartureDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.flightDepartureDateLabel.Name = "flightDepartureDateLabel";
			this.flightDepartureDateLabel.Size = new System.Drawing.Size(116, 19);
			this.flightDepartureDateLabel.TabIndex = 6;
			this.flightDepartureDateLabel.Text = "materialLabel14";
			// 
			// materialLabel13
			// 
			this.materialLabel13.AutoSize = true;
			this.materialLabel13.Depth = 0;
			this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel13.Location = new System.Drawing.Point(18, 99);
			this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel13.Name = "materialLabel13";
			this.materialLabel13.Size = new System.Drawing.Size(208, 19);
			this.materialLabel13.TabIndex = 5;
			this.materialLabel13.Text = "Дата и время отправления:";
			// 
			// flightRouteLabel
			// 
			this.flightRouteLabel.AutoSize = true;
			this.flightRouteLabel.Depth = 0;
			this.flightRouteLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.flightRouteLabel.Location = new System.Drawing.Point(99, 74);
			this.flightRouteLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.flightRouteLabel.Name = "flightRouteLabel";
			this.flightRouteLabel.Size = new System.Drawing.Size(116, 19);
			this.flightRouteLabel.TabIndex = 4;
			this.flightRouteLabel.Text = "materialLabel12";
			// 
			// materialLabel11
			// 
			this.materialLabel11.AutoSize = true;
			this.materialLabel11.Depth = 0;
			this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel11.Location = new System.Drawing.Point(18, 74);
			this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel11.Name = "materialLabel11";
			this.materialLabel11.Size = new System.Drawing.Size(75, 19);
			this.materialLabel11.TabIndex = 3;
			this.materialLabel11.Text = "Маршрут:";
			// 
			// flightNumberLabel
			// 
			this.flightNumberLabel.AutoSize = true;
			this.flightNumberLabel.Depth = 0;
			this.flightNumberLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.flightNumberLabel.Location = new System.Drawing.Point(78, 49);
			this.flightNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.flightNumberLabel.Name = "flightNumberLabel";
			this.flightNumberLabel.Size = new System.Drawing.Size(116, 19);
			this.flightNumberLabel.TabIndex = 2;
			this.flightNumberLabel.Text = "materialLabel10";
			// 
			// materialLabel9
			// 
			this.materialLabel9.AutoSize = true;
			this.materialLabel9.Depth = 0;
			this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel9.Location = new System.Drawing.Point(18, 49);
			this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel9.Name = "materialLabel9";
			this.materialLabel9.Size = new System.Drawing.Size(54, 19);
			this.materialLabel9.TabIndex = 1;
			this.materialLabel9.Text = "Номер:";
			// 
			// materialLabel8
			// 
			this.materialLabel8.AutoSize = true;
			this.materialLabel8.Depth = 0;
			this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel8.Location = new System.Drawing.Point(17, 14);
			this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel8.Name = "materialLabel8";
			this.materialLabel8.Size = new System.Drawing.Size(203, 24);
			this.materialLabel8.TabIndex = 0;
			this.materialLabel8.Text = "Информация о рейсе:";
			// 
			// carouselCard
			// 
			this.carouselCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.carouselCard.Depth = 0;
			this.carouselCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.carouselCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.carouselCard.Location = new System.Drawing.Point(14, 14);
			this.carouselCard.Margin = new System.Windows.Forms.Padding(14);
			this.carouselCard.MouseState = MaterialSkin.MouseState.HOVER;
			this.carouselCard.Name = "carouselCard";
			this.carouselCard.Padding = new System.Windows.Forms.Padding(14);
			this.carouselCard.Size = new System.Drawing.Size(235, 501);
			this.carouselCard.TabIndex = 6;
			// 
			// mapTabPage
			// 
			this.mapTabPage.BackColor = System.Drawing.Color.White;
			this.mapTabPage.Controls.Add(this.materialCard2);
			this.mapTabPage.Controls.Add(this.materialLabel19);
			this.mapTabPage.Controls.Add(this.pictureBox8);
			this.mapTabPage.Controls.Add(this.pictureBox7);
			this.mapTabPage.Controls.Add(this.pictureBox6);
			this.mapTabPage.Controls.Add(this.pictureBox5);
			this.mapTabPage.Controls.Add(this.pictureBox4);
			this.mapTabPage.Controls.Add(this.pictureBox3);
			this.mapTabPage.Controls.Add(this.pictureBox1);
			this.mapTabPage.ImageKey = "map_icon.png";
			this.mapTabPage.Location = new System.Drawing.Point(4, 39);
			this.mapTabPage.Margin = new System.Windows.Forms.Padding(0);
			this.mapTabPage.Name = "mapTabPage";
			this.mapTabPage.Size = new System.Drawing.Size(1058, 535);
			this.mapTabPage.TabIndex = 0;
			this.mapTabPage.Text = "Карта";
			// 
			// actionIconsImageList
			// 
			this.actionIconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("actionIconsImageList.ImageStream")));
			this.actionIconsImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.actionIconsImageList.Images.SetKeyName(0, "add_icon.png");
			this.actionIconsImageList.Images.SetKeyName(1, "delete_icon.png");
			this.actionIconsImageList.Images.SetKeyName(2, "save_icon.png");
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// materialCard2
			// 
			this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard2.Controls.Add(this.pictureBox2);
			this.materialCard2.Controls.Add(this.materialLabel10);
			this.materialCard2.Controls.Add(this.materialLabel12);
			this.materialCard2.Controls.Add(this.materialLabel14);
			this.materialCard2.Controls.Add(this.materialLabel15);
			this.materialCard2.Depth = 0;
			this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard2.Location = new System.Drawing.Point(640, 61);
			this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
			this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard2.Name = "materialCard2";
			this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
			this.materialCard2.Size = new System.Drawing.Size(404, 460);
			this.materialCard2.TabIndex = 31;
			this.materialCard2.Visible = false;
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
			this.materialLabel10.Size = new System.Drawing.Size(81, 24);
			this.materialLabel10.TabIndex = 3;
			this.materialLabel10.Text = "Касса №";
			// 
			// materialLabel12
			// 
			this.materialLabel12.AutoSize = true;
			this.materialLabel12.Depth = 0;
			this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel12.Location = new System.Drawing.Point(104, 14);
			this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel12.Name = "materialLabel12";
			this.materialLabel12.Size = new System.Drawing.Size(34, 24);
			this.materialLabel12.TabIndex = 4;
			this.materialLabel12.Text = "777";
			// 
			// materialLabel14
			// 
			this.materialLabel14.AutoSize = true;
			this.materialLabel14.Depth = 0;
			this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel14.Location = new System.Drawing.Point(17, 324);
			this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel14.Name = "materialLabel14";
			this.materialLabel14.Size = new System.Drawing.Size(63, 24);
			this.materialLabel14.TabIndex = 5;
			this.materialLabel14.Text = "Адрес:";
			// 
			// materialLabel15
			// 
			this.materialLabel15.AutoSize = true;
			this.materialLabel15.Depth = 0;
			this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel15.Location = new System.Drawing.Point(17, 348);
			this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel15.Name = "materialLabel15";
			this.materialLabel15.Size = new System.Drawing.Size(156, 19);
			this.materialLabel15.TabIndex = 6;
			this.materialLabel15.Text = "ул. Карла Маркса 77";
			// 
			// materialLabel19
			// 
			this.materialLabel19.Depth = 0;
			this.materialLabel19.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel19.Location = new System.Drawing.Point(640, 8);
			this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel19.Name = "materialLabel19";
			this.materialLabel19.Size = new System.Drawing.Size(404, 51);
			this.materialLabel19.TabIndex = 30;
			this.materialLabel19.Text = "Выберите точку кассы на карте, чтобы узнать о ней подробнее";
			this.materialLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::AirTicketOffice.Properties.Resources._3_Post;
			this.pictureBox2.Location = new System.Drawing.Point(17, 41);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(370, 277);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox8.Image = global::AirTicketOffice.Properties.Resources.OfficePointSix;
			this.pictureBox8.Location = new System.Drawing.Point(476, 394);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(45, 45);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 29;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox7.Image = global::AirTicketOffice.Properties.Resources.OfficePointFive;
			this.pictureBox7.Location = new System.Drawing.Point(450, 223);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(45, 45);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 28;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox6.Image = global::AirTicketOffice.Properties.Resources.OfficePointFour;
			this.pictureBox6.Location = new System.Drawing.Point(361, 343);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(45, 45);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.Image = global::AirTicketOffice.Properties.Resources.OfficePointOne;
			this.pictureBox5.Location = new System.Drawing.Point(47, 205);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(45, 45);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 26;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Image = global::AirTicketOffice.Properties.Resources.OfficePointTwo;
			this.pictureBox4.Location = new System.Drawing.Point(268, 205);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(45, 45);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 25;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = global::AirTicketOffice.Properties.Resources.OfficePointThree;
			this.pictureBox3.Location = new System.Drawing.Point(173, 427);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(45, 45);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 24;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = global::AirTicketOffice.Properties.Resources.map;
			this.pictureBox1.ImageLocation = "";
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(8, 61);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(615, 460);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// PassengerMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 600);
			this.Controls.Add(this.mainTabControl);
			this.Controls.Add(this.statusStrip1);
			this.DrawerShowIconsWhenHidden = true;
			this.DrawerTabControl = this.mainTabControl;
			this.Name = "PassengerMainWindow";
			this.Padding = new System.Windows.Forms.Padding(0);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.PassengerMainWindow_Load);
			this.mainTabControl.ResumeLayout(false);
			this.profileTabPage.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.orderTabPage.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.dataGridViewCard.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
			this.propertiesCard.ResumeLayout(false);
			this.propertiesCard.PerformLayout();
			this.mapTabPage.ResumeLayout(false);
			this.materialCard2.ResumeLayout(false);
			this.materialCard2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ImageList mainTabControlImageList;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private MaterialSkin.Controls.MaterialTabControl mainTabControl;
		private System.Windows.Forms.TabPage mapTabPage;
		private ImageList actionIconsImageList;
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
		private TabPage orderTabPage;
		private TableLayoutPanel tableLayoutPanel2;
		private MaterialSkin.Controls.MaterialCard dataGridViewCard;
		private DataGridView flightsDataGridView;
		private MaterialSkin.Controls.MaterialCard propertiesCard;
		private DataGridViewTextBoxColumn flightsNumberColumn;
		private DataGridViewTextBoxColumn flightsPlaneColumn;
		private DataGridViewTextBoxColumn flightsRouteColumn;
		private DataGridViewTextBoxColumn flightsDateFromColumn;
		private DataGridViewTextBoxColumn flightsDateToColumn;
		private Timer timer1;
		private MaterialSkin.Controls.MaterialCard carouselCard;
		private MaterialSkin.Controls.MaterialButton orderTicketButton;
		private MaterialSkin.Controls.MaterialLabel ticketPriceLabel;
		private MaterialSkin.Controls.MaterialLabel materialLabel18;
		private MaterialSkin.Controls.MaterialDivider materialDivider2;
		private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
		private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
		private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
		private MaterialSkin.Controls.MaterialLabel materialLabel17;
		private MaterialSkin.Controls.MaterialDivider materialDivider1;
		private MaterialSkin.Controls.MaterialLabel flightArrivalDateLabel;
		private MaterialSkin.Controls.MaterialLabel materialLabel16;
		private MaterialSkin.Controls.MaterialLabel flightDepartureDateLabel;
		private MaterialSkin.Controls.MaterialLabel materialLabel13;
		private MaterialSkin.Controls.MaterialLabel flightRouteLabel;
		private MaterialSkin.Controls.MaterialLabel materialLabel11;
		private MaterialSkin.Controls.MaterialLabel flightNumberLabel;
		private MaterialSkin.Controls.MaterialLabel materialLabel9;
		private MaterialSkin.Controls.MaterialLabel materialLabel8;
		private MaterialSkin.Controls.MaterialLabel flightRdClassEmptySeatsLabel;
		private MaterialSkin.Controls.MaterialLabel flightNdClassEmptySeatsLabel;
		private MaterialSkin.Controls.MaterialLabel flightStClassEmptySeatsLabel;
		private MaterialSkin.Controls.MaterialCard materialCard2;
		private PictureBox pictureBox2;
		private MaterialSkin.Controls.MaterialLabel materialLabel10;
		private MaterialSkin.Controls.MaterialLabel materialLabel12;
		private MaterialSkin.Controls.MaterialLabel materialLabel14;
		private MaterialSkin.Controls.MaterialLabel materialLabel15;
		private MaterialSkin.Controls.MaterialLabel materialLabel19;
		private PictureBox pictureBox8;
		private PictureBox pictureBox7;
		private PictureBox pictureBox6;
		private PictureBox pictureBox5;
		private PictureBox pictureBox4;
		private PictureBox pictureBox3;
		private PictureBox pictureBox1;
	}
}

