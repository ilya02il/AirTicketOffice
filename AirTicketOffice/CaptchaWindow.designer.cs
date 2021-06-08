
namespace AirTicketOffice
{
	partial class CaptchaWindow
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
			this.captchaLabel = new MaterialSkin.Controls.MaterialLabel();
			this.captchaTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.acceptButton = new MaterialSkin.Controls.MaterialButton();
			this.captchaPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// captchaLabel
			// 
			this.captchaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.captchaLabel.AutoSize = true;
			this.captchaLabel.Depth = 0;
			this.captchaLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.captchaLabel.Location = new System.Drawing.Point(20, 195);
			this.captchaLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.captchaLabel.Name = "captchaLabel";
			this.captchaLabel.Size = new System.Drawing.Size(93, 19);
			this.captchaLabel.TabIndex = 1;
			this.captchaLabel.Text = "Текст капчи";
			// 
			// captchaTextBox
			// 
			this.captchaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.captchaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.captchaTextBox.Depth = 0;
			this.captchaTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.captchaTextBox.LeadingIcon = null;
			this.captchaTextBox.Location = new System.Drawing.Point(20, 225);
			this.captchaTextBox.MaxLength = 50;
			this.captchaTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.captchaTextBox.Multiline = false;
			this.captchaTextBox.Name = "captchaTextBox";
			this.captchaTextBox.Size = new System.Drawing.Size(310, 50);
			this.captchaTextBox.TabIndex = 2;
			this.captchaTextBox.Text = "";
			this.captchaTextBox.TrailingIcon = null;
			// 
			// acceptButton
			// 
			this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.acceptButton.AutoSize = false;
			this.acceptButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.acceptButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.acceptButton.Depth = 0;
			this.acceptButton.HighEmphasis = true;
			this.acceptButton.Icon = null;
			this.acceptButton.Location = new System.Drawing.Point(145, 290);
			this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.acceptButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(64, 36);
			this.acceptButton.TabIndex = 3;
			this.acceptButton.Text = "OK";
			this.acceptButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.acceptButton.UseAccentColor = false;
			this.acceptButton.UseVisualStyleBackColor = true;
			// 
			// captchaPictureBox
			// 
			this.captchaPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.captchaPictureBox.Location = new System.Drawing.Point(20, 80);
			this.captchaPictureBox.Name = "captchaPictureBox";
			this.captchaPictureBox.Size = new System.Drawing.Size(310, 100);
			this.captchaPictureBox.TabIndex = 0;
			this.captchaPictureBox.TabStop = false;
			// 
			// CaptchaWindow
			// 
			this.AcceptButton = this.acceptButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 350);
			this.Controls.Add(this.acceptButton);
			this.Controls.Add(this.captchaTextBox);
			this.Controls.Add(this.captchaLabel);
			this.Controls.Add(this.captchaPictureBox);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(350, 350);
			this.MinimumSize = new System.Drawing.Size(350, 350);
			this.Name = "CaptchaWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "reCAPTCHA";
			((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox captchaPictureBox;
		private MaterialSkin.Controls.MaterialLabel captchaLabel;
		private MaterialSkin.Controls.MaterialTextBox captchaTextBox;
		private MaterialSkin.Controls.MaterialButton acceptButton;
	}
}