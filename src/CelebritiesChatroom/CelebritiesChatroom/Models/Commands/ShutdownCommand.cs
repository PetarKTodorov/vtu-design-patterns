namespace CelebritiesChatroom.Models.Commands
{
    using System;

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
