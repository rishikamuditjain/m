using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= n; i++) {
                result = result * i;
                Console.WriteLine(i + "! = " + result);
            }
            Console.ReadLine();
        }
    }
}
