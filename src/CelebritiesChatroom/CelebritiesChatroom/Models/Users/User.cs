namespace CelebritiesChatroom.Models.Users
{
    using System;

    using CelebritiesChatroom.Models.Chatrooms;
    using CelebritiesChatroom.Models.Users.Interfaces;

    public abstract class User : IUser
    {
        private const string FULL_NAME_PATTERN = "{0} {1}";
        private const int MIN_AGE_VALUE = 0;
        private const string AGE_ERROR_MESSAGE = "Invalid age \"{0}\", age must be greater or equal to {1}.";
        private const string RECEIVE_MESSAGE_TEMPLATE = "{0} to {1}: \"{2}\"";

        private int age;

        public User(string firstName, string lastName, int age)
        {
            this.Id = Guid.NewGuid().ToString();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Chatroom Chatroom { get; set; }

        public string FullName => String.Format(FULL_NAME_PATTERN, this.FirstName, this.LastName);

        public virtual int Age 
        { 
            get
            {
                return this.age;
            }
            set
            {
                bool isNotAdult = value < MIN_AGE_VALUE;

                if (isNotAdult)
                {
                    string errorMessage = String.Format(AGE_ERROR_MESSAGE, value, MIN_AGE_VALUE);

                    throw new ArgumentException(errorMessage);
                }

                this.age = value;
            }
        }

        public override bool Equals(object obj)
        {
            var comparableUser = obj as IUser;

            if (comparableUser == null)
            {
                return false;
            }

            bool isEquals = this.FullName == comparableUser.FullName && this.Age == comparableUser.Age;

            return isEquals;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string userAsString = $"Name: {this.FullName}; Age: {this.Age}";

            return userAsString;
        }

        public void Send(string to, string message)
        {
            this.Chatroom.Send(this.FullName, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            string messages = String.Format(RECEIVE_MESSAGE_TEMPLATE, from, this.FullName, message);

            Console.WriteLine(messages);
        }
    }
}
