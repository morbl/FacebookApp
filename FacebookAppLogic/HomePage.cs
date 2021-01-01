using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class HomePage
    {
        private readonly FacebookAppManagerLogic r_AppManager;

        public HomePage()
        {
            r_AppManager = FacebookAppManagerLogic.Instance;
        }

        public FacebookObjectCollection<Page> FetchLikedPages()
        {
            return r_AppManager.FetchPagesUserCollection();
        }

        public FacebookObjectCollection<Post> FetchNewsFeed()
        {
            return r_AppManager.FetchNewsFeedUserCollection();
        }

        public List<string> FetchBirthdaysFriendListLogic()
        {

            List<string> birthdaysFriends = new List<string>();

            foreach(User friend in r_AppManager.FetchFriendsUserCollection())
            {
                IBirthdayFormat iBirthdayFormat = new BirthdayFormatAdapter(friend);
                if (friend.Birthday != null)
                {
                    birthdaysFriends.AddRange(iBirthdayFormat.CreateFormattedBirthdaysList());
                }
            }

            return birthdaysFriends;
        }

        public string GetUserName()
        {
            return r_AppManager.FetchNameUserLogic();
        }

        public string GetUserProfilePicture()
        {
            return r_AppManager.FetchProfileSquarePictureUserLogic();
        }
    }
}
