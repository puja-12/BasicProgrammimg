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
                Console.WriteLine("select number\n1)Leap year\n2)even odd\n3) swap\n4) Harmonic\n5) " +
                    "MaxOfThreeNumbers\n6) Quotient and remainder\n7 VowelsOrConsonent\n8 PowerOf2\n ");
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
                    case 3:
                        uc3 swap = new uc3();
                        swap.SwapExample();
                        break;
                    case 4:
                        Uc4 harmonic = new Uc4();
                        harmonic.Harmonic();
                        break;
                    case 5:
                        Uc5 maxofthree = new Uc5();
                        maxofthree.maxOfThree();
                        break;
                    case 6:
                        Uc6 quotient = new Uc6();
                        quotient.QuotientRemainder();
                        break;
                    case 7:
                        Uc7 test = new Uc7();
                        test.vowels();
                        break;
                    case 8:
                        Uc8cs power = new Uc8cs();
                        power.PowerOf2();
                        break;


                }

            }
        }
    }
}