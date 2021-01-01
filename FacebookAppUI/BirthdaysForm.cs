using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public partial class BirthdaysForm : Form
    {
        private readonly HomePage r_HomePage;

        public BirthdaysForm()
        {
            InitializeComponent();
            r_HomePage = new HomePage();
        }

        protected override void OnShown(EventArgs e)
        {
            new Thread(fetchFriendsBirthdays).Start();
            base.OnShown(e);
        }

        private void fetchFriendsBirthdays()
        {
            try
            {
                List<string> friendsBirthdaysList = r_HomePage.FetchBirthdaysFriendListLogic();

                foreach (string friendBirthday in friendsBirthdaysList)
                {
                    birthdaysFriendListBox.Invoke(new Action(() => birthdaysFriendListBox.Items.Add(friendBirthday)));
                }

                if (birthdaysFriendListBox.Items.Count == 0)
                {
                    MessageBox.Show(
                        (@"No friend using this app. 
This is the time to invite them"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void BirthdaysForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(240, 215);
            this.Icon = Properties.Resources._1200px_F_icon_svg__2_;
        }

    }
}
