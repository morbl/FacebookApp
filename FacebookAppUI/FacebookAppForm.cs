using System;
using System.Threading;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public partial class FacebookAppForm : Form
    {
        private readonly HomePage r_HomePage;
        
        public FacebookAppForm()
        {
            InitializeComponent();
            r_HomePage = new HomePage();
        }

        protected override void OnShown(EventArgs e)
        {
            new Thread(fetchInformation).Start();
            base.OnShown(e);
        }

        private void fetchInformation()
        {
            pictureUserBox.Load(r_HomePage.GetUserProfilePicture());
            userNameLabel.Invoke(new Action(()=> userNameLabel.Text = r_HomePage.GetUserName()));
            new Thread(fetchLikedPagesAndNewsFeed).Start();
        }

        private void fetchLikedPagesAndNewsFeed()
        {
            try
            {
                postBindingSource.DataSource = r_HomePage.FetchNewsFeed();

                if(newsFeedTabListBox.Items.Count == 0)
                {
                    newsFeedTabListBox.Invoke(new Action(
                        () => newsFeedTabListBox.Items.Add("No liked pages to retrieve"))); 
                }

                pageBindingSource.DataSource = r_HomePage.FetchLikedPages();

                if(pagesTabListBox.Items.Count == 0)
                {
                    pagesTabListBox.Invoke(new Action(()=> pagesTabListBox.Items.Add("No liked pages to retrieve")));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            MyProfilePageForm profileUser = new MyProfilePageForm();
            profileUser.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            activateLogOut();
        }

        private void activateLogOut()
        {
            DialogResult dialogResult = MessageBox.Show(
                String.Format(
                    $@"{r_HomePage.GetUserName()}, 
are you sure you want to log out from this app?"),
                "",
                MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void birthdayButton_Click(object sender, EventArgs e)
        {
            activateBirthdaysFriends();
        }

        private void activateBirthdaysFriends()
        {
            BirthdaysForm birthdays = new BirthdaysForm();
            birthdays.ShowDialog();
        }

        private void filterFriendButton_Click(object sender, EventArgs e)
        {
            activateFilterFriends();
        }

        private void activateFilterFriends()
        {
            FilterFriendsForm filterFriends = new FilterFriendsForm();
            filterFriends.FormClosed += formClose_Click;
            this.Hide();
            filterFriends.ShowDialog();
        }

        private void formClose_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void likersRankButton_Click(object sender, EventArgs e)
        {
            activateLikerRank();
        }

        private void activateLikerRank()
        {
            LikerRankForm likerRank = new LikerRankForm();
            likerRank.FormClosed += formClose_Click;
            this.Hide();
            likerRank.ShowDialog();
        }

        private void FacebookAppForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources._1200px_F_icon_svg__2_;
        }
    }
}
