using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprogramming
{
    public class Uc2
    {
        public void evenOdd()
        {
                Console.WriteLine("enter number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("even number ");
                }
                else
                {
                    Console.WriteLine("odd number");
                }

            }
    }
}
