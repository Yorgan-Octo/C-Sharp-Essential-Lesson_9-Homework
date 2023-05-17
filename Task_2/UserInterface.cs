using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class UserInterface
    {

        public static double InNumData(string info = "Введіть число: ")
        {
            double operand;

            Console.Clear();
            while (true)
            {
                try
                {
                    Console.Write(info);
                    operand = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Clear();
                    ShowError();
                }
            }
            return operand;
        }
        public static string InMathOperator(string info = "Введіть оператор: ")
        {

            string mathOperator;

            Console.Clear();
            while (true)
            {
                Console.Write(info);
                mathOperator = Console.ReadLine().Replace(" ", "");

                if (mathOperator == "+" || mathOperator == "-" || mathOperator == "*" || mathOperator == "/")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    ShowError();
                }
            }

            return mathOperator;
        }
        public static void ShowError(string error = "Помилка")
        {

            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = color;

        }


    }
}
