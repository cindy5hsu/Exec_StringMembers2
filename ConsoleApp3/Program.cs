using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Q3將字串 "aLLeN kUO" 轉換成 "Allen Kuo"

            // Defines the string with mixed casing.
            string myString = "aLLeN kUO";
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            // Changes a string to titlecase.
            Console.WriteLine("\"{0}\" to titlecase: {1}", myString, myTI.ToTitleCase(myString));
        }
    }
}
