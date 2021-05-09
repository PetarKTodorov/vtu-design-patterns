namespace P02.StructuralPattern.FacadePattern
{
    using System;

    using P02.StructuralPattern.FacadePattern.Core;

    public class Engine
    {
        public void Run()
        {
            var car = new CarBuilderFacade()
                .Info
                    .WithType("Honda")
                    .WithColor("Red")
                    .WithNumberOfDoors(5)
                .Built
                    .InCity("Karlovo")
                    .AtAddress("Yumruk-Chal 1")
                .Build();

            Console.WriteLine(car);
        }
    }
}
