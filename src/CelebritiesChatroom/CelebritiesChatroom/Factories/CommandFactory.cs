namespace CelebritiesChatroom.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using CelebritiesChatroom.Factories.Interfaces;
    using CelebritiesChatroom.Models.Commands.Interfaces;

    public class CommandFactory : IFactory<ICommand>
    {
        private const string COMMAND_SUFIX = "Command";

        public ICommand Create(params string[] tokens)
        {
            string commandName = tokens[0] + COMMAND_SUFIX;

            Type commandType = Assembly.GetCallingAssembly()
                .GetTypes()
                .Where(t => typeof(ICommand).IsAssignableFrom(t))
                .FirstOrDefault(t => t.Name == commandName);

            ICommand command = (ICommand)Activator.CreateInstance(commandType);

            return command;
        }
    }
}
