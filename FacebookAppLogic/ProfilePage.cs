using System.Collections.Generic;

using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class ProfilePage
    {
        private readonly FacebookAppManagerLogic r_AppManager;

        public ProfilePage()
        {
            r_AppManager = FacebookAppManagerLogic.Instance;
        }

        public List<string> FetchStatusList()
        {
            List<string> statusList = new List<string>();

            foreach(Status status in r_AppManager.FetchStatusesUserCollection())
            {
                if(status.Message != null)
                {
                    statusList.Add(status.Message);
                }
            }

            return statusList;
        }

        public List<string> FetchAlbumsList()
        {
            List<string> albumList = new List<string>();


            foreach(Album album in r_AppManager.FetchAlbumsUserCollection())
            {
                if(album.Message != null)
                {
                    albumList.Add(album.Message);
                }
            }
            return albumList;
        }

        public FacebookObjectCollection<User> FetchFriendsList()
        {
            return r_AppManager.FetchFriendsUserCollection();
        }

        public string GetUserGender()
        {
            return r_AppManager.FetchGenderUserLogic();
        }

        public string GetUserBirthday()
        {
            return r_AppManager.FetchBirthdayUserLogic();
        }

        public string GetUserLocation()
        {
            return r_AppManager.FetchInfoLocationLogic();
        }

        public string GetUserName()
        {
            return r_AppManager.FetchNameUserLogic();
        }

        public string GetUserProfilePicture()
        {
            return r_AppManager.FetchProfileNormalPictureUserLogic();
        }

        public Status PostedStatus(string i_MessageToPost)
        {
            return r_AppManager.PostedStatus(i_MessageToPost);
        }
    }
}
