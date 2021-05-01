namespace P01.CreationalPattern.FactoryPattern.Models.Interfaces
{
    public interface IInstrument
    {
        decimal Price { get; set; }

        bool IsBroken { get; set; }
    }
}
