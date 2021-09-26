namespace AbstractFactory.Interfaces
{
    public interface IContinent
    {
        IHerbivore CreateHerbivore();
        ICarnivore CreateCarnivore();
    }
}
