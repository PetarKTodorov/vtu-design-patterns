namespace CelebritiesChatroom.Models.Validators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CelebritiesChatroom.Common;
    using CelebritiesChatroom.Models.Users.Interfaces;

    public class People
    {
        private readonly List<IUser> celebrities;

        public People()
        {
            this.celebrities = Constants.Celebrities;
        }

        public bool IsCelebrity(IUser user)
        {
            bool isCelebrity = this.celebrities.Any(person => person.Equals(user));

            return isCelebrity;
        }

        public void AddCelebrity(IUser user)
        {
            this.celebrities.Add(user);
        }

        public string GetAllCelebritiesAsText()
        {
            string celebritiesAsText = String.Join(Environment.NewLine, this.celebrities);

            return celebritiesAsText;
        }
    }
}
