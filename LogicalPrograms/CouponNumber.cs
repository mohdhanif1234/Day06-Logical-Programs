using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public void CouponNumberMethod()
        {
            // Displaying the message for input
            Console.WriteLine("Assuming the coupon numbers are availaible between 1 and 10, including 1 and 30");
            Console.Write("How many distinct coupon numbers do you want to generate?: ");
            int couponNumbers = Convert.ToInt32(Console.ReadLine());

            // Variable declaration and assigning
            int[] distinct = new int[couponNumbers];
            int randomNumCount = 0, x = 0;

            // Computation
            Random random = new Random();
            for (int i = 0; i < couponNumbers; i++)
            {
                distinct[i] = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    randomNumCount++;
                    x = random.Next(1, 11); // Random numbers from 1 to 10 including 1 and 10 will be generated
                    if (x == distinct[i])
                    {
                        // Displaying the result
                        Console.WriteLine("To generate {0}, {1} distinct random number/s were required",distinct[i],randomNumCount);
                        randomNumCount = 0;
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
