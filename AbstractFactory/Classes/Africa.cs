using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    class Africa : IContinent
    {
        public IHerbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}