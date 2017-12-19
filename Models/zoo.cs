using System;
using System.Collections.Generic;

namespace zoo
{

    public class Zoo
    {
        public string Name;

        public string Location;

        // public List<Animal> Animals = new List<Animal>();

        private Dictionary<string, List<Animal>> _pens;

        public void AddAnimal(Animal animal)
        {
            if(!_pens.ContainsKey(animal.Type)){
                _pens[animal.Type] = new List<Animal>();
            }
            _pens[animal.Type].Add(animal);
        }
        public void printDirectory()
        {
           foreach (var pen in _pens)
           {
               Console.WriteLine(pen.Key);
               foreach (var animal in pen.Value)
               {
                   Console.WriteLine($"  {animal.Name}");
               }
           }
        }

        public Zoo(string name, string location)
        {
            Name = name;
            Location = location;
            _pens = new Dictionary<string, List<Animal>>();
        }

    }
}