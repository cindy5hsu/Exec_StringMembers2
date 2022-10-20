using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q8隱藏手機的資訊,呈現 0935****46
            Console.WriteLine("請輸入您的電話號碼 ：");
            string sid = Console.ReadLine();

            //pre condition
            if (string.IsNullOrEmpty(sid) || sid.Length !=10)
            {
                Console.WriteLine("sid 格式不對");
                return;
            }
            //加密
            string encryptedSid = sid.Substring(0, 4) + new string('*', 4) + sid.Substring(8, 2);

            Console.WriteLine(encryptedSid);
        }
    }
}
