namespace FacebookAppUI
{
    partial class CityFilterForm
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
            this.hidePanel = new System.Windows.Forms.Panel();
            this.facebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fiterByCityListBox = new System.Windows.Forms.ListBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.hidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hidePanel
            // 
            this.hidePanel.BackColor = System.Drawing.Color.Navy;
            this.hidePanel.Controls.Add(this.facebookLogoPictureBox);
            this.hidePanel.Location = new System.Drawing.Point(0, 0);
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(378, 58);
            this.hidePanel.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.fiterByCityListBox);
            this.panel1.Controls.Add(this.textLabel);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 378);
            this.panel1.TabIndex = 4;
            // 
            // fiterByCityListBox
            // 
            this.fiterByCityListBox.FormattingEnabled = true;
            this.fiterByCityListBox.ItemHeight = 20;
            this.fiterByCityListBox.Location = new System.Drawing.Point(17, 137);
            this.fiterByCityListBox.Name = "fiterByCityListBox";
            this.fiterByCityListBox.Size = new System.Drawing.Size(365, 224);
            this.fiterByCityListBox.TabIndex = 3;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(3, 10);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(352, 23);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "please write the city to filter by:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(22, 64);
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(225, 33);
            this.cityTextBox.TabIndex = 1;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.Navy;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.findButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findButton.Location = new System.Drawing.Point(262, 53);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(93, 67);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "find";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // CityFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hidePanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CityFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CityFilterForm";
            this.Load += new System.EventHandler(this.CityFilterForm_Load);
            this.hidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hidePanel;
        private System.Windows.Forms.PictureBox facebookLogoPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox fiterByCityListBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button findButton;
    }
}