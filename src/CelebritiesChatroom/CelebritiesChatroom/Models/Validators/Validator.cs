namespace CelebritiesChatroom.Models.Validators
{
    using System;
    using System.Text;

    using CelebritiesChatroom.Models.Users.Interfaces;

    public class Validator
    {
        private readonly Prison prison;
        private readonly People people;

        public Validator()
        {
            this.prison = new Prison();
            this.people = new People();
        }

        public bool IsEligible(IUser user)
        {
            bool isEligible = true;

            bool isNotCelebrity = people.IsCelebrity(user) == false;
            if (prison.IsBeenInPrison(user) || isNotCelebrity)
            {
                isEligible = false;
            }

            return isEligible;
        }

        public string GetCelebritiesAndPeopleInPrison()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine();
            stringBuilder.AppendLine("All celebrities");
            stringBuilder.AppendLine(this.people.GetAllCelebritiesAsText());
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Celebrities been in prison");
            stringBuilder.AppendLine(this.prison.GetAllPeopleInPrisonAsText());
            stringBuilder.AppendLine();

            string result = stringBuilder.ToString();

            return result;
        }
    }
}
