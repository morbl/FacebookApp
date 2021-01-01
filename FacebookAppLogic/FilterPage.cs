using System.Collections.Generic;


namespace FacebookAppLogic
{
    public class FilterPage
    {
        private readonly BirthdayFilterLogic r_BirthdayFilterLogic;
        private readonly GenderFilterLogic r_GenderFilterLogic;
        private readonly LocationFilterLogic r_LocationFilterLogic;

        public FilterPage()
        {
            r_BirthdayFilterLogic = new BirthdayFilterLogic();
            r_GenderFilterLogic = new GenderFilterLogic();
            r_LocationFilterLogic = new LocationFilterLogic();
        }

        public List<string> FetchFriendsByBirthYear(string i_BirthYear)
        {
            return r_BirthdayFilterLogic.FetchFriendsByBirthYear(i_BirthYear);
        }

        public List<string> FetchFriendByCityListLogic(string i_City)
        {
            return r_LocationFilterLogic.FetchFriendByCityListLogic(i_City);
        }

        public List<string> FetchFriendByGenderListLogic(string i_GenderType)
        {
            return r_GenderFilterLogic.FetchFriendByGenderListLogic(i_GenderType);
        }
    }
}
