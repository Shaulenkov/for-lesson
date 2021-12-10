using System;

namespace Урок_1
{
    class Example2
    {   /*  Ввести вес и рост человека. Рассчитать и вывести 
    индекс массы тела (ИМТ) по формуле I=m/(h*h); 
    где m — масса тела в килограммах, h — рост в метрах.  */
        static void Main(string[] args)
        {   
            Console.WriteLine("Введите ваш вес");
            double weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост");
            double height = Double.Parse(Console.ReadLine());

            height /= 100;
            
            

            Console.WriteLine("Индекс вашего тела = ");
            double mass = weight / (height * height);
            Console.WriteLine("индекс массы тела = ", mass);

        }
    }
}
