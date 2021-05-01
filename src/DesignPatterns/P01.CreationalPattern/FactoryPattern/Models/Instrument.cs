namespace P01.CreationalPattern.FactoryPattern.Models
{
    using System.Text;

    using Interfaces;

    public abstract class Instrument : IInstrument
    {
        public decimal Price { get; set; }

        public bool IsBroken { get; set; }

        protected abstract decimal RepairAmount { get; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append($"{this.GetType().Name}, ");
            stringBuilder.Append($"Price: ${this.Price}, ");
            stringBuilder.Append($"Is broken: {this.IsBroken}");

            if (this.IsBroken)
            {
                stringBuilder.Append($", Repair amount: {this.RepairAmount}");
            }

            string instrumentAsString = stringBuilder.ToString().Trim();

            return instrumentAsString;
        }
    }
}
