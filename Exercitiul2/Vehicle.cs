using System;
using System.Collections.Generic;

namespace Exercitiul2
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public List<string> Accessories { get; set; }

        public Vehicle()
        {
            Accessories = new List<string>();
        }

        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Engine: {0}", Engine);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Accessories:");
            foreach (var accessory in Accessories)
            {
                Console.WriteLine("{0}", accessory);
            }
        }
    }
}
