using System;
using System.Windows.Forms;

namespace FacebookAppUI
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            LogInForm logInApp = new LogInForm();
            logInApp.ShowDialog();
        }
    }
}
