using System;
using System.Collections.Generic;
using System.Globalization;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class  BirthdayFormatAdapter: IBirthdayFormat
    {
        private readonly User r_FriendUser;
        private readonly int r_CurrentAge;

        public BirthdayFormatAdapter(User i_FriendUser)
        {
            r_FriendUser = i_FriendUser;
            r_CurrentAge = int.Parse(DateTime.Now.Year.ToString());
        }

        public List<string> CreateFormattedBirthdaysList()
        {
            try
            {
                List<string> friendBirthday = new List<string>();
                int yearOfBirth = int.Parse(r_FriendUser.Birthday.Substring(6, 4));
                CultureInfo provider = CultureInfo.InvariantCulture;

                friendBirthday.Add(string.Format($@"Friend's name: {r_FriendUser.Name}"));
                friendBirthday.Add(string.Format($@"Birthday: {r_FriendUser.Birthday}"));
                friendBirthday.Add(string.Format($@"Age: {r_CurrentAge - yearOfBirth}"));
                friendBirthday.Add(string.Format($@"Sign: {getHoroName(DateTime.Parse(r_FriendUser.Birthday,provider))}"));
                friendBirthday.Add(drawLine());

                return friendBirthday;
            }
            catch(Exception ex)
            {
                throw new Exception("Error: Couldn't fetch information");
            }
        }

        private string drawLine()
        {
            return @"------------------------------------";
        }

        private string getHoroName(DateTime dt)
        {
            int month = dt.Month;
            int day = dt.Day;
            switch (month)
            {
                case 1:
                    if (day <= 19)
                        return "Capricorn";
                    else
                        return "Aquarius";

                case 2:
                    if (day <= 18)
                        return "Aquarius";
                    else
                        return "Pisces";
                case 3:
                    if (day <= 20)
                        return "Pisces";
                    else
                        return "Aries";
                case 4:
                    if (day <= 19)
                        return "Aries";
                    else
                        return "Taurus";
                case 5:
                    if (day <= 20)
                        return "Taurus";
                    else
                        return "Gemini";
                case 6:
                    if (day <= 20)
                        return "Gemini";
                    else
                        return "Cancer";
                case 7:
                    if (day <= 22)
                        return "Cancer";
                    else
                        return "Leo";
                case 8:
                    if (day <= 22)
                        return "Leo";
                    else
                        return "Virgo";
                case 9:
                    if (day <= 22)
                        return "Virgo";
                    else
                        return "Libra";
                case 10:
                    if (day <= 22)
                        return "Libra";
                    else
                        return "Scorpio";
                case 11:
                    if (day <= 21)
                        return "Scorpio";
                    else
                        return "Sagittarius";
                case 12:
                    if (day <= 21)
                        return "Sagittarius";
                    else
                        return "Capricorn";
            }
            return "";
        }

    }
}
