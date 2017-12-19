using System;

namespace zoo
{
    public class Animal
    {
        public string Name;
        public bool Hungry;
        private string _food;

        public string Type;

        public void Feed(string food)
        {
            if (food == _food)
            {
                Hungry = false;
                Console.WriteLine($@"
                Yumm thanks for the {food}
                {Name} is no longer hungry!
                ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine($"{Name}, vomits that {food} right up, they want {_food}");
                Console.BackgroundColor = ConsoleColor.Black;
            }

        }


        public Animal(string name, string food, string type)
        {
            Name = name;
            _food = food;
            Type = type;
        }
    }
}