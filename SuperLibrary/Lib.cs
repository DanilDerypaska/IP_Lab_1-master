using System;

namespace ClassLibrary
{
    public class Lib
    {
        /// <summary>
        /// </summary>
        /// <param name="katetOne"></param>
        /// <param name="katetTwo"></param>
        /// <returns></returns>        
        public static double FindHypotenuse(double katetOne, double katetTwo)
        {

            double koef = katetOne + katetTwo;
            if (koef > 0)
            {
                return (Math.Sqrt(Math.Pow(katetOne, 2) + Math.Pow(katetTwo, 2)));
            }
            else
            {
                Console.WriteLine("Ви ввели не коректні данні");
                return 0;
            }

        }

        /// <summary>
        /// </summary>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>        
        public static double Summa(int n, double x)
        {
            double s = 0;
            bool q = true;
            for (int i = 1; i == n; i++)
            {
                if (q)
                {
                    s = s + (Math.Sin(i * x) / i);
                    q = false;
                }
                else
                {
                    s = s - (Math.Sin(i * x) / i);
                    q = true;
                }
            }
            s = s + Math.Pow(-1, n - 1) * Math.Sin(n * x) / n;
            return s;
        }

    }
}
