namespace FacebookAppUI
{
    partial class BirthYearFilterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fiterByBirthYearListBox = new System.Windows.Forms.ListBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.birthYearTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.hidePanel = new System.Windows.Forms.Panel();
            this.facebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.hidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fiterByBirthYearListBox);
            this.panel1.Controls.Add(this.textLabel);
            this.panel1.Controls.Add(this.birthYearTextBox);
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Location = new System.Drawing.Point(-2, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 318);
            this.panel1.TabIndex = 5;
            // 
            // fiterByBirthYearListBox
            // 
            this.fiterByBirthYearListBox.FormattingEnabled = true;
            this.fiterByBirthYearListBox.ItemHeight = 20;
            this.fiterByBirthYearListBox.Location = new System.Drawing.Point(111, 123);
            this.fiterByBirthYearListBox.Name = "fiterByBirthYearListBox";
            this.fiterByBirthYearListBox.Size = new System.Drawing.Size(246, 184);
            this.fiterByBirthYearListBox.TabIndex = 3;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(3, 10);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(445, 23);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "please write the year of birth to filter by:";
            // 
            // birthYearTextBox
            // 
            this.birthYearTextBox.Location = new System.Drawing.Point(81, 56);
            this.birthYearTextBox.Multiline = true;
            this.birthYearTextBox.Name = "birthYearTextBox";
            this.birthYearTextBox.Size = new System.Drawing.Size(186, 45);
            this.birthYearTextBox.TabIndex = 1;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.Navy;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.findButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findButton.Location = new System.Drawing.Point(273, 48);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(93, 69);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "find";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // hidePanel
            // 
            this.hidePanel.BackColor = System.Drawing.Color.Navy;
            this.hidePanel.Controls.Add(this.facebookLogoPictureBox);
            this.hidePanel.Location = new System.Drawing.Point(1, 0);
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(454, 58);
            this.hidePanel.TabIndex = 6;
            // 
            // facebookLogoPictureBox
            // 
            this.facebookLogoPictureBox.Image = global::FacebookAppUI.Properties.Resources.facebookLogo;
            this.facebookLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.facebookLogoPictureBox.Name = "facebookLogoPictureBox";
            this.facebookLogoPictureBox.Size = new System.Drawing.Size(129, 57);
            this.facebookLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookLogoPictureBox.TabIndex = 0;
            this.facebookLogoPictureBox.TabStop = false;
            // 
            // BirthdayFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 379);
            this.Controls.Add(this.hidePanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BirthdayFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birth year friends filter";
            this.Load += new System.EventHandler(this.BirthdayFilterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.hidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox fiterByBirthYearListBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox birthYearTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Panel hidePanel;
        private System.Windows.Forms.PictureBox facebookLogoPictureBox;
    }
}