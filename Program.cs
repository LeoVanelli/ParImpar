using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double _numero = double.Parse(Console.ReadLine());
            string _validador = _numero % 2 == 0 ? "Par" : "Impar";

            Console.WriteLine($"{_numero} é {_validador}");
        }
    }
}
