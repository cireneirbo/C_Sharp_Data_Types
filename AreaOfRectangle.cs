using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Data_Types
{
    class AreaOfRectangle
    {
        public static void CalculateArea()
        {
            Console.WriteLine("What is the length of the rectangle?");
            string lengthInput = Console.ReadLine();
            int length = int.Parse(lengthInput);

            Console.WriteLine("What is the width of the rectangle?");
            string widthInput = Console.ReadLine();
            int width = int.Parse(widthInput);

            Console.WriteLine("Area of Rectangle = " + length * width);
            Console.WriteLine();
        }
    }
}
