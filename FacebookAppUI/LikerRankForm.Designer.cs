namespace FacebookAppUI
{
    partial class LikerRankForm
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
            this.topHeaderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.facebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.likersListPanel = new System.Windows.Forms.Panel();
            this.likersListLabel = new System.Windows.Forms.Label();
            this.likersListBox = new System.Windows.Forms.ListBox();
            this.thankYouLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tagsRankLabel = new System.Windows.Forms.Label();
            this.tagsRankListBox = new System.Windows.Forms.ListBox();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.sendTagsButton = new System.Windows.Forms.Button();
            this.topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).BeginInit();
            this.likersListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topHeaderPanel
            // 
            this.topHeaderPanel.BackColor = System.Drawing.Color.Navy;
            this.topHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topHeaderPanel.Controls.Add(this.facebookLogoPictureBox);
            this.topHeaderPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.topHeaderPanel.Location = new System.Drawing.Point(0, 1);
            this.topHeaderPanel.Name = "topHeaderPanel";
            this.topHeaderPanel.Size = new System.Drawing.Size(686, 56);
            this.topHeaderPanel.TabIndex = 14;
            // 
            // facebookLogoPictureBox
            // 
            this.facebookLogoPictureBox.Image = global::FacebookAppUI.Properties.Resources.facebookLogo;
            this.facebookLogoPictureBox.InitialImage = global::FacebookAppUI.Properties.Resources.facebookLogo2;
            this.facebookLogoPictureBox.Location = new System.Drawing.Point(3, -13);
            this.facebookLogoPictureBox.Name = "facebookLogoPictureBox";
            this.facebookLogoPictureBox.Size = new System.Drawing.Size(190, 62);
            this.facebookLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookLogoPictureBox.TabIndex = 14;
            this.facebookLogoPictureBox.TabStop = false;
            // 
            // likersListPanel
            // 
            this.likersListPanel.BackColor = System.Drawing.SystemColors.Control;
            this.likersListPanel.Controls.Add(this.sendTagsButton);
            this.likersListPanel.Controls.Add(this.tagsLabel);
            this.likersListPanel.Controls.Add(this.tagsRankListBox);
            this.likersListPanel.Controls.Add(this.tagsRankLabel);
            this.likersListPanel.Controls.Add(this.likersListLabel);
            this.likersListPanel.Controls.Add(this.likersListBox);
            this.likersListPanel.Controls.Add(this.thankYouLabel);
            this.likersListPanel.Controls.Add(this.sendButton);
            this.likersListPanel.Location = new System.Drawing.Point(0, 58);
            this.likersListPanel.Name = "likersListPanel";
            this.likersListPanel.Size = new System.Drawing.Size(686, 351);
            this.likersListPanel.TabIndex = 15;
            // 
            // likersListLabel
            // 
            this.likersListLabel.AutoSize = true;
            this.likersListLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likersListLabel.Location = new System.Drawing.Point(3, 9);
            this.likersListLabel.Name = "likersListLabel";
            this.likersListLabel.Size = new System.Drawing.Size(197, 27);
            this.likersListLabel.TabIndex = 4;
            this.likersListLabel.Text = "Likers rank list:";
            // 
            // likersListBox
            // 
            this.likersListBox.FormattingEnabled = true;
            this.likersListBox.ItemHeight = 20;
            this.likersListBox.Location = new System.Drawing.Point(0, 59);
            this.likersListBox.Name = "likersListBox";
            this.likersListBox.Size = new System.Drawing.Size(311, 184);
            this.likersListBox.TabIndex = 3;
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.AutoSize = true;
            this.thankYouLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLabel.Location = new System.Drawing.Point(4, 266);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Size = new System.Drawing.Size(227, 69);
            this.thankYouLabel.TabIndex = 0;
            this.thankYouLabel.Text = "Do you want to send\r\nthank you to \r\nyour biggest fan?";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Navy;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sendButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendButton.Location = new System.Drawing.Point(226, 289);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(85, 53);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacebookAppUI.Properties.Resources.likeBanner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tagsRankLabel
            // 
            this.tagsRankLabel.AutoSize = true;
            this.tagsRankLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsRankLabel.Location = new System.Drawing.Point(361, 9);
            this.tagsRankLabel.Name = "tagsRankLabel";
            this.tagsRankLabel.Size = new System.Drawing.Size(178, 27);
            this.tagsRankLabel.TabIndex = 5;
            this.tagsRankLabel.Text = "Tags rank list:";
            // 
            // tagsRankListBox
            // 
            this.tagsRankListBox.FormattingEnabled = true;
            this.tagsRankListBox.ItemHeight = 20;
            this.tagsRankListBox.Location = new System.Drawing.Point(357, 59);
            this.tagsRankListBox.Name = "tagsRankListBox";
            this.tagsRankListBox.Size = new System.Drawing.Size(307, 184);
            this.tagsRankListBox.TabIndex = 6;
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsLabel.Location = new System.Drawing.Point(346, 266);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(227, 69);
            this.tagsLabel.TabIndex = 7;
            this.tagsLabel.Text = "Do you want to send\r\nI love you to your \r\nmost tagged friend?";
            // 
            // sendTagsButton
            // 
            this.sendTagsButton.BackColor = System.Drawing.Color.Navy;
            this.sendTagsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sendTagsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendTagsButton.Location = new System.Drawing.Point(579, 289);
            this.sendTagsButton.Name = "sendTagsButton";
            this.sendTagsButton.Size = new System.Drawing.Size(85, 53);
            this.sendTagsButton.TabIndex = 8;
            this.sendTagsButton.Text = "Send";
            this.sendTagsButton.UseVisualStyleBackColor = false;
            this.sendTagsButton.Click += new System.EventHandler(this.sendTagsButton_Click);
            // 
            // LikerRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.likersListPanel);
            this.Controls.Add(this.topHeaderPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LikerRankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liker rank";
            this.Load += new System.EventHandler(this.LikerRankForm_Load);
            this.topHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).EndInit();
            this.likersListPanel.ResumeLayout(false);
            this.likersListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel topHeaderPanel;
        private System.Windows.Forms.PictureBox facebookLogoPictureBox;
        private System.Windows.Forms.Panel likersListPanel;
        private System.Windows.Forms.Label likersListLabel;
        private System.Windows.Forms.ListBox likersListBox;
        private System.Windows.Forms.Label thankYouLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sendTagsButton;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.ListBox tagsRankListBox;
        private System.Windows.Forms.Label tagsRankLabel;
    }
}