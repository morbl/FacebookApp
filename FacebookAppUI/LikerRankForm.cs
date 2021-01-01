using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppUI
{
    public partial class LikerRankForm : Form
    {
        public const string k_MessageNoFriend = @"No friends friend using this app. 
This is the time to enlarge the friends using this app";

        private readonly RankPage r_RankPage; 

        private User m_BestFriend;

        private User m_MostTagged;

        public LikerRankForm()
        {
            InitializeComponent();
            r_RankPage = new RankPage();
        }

        private void LikerRankForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources._1200px_F_icon_svg__2_;
        }

        protected override void OnShown(EventArgs e)
        {
           fetchInformation();
        }

        private void fetchInformation()
        {
            try
            {
                new Thread(fetchFriendsSortedByLikes).Start();
                new Thread(fetchFriendsSortedByTags).Start();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void fetchFriendsSortedByLikes()
        {
            try
            {
                List<Friend> friendsList = r_RankPage.FetchFriendsSortedByLikes();
                m_BestFriend = friendsList[0].FriendUser;

                foreach(Friend friend in friendsList)
                {
                    likersListBox.Invoke(new Action(() => likersListBox.Items.Add(string.Format($@"{friend.FriendUser.Name} - {friend.NumOfLikes}"))));
                }

                if(likersListBox.Items.Count == 0)
                {
                    MessageBox.Show(k_MessageNoFriend);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void fetchFriendsSortedByTags()
        {
            try
            {
                List<Friend> friendsList = r_RankPage.FetchFriendsSortedByTags();
                m_MostTagged = friendsList[0].FriendUser;

                foreach(Friend friend in friendsList)
                {
                    tagsRankListBox.Invoke(
                        new Action(
                            () => tagsRankListBox.Items.Add(
                                string.Format($@"{friend.FriendUser.Name} - {friend.NumOfTags}"))));
                }

                if(tagsRankListBox.Items.Count == 0)
                {
                    MessageBox.Show(k_MessageNoFriend);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendMessageAndTagFriend(m_BestFriend, "Thank you");
        }

        private void sendMessageAndTagFriend(User i_ToTagged, string i_Message)
        {
            try
            {
                r_RankPage.PostAndTag(i_ToTagged,i_Message);
                MessageBox.Show($@"{i_Message} - send successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(@"Something wrong. Try later");
            }
        }

        private void sendTagsButton_Click(object sender, EventArgs e)
        {
            sendMessageAndTagFriend(m_MostTagged, "I love you");
        }
    }
}
