using System;
using ClassLibrary;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Функцiя знаходження гіпотенузи прямокутного трикутника");
            double katetOne = Enter("Введіть перший катет ");
            double katetTwo = Enter("Введіть другий катет ");
            double c;
            c = Lib.FindHypotenuse(katetOne, katetTwo);
            Console.WriteLine($"Гипотенуза = {c}");
            Console.ReadLine();

            Console.WriteLine("2) Знаходження суми ряду.");
            Console.WriteLine("Введiть n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double x = Enter("Введiть x: ");
            Console.WriteLine("Сума ряду" + Lib.Summa(n, x));
     
        }

        public static double Enter(string text)
        {
            double n;
            Console.Write(text);
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Невірні дані");
                Console.Write("Спробуйте ще раз : ");
            }
            return n;
        }   
    }
}
