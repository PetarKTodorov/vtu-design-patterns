namespace CelebritiesChatroom.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using CelebritiesChatroom.Factories.Interfaces;
    using CelebritiesChatroom.Models.Users.Interfaces;
    using CelebritiesChatroom.Models.Validators;

    public class UserFactory : IFactory<IUser>
    {
        private const string INVALID_USER_TYPE_ERROR_MESSAGE = "User \"{0}\" don't inherits IUser or is invalide.";
        private const string INVALID_AGE_FORMAT_ERROR_MESSAGE = "\"{0}\" is not a number.";
        private const int COUNT_OF_EXPECTED_ARGUMENTS = 4;
        private const string INVALID_COUNT_OF_ARGUMENTS_ERROR_MESSAGE = "Expected count of arguments is {0}, you pass {1}.";
        private const string INVALID_CELEBRITY_ERROR_MESSAGE = "Your try to create celebrity that is not in the list of celebrities or is been in prison.";

        public IUser Create(params string[] tokens)
        {
            if (tokens.Length != COUNT_OF_EXPECTED_ARGUMENTS)
            {
                string errorMessage = string.Format
                    (INVALID_COUNT_OF_ARGUMENTS_ERROR_MESSAGE, COUNT_OF_EXPECTED_ARGUMENTS, tokens.Length);

                throw new ArgumentOutOfRangeException(errorMessage);
            }

            string userTypeAsString = tokens[0];
            string firstName = tokens[1];
            string lastName = tokens[2];
            string ageAsString = tokens[3];

            int age;
            bool isNumber = int.TryParse(ageAsString, out age);

            if (isNumber == false)
            {
                string errorMessage = string.Format(INVALID_AGE_FORMAT_ERROR_MESSAGE, ageAsString);

                throw new FormatException(errorMessage);
            }       

            Type userType = Assembly.GetCallingAssembly()
                .GetTypes()
                .Where(t => typeof(IUser).IsAssignableFrom(t) && t.IsAbstract == false)
                .FirstOrDefault(t => t.Name == userTypeAsString);

            if (userType == null)
            {
                string errorMessage = string.Format(INVALID_USER_TYPE_ERROR_MESSAGE, userTypeAsString);

                throw new ArgumentException(errorMessage);
            }

            object[] constructorArguments = new object[] { firstName, lastName, age };

            IUser user = (IUser)Activator.CreateInstance(userType, constructorArguments);

            var validator = new Validator();

            bool isInvalid = validator.IsEligible(user) == false;

            if (isInvalid)
            {
                string allCelebrities = validator.GetCelebritiesAndPeopleInPrison();

                throw new ArgumentException(allCelebrities + INVALID_CELEBRITY_ERROR_MESSAGE);
            }

            return user;
        }
    }
}
