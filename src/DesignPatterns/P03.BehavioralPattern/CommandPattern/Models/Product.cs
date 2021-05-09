namespace P03.BehavioralPattern.CommandPattern.Models
{
    using System;

    public class Product
    {
        private const string INCREASE_PRICE_MESSAGE = "The price for the {0} has been increase by ${1}";
        private const string DECREASE_PRICE_MESSAGE = "The price for the {0} has been decrease by ${1}";

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public int Price { get; set; }

        public void IncreasePrice(int amount)
        {
            this.Price += amount;

            string increasePriceMessage = String.Format(INCREASE_PRICE_MESSAGE, this.Name, amount);

            Console.WriteLine(increasePriceMessage);
        }

        public void DecreasePrice(int amount)
        {
            if (amount < this.Price)
            {
                this.Price -= amount;

                string decreasePriceMessage = String.Format(DECREASE_PRICE_MESSAGE, this.Name, amount);

                Console.WriteLine(decreasePriceMessage);
            }
        }

        public override string ToString() 
        {
            string productAsString = $"Current price for the {Name} product is ${Price}";

            return productAsString;
        } 
    }
}
