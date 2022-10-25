using System;
namespace MidExamOctober2022
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double totalEnergy = double.Parse(Console.ReadLine());
            double personWater = double.Parse(Console.ReadLine());
            double personFood = double.Parse(Console.ReadLine());
            double totalWater = days * players * personWater;
            double totalFood = days * players * personFood;

            int waterDay = 0;
            int foodDay = 0;

            for (int i = 0; i < days; i++)
            {
                {
                    double wastedEnergy = double.Parse(Console.ReadLine());
                    totalEnergy -= wastedEnergy;
                    if (totalEnergy <= 0)
                    {
                        break;
                    }
                }
                {
                    waterDay += 1;
                    if (waterDay >= 2)
                    {
                        totalWater -= totalWater * 0.3;
                        totalEnergy += totalEnergy * 0.05;
                        waterDay = 0;
                    }
                }
                {
                    foodDay += 1;
                    if (foodDay >= 3)
                    {
                        totalFood -= (totalFood / players);
                        totalEnergy += totalEnergy * 0.1;
                        foodDay = 0;
                    }
                }
            }

            if (totalEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {Math.Round(totalEnergy,2)} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {Math.Round(totalFood,2)} food and {Math.Round(totalWater,2)} water.");
            }
        }
    }
}