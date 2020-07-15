using System;
using System.Collections;
using System.Text;

namespace Lab3._3DataStructures
{
    class Program
    {
        static string ReverseString(string forward)
        {  
            //initiate stack
            Stack wordForward = new Stack();
            string reversedWord = "";
           

            foreach (char letter in forward)
            {
                //use stack to store characters
                wordForward.Push(letter);
            }

            for (int index = 0; index < forward.Length; index++)
            {
                char revLetter = (char)wordForward.Pop();
                reversedWord += revLetter;
            }
           
            return reversedWord;


        }
        static void Main(string[] args)
        {
            //Request and take user imput
            Console.WriteLine("Enter a phrase to be reversed");
            string forward = Console.ReadLine();

            //Seperate method that with string as return and parameter
            Console.WriteLine(ReverseString(forward));
            
        }
    }
}
