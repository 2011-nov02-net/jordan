using System;

namespace acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a multi word statement: ");
            string words = Console.ReadLine();

            // split the words into an array
            string[] wordsArray = words.Split(" ");

            foreach(string word in wordsArray) {
                System.Console.Write(word[0]);
            }

        }
    }
}
