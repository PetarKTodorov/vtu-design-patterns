namespace P02.StructuralPattern.FacadePattern.Core
{
    using P02.StructuralPattern.FacadePattern.Model;

    public class CarInfoBuilder : CarBuilderFacade
    {
        public CarInfoBuilder(Car car)
        {
            Car = car;
        }

        public CarInfoBuilder WithType(string type)
        {
            Car.Type = type;

            return this;
        }

        public CarInfoBuilder WithColor(string color)
        {
            Car.Color = color;

            return this;
        }

        public CarInfoBuilder WithNumberOfDoors(int number)
        {
            Car.NumberOfDoors = number;

            return this;
        }
    }
}
