using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Fibonacci
    {
        public void FibonnaciMethod()
        {
            Console.Write("Enter the nth term: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            int sum;
            Console.Write("The terms in the fibonacci series are: " + first + ", " + second);
            for (int i = 1; i <= n - 2; i++)
            {
                sum = first + second;
                Console.Write(", " + sum);
                first = second;
                second = sum;
            }
            Console.ReadLine();
        }
    }
}
