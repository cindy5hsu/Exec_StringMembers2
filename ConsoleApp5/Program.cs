using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q5.比對使用者輸入值是否為 "Allen" 不拘大小寫
            string answer = "Allen";

            Console.WriteLine("請輸入驗證碼， 不拘是小寫： ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您沒有輸入");
                return;
            }

            if (answer.ToLower() == input.ToLower())
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
