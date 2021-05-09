namespace P02.StructuralPattern.FacadePattern.Core
{
    using P02.StructuralPattern.FacadePattern.Model;

    public class CarAddressBuilder : CarBuilderFacade
    {
        public CarAddressBuilder(Car car)
        {
            Car = car;
        }

        public CarAddressBuilder InCity(string city)
        {
            Car.City = city;

            return this;
        }

        public CarAddressBuilder AtAddress(string address)
        {
            Car.Address = address;

            return this;
        }
    }
}
