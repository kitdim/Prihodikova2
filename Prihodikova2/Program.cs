using System;

namespace Prihodikova2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести три действительных числа." +
                "\nОпределить, какие из них принадлежат интервалу (1, 5)," +
                "\nи дать об этом сообщение на печать.");

            Console.Write("Первое число = "); var oneNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число = "); var twoNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число = "); var threeNumber = Convert.ToInt32(Console.ReadLine());

            if (oneNumber >= 1 && oneNumber <= 5)
            {
                Console.WriteLine($"{oneNumber} принадлежит интервалу (1...5)");
            }
            else
            { 
                Console.WriteLine($"{oneNumber} не принадлежит интервалу (1...5)"); 
            }

            if (twoNumber >= 1 && twoNumber <= 5)
            {
                Console.WriteLine($"{twoNumber} принадлежит интервалу (1...5)");
            }
            else
            {
                Console.WriteLine($"{twoNumber} не принадлежит интервалу (1...5)");
            }

            if (threeNumber >= 1 && threeNumber <= 5)
            {
                Console.WriteLine($"{threeNumber} принадлежит интервалу (1...5)");
            }
            else
            {
                Console.WriteLine($"{threeNumber} не принадлежит интервалу (1...5)");
            }


        }
    }
}
