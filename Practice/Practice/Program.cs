using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            String strName;
            while (true)
            {
                Console.Write("Please enter the month number (1 to 12): ");
                strName = Console.ReadLine();

                String month;
                int days;
                switch (strName)
                {
                    case "1": month = "January"; days = 31; break;
                    case "2": month = "February"; days = 29; break;
                    case "3": month = "March"; days = 31; break;
                    case "4": month = "April"; days = 30; break;
                    case "5": month = "May"; days = 31; break;
                    case "6": month = "June"; days = 30; break;
                    case "7": month = "July"; days = 31; break;
                    case "8": month = "August"; days = 31; break;
                    case "9": month = "September"; days = 30; break;
                    case "10": month = "October"; days = 31; break;
                    case "11": month = "November"; days = 30; break;
                    case "12": month = "December"; days = 31; break;
                    default: month = "Unknown"; days = -1; break;
                }
                Console.WriteLine("The month {0} has {1} days", month, days);
                Console.ReadLine();
            }         
        }
    }
}