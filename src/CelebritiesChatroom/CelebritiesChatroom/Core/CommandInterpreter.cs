namespace CelebritiesChatroom.Core
{
    using System.Linq;

    using CelebritiesChatroom.Factories;
    using CelebritiesChatroom.Models.Chatrooms;
    using CelebritiesChatroom.Models.Commands.Interfaces;

    public class CommandInterpreter
    {
        private readonly CommandFactory commandFactory;
        private readonly Chatroom chatroom;

        public CommandInterpreter(Chatroom chatroom)
        {
            this.commandFactory = new CommandFactory();
            this.chatroom = chatroom;
        }

        public void ProcessCommand(string input)
        {
            string[] tokens = input.Split(' ').ToArray();
            string commandType = tokens.First();
            string[] arguments = tokens.Skip(1).ToArray();

            ICommand command = this.commandFactory.Create(commandType);

            command.Execute(this.chatroom, arguments);
        }
    }
}
