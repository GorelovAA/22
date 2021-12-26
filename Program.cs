using System;

namespace ДЗ_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Задаем стартовые переменные
            string userName = "Горелов Алексей Анатольевич", email = "gorelov.alex@gmail.com";
            byte age = 35;
            double bprog = 5, bmath = 4, bphis = 3;

            /// Выводим на экран столбиком
            Console.WriteLine($"Ф.И.О.: {userName} \nВозраст: {age} \nEmail: {email} \nБаллы по программированию: {bprog} \nБаллы по математике: {bmath} \nБаллы по физике: {bphis}");
            Console.ReadKey();

            /// Считаем сумму баллов
            double sum = bprog + bmath + bphis;
            Console.WriteLine($"\nСумма баллов по всем предметам: {sum}");

            /// Считаем средний балл
            double sr = sum / 3;
            Console.WriteLine($"Средний балл: {sr}");
            Console.ReadKey();

        }
    }
}
