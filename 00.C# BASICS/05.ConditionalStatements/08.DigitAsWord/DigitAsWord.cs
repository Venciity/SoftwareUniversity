﻿/*Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 * Print “not a digit” in case of invalid inut. Use a switch statement. */
using System;

    class DigitAsWord
    {
        static void Main()
        {
            Console.Write("Enter digit in range from 0 to 9 : ");
            string digit = Console.ReadLine();

            switch (digit)
            {
                case "0":
                    Console.WriteLine("Result : zero");
                    break;
                case "1":
                    Console.WriteLine("Result : one");
                    break;
                case "2":
                    Console.WriteLine("Result : two");
                    break;
                case "3":
                    Console.WriteLine("Result : three");
                    break;
                case "4":
                    Console.WriteLine("Result : four");
                    break;
                case "5":
                    Console.WriteLine("Result : five");
                    break;
                case "6":
                    Console.WriteLine("Result : six");
                    break;
                case "7":
                    Console.WriteLine("Result : seven");
                    break;
                case "8":
                    Console.WriteLine("Result : eight");
                    break;
                case "9":
                    Console.WriteLine("Result : nine");
                    break;
                default:
                    Console.WriteLine("Result : not a digit");
                    break;
            }
        }
    }