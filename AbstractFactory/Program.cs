using System;
using AbstractFactory.Classes;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IContinent africa = new Africa();
            IContinent america = new America();

            AnimalWorld africanAnimalWorld = new AnimalWorld(africa);
            AnimalWorld americanAnimalWorld = new AnimalWorld(america);

            africanAnimalWorld.RunFoodChain();
            americanAnimalWorld.RunFoodChain();

            // Console.WriteLine("Hello World!");
        }
    }
}
