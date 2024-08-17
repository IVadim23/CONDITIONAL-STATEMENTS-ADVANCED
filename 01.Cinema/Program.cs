using System;

namespace _1._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Четем от конзолата: тип прожекция, редове в залата и колони в залата
            string ticketType = Console.ReadLine(); //"Premiere" - 12.00; "Normal"- 7.50 лева."Discount" - 5.00;

            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            //2) Пресмятаме колко са общо местата в залата
            double income = row * col;

            //3) Изчисляваме какви са пеиходите от продадените билети 
            if (ticketType == "Premiere")
            {
                income = income * 12.00;
                //income *= 12.00;
            }
            else if (ticketType == "Normal")
            {
                income = income * 7.50;
                //income *= 7.50;
            }
            else //"Discount"
            {
                income = income * 5.00;
                //income *= 5.00;
            }

            //4) Отпечатваме резултата на конзолата
            Console.WriteLine("{0:f2} leva", income);
            //Console.WriteLine($"{income:f2} leva");
            //Console.WriteLine(income + " leva");
        }
    }
}
}
    
