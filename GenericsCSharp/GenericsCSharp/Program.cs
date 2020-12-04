using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>()
            {
                new Animal
                {
                    Nome = "Dog"
                },

                new Animal
                {
                    Nome = "Cat"
                },

                new Animal
                {
                    Nome = "Lion"
                },

                new Animal
                {
                    Nome = "Elephant"
                }
            };

            Console.WriteLine($"Total de animais: {animals.Count}");

            var selectAnimais = from animal in animals
                                //where animal.Nome.Contains("a")
                                select animal;

            foreach (var animal in selectAnimais)
            {
                Console.WriteLine($"Nome dos animais: {animal.Nome}");
            }

            //método genérico
            int x = 5, y = 5;
            Animal.GetSum(ref x, ref y);

            string a = "6", b = "10";
            Animal.GetSum(ref a, ref b);

            Console.ReadLine();
        }
    }
}
