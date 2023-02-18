using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double weigh, heigh, BMI, maxHealthyWeight, minHealthyWeight;
            string resault = "";
            bool badWeight;
            try
            {
                Console.WriteLine("     ** BMI calculator **");
                Console.WriteLine();
                Console.Write("       Enter weigh(in kelogram) --> ");
                weigh = Convert.ToDouble(Console.ReadLine());
                Console.Write("       Enter heigh(in centimeters) --> ");
                heigh = Convert.ToDouble(Console.ReadLine());
                heigh = heigh / 100;
                BMI = weigh / (Math.Pow(heigh, 2));
                if (BMI <= 18.4)
                {
                    resault = "Underweigh";
                    badWeight = true;
                }
                else if (18.5 <= BMI && BMI <= 24.9)
                {
                    resault = "Normal";
                    badWeight = false;
                }
                else if (25 <= BMI && BMI <= 39.9)
                {
                    resault = "Overweight";
                    badWeight = true;
                }
                else if (BMI >= 40)
                {
                    resault = "Obese";
                    badWeight = true;
                }
                else
                {
                    Console.WriteLine("Enter the values correctly --> Weigh in kg and Heigh in cm");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a number");
                throw;
            }
            BMI = Math.Round(BMI);
            Console.WriteLine($"       Your BMI is: {BMI} ({resault})");
            if (badWeight = true)
            {
                if (resault != "Normal")
                {
                    if (resault == "Underweigh" || resault == "Overweight" || resault == "Obese")
                    {
                        minHealthyWeight = 18.5 * (Math.Pow(heigh, 2));
                        maxHealthyWeight = 24.9 * (Math.Pow(heigh, 2));
                        minHealthyWeight = Math.Round(minHealthyWeight);
                        maxHealthyWeight = Math.Round(maxHealthyWeight);
                        Console.WriteLine($"       The healthy weight range for you is from {minHealthyWeight}kg to {maxHealthyWeight}kg");
                    }
                }
            }
        }
    }
}