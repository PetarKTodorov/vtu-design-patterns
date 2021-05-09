namespace P03.BehavioralPattern.CommandPattern.Commands
{
    using P03.BehavioralPattern.CommandPattern.Commands.Interfaces;
    using P03.BehavioralPattern.CommandPattern.Enums;
    using P03.BehavioralPattern.CommandPattern.Models;

    public class ProductCommand : ICommand
    {
        private readonly Product product;
        private readonly PriceAction priceAction;
        private readonly int amount;

        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            this.product = product;
            this.priceAction = priceAction;
            this.amount = amount;
        }

        public void ExecuteAction()
        {
            if (this.priceAction == PriceAction.Increase)
            {
                this.product.IncreasePrice(this.amount);
            }
            else
            {
                this.product.DecreasePrice(this.amount);
            }
        }
    }
}
