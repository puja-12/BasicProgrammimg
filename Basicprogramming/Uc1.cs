using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprogramming
{
   class Uc1
    {
        public void checkLeapyear()
        {
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("leap year");
                    }
            else
            {
                Console.WriteLine("not leap year");
            }
             
        }
    }
}
