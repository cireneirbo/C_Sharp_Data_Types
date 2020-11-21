using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Data_Types
{
    class GasMileageCalculator
    {
        public static void CalculateMileage()
        {
            Console.WriteLine("So you're going on a trip, eh? \nWe've rented you a motorized skateboard that gets 45 miles to the gallon. \nHow many miles will you be traveling?");
            string milesInput = Console.ReadLine();
            double miles = double.Parse(milesInput);
            double milesPerGallon = miles / 45;
            Console.WriteLine("Your trip will require " + (Math.Floor(milesPerGallon * 100) / 100) + " gallons of gasoline, and cost you $" + (Math.Floor((milesPerGallon * 1.9) * 100) / 100) + " at current fuel prices.");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
