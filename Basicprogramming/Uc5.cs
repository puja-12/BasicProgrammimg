﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprogramming
{
    class Uc5
    {
      
            public void maxOfThree()
            {
                int num1;
                int num2;
                int num3;
                Console.Write("Input the 1st number :");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the  2nd number :");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 3rd  number :");
                num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.Write("Number one is the largest!\n");
                    }
                    else
                    {
                        Console.Write("Number three is the largest!\n");
                    }
                }
                else if (num2 > num3)
                    Console.Write("Number two is the largest!\n");
                else
                    Console.Write("Number three is the largest!\n");
            }
        }
    }