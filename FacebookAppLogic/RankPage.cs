using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class RankPage
    {
        private readonly RankFriendLogic r_RankFriendLogic;

        public RankPage()
        {
            r_RankFriendLogic = new RankFriendLogic();
        }

        public List<Friend> FetchFriendsSortedByTags()
        {
            return r_RankFriendLogic.FetchFriendsSortedByTagsLogic();
        }

        public List<Friend> FetchFriendsSortedByLikes()
        {
            return r_RankFriendLogic.FetchFriendsSortedByLikesLogic();
        }

        public void PostAndTag(User i_User, string i_Message)
        {
            r_RankFriendLogic.PostAndTagLogic(i_User, i_Message);
        }
    }
}
