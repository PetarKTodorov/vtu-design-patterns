namespace CelebritiesChatroom.Models.Users.Interfaces
{
    using CelebritiesChatroom.Models.Chatrooms;

    public interface IUser
    {
        string Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string FullName { get; }

        abstract int Age { get; set; }

        public Chatroom Chatroom { get; set; }

        void Send(string to, string message);

        void Receive(string from, string message);
    }
}
