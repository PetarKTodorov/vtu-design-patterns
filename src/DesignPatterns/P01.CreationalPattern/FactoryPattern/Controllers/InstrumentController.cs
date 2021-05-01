namespace P01.CreationalPattern.FactoryPattern.Controllers
{
    using System;

    using P01.CreationalPattern.FactoryPattern.Controllers.Interfaces;
    using P01.CreationalPattern.FactoryPattern.Factories;
    using P01.CreationalPattern.FactoryPattern.Models.Interfaces;

    public class InstrumentController : IController
    {
        private InstrumentFactory instrumentFactory;

        public InstrumentController()
        {
            this.instrumentFactory = new InstrumentFactory();
        }

        public string Create(string type)
        {
            string result = string.Empty;

            try
            {
                IInstrument instrument = this.instrumentFactory.CreateInstrument(type);

                result = "Successfully created: " + instrument.ToString();
            }
            catch (ArgumentException ae)
            {
                result = ae.Message;
            }

            return result;
        }
    }
}
