using System;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Threading;


namespace FacebookAppUI
{
    public partial class MyProfilePageForm : Form
    {
        private readonly ProfilePage r_ProfilePage;

        private const string k_NoCharacterMessage = @"To post you have to enter one character at least";

        public MyProfilePageForm()
        {
            InitializeComponent(); 
            r_ProfilePage = new ProfilePage();
        }

        private void MyProfilePageForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources._1200px_F_icon_svg__2_;
            new Thread(fetchUserInformation).Start();
        }

        private void fetchUserInformation()
        {
            userPictureProfile.Load(r_ProfilePage.GetUserProfilePicture());
            nameLabel.Invoke(new Action(() => nameLabel.Text = r_ProfilePage.GetUserName()));
            BirthdayInfoLabel.Invoke(new Action(() => BirthdayInfoLabel.Text = r_ProfilePage.GetUserBirthday()));
            fromInfoLabel.Invoke(new Action(() => fromInfoLabel.Text = r_ProfilePage.GetUserLocation()));
            genderUserLable.Invoke(new Action(() => genderUserLable.Text = r_ProfilePage.GetUserGender()));
        }

        private void listBoxFriend_Click(object sender, EventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            try
            {
                if(friendsListBox.Items.Count != 0)
                {
                    friendsListBox.Items.Clear();
                }
                else
                {
                    userBindingSource.DataSource = r_ProfilePage.FetchFriendsList();

                    if(friendsListBox.Items.Count == 0)
                    {
                        MessageBox.Show(
                            (
                               @"No friend using this app. 
This is the time to invite them"));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            fetchStatusUser();
        }

        private void fetchStatusUser()
        {
            try
            {
                if(statusListBox.Items.Count != 0)
                {
                    statusListBox.Items.Clear();
                }
                else
                {
                    List<string> statusesList = r_ProfilePage.FetchStatusList();

                    foreach(string statusUser in statusesList)
                    {
                        statusListBox.Items.Add(statusUser);
                    }

                    if(statusListBox.Items.Count == 0)
                    {
                        MessageBox.Show((
                                            @"No status to retrieve. 
This is the time to post one"));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void albumUserButton_Click(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            try
            {
                if(albumListBox.Items.Count != 0)
                {
                    albumListBox.Items.Clear();
                }
                else
                {
                    albumListBox.DisplayMember = "Name";
                    List<string> albumsList = r_ProfilePage.FetchAlbumsList();

                    foreach(string album in albumsList)
                    { 
                        albumListBox.Items.Add(album);
                    }

                    if(albumListBox.Items.Count == 0)
                    {
                        MessageBox.Show(
                            @"No Album to retrieve. 
This is the time to start");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            new Thread(postStatus).Start();
        }

        private void postStatus()
        {
            try
            {
                if(!(string.IsNullOrEmpty(postTextBox.Text)))
                {
                    Status postedStatus = r_ProfilePage.PostedStatus(postTextBox.Text);
                    MessageBox.Show($@"Status Posted! ID: {postedStatus.Id}");
                }
                else
                {
                    MessageBox.Show(k_NoCharacterMessage);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                postTextBox.Invoke(new Action(()=> postTextBox.Text = String.Empty));
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
