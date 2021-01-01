using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class RankFriendLogic
    {
        private readonly List<Friend> r_FriendList;
        private readonly FacebookAppManagerLogic r_AppManager;
        private const string k_MessageError = @"Error, don't have premission";

        public RankFriendLogic()
        {
            r_AppManager= FacebookAppManagerLogic.Instance;
            r_FriendList = new List<Friend>();
            updateFriendList(r_FriendList);
        }

        public List<Friend> FetchFriendsSortedByLikesLogic()
        {
            updateLikesPerFriend(r_FriendList);
            try
            {
                List<Friend> orderedList = r_FriendList.OrderByDescending(i_FriendUser => i_FriendUser.NumOfLikes).ToList();

                return orderedList;
            }
            catch(Exception e)
            {
                throw new Exception("Fetch friends by like rank failed. Please try again.");
            }
        }

        public List<Friend> FetchFriendsSortedByTagsLogic()
        {
            updateTagsPerFriend(r_FriendList);
            try
            {
                List<Friend> orderedList = r_FriendList.OrderByDescending(i_FriendUser => i_FriendUser.NumOfTags).ToList();

                return orderedList;
            }
            catch(Exception e)
            {
                throw new Exception("Fetch friends by tags rank failed. Please try again.");
            }
        }

        private void updateFriendList(List<Friend> io_Friends)
        {
            initFriendList(io_Friends);
        }

        private void initFriendList(List<Friend> io_Friends)
        {
            foreach(User friendOfUser in r_AppManager.FetchFriendsUserCollection())
            {
                io_Friends.Add(new Friend(friendOfUser));
            }
        }

        private void updateLikesPerFriend(List<Friend> io_Friends)
        {
            try
            {
                foreach (Post postOfUser in r_AppManager.FetchPostsUserCollection())
                {
                    foreach (User friend in postOfUser.LikedBy)
                    {
                        io_Friends.Find(i_FriendUser => i_FriendUser.FriendUser.Email == friend.Email).NumOfLikes++;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception(k_MessageError);
            }
        }

        private void updateTagsPerFriend(List<Friend> io_Friends)
        {
            try
            {
                foreach(Album albumOfUser in r_AppManager.FetchAlbumsUserCollection())
                {
                    foreach(Photo photo in albumOfUser.Photos)
                    {
                        foreach(PhotoTag tag in photo.Tags)
                        {
                            User friend = tag.User;
                            io_Friends.Find(i_FriendUser => i_FriendUser.FriendUser.Email == friend.Email).NumOfTags++;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception(k_MessageError);
            }
        }

        public void PostAndTagLogic(User i_User, string i_Message)
        {
            r_AppManager.PostedWithTagsStatus(i_Message, i_User);
        }
    }
}
