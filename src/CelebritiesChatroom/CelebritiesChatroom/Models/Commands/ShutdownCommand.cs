namespace CelebritiesChatroom.Models.Commands
{
    using CelebritiesChatroom.Common;
    using CelebritiesChatroom.Models.Chatrooms;
    using CelebritiesChatroom.Models.Commands.Interfaces;

    public class ShutdownCommand : ICommand
    {
        public void Execute(Chatroom chatroom, params string[] arguments)
        {
            Constants.IsApplicationRun = false;
        }
    }
}
