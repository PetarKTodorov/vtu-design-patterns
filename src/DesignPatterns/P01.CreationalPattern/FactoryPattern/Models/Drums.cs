namespace P01.CreationalPattern.FactoryPattern.Models
{
    public class Drums : Instrument
    {
        private const decimal REPAIER_AMOUNT = 40;

        public Drums()
        {
            this.Price = 100;
        }

        protected override decimal RepairAmount => REPAIER_AMOUNT;
    }
}
