using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public partial class GenderFilterForm : Form
    {
        public enum eGenderType
        {
            Female = 1,
            Male = 2,
            Other = 3
        }
        private readonly FilterPage r_FilterPage;

        public GenderFilterForm()
        {
            InitializeComponent();
            r_FilterPage = new FilterPage();
        }

        private void GenderFilterForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources._1200px_F_icon_svg__2_;
        }

        private void fetchFriendsByGender(eGenderType i_GenderType)
        {
            try
            {
                filterFriendsListBox.Items.Clear();
                List<string> friendsList = r_FilterPage.FetchFriendByGenderListLogic(i_GenderType.ToString());

                foreach(string friend in friendsList)
                {
                    filterFriendsListBox.Items.Add(friend);
                }

                if(filterFriendsListBox.Items.Count == 0)
                {
                    MessageBox.Show(
                        (string.Format($@"No {i_GenderType.ToString().ToLower()} friend using this app. 
This is the time to enlarge the friends in this gender")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void femaleButton_Click(object sender, EventArgs e)
        {
            fetchFriendsByGender(eGenderType.Female);
        }

        private void maleButton_Click_1(object sender, EventArgs e)
        {
            fetchFriendsByGender(eGenderType.Male);
        }

        private void otherButton_Click_1(object sender, EventArgs e)
        {
            fetchFriendsByGender(eGenderType.Other);
        }
    }
}
