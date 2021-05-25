namespace CelebritiesChatroom.Common
{
    using System.Collections.Generic;
    using CelebritiesChatroom.Models.Users;
    using CelebritiesChatroom.Models.Users.Interfaces;

    public static class Constants
    {
        public static List<IUser> PeopleInPrison = new List<IUser>()
        {
            new AdultUser("Mike", "Tyson", 54),
            new AdultUser("Robert", "Downey, Jr.", 56),
            new YoungUser("Berin", "Kibar", 16),
        };

        public static List<IUser> Celebrities = new List<IUser>()
        {
            new AdultUser("Mike", "Tyson", 54),
            new AdultUser("Robert", "Downey, Jr.", 56),
            new AdultUser("Ariana", "Grande", 27),
            new AdultUser("Angelina", "Jolie", 45),
            new AdultUser("Justin", "Timberlake", 40),
            new AdultUser("Brad", "Pitt", 57),
            new YoungUser("Elsie", "Fisher", 16),
            new YoungUser("Maxwell", "Jenkins", 14),
            new YoungUser("Noah", "Jupe", 14),
            new YoungUser("Julia", "Butters", 10),
        };

        public static bool IsApplicationRun = true;
    }
}
