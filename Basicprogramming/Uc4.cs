using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprogramming
{
    class Uc4
    {
        public  void Harmonic()
        {
            int i, n;
            double s = 0.0;
            float harmonic = 1;


            Console.Write("Calculate the harmonic series and their sum:\n");
            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {

                Console.Write("1/{0}  ", i);
            }
        }
    }
}
