
namespace AirTicketOffice
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.userInfoToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitFromProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripMenu,
            this.searchToolStripTextBox});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 41);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// userInfoToolStripMenu
			// 
			this.userInfoToolStripMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.userInfoToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.editProfileToolStripMenuItem,
            this.exitFromProfileToolStripMenuItem});
			this.userInfoToolStripMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userInfoToolStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("userInfoToolStripMenu.Image")));
			this.userInfoToolStripMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.userInfoToolStripMenu.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.userInfoToolStripMenu.Name = "userInfoToolStripMenu";
			this.userInfoToolStripMenu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.userInfoToolStripMenu.Size = new System.Drawing.Size(94, 27);
			this.userInfoToolStripMenu.Text = "myLogin";
			this.userInfoToolStripMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// myProfileToolStripMenuItem
			// 
			this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
			this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.myProfileToolStripMenuItem.Text = "Мой профиль";
			// 
			// editProfileToolStripMenuItem
			// 
			this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
			this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.editProfileToolStripMenuItem.Text = "Редактировать профиль";
			// 
			// exitFromProfileToolStripMenuItem
			// 
			this.exitFromProfileToolStripMenuItem.Name = "exitFromProfileToolStripMenuItem";
			this.exitFromProfileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.exitFromProfileToolStripMenuItem.Text = "Выйти из профиля";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// searchToolStripTextBox
			// 
			this.searchToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.searchToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.searchToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.searchToolStripTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.searchToolStripTextBox.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
			this.searchToolStripTextBox.Name = "searchToolStripTextBox";
			this.searchToolStripTextBox.Size = new System.Drawing.Size(150, 27);
			this.searchToolStripTextBox.Text = "Поиск...";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(0, 41);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 387);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(792, 357);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 26);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 357);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainWindow";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenu;
		private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitFromProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox searchToolStripTextBox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
	}
}