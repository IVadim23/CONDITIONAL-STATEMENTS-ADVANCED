using System;

namespace _7._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double price_apartment = 0;
            double price_studio = 0;

            if (month == "May" || month == "October")
            {
                price_apartment = 65 * nights;
                price_studio = 50 * nights;
                if (nights > 7 && nights <= 14)
                {
                    price_studio = price_studio - price_studio * 5 / 100;
                }
                else if (nights > 14)
                {
                    price_studio = price_studio - price_studio * 30 / 100;
                }
                if (nights > 14)
                {
                    price_apartment = price_apartment - price_apartment * 10 / 100;
                }
            }
            else if (month == "June" || month == "September")
            {
                price_apartment = 68.70 * nights;
                price_studio = 75.20 * nights;
                if (nights > 14)
                {
                    price_studio = price_studio - price_studio * 20 / 100;
                }
                if (nights > 14)
                {
                    price_apartment = price_apartment - price_apartment * 10 / 100;
                }
            }
            else if (month == "July" || month == "August")
            {
                price_apartment = 77 * nights;
                price_studio = 76 * nights;
                if (nights > 14)
                {
                    price_apartment = price_apartment - price_apartment * 10 / 100;
                }
            }
            Console.WriteLine($"Apartment: {price_apartment:f2} lv.");
            Console.WriteLine($"Studio: {price_studio:f2} lv.");
        }
    }
}