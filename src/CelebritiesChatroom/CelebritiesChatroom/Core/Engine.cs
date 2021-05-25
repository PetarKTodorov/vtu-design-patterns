namespace CelebritiesChatroom.Core
{
    using System;

    using CelebritiesChatroom.Common;
    using CelebritiesChatroom.Models.Chatrooms;

    public class Engine
    {
        public void Run()
        {
            Chatroom chatroom = new Chatroom();
            CommandInterpreter commandInterpreter = new CommandInterpreter(chatroom);

            while (Constants.IsApplicationRun)
            {
                try
                {
                    string input = Console.ReadLine();
                    commandInterpreter.ProcessCommand(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
