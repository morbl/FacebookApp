using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public partial class BirthYearFilterForm : Form
    {
        private readonly FilterPage r_FilterPage;

        private const string k_NoCharacterMessage =
            @"To search friends by year of birth you have to enter at least one character";
        public BirthYearFilterForm()
        {
            InitializeComponent();
            r_FilterPage = new FilterPage();
        }

        private void BirthdayFilterForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources._1200px_F_icon_svg__2_;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            fetchFriendsByBirthYear(birthYearTextBox.Text);
        } 

        private void fetchFriendsByBirthYear(string i_BirthYear)
        {
            try
            {
                if(!(string.IsNullOrEmpty(birthYearTextBox.Text)))
                {
                    fiterByBirthYearListBox.Items.Clear();
                    List<string> friendsList = r_FilterPage.FetchFriendsByBirthYear(i_BirthYear);

                    foreach (string friend in friendsList)
                    {
                        fiterByBirthYearListBox.Items.Add(friend);
                    }

                    if (fiterByBirthYearListBox.Items.Count == 0)
                    {
                        MessageBox.Show(
                            (string.Format($@"No friend in birth year: {i_BirthYear} using this app. 
This is the time to enlarge the friends in this age")));
                    }
                }
                else
                {
                    MessageBox.Show(k_NoCharacterMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }
    }
}
