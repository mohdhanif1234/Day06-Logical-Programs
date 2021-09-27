using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Fibonacci series program");
            Console.WriteLine("Enter 2 for Perfect program");
            Console.WriteLine("Enter 3 for Prime Number program");
            Console.WriteLine("Enter 4 for Reverse Number program");
            Console.WriteLine("Enter 5 for Coupon Number program");
            Console.WriteLine("Enter 6 for Stopwatch Simulator program");
            Console.Write("Select any option to run a particular program: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Fibonacci fibo = new Fibonacci();
                    fibo.FibonnaciMethod();
                    break;
                case 2:
                     PerfectNumber perfNum = new PerfectNumber();
                    perfNum.PerfectNumberMethod();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.PrimeNumberMethod();
                    break;
                case 4:
                    int finalReverse;
                    Palindrome palindrome = new Palindrome();
                    finalReverse = palindrome.PalindromeMethod();
                    Console.WriteLine("The reverse of the given number = " + finalReverse);
                    Console.ReadLine();
                    break;
                case 5:
                    CouponNumber coupon = new CouponNumber();
                    coupon.CouponNumberMethod();
                    break;
                case 6:
                    StopwatchSimulator.StopwatchSimulatorMethod();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input!!!");
                break;
            }
            
        }
    }
}
