using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class BirthdayFilterLogic
    {
        private readonly FacebookAppManagerLogic r_AppManager;
        
        public BirthdayFilterLogic()
        {
            r_AppManager = FacebookAppManagerLogic.Instance;
        }

        public List<string> FetchFriendsByBirthYear(string i_BirthYear)
        {
            List<string> friendListFilter = new List<string>();

            try
            {
                foreach (User friend in r_AppManager.FetchFriendsUserCollection())
                {
                    if (friend.Birthday != null)
                    {
                        string year = friend.Birthday.Substring(6, 4);
                        if (year.Equals(i_BirthYear))
                        {
                            friendListFilter.Add($"{friend.Name}");
                        }
                    }
                }

                return friendListFilter;
            }
            catch (Exception ex)
            {
                throw new Exception("Fetch friends by birth year failed. Please try again.");
            }
        }
    }
}
