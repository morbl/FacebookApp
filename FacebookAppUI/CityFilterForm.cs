using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public partial class CityFilterForm : Form
    {
        private readonly FilterPage r_FilterPage;

        private const string k_NoCharacterMessage =
            @"To search friends by city you have to enter at least one character";

        public CityFilterForm()
        {
            InitializeComponent();
            r_FilterPage = new FilterPage();
        }

        private void fetchFriendsByGender(string i_City)
        {
            try
            {
                if(!(string.IsNullOrEmpty(cityTextBox.Text)))
                {
                    fiterByCityListBox.Items.Clear();
                    List<string> friendsList = r_FilterPage.FetchFriendByCityListLogic(i_City);

                    foreach (string friend in friendsList)
                    {
                        fiterByCityListBox.Items.Add(friend);
                    }

                    if (fiterByCityListBox.Items.Count == 0)
                    {
                        MessageBox.Show(
                            (string.Format($@"No friend from {i_City} using this app. 
This is the time to enlarge the friends from this city")));
                    }
                }
                else
                {
                    MessageBox.Show(k_NoCharacterMessage);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            fetchFriendsByGender(cityTextBox.Text);
        }

        private void CityFilterForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources._1200px_F_icon_svg__2_;
        }
    }
}
