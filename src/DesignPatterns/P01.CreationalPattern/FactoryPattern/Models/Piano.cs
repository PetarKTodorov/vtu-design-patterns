namespace P01.CreationalPattern.FactoryPattern.Models
{
    public class Piano : Instrument
    {
        private const decimal REPAIER_AMOUNT = 80.60m;

        public Piano()
        {
            this.Price = 45.99m;
        }

        protected override decimal RepairAmount => REPAIER_AMOUNT;
    }
}
