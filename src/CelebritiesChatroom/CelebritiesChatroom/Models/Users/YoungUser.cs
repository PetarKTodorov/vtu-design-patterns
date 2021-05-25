namespace CelebritiesChatroom.Models.Users
{
    using System;

    public class YoungUser : User
    {
        private const int MAX_AGE_VALUE = 18;
        private const string AGE_ERROR_MESSAGE = "Invalid age \"{0}\", required age must be lower than {1}.";

        public YoungUser(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {

        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                base.Age = value;

                bool isAdult = value >= MAX_AGE_VALUE;

                if (isAdult)
                {
                    string errorMessage = String.Format(AGE_ERROR_MESSAGE, value, MAX_AGE_VALUE);

                    throw new ArgumentException(errorMessage);
                }

                base.Age = value;
            }
        }

        public override void Receive(string from, string message)
        {
            Console.Write("Young users: ");
            base.Receive(from, message);
        }
    }
}
