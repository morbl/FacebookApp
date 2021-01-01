
namespace FacebookAppLogic
{
    public class LoginPage
    {
        private readonly FacebookAppManagerLogic r_AppManager;         

        public LoginPage()
        {
            r_AppManager = FacebookAppManagerLogic.Instance;
        }

        public void Login()
        {
            r_AppManager.LogInUserBackend();
        }

        public string FetchAccessToken()
        {
            return r_AppManager.FetchAccessTokenLogic();
        }

    }
}
