using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    class Lion: ICarnivore
    {
        public void Eat(IHerbivore h)
        {
            Console.WriteLine($"{this.GetType().Name} eats {h.GetType().Name}");
        }
    }
}
