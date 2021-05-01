using System;
using System.Linq;
using P01.CreationalPattern.FactoryPattern.Controllers;
using P01.CreationalPattern.FactoryPattern.Controllers.Interfaces;
using P01.CreationalPattern.FactoryPattern.Factories;
using P01.CreationalPattern.FactoryPattern.Models.Interfaces;

namespace P01.CreationalPattern.FactoryPattern
{
    public class Engine
    {
        private const string FINISH_COMMAND = "Finish";
        private const string CREATE_COMMAND = "Create";

        private IController instrumentController;

        public Engine()
        {
            this.instrumentController = new InstrumentController();
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != FINISH_COMMAND)
            {
                string result = String.Empty;
                string[] arguments = input.Split(' ');

                string command = arguments.First();
                string instrumentType = arguments.Skip(1).Take(1).ToArray().First();

                switch (command)
                {
                    case CREATE_COMMAND:
                        result = this.instrumentController.Create(instrumentType);
                        break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
