namespace P02.StructuralPattern.FacadePattern.Core
{
    using P02.StructuralPattern.FacadePattern.Model;

    public class CarBuilderFacade
    {
        public CarBuilderFacade()
        {
            Car = new Car();
        }

        protected Car Car { get; set; }

        public Car Build() => Car;

        public CarInfoBuilder Info => new CarInfoBuilder(Car);
        public CarAddressBuilder Built => new CarAddressBuilder(Car);
    }
}
