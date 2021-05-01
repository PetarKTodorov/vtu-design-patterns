namespace P01.CreationalPattern.FactoryPattern.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using P01.CreationalPattern.FactoryPattern.Common;
    using P01.CreationalPattern.FactoryPattern.Models.Interfaces;

    public class InstrumentFactory
    {
        public IInstrument CreateInstrument(string type)
        {
            var instrumentType = Assembly.GetCallingAssembly()
                .GetTypes()
                .Where(t => typeof(IInstrument).IsAssignableFrom(t))
                .FirstOrDefault(t => t.Name == type);

            if (instrumentType == null)
            {
                string error = string.Format(ErrorMessages.InvalideInstrument, type);

                throw new ArgumentException(error);
            }

            IInstrument instrument = (IInstrument)Activator.CreateInstance(instrumentType);

            return instrument;
        }
    }
}
