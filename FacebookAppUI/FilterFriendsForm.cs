using System;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public partial class FilterFriendsForm : Form
    {

        public FilterFriendsForm()
        {
            InitializeComponent();
        }

        private void FilterFriendsForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources._1200px_F_icon_svg__2_;
        }

        private void genderFilterButton_Click(object sender, EventArgs e)
        {
            activateGenderFilterForm();
        }

        private void activateGenderFilterForm()
        {
            GenderFilterForm genderFilter = new GenderFilterForm();
            this.Hide();
            genderFilter.FormClosed += FormClose_Click;
            genderFilter.ShowDialog();
        }

        private void cityFilterButton_Click(object sender, EventArgs e)
        {
            activateCityFilterForm();
        }

        private void activateCityFilterForm()
        {
            CityFilterForm cityFilter = new CityFilterForm();
            this.Hide();
            cityFilter.FormClosed += FormClose_Click;
            cityFilter.ShowDialog();
        }

        private void birthdayFilterButton_Click(object sender, EventArgs e)
        {
            activateBirthFilterForm();
        }

        private void activateBirthFilterForm()
        {
            BirthYearFilterForm birthYearFilter = new BirthYearFilterForm();
            this.Hide();
            birthYearFilter.FormClosed += FormClose_Click;
            birthYearFilter.ShowDialog();
        }
        private void FormClose_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
