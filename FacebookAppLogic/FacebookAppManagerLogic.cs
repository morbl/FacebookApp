using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;


namespace FacebookAppLogic
{
    public sealed class FacebookAppManagerLogic
    {
        public User LoggedInUser { get; set; }
        public LoginResult LoginResult { get; set; }

        private FacebookObjectCollection<User> m_FriendsUser = null;
        private FacebookObjectCollection<Album> m_AlbumsUser = null;
        private FacebookObjectCollection<Page> m_PagesUser = null;
        private FacebookObjectCollection<Status> m_StatusesUser = null;
        private FacebookObjectCollection<Post> m_NewsFeed = null;
        private FacebookObjectCollection<Post> m_Posts = null;
        private string m_NameOfUser = null;
        private string m_ProfilePictureUrlNormal = null;
        private string m_ProfilePictureUrlSquare = null;
        private string m_GenderOfUser = null;
        private string m_LocationOfUser = null;
        private string m_BirthdayOfUser = null;
        private const string k_MessageFailedFetch = "Fetch failed. Please try again.";
        private static FacebookAppManagerLogic s_Instance = null;
        private static readonly object sr_FacebookAppManagerLock = new object();

        private FacebookAppManagerLogic()
        {

        }

        public static FacebookAppManagerLogic Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_FacebookAppManagerLock)
                    {
                        if(s_Instance == null)
                        {
                            s_Instance = new FacebookAppManagerLogic();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public void LogInUserBackend()
        {
            AppSettings settings = AppSettings.LoadFromFile();

            if(settings.RememberUser && !string.IsNullOrEmpty(settings.LastAccessToken))
            {
                LoginResult = FacebookService.Connect(settings.LastAccessToken);
            }
            else
            {
                logIn();
            }

            if(!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;
            }
            else
            {
                throw new Exception(@"Login failed. Please try again.");
            }
        }

        private void logIn()
        {
            LoginResult = FacebookService.Login(
                "2537497946542260",
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown");
        }

        public FacebookObjectCollection<User> FetchFriendsUserCollection()
        {
            try
            {
                return m_FriendsUser ?? (m_FriendsUser = LoggedInUser.Friends);
            }
            catch(Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public FacebookObjectCollection<Album> FetchAlbumsUserCollection()
        {
            try
            {
                return m_AlbumsUser ?? (m_AlbumsUser = LoggedInUser.Albums);
            }
            catch(Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public FacebookObjectCollection<Page> FetchPagesUserCollection()
        {
            try
            {
                return m_PagesUser ?? (m_PagesUser = LoggedInUser.LikedPages);
            }
            catch(Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public FacebookObjectCollection<Post> FetchPostsUserCollection()
        {
            try
            {
                return m_Posts ?? (m_Posts = LoggedInUser.Posts);
            }
            catch (Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public FacebookObjectCollection<Status> FetchStatusesUserCollection()
        {
            try
            {
                return m_StatusesUser ?? (m_StatusesUser = LoggedInUser.Statuses);
            }
            catch(Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public FacebookObjectCollection<Post> FetchNewsFeedUserCollection()
        {
            try
            {
                return m_NewsFeed ?? (m_NewsFeed = LoggedInUser.NewsFeed);
            }
            catch(Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public string FetchGenderUserLogic()
        {
            try
            {
                return m_GenderOfUser ?? (m_GenderOfUser = LoggedInUser.Gender.ToString());
            }
            catch(Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public string FetchProfileSquarePictureUserLogic()
        {
            try
            {
                return m_ProfilePictureUrlSquare ?? (m_ProfilePictureUrlSquare = LoggedInUser.PictureSqaureURL);
            }
            catch (Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public string FetchProfileNormalPictureUserLogic()
        {
            try
            {
                return m_ProfilePictureUrlNormal ?? (m_ProfilePictureUrlNormal = LoggedInUser.PictureNormalURL);
            }
            catch (Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public string FetchNameUserLogic()
        {
            try
            {
                return m_NameOfUser ?? (m_NameOfUser = LoggedInUser.Name);
            }
            catch (Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public string FetchInfoLocationLogic()
        {
            try
            {
                return m_LocationOfUser ?? (m_LocationOfUser = LoggedInUser.Location.Name);
            }
            catch (Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public string FetchBirthdayUserLogic()
        {
            try
            {
                return m_BirthdayOfUser ?? (m_BirthdayOfUser = LoggedInUser.Birthday);
            }
            catch (Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public Status PostedStatus(string i_MessageToPost)
        {
            try
            {
                return LoggedInUser.PostStatus(i_MessageToPost);
            }
            catch (Exception ex)
            {
                throw new Exception(@"Sorry can't post, but if we could 
we are sure you would have gotten a lot of likes!");
            }
        }

        public Status PostedWithTagsStatus(string i_MessageToPost, User i_User)
        {
            try
            {
                return LoggedInUser.PostStatus(i_MessageToPost, i_TaggedFriendIDs: i_User.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(@"Sorry can't post, but if we could 
we are sure you would have gotten a lot of likes!");
            }
        }

        public string FetchAccessTokenLogic()
        {
            try
            {
                return LoginResult.AccessToken;
            }
            catch (Exception ex)
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }
    }
}
