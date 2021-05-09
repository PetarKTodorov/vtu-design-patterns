namespace P03.BehavioralPattern.CommandPattern
{
    using System;

    using P03.BehavioralPattern.CommandPattern.Commands;
    using P03.BehavioralPattern.CommandPattern.Commands.Interfaces;
    using P03.BehavioralPattern.CommandPattern.Controllers;
    using P03.BehavioralPattern.CommandPattern.Enums;
    using P03.BehavioralPattern.CommandPattern.Models;

    public class Engine
    {
        public void Run()
        {
            var modifyPriceController = new ModifyPriceController();
            var product = new Product("Phone", 500);

            Execute(product, modifyPriceController, new ProductCommand(product, PriceAction.Increase, 100));

            Execute(product, modifyPriceController, new ProductCommand(product, PriceAction.Increase, 50));

            Execute(product, modifyPriceController, new ProductCommand(product, PriceAction.Decrease, 25));

            Console.WriteLine(product);
        }

        private static void Execute(Product product, ModifyPriceController modifyPrice, ICommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);

            modifyPrice.Invoke();
        }
    }
}
