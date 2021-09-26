using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    class AnimalWorld
    {
        private readonly IHerbivore _herbivore;
        private readonly ICarnivore _carnivore;

        public AnimalWorld(IContinent continent)
        {
            _carnivore = continent.CreateCarnivore();
            _herbivore = continent.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}