using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{


    public delegate double Add(double val1, double val2);
    public delegate double Sub(double val1, double val2);
    public delegate double Mul(double val1, double val2);
    public delegate double Div(double val1, double val2);

    internal class Program
    {
        static void Main(string[] args)
        {

            Add add = (val1, val2) => { return val1 + val2; };
            Sub sub = (val1, val2) => { return val1 - val2; };
            Mul mul = (val1, val2) => { return val1 * val2; };
            Div div = (val1, val2) =>
            {
                if (val1 != 0 && val2 != 0)
                    return val1 / val2;
                else 
                    return double.NaN;
            };

            while (true)
            {
                double operand1 = UserInterface.InNumData("Введить число 1: ");
                double operand2 = UserInterface.InNumData("Введить число 2: ");
                string mathOperator = UserInterface.InMathOperator();

                double sum = (mathOperator == "+") ? add(operand1, operand2) 
                    : (mathOperator == "-") ? sub(operand1, operand2)
                    : (mathOperator == "*") ? mul(operand1, operand2)
                    : (mathOperator == "/") ? div(operand1, operand2) : double.NaN;

                string line = new String('=', 50);

                Console.Clear();
                if (double.IsNaN(sum))
                {
                    Console.WriteLine(line);
                    UserInterface.ShowError("Помилка! Спробуйде ще раз!");
                    Console.WriteLine(line);
                }
                else
                {
                    Console.WriteLine(line);
                    Console.WriteLine($"Результат операції {operand1} {mathOperator} {operand2} = {sum}");
                    Console.WriteLine(line);
                }

                Console.Write("\nНатисни на будь яку кнопку щоб продовжити!");
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}
