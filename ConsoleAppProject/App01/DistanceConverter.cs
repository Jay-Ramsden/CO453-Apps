using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
    }
}
using System;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Distance Converter Program!");
            Console.WriteLine("Created by [Your Name Here]");

            // Prompt the user to select the units to convert from and to
            string fromUnit = GetValidUnit("from");
            string toUnit = GetValidUnit("to");

            // Input distance and convert between units
            double distance = GetValidDistance(fromUnit);
            double convertedDistance = ConvertDistance(distance, fromUnit, toUnit);

            // Output the converted distance
            Console.WriteLine($"{distance} {fromUnit} is equal to {convertedDistance} {toUnit}.");

            Console.WriteLine("\nThank you for using the Distance Converter Program!");
        }

        static string GetValidUnit(string prompt)
        {
            string unit;
            bool isValid = false;

            do
            {
                Console.Write($"Please select a unit to convert {prompt} (miles, feet, metres, kilometers, yards, or inches): ");
                unit = Console.ReadLine().ToLower();

                if (unit == "miles" || unit == "feet" || unit == "metres" || unit == "kilometers" || unit == "yards" || unit == "inches")
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid unit choice. Please select 'miles', 'feet', 'metres', 'kilometers', 'yards', or 'inches'.");
                }
            } while (!isValid);

            return unit;
        }

        static double GetValidDistance(string unit)
        {
            double distance;
            bool isValid = false;

            do
            {
                Console.Write($"Please enter a distance in {unit}: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out distance) && distance >= 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid distance entered. Please enter a non-negative number.");
                }
            } while (!isValid);

            return distance;
        }

        static double ConvertDistance(double distance, string fromUnit, string toUnit)
        {
            if (fromUnit == "miles" && toUnit == "feet")
            {
                return distance * 5280;
            }
            else if (fromUnit == "feet" && toUnit == "miles")
            {
                return distance / 5280;
            }
            else if (fromUnit == "miles" && toUnit == "metres")
            {
                return distance * 1609.34;
            }
            else if (fromUnit == "metres" && toUnit == "miles")
            {
                return distance / 1609.34;
            }
            else if (fromUnit == "feet" && toUnit == "metres")
            {
                return distance * 0.3048;
            }
            else if (fromUnit == "metres" && toUnit == "feet")
            {
                return distance / 0.3048;
            }
            else if (fromUnit == "kilometers" && toUnit == "miles")
            {
                return distance / 1.60934;
            }
            else if (fromUnit == "miles" && toUnit == "kilometers")
            {
                return distance * 1.60934;
            }
            else if (fromUnit == "yards" && toUnit == "feet")
            {
                return distance * 3;
            }
            else if (fromUnit == "fe
