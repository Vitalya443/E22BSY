using System;

namespace Волинец_Виталик_2_13
{
    class Adress
    {
        static void Main(string[] args)
        {
            string Country;
            Console.WriteLine("Страна: ");
            Country = Console.ReadLine();

            string City;
            Console.WriteLine("Город: ");
            City = Console.ReadLine();

            string Street;
            Console.WriteLine("Улица: ");
            Street = Console.ReadLine();

            string House;
            Console.WriteLine("Дом");
            House = Console.ReadLine();

            string Apartment;
            Console.WriteLine("Квартира: ");
            Apartment = Console.ReadLine();

            string Index;
            Console.WriteLine("Почтовый Индекс: ");
            Index = Console.ReadLine();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("RESULT: ");
            Console.WriteLine("Страна: " + Country);
            Console.WriteLine("Город: " + City);
            Console.WriteLine("Улица: " + Street);
            Console.WriteLine("Дом: " + House);
            Console.WriteLine("Квартира: " + Apartment);
            Console.WriteLine("Почтовый индекс: " + Index);
        }
    }
}
