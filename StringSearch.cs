using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Data_Types
{
    class StringSearch
    {
        public static void SearchForString()
        {
            string stringWithContentToSearch = "Alice was beginning to get very tired of sitting by her sister on the bank, \n" +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, \n" +
                "but it had no pictures or conversations in it, 'and what is the use of a book,' \n" +
                "thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Please type your search word/phrase for the following string: \n\n\"" + stringWithContentToSearch + "\": ");
            string searchTerm = Console.ReadLine();
            Console.WriteLine("Is '" + searchTerm + "' in the string?");

            string[] stringArray = stringWithContentToSearch.ToLower().Split(' ');
            if (Array.Exists(stringArray, element => element == searchTerm.ToLower()))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            Console.WriteLine("What is the index of " + searchTerm + "?");
            Console.WriteLine(Array.FindIndex(stringArray, element => element == searchTerm));
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
