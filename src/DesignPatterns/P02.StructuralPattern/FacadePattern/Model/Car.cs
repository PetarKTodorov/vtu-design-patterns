namespace P02.StructuralPattern.FacadePattern.Model
{
    public class Car
    {
        public string Type { get; set; }

        public string Color { get; set; }

        public int NumberOfDoors { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            string carAsString = $"CarType: {Type}, Color: {Color}, Number of doors: {NumberOfDoors}, Manufactured in {City}, at address: {Address}";

            return carAsString;
        }
    }
}
