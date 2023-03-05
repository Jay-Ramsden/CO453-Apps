namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
    }
}
using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the BMI Calculator!");
            Console.WriteLine("Created by Jay Ramsden");

            // Prompt the user to choose between metric or imperial units
            Console.WriteLine("Enter '1' for Metric Units or '2' for Imperial Units:");
            int choice = int.Parse(Console.ReadLine());

            // Prompt the user to enter their weight and height
            double weight, height;
            if (choice == 1)
            {
                Console.WriteLine("Enter your weight in kilograms:");
                weight = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your height in meters:");
                height = double.Parse(Console.ReadLine());
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter your weight in stones:");
                double weightStones = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your weight in pounds:");
                double weightPounds = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your height in feet:");
                double heightFeet = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your height in inches:");
                double heightInches = double.Parse(Console.ReadLine());

                // Convert imperial units to metric units
                weight = (weightStones * 6.35) + (weightPounds * 0.453592);
                height = (heightFeet * 0.3048) + (heightInches * 0.0254);
            }
            else
            {
                Console.WriteLine("Invalid choice entered. Please enter '1' for Metric Units or '2' for Imperial Units.");
                return;
            }

            // Calculate the BMI value
            double bmi = weight / Math.Pow(height, 2);

            // Display the BMI value and weight status
            Console.WriteLine("Your BMI value is: " + bmi.ToString("F"));

            if (bmi < 18.5)
            {
                Console.WriteLine("Your weight status is: Underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Your weight status is: Normal");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("Your weight status is: Overweight");
            }
            else if (bmi < 35)
            {
                Console.WriteLine("Your weight status is: Obese Class I");
            }
            else if (bmi < 40)
            {
                Console.WriteLine("Your weight status is: Obese Class II");
            }
            else
            {
                Console.WriteLine("Your weight status is: Obese Class III");
            }

            // Display the extra risks for BAME groups
            if (choice == 1) // Only applies to metric units
            {
                Console.WriteLine("Note: If you are from a Black, Asian or other minority ethnic group, you have a higher risk of developing " +
                    "health problems such as type 2 diabetes and heart disease at a lower BMI than people from White European backgrounds. " +
                    "A BMI of 23 or more indicates that you are at increased risk.");
            }

            Console.WriteLine("Thank you for using the BMI Calculator!");
        }
    }
}
