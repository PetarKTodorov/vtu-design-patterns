namespace CelebritiesChatroom.Models.Users
{
    using System;

    public class AdultUser : User
    {
        private const int MIN_AGE_VALUE = 18;
        private const string AGE_ERROR_MESSAGE = "Invalid age \"{0}\", required age must be greater or equal to {1}.";

        public AdultUser(string firstName, string lastName, int age) 
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

                bool isNotAdult = value < MIN_AGE_VALUE;

                if (isNotAdult)
                {
                    string errorMessage = String.Format(AGE_ERROR_MESSAGE, value, MIN_AGE_VALUE);

                    throw new ArgumentException(errorMessage);
                }

                base.Age = value;
            }
        }

        public override void Receive(string from, string message)
        {
            Console.Write("Send to adult user: ");
            base.Receive(from, message);
        }
    }
}
