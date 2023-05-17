using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{


    public delegate double Average(int nam1, int nam2, int nam3);
    public delegate (int, int, int) IntManIn();

    internal class Program
    {
        public static int UsInNams(string mesText)
        {
            int nam;

            Console.Clear();
            while (true)
            {
                
                try
                {
                    Console.Write(mesText);
                    nam = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка, не вірні данні! ");
                    Console.ResetColor();
                }
            }
            return nam;
        }

        static void Main(string[] args)
        {

            IntManIn intManIn = () =>
            {
                int nam1 = UsInNams("Введите число 1: ");
                int nam2 = UsInNams("Введите число 2: ");
                int nam3 = UsInNams("Введите число 3: ");
                return (nam1, nam2, nam3);
            };


            var nams = intManIn();


            Average average = (int nam1, int nam2, int nam3) => { return (nam1 + nam2 + nam3) / 3; };
            
            double sum = average(nams.Item1, nams.Item2, nams.Item3);

            Console.Clear();
            Console.WriteLine(new String('=',70));
            Console.WriteLine($"Середне арехметичне буде: {sum}");
            Console.WriteLine(new String('=', 70));

            Console.ReadKey();
        }


    }
}
