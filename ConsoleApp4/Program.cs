using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q4假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
            string inputDate = "110/02/25";
            CultureInfo culture = new CultureInfo("zh-TW");
            culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            DateTime dateTime = DateTime.Parse(inputDate,culture);
            Console.WriteLine(dateTime.ToString("yyyy/MM/dd"));

        }
    }
}
