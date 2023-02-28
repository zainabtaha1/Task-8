using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 in  section 3
            Console.WriteLine(" Enter the first number ");
            double firstnum = double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the second number ");
            double secondnum = double.Parse(Console.ReadLine());
            double result;
            result = firstnum + secondnum;
            Console.WriteLine(firstnum + "+" + secondnum + "=" + result);
            result = firstnum - secondnum;
            Console.WriteLine(firstnum + "-" + secondnum + "=" + result);
            result = firstnum * secondnum;
            Console.WriteLine(firstnum + "*" + secondnum + "=" + result);
            result = firstnum / secondnum;
            Console.WriteLine(firstnum + "/" + secondnum + "=" + result);
            result = firstnum % secondnum;
            Console.WriteLine(firstnum + "%" + secondnum + "=" + result);
        }
    }
}
