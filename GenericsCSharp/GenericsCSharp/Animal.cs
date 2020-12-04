using System;
namespace GenericsCSharp
{
    public class Animal
    {
        public string Nome { get; set; }
        public Animal(string nome = "Sem nome")
        {
            Nome = nome;
        }

        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double n1 = Convert.ToDouble(num1);
            double n2 = Convert.ToDouble(num2);

            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        }
    }
}
