namespace FacebookAppUI
{
    partial class GenderFilterForm
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
            this.femaleButton = new System.Windows.Forms.Button();
            this.maleButton = new System.Windows.Forms.Button();
            this.otherButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterFriendsListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // femaleButton
            // 
            this.femaleButton.BackColor = System.Drawing.Color.Navy;
            this.femaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.femaleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.femaleButton.Location = new System.Drawing.Point(3, 3);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(109, 48);
            this.femaleButton.TabIndex = 0;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = false;
            this.femaleButton.Click += new System.EventHandler(this.femaleButton_Click);
            // 
            // maleButton
            // 
            this.maleButton.BackColor = System.Drawing.Color.Navy;
            this.maleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.maleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maleButton.Location = new System.Drawing.Point(118, 3);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(109, 48);
            this.maleButton.TabIndex = 1;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = false;
            this.maleButton.Click += new System.EventHandler(this.maleButton_Click_1);
            // 
            // otherButton
            // 
            this.otherButton.BackColor = System.Drawing.Color.Navy;
            this.otherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.otherButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.otherButton.Location = new System.Drawing.Point(233, 3);
            this.otherButton.Name = "otherButton";
            this.otherButton.Size = new System.Drawing.Size(112, 48);
            this.otherButton.TabIndex = 2;
            this.otherButton.Text = "Other";
            this.otherButton.UseVisualStyleBackColor = false;
            this.otherButton.Click += new System.EventHandler(this.otherButton_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.femaleButton);
            this.panel1.Controls.Add(this.otherButton);
            this.panel1.Controls.Add(this.filterFriendsListBox);
            this.panel1.Controls.Add(this.maleButton);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 332);
            this.panel1.TabIndex = 3;
            // 
            // filterFriendsListBox
            // 
            this.filterFriendsListBox.FormattingEnabled = true;
            this.filterFriendsListBox.ItemHeight = 20;
            this.filterFriendsListBox.Location = new System.Drawing.Point(3, 57);
            this.filterFriendsListBox.Name = "filterFriendsListBox";
            this.filterFriendsListBox.Size = new System.Drawing.Size(342, 264);
            this.filterFriendsListBox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 46);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacebookAppUI.Properties.Resources.facebookLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // GenderFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenderFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gender filter";
            this.Load += new System.EventHandler(this.GenderFilterForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button femaleButton;
        private System.Windows.Forms.Button maleButton;
        private System.Windows.Forms.Button otherButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox filterFriendsListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}