using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{

    public delegate int RandIntDelegat();

    public delegate int AverageDelegat(RandIntDelegat[] intDelegats);


    internal class Program
    {
        static void Main(string[] args)
        {

            RandIntDelegat randIntDelegat = () => { return new Random().Next(1, 100); };
            AverageDelegat averageDelegat = (RandIntDelegat[] intDelegats) =>
            {
                int sum = default;
                foreach (var item in intDelegats)
                {
                    sum += item();
                }

                return sum / intDelegats.Length;
            };

            RandIntDelegat[] rands =
            {
                randIntDelegat,
                randIntDelegat,
                randIntDelegat
            };

            int allSum = averageDelegat(rands);
            Console.WriteLine($"Середне арехметичне буде: {allSum}");

            Console.ReadKey();
        }
    }
}
