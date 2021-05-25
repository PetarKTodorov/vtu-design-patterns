namespace CelebritiesChatroom.Models.Chatrooms
{
    using System.Collections.Generic;
    using System.Linq;

    using CelebritiesChatroom.Models.Users.Interfaces;

    public class Chatroom
    {
        private Dictionary<string, IUser> participants = new Dictionary<string, IUser>();

        public void Register(IUser participant)
        {
            if (!participants.ContainsValue(participant))
            {
                participants[participant.Id] = participant;
            }

            participant.Chatroom = this;
        }

        public void Send(string from, string to, string message)
        {
            IUser participant = participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }

        public IUser GetUser(string userFullName)
        {
            IUser user = this.participants.Values.FirstOrDefault(user => user.FullName == userFullName);

            return user;
        }
    }
}
