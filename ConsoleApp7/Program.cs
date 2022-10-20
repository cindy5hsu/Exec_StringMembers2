using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q7計算兩數之和,並只呈現小數二位數
            double n1 = 1.234567;
            double n2 = 100.2;

            double sum = n1 + n2;

            Console.WriteLine(sum.ToString("0.00"));
        }
    }
}
