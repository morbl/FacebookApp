using System;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public partial class LogInForm : Form
    {
        private readonly AppSettings r_AppSetting;
        private readonly LoginPage r_LoginPage;

        public LogInForm()
        {
            InitializeComponent();
            r_AppSetting = new AppSettings();
            r_LoginPage = new LoginPage();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            upDateSettings();
            base.OnClosing(e);
        }

        private void upDateSettings()
        {
            r_AppSetting.RememberUser = RememberCheckBox.Checked;
            r_AppSetting.LastAccessToken = r_AppSetting.RememberUser ? r_LoginPage.FetchAccessToken() : null;
            r_AppSetting.SaveToFile();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources._1200px_F_icon_svg__2_;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            logInUser();
        }

        private void logInUser()
        {
            try
            {
                r_LoginPage.Login();
                this.Close();
                this.Hide();
                FacebookAppForm facebookAppForm = new FacebookAppForm();

                facebookAppForm.ShowDialog();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
