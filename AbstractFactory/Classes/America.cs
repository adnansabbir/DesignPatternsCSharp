using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    class America : IContinent
    {
        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}