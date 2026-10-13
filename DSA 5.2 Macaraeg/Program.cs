
/*
 * DSA Activity 5.2 - [Macaraeg, Lorena]
 * Program Description:Create a program that will ask the user to enter a word then determine if it is a
palindrome. Palindrome word that are spelled the same forward and backward. You
must use stack algorithm in solving this problem. The program shall continuously accept
entries until the user entered 0 to exit the program.
 */

using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PALINDROME PROGRAM");
            Console.WriteLine("Enter 0 to exit.\n");

            while (true)
            {
                Console.Write("Enter word: ");
                string word = Console.ReadLine();

                // Check if user wants to exit
                if (word == "0")
                {
                    Console.WriteLine("Thank you for using the program");
                    break;
                }

                // Push all characters of the word onto the Stack
                Stack<char> charStack = new Stack<char>();
                foreach (char c in word)
                {
                    charStack.Push(c);
                }

                // Pop characters from the stack and compare with the original word
                bool isPalindrome = true;
                foreach (char c in word)
                {
                    if (c != charStack.Pop())
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                // Output the result matching the school's sample output format
                if (isPalindrome)
                {
                    Console.WriteLine("It is PALINDROME");
                }
                else
                {
                    Console.WriteLine("It is NOT PALINDROME");
                }
            }
        }
    }
}

