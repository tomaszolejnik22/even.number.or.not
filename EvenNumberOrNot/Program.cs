using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Proszę, podaj liczbę całkowitą!");
                var number = GetInput();

                if (number % 2 == 0)
                {
                    Console.WriteLine("Liczba parzysta");
                }
                else
                {
                    Console.WriteLine("Liczba nieparzysta");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int number))
                throw new Exception("Podana wartość jest nieprawidłowa");

            return number;
        }
    }
}
