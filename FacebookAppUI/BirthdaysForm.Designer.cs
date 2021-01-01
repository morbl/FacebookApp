namespace FacebookAppUI
{
    partial class BirthdaysForm
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
            this.birthdaysFriendListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // birthdaysFriendListBox
            // 
            this.birthdaysFriendListBox.FormattingEnabled = true;
            this.birthdaysFriendListBox.ItemHeight = 20;
            this.birthdaysFriendListBox.Location = new System.Drawing.Point(1, 2);
            this.birthdaysFriendListBox.Name = "birthdaysFriendListBox";
            this.birthdaysFriendListBox.Size = new System.Drawing.Size(243, 444);
            this.birthdaysFriendListBox.TabIndex = 0;
            // 
            // BirthdaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 448);
            this.Controls.Add(this.birthdaysFriendListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BirthdaysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "My friends\' birthdays";
            this.Load += new System.EventHandler(this.BirthdaysForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox birthdaysFriendListBox;
    }
}