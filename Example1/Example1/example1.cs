using System;

namespace Урок_1
{
    class Example1
    {
        static void Main()
        { /*  1. Написать программу «Анкета». Последовательно задаются вопросы 
        (имя, фамилия, возраст, рост, вес). В результате вся информация 
        выводится в одну строчку: */
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию");
            string lastname = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            string age = Console.ReadLine();

            Console.WriteLine("Введите ваш рост");
            string growth = Console.ReadLine();

            Console.WriteLine("Введите ваш вес");
            string weight = Console.ReadLine();

            Console.WriteLine(name + " " + lastname + ": " + age + " лет, " + growth + " см, " + weight + " кг");
            Console.WriteLine("{0} {1} {2}  лет,  {3}  см,  {4}  кг", name, lastname, age, growth, weight);
            Console.WriteLine($ "{name} , {lastname} , {age}  лет,  {growth}  см,  {weight}  кг");
        }
    }
}
