using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Data_Types
{
    class InputOutput
    {
        public static void HelloUser()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
