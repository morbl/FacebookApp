using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class LocationFilterLogic
    {
        private readonly FacebookAppManagerLogic r_AppManager;

        public LocationFilterLogic()
        {
            r_AppManager = FacebookAppManagerLogic.Instance;
        }

        public List<string> FetchFriendByCityListLogic(string i_City)
        {
            List<string> friendListFilter = new List<string>();

            try
            {
                foreach (User friend in r_AppManager.FetchFriendsUserCollection())
                {
                    if (friend.Location.Name != null)
                    {
                        if (friend.Location.Name.ToLower().Contains(i_City.ToLower()))
                        {
                            friendListFilter.Add($"{friend.Name}");
                        }
                    }
                }

                return friendListFilter;
            }
            catch (Exception ex)
            {
                throw new Exception("Fetch friends by city failed. Please try again.");
            }
        }
    }
}
