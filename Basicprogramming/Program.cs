// See https://aka.ms/new-console-template for more information
using System;

public class Vowels
{
    static void Main(string[] args)
    {
        char ch;

        Console.WriteLine("Enter any character: ");
        ch = Convert.ToChar(Console.ReadLine());


        // Condition for vowel checking
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
        {

            Console.WriteLine(ch + " is Vowel.");

        }
        else
        {
            Console.WriteLine(ch + " is Consonant.");
        }

        Console.ReadLine();
    }
}