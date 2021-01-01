namespace FacebookAppUI
{
    partial class FacebookAppForm
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
            this.pictureUserBox = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.myPgeButton = new System.Windows.Forms.Button();
            this.birthdayButton = new System.Windows.Forms.Button();
            this.likersRankButton = new System.Windows.Forms.Button();
            this.filterFriendButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.menuOptionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.logOutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topHeaderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.facebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.optionsTab = new System.Windows.Forms.TabControl();
            this.pagesTab = new System.Windows.Forms.TabPage();
            this.pagesTabListBox = new System.Windows.Forms.ListBox();
            this.newsFeedTab = new System.Windows.Forms.TabPage();
            this.newsFeedTabListBox = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserBox)).BeginInit();
            this.menuOptionsPanel.SuspendLayout();
            this.logOutPanel.SuspendLayout();
            this.topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).BeginInit();
            this.optionsTab.SuspendLayout();
            this.pagesTab.SuspendLayout();
            this.newsFeedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureUserBox
            // 
            this.pictureUserBox.Location = new System.Drawing.Point(12, 77);
            this.pictureUserBox.Name = "pictureUserBox";
            this.pictureUserBox.Size = new System.Drawing.Size(126, 112);
            this.pictureUserBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUserBox.TabIndex = 0;
            this.pictureUserBox.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(144, 123);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(51, 20);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "label1";
            // 
            // myPgeButton
            // 
            this.myPgeButton.BackColor = System.Drawing.Color.Navy;
            this.myPgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.myPgeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.myPgeButton.Location = new System.Drawing.Point(3, 3);
            this.myPgeButton.Name = "myPgeButton";
            this.myPgeButton.Size = new System.Drawing.Size(207, 66);
            this.myPgeButton.TabIndex = 2;
            this.myPgeButton.Text = "My page";
            this.myPgeButton.UseVisualStyleBackColor = false;
            this.myPgeButton.Click += new System.EventHandler(this.myProfileButton_Click);
            // 
            // birthdayButton
            // 
            this.birthdayButton.BackColor = System.Drawing.Color.Navy;
            this.birthdayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.birthdayButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthdayButton.Location = new System.Drawing.Point(3, 75);
            this.birthdayButton.Name = "birthdayButton";
            this.birthdayButton.Size = new System.Drawing.Size(207, 66);
            this.birthdayButton.TabIndex = 3;
            this.birthdayButton.Text = "My friendes\' birthdays";
            this.birthdayButton.UseVisualStyleBackColor = false;
            this.birthdayButton.Click += new System.EventHandler(this.birthdayButton_Click);
            // 
            // likersRankButton
            // 
            this.likersRankButton.BackColor = System.Drawing.Color.Navy;
            this.likersRankButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likersRankButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likersRankButton.Location = new System.Drawing.Point(3, 147);
            this.likersRankButton.Name = "likersRankButton";
            this.likersRankButton.Size = new System.Drawing.Size(207, 67);
            this.likersRankButton.TabIndex = 4;
            this.likersRankButton.Text = "Likers rank";
            this.likersRankButton.UseVisualStyleBackColor = false;
            this.likersRankButton.Click += new System.EventHandler(this.likersRankButton_Click);
            // 
            // filterFriendButton
            // 
            this.filterFriendButton.BackColor = System.Drawing.Color.Navy;
            this.filterFriendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.filterFriendButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterFriendButton.Location = new System.Drawing.Point(3, 220);
            this.filterFriendButton.Name = "filterFriendButton";
            this.filterFriendButton.Size = new System.Drawing.Size(207, 68);
            this.filterFriendButton.TabIndex = 5;
            this.filterFriendButton.Text = "Filter friends";
            this.filterFriendButton.UseVisualStyleBackColor = false;
            this.filterFriendButton.Click += new System.EventHandler(this.filterFriendButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Navy;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logOutButton.ForeColor = System.Drawing.Color.Snow;
            this.logOutButton.Location = new System.Drawing.Point(3, 3);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(95, 63);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // menuOptionsPanel
            // 
            this.menuOptionsPanel.Controls.Add(this.myPgeButton);
            this.menuOptionsPanel.Controls.Add(this.birthdayButton);
            this.menuOptionsPanel.Controls.Add(this.likersRankButton);
            this.menuOptionsPanel.Controls.Add(this.filterFriendButton);
            this.menuOptionsPanel.Location = new System.Drawing.Point(12, 211);
            this.menuOptionsPanel.Name = "menuOptionsPanel";
            this.menuOptionsPanel.Size = new System.Drawing.Size(210, 298);
            this.menuOptionsPanel.TabIndex = 12;
            // 
            // logOutPanel
            // 
            this.logOutPanel.Controls.Add(this.logOutButton);
            this.logOutPanel.Location = new System.Drawing.Point(572, 504);
            this.logOutPanel.Name = "logOutPanel";
            this.logOutPanel.Size = new System.Drawing.Size(98, 66);
            this.logOutPanel.TabIndex = 0;
            // 
            // topHeaderPanel
            // 
            this.topHeaderPanel.BackColor = System.Drawing.Color.Navy;
            this.topHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topHeaderPanel.Controls.Add(this.facebookLogoPictureBox);
            this.topHeaderPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.topHeaderPanel.Location = new System.Drawing.Point(-2, 0);
            this.topHeaderPanel.Name = "topHeaderPanel";
            this.topHeaderPanel.Size = new System.Drawing.Size(684, 71);
            this.topHeaderPanel.TabIndex = 13;
            // 
            // facebookLogoPictureBox
            // 
            this.facebookLogoPictureBox.Image = global::FacebookAppUI.Properties.Resources.facebookLogo;
            this.facebookLogoPictureBox.InitialImage = global::FacebookAppUI.Properties.Resources.facebookLogo2;
            this.facebookLogoPictureBox.Location = new System.Drawing.Point(3, -12);
            this.facebookLogoPictureBox.Name = "facebookLogoPictureBox";
            this.facebookLogoPictureBox.Size = new System.Drawing.Size(219, 76);
            this.facebookLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookLogoPictureBox.TabIndex = 14;
            this.facebookLogoPictureBox.TabStop = false;
            // 
            // optionsTab
            // 
            this.optionsTab.Controls.Add(this.pagesTab);
            this.optionsTab.Controls.Add(this.newsFeedTab);
            this.optionsTab.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsTab.Location = new System.Drawing.Point(242, 85);
            this.optionsTab.Name = "optionsTab";
            this.optionsTab.SelectedIndex = 0;
            this.optionsTab.Size = new System.Drawing.Size(428, 404);
            this.optionsTab.TabIndex = 14;
            // 
            // pagesTab
            // 
            this.pagesTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pagesTab.Controls.Add(this.pagesTabListBox);
            this.pagesTab.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagesTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pagesTab.Location = new System.Drawing.Point(4, 36);
            this.pagesTab.Name = "pagesTab";
            this.pagesTab.Padding = new System.Windows.Forms.Padding(3);
            this.pagesTab.Size = new System.Drawing.Size(420, 364);
            this.pagesTab.TabIndex = 0;
            this.pagesTab.Text = "Pages";
            // 
            // pagesTabListBox
            // 
            this.pagesTabListBox.DataSource = this.pageBindingSource;
            this.pagesTabListBox.DisplayMember = "Name";
            this.pagesTabListBox.FormattingEnabled = true;
            this.pagesTabListBox.ItemHeight = 24;
            this.pagesTabListBox.Location = new System.Drawing.Point(6, 1);
            this.pagesTabListBox.Name = "pagesTabListBox";
            this.pagesTabListBox.Size = new System.Drawing.Size(397, 364);
            this.pagesTabListBox.TabIndex = 15;
            this.pagesTabListBox.ValueMember = "AccessToken";
            // 
            // newsFeedTab
            // 
            this.newsFeedTab.Controls.Add(this.newsFeedTabListBox);
            this.newsFeedTab.Location = new System.Drawing.Point(4, 36);
            this.newsFeedTab.Name = "newsFeedTab";
            this.newsFeedTab.Padding = new System.Windows.Forms.Padding(3);
            this.newsFeedTab.Size = new System.Drawing.Size(420, 364);
            this.newsFeedTab.TabIndex = 1;
            this.newsFeedTab.Text = "News feed";
            this.newsFeedTab.UseVisualStyleBackColor = true;
            // 
            // newsFeedTabListBox
            // 
            this.newsFeedTabListBox.DataSource = this.postBindingSource;
            this.newsFeedTabListBox.DisplayMember = "Message";
            this.newsFeedTabListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsFeedTabListBox.FormattingEnabled = true;
            this.newsFeedTabListBox.ItemHeight = 20;
            this.newsFeedTabListBox.Location = new System.Drawing.Point(5, 9);
            this.newsFeedTabListBox.Name = "newsFeedTabListBox";
            this.newsFeedTabListBox.Size = new System.Drawing.Size(409, 344);
            this.newsFeedTabListBox.TabIndex = 16;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // FacebookAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 569);
            this.Controls.Add(this.pictureUserBox);
            this.Controls.Add(this.optionsTab);
            this.Controls.Add(this.topHeaderPanel);
            this.Controls.Add(this.logOutPanel);
            this.Controls.Add(this.menuOptionsPanel);
            this.Controls.Add(this.userNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FacebookAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook feed";
            this.Load += new System.EventHandler(this.FacebookAppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserBox)).EndInit();
            this.menuOptionsPanel.ResumeLayout(false);
            this.logOutPanel.ResumeLayout(false);
            this.topHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).EndInit();
            this.optionsTab.ResumeLayout(false);
            this.pagesTab.ResumeLayout(false);
            this.newsFeedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureUserBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button myPgeButton;
        private System.Windows.Forms.Button birthdayButton;
        private System.Windows.Forms.Button likersRankButton;
        private System.Windows.Forms.Button filterFriendButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.FlowLayoutPanel menuOptionsPanel;
        private System.Windows.Forms.FlowLayoutPanel logOutPanel;
        private System.Windows.Forms.FlowLayoutPanel topHeaderPanel;
        private System.Windows.Forms.PictureBox facebookLogoPictureBox;
        private System.Windows.Forms.TabControl optionsTab;
        private System.Windows.Forms.TabPage pagesTab;
        private System.Windows.Forms.TabPage newsFeedTab;
        private System.Windows.Forms.ListBox pagesTabListBox;
        private System.Windows.Forms.ListBox newsFeedTabListBox;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.BindingSource postBindingSource;
    }
}