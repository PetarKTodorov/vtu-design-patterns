namespace P01.CreationalPattern.FactoryPattern.Models
{
    public class Guitar : Instrument
    {
        private const decimal REPAIER_AMOUNT = 60;

        public Guitar()
        {
            this.Price = 200.20m;
        }

        protected override decimal RepairAmount => REPAIER_AMOUNT;
    }
}
