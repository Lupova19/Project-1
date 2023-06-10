using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases1 = {"Продуктът е отличен.", "Това е страхотен продукт.",
                "Постоянно ползвам този продукт.", "Това е най-добрият продукт от тази категория."
            };
            string[] phrases2 = {"Чувствам се добре.", "Успях да се променя.", "Той направи чудо.",
                "Спечелих! Случи се чудо!", "Не мога да повярвам, но успях да превъзмогна себе си.",
                "Опитайте и вие. Аз съм много доволна."
            };
            string[] authorFirstNames = { "Калина", "Гергана", "Стела", "Елена", "Катя" };
            string[] authorLastNames = { "Иванова", "Петрова", "Кирова" };
            string[] cities = { "София", "Пловдив", "Варна", "Русе", "Бургас", "Карлово", "Сопот" };

            Random random = new Random();

            int phrase1Index = random.Next(0, phrases1.Length);
            int phrase2Index = random.Next(0, phrases2.Length);
            int authorFirstNameIndex = random.Next(0, authorFirstNames.Length);
            int authorLastNameIndex = random.Next(0, authorLastNames.Length);
            int citiesIndex = random.Next(0, cities.Length);


            string advertisingMessage = $"{phrases1[phrase1Index]} {phrases2[phrase2Index]} Автор:{authorFirstNames[authorFirstNameIndex]} {authorLastNames[authorLastNameIndex]}, {cities[citiesIndex]}";

            Console.WriteLine(advertisingMessage);
        }
    }
}
