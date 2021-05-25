namespace CelebritiesChatroom.Models.Commands
{
    using System;
    using System.Linq;

    using CelebritiesChatroom.Models.Chatrooms;
    using CelebritiesChatroom.Models.Commands.Interfaces;
    using CelebritiesChatroom.Models.Users.Interfaces;

    public class SendMessageCommand : ICommand
    {
        private const string NULL_SENDER_OR_RECEIVER_ERROR_MESSAGE = "Sender or Receiver are not found.";

        public void Execute(Chatroom chatroom, params string[] arguments)
        {
            string fullNameSender = String.Join(' ', arguments.Take(2));
            string fullNameReciver = String.Join(' ', arguments.Skip(3).Take(2));
            string message = String.Join(' ', arguments.Skip(5));

            IUser sender = chatroom.GetUser(fullNameSender);
            IUser receiver = chatroom.GetUser(fullNameReciver);

            if (sender == null || receiver == null)
            {
                throw new ArgumentNullException(NULL_SENDER_OR_RECEIVER_ERROR_MESSAGE);
            }

            sender.Send(receiver.Id, message);
        }
    }
}
