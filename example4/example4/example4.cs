using System;

namespace Урок_1
{
    class Example3
    {
        static void Main(string[] args)
        {
            int per = 40;
            int per1 = 70;

            Console.WriteLine("Первая переменная " + per);
            Console.WriteLine("Вторая переменная " + per1);
              //с использованием третьей переменной
            int result = per;
            per = per1;
            per1 = result;

            Console.WriteLine("Первая переменная " + per);
            Console.WriteLine("Вторая переменная " + per1);

            //без использования третьей переменной

            int per2 = 990;
            int per3 = 564;
            per2 = per2 + per3;
            per3 = per3 - per2;
            per3 = -per3;
            per2 = per2 - per3;

            Console.WriteLine("Первая переменная " + per2);
            Console.WriteLine("Вторая переменная " + per3);

        }
    }
}