using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class GenderFilterLogic
    {
        private readonly FacebookAppManagerLogic r_AppManager;

        public GenderFilterLogic()
        {
            r_AppManager = FacebookAppManagerLogic.Instance;
        }

        public List<string> FetchFriendByGenderListLogic(string i_GenderType)
        {
            List<string> friendListFilter = new List<string>();

            try
            {
                foreach (User friend in r_AppManager.FetchFriendsUserCollection())
                {
                    if (friend.Gender != null)
                    {
                        if (friend.Gender.ToString().Equals(i_GenderType.ToLower()))
                        {
                            friendListFilter.Add($"{friend.Name}");
                        }
                    }
                }

                return friendListFilter;
            }
            catch (Exception ex)
            {
                throw new Exception("Fetch friends by gender failed. Please try again.");
            }
        }
    }
}
