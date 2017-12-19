using System;

namespace zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Zoo zooBoise = new Zoo("Zoo Boise", "Boise, ID");

            Animal simba = new Animal("Simba", "grubs", "Lion");
            Animal nala = new Animal("Nala", "Fear", "Lion");
            Animal scar = new Animal("Scar", "Dirt", "Lion");
            Animal zazu = new Animal("Zazu", "coconuts", "Bird");
            Animal sam = new Animal("Tucan Sam", "Fruit Loops", "Bird");
            Animal tweety = new Animal("Tweety", "cats", "Bird");
            Animal smokey = new Animal("Smokey", "Forest Fire Starters", "Bear");
            Animal fozzie = new Animal("Fozzie", "Tomatoes", "Bear");

            // zooBoise.Animals.Add(simba);
            // zooBoise.Animals.Add(zazu);
            zooBoise.AddAnimal(simba);
            zooBoise.AddAnimal(nala);
            zooBoise.AddAnimal(scar);
            zooBoise.AddAnimal(zazu);
            zooBoise.AddAnimal(sam);
            zooBoise.AddAnimal(tweety);
            zooBoise.AddAnimal(smokey);
            zooBoise.AddAnimal(fozzie);
            



            Console.WriteLine("Hello Zoo's!");
            zooBoise.printDirectory();







            // for (int i = 0; i < zooBoise.Animals.Count; i++)
            // {
            //     Console.WriteLine(zooBoise.Animals[i].Name);
            // }
            // System.Console.WriteLine("Feeding Simba Rocks!");
            // simba.Feed("Rocks");
            // System.Console.WriteLine("Oops feeding Simba grubs....");
            // simba.Feed("grubs");
        }
    }
}
