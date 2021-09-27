using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public void PrimeNumberMethod()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i=2; i < number / 2; i++)
            {
                int temp = number % i;
                if (temp == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("{0} is a  prime number",number);
                Console.ReadLine();
            } 
            else
            {
                Console.Write("{0} is not a prime number",number);
                Console.ReadLine();
            }
            
        }
    }
}
