namespace CelebritiesChatroom.Models.Validators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CelebritiesChatroom.Common;
    using CelebritiesChatroom.Models.Users.Interfaces;

    public class Prison
    {
        private readonly List<IUser> peopleInPrison;

        public Prison()
        {
            this.peopleInPrison = Constants.PeopleInPrison;
        }

        public bool IsBeenInPrison(IUser user)
        {
            bool isBeenInPrison = this.peopleInPrison.Any(person => person.Equals(user));

            return isBeenInPrison;
        }

        public void AddPrisoner(IUser user)
        {
            this.peopleInPrison.Add(user);
        }

        public string GetAllPeopleInPrisonAsText()
        {
            string peopleInPrisonAsText = String.Join(Environment.NewLine, this.peopleInPrison);

            return peopleInPrisonAsText;
        }
    }
}
