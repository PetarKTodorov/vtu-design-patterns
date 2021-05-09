namespace P03.BehavioralPattern.CommandPattern.Controllers
{
    using System.Collections.Generic;

    using P03.BehavioralPattern.CommandPattern.Commands.Interfaces;

    public class ModifyPriceController
    {
        private readonly ICollection<ICommand> commands;
        private ICommand command;

        public ModifyPriceController()
        {
            this.commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command) => this.command = command;

        public void Invoke()
        {
            this.commands.Add(this.command);

            this.command.ExecuteAction();
        }
    }
}
