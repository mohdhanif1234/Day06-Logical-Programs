using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public void PerfectNumberMethod()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Write("The divisors of {0} are: ", number);
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("\n" + number + " is a perfect number");
            }
            else
            {
                Console.WriteLine("\n" + number + " is not a perfect number");
            }
            Console.ReadLine();
        }
    }
}
