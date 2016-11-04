using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Please enter a number");
                int n = Console.Read();
                sum += n;
            }
            int average = sum / 10;
            Console.Write(average);
            Console.ReadLine();
        }
    }
}
