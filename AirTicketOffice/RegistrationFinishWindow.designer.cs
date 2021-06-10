
namespace AirTicketOffice
{
    partial class RegistrationFinishWindow
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
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.continueButton = new MaterialSkin.Controls.MaterialButton();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.SuspendLayout();
			// 
			// materialLabel2
			// 
			this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
			this.materialLabel2.Location = new System.Drawing.Point(54, 139);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(343, 19);
			this.materialLabel2.TabIndex = 35;
			this.materialLabel2.Text = "Теперь Вы можете использовать,  введенные";
			this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
			this.materialLabel1.Location = new System.Drawing.Point(169, 95);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(105, 29);
			this.materialLabel1.TabIndex = 36;
			this.materialLabel1.Text = "Отлично!";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// continueButton
			// 
			this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.continueButton.AutoSize = false;
			this.continueButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.continueButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.continueButton.Depth = 0;
			this.continueButton.HighEmphasis = true;
			this.continueButton.Icon = null;
			this.continueButton.Location = new System.Drawing.Point(41, 229);
			this.continueButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.continueButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.continueButton.Name = "continueButton";
			this.continueButton.Size = new System.Drawing.Size(366, 42);
			this.continueButton.TabIndex = 29;
			this.continueButton.Text = "Войти в аккаунт";
			this.continueButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.continueButton.UseAccentColor = false;
			this.continueButton.UseVisualStyleBackColor = true;
			// 
			// materialLabel3
			// 
			this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel3.Location = new System.Drawing.Point(93, 162);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(267, 19);
			this.materialLabel3.TabIndex = 37;
			this.materialLabel3.Text = "ранее, данные для входа в систему";
			// 
			// RegistrationFinishWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 313);
			this.Controls.Add(this.materialLabel3);
			this.Controls.Add(this.materialLabel2);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.continueButton);
			this.Name = "RegistrationFinishWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Завершение регистрации";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton continueButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}