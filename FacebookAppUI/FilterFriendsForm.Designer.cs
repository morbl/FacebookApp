namespace FacebookAppUI
{
    partial class FilterFriendsForm
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
            this.headerFriendsPanel = new System.Windows.Forms.Panel();
            this.facebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.genderFilterButton = new System.Windows.Forms.Button();
            this.cityFilterButton = new System.Windows.Forms.Button();
            this.birthdayFilterButton = new System.Windows.Forms.Button();
            this.filterFriendOptionsPanel = new System.Windows.Forms.Panel();
            this.friendBannerPictureBox = new System.Windows.Forms.PictureBox();
            this.filterFriendsLabel = new System.Windows.Forms.Label();
            this.headerFriendsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).BeginInit();
            this.filterFriendOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendBannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerFriendsPanel
            // 
            this.headerFriendsPanel.BackColor = System.Drawing.Color.Navy;
            this.headerFriendsPanel.Controls.Add(this.facebookLogoPictureBox);
            this.headerFriendsPanel.Location = new System.Drawing.Point(0, 0);
            this.headerFriendsPanel.Name = "headerFriendsPanel";
            this.headerFriendsPanel.Size = new System.Drawing.Size(600, 55);
            this.headerFriendsPanel.TabIndex = 0;
            // 
            // facebookLogoPictureBox
            // 
            this.facebookLogoPictureBox.Image = global::FacebookAppUI.Properties.Resources.facebookLogo;
            this.facebookLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.facebookLogoPictureBox.Name = "facebookLogoPictureBox";
            this.facebookLogoPictureBox.Size = new System.Drawing.Size(202, 54);
            this.facebookLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookLogoPictureBox.TabIndex = 0;
            this.facebookLogoPictureBox.TabStop = false;
            // 
            // genderFilterButton
            // 
            this.genderFilterButton.BackColor = System.Drawing.Color.Navy;
            this.genderFilterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genderFilterButton.Location = new System.Drawing.Point(0, 124);
            this.genderFilterButton.Name = "genderFilterButton";
            this.genderFilterButton.Size = new System.Drawing.Size(186, 74);
            this.genderFilterButton.TabIndex = 1;
            this.genderFilterButton.Text = "Gender";
            this.genderFilterButton.UseVisualStyleBackColor = false;
            this.genderFilterButton.Click += new System.EventHandler(this.genderFilterButton_Click);
            // 
            // cityFilterButton
            // 
            this.cityFilterButton.BackColor = System.Drawing.Color.Navy;
            this.cityFilterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cityFilterButton.Location = new System.Drawing.Point(192, 124);
            this.cityFilterButton.Name = "cityFilterButton";
            this.cityFilterButton.Size = new System.Drawing.Size(189, 74);
            this.cityFilterButton.TabIndex = 2;
            this.cityFilterButton.Text = "City";
            this.cityFilterButton.UseVisualStyleBackColor = false;
            this.cityFilterButton.Click += new System.EventHandler(this.cityFilterButton_Click);
            // 
            // birthdayFilterButton
            // 
            this.birthdayFilterButton.BackColor = System.Drawing.Color.Navy;
            this.birthdayFilterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthdayFilterButton.Location = new System.Drawing.Point(385, 124);
            this.birthdayFilterButton.Name = "birthdayFilterButton";
            this.birthdayFilterButton.Size = new System.Drawing.Size(184, 74);
            this.birthdayFilterButton.TabIndex = 3;
            this.birthdayFilterButton.Text = "Birthday";
            this.birthdayFilterButton.UseVisualStyleBackColor = false;
            this.birthdayFilterButton.Click += new System.EventHandler(this.birthdayFilterButton_Click);
            // 
            // filterFriendOptionsPanel
            // 
            this.filterFriendOptionsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filterFriendOptionsPanel.Controls.Add(this.friendBannerPictureBox);
            this.filterFriendOptionsPanel.Controls.Add(this.filterFriendsLabel);
            this.filterFriendOptionsPanel.Controls.Add(this.genderFilterButton);
            this.filterFriendOptionsPanel.Controls.Add(this.cityFilterButton);
            this.filterFriendOptionsPanel.Controls.Add(this.birthdayFilterButton);
            this.filterFriendOptionsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.filterFriendOptionsPanel.Location = new System.Drawing.Point(12, 71);
            this.filterFriendOptionsPanel.Name = "filterFriendOptionsPanel";
            this.filterFriendOptionsPanel.Size = new System.Drawing.Size(572, 220);
            this.filterFriendOptionsPanel.TabIndex = 4;
            // 
            // friendBannerPictureBox
            // 
            this.friendBannerPictureBox.Image = global::FacebookAppUI.Properties.Resources.friendsBanner;
            this.friendBannerPictureBox.Location = new System.Drawing.Point(-2, 0);
            this.friendBannerPictureBox.Name = "friendBannerPictureBox";
            this.friendBannerPictureBox.Size = new System.Drawing.Size(574, 69);
            this.friendBannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendBannerPictureBox.TabIndex = 6;
            this.friendBannerPictureBox.TabStop = false;
            // 
            // filterFriendsLabel
            // 
            this.filterFriendsLabel.AutoSize = true;
            this.filterFriendsLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFriendsLabel.Location = new System.Drawing.Point(3, 82);
            this.filterFriendsLabel.Name = "filterFriendsLabel";
            this.filterFriendsLabel.Size = new System.Drawing.Size(260, 27);
            this.filterFriendsLabel.TabIndex = 5;
            this.filterFriendsLabel.Text = "please choose a filter:";
            // 
            // FilterFriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 305);
            this.Controls.Add(this.filterFriendOptionsPanel);
            this.Controls.Add(this.headerFriendsPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterFriendsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter friends";
            this.Load += new System.EventHandler(this.FilterFriendsForm_Load);
            this.headerFriendsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).EndInit();
            this.filterFriendOptionsPanel.ResumeLayout(false);
            this.filterFriendOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendBannerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerFriendsPanel;
        private System.Windows.Forms.PictureBox facebookLogoPictureBox;
        private System.Windows.Forms.Button genderFilterButton;
        private System.Windows.Forms.Button cityFilterButton;
        private System.Windows.Forms.Button birthdayFilterButton;
        private System.Windows.Forms.Panel filterFriendOptionsPanel;
        private System.Windows.Forms.Label filterFriendsLabel;
        private System.Windows.Forms.PictureBox friendBannerPictureBox;
    }
}