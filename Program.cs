using System;

namespace ДЗ_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Задаем стартовые переменные
            string FIO = "Горелов Алексей Анатольевич", Email = "gorelov.alex@gmail.com";
            byte Age = 35;
            double Bprog = 5, Bmath = 4, Bphis = 3;

            /// Выводим на экран столбиком
            Console.WriteLine($"Ф.И.О.: {FIO} \nВозраст: {Age} \nEmail: {Email} \nБаллы по программированию: {Bprog} \nБаллы по математике: {Bmath} \nБаллы по физике: {Bphis}");
            Console.ReadKey();

            /// Считаем сумму баллов
            double Sum = Bprog + Bmath + Bphis;
            Console.WriteLine($"\nСумма баллов по всем предметам: {Sum}");

            /// Считаем средний балл
            double Sr = Sum / 3;
            Console.WriteLine($"Средний балл: {Sr}");
            Console.ReadKey();

        }
    }
}
