namespace CelebritiesChatroom.Models.Commands
{
    using CelebritiesChatroom.Factories;
    using CelebritiesChatroom.Models.Chatrooms;
    using CelebritiesChatroom.Models.Commands.Interfaces;
    using CelebritiesChatroom.Models.Users.Interfaces;

    public class RegisterCelebrityCommand : ICommand
    {
        private readonly UserFactory userFactory;

        public RegisterCelebrityCommand()
        {
            this.userFactory = new UserFactory();
        }

        public void Execute(Chatroom chatroom, params string[] arguments)
        {
            IUser user = this.userFactory.Create(arguments);

            chatroom.Register(user);
        }
    }
}
