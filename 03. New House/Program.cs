using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalSum = 0;
            double discounts = 0;

            switch (flowerType)
            {
                case "Roses":
                    totalSum = flowersCount * 5.00;
                    if (flowersCount > 80)
                    {
                        discounts = totalSum * 0.10;
                        totalSum = totalSum - discounts;
                    }
                    break;
                case "Dahlias":
                    totalSum = flowersCount * 3.80;
                    if (flowersCount > 90)
                    {
                        discounts = totalSum * 0.15;
                        discounts = totalSum - discounts;
                    }
                    break;
                case "Tulips":
                    totalSum = flowersCount * 2.80;
                    if (flowersCount > 80)
                    {
                        discounts = totalSum * 0.15;
                        totalSum = totalSum - discounts;
                    }
                    break;
                case "Narcissus":
                    totalSum = flowersCount * 3.00;
                    if (flowersCount < 120)
                    {
                        discounts = totalSum * 0.15;
                        totalSum = totalSum + discounts;

                    }
                    break;
                case "Gladiolus":
                    totalSum = flowersCount * 2.50;
                    if (flowersCount < 80)
                    {
                        discounts = totalSum * 0.20;
                        totalSum = totalSum + discounts;
                    }
                    break;
                default:
                    break;

            }
            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {moneyLeft:f2} leva left.");
            }
            else if (totalSum > budget)
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
