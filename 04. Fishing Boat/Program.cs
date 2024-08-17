 using System;


namespace _04._Fishing_Boat
    {
        class Program
        {
            static void Main(string[] args)
            {
                //1. четем от конзолата: бюджет, сезон и брой рибари
                int budget = int.Parse(Console.ReadLine());
                string season = Console.ReadLine(); //"Spring", "Summer", "Autumn", "Winter"
                int fishermen = int.Parse(Console.ReadLine());

                double price = 0;

                //2. Намираме цената на кораба спрямо сезона
                switch (season)
                {
                    case "Spring":
                        price = 3000;
                        break;
                    case "Summer":
                    case "Autumn":
                        price = 4200;
                        break;
                    default: //"Winter"
                        price = 2600;
                        break;
                }

                //3. Начисляваме отстъпка спрямо броя рибари
                if (fishermen <= 6)
                {
                    price = price - price * 10 / 100;
                    //price = price - price * 0.10;
                    //price -= price * 0.10;
                }
                else if (fishermen <= 11)
                {
                    price -= price * 0.15;
                }
                else //fishermen>=12
                {
                    price -= price * 0.25;
                }

                //4. Проверяваме дали имат допълнителна отстъпка
                //  => трябва рибарите да са четен брой и сезона да е РАЗЛИЧЕН от есен 
                if ((fishermen % 2 == 0) && (season != "Autumn"))
                {
                    price -= price * 0.05;
                }

                //5. Отпеатваме резултата в зависимост дали бюджета е достатъчен
                if (price <= budget)
                {
                    Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
                }
            }
        }
    }
}
    