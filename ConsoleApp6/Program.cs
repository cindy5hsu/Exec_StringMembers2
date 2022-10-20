using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q6.比對使用者輸入值是否為 "Allen", 區分大小寫
           
            string answer = "Allen";

            Console.WriteLine("請輸入驗證碼， 區分大小寫： ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您沒有輸入");
                return;
            }

            if ( answer == input)
            {
                Console.WriteLine("正確");
            }

            else
            {
                Console.WriteLine("錯誤");
            }

        }
    }
}
