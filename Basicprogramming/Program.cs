// See https://aka.ms/new-console-template for more information
using System;

namespace Basicprogramming
{
    class Program

    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("select number\n1)Leap year\n2)even odd\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Uc1 leap = new Uc1();
                        leap.checkLeapyear();
                        break;
                    case 2:
                        Uc2 evenodd = new Uc2();
                        evenodd.evenOdd();
                        break;
                }

            }
        }
    }
}