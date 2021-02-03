using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Калькулятор \n");

        Start:
            int menu;
            е

            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Выход\n");
            Console.Write("Выбор: ");




            String s = Console.ReadLine();
            menu = s.Length > 0 ? s[0] : ' ';

            Console.Clear();

            double q = 0, w = 0;


            switch (menu)
            {

                case '1':

                    string result;

                    do
                    {
                        Console.Clear();
                        GetTwoDigit("Сложение", ref q, ref w);
                        Console.WriteLine("Ответ: " + (q + w));

                        Console.WriteLine("Хотите еще посчитать? Y/N");
                        result = Console.ReadLine().Trim();

                    } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'y');
                    break;

                case '2':

                    do
                    {
                        Console.Clear();
                        GetTwoDigit("Вычитание", ref q, ref w);
                        Console.WriteLine("Ответ: " + (q - w));

                        Console.WriteLine("Хотите еще посчитать? Y/N");
                        result = Console.ReadLine().Trim();

                    } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'y');
                    break;

                case '3':
                    do
                    {
                        Console.Clear();
                        GetTwoDigit("Умножение", ref q, ref w);
                        Console.WriteLine("Ответ: " + (q * w));

                        Console.WriteLine("Хотите еще посчитать? Y/N");
                        result = Console.ReadLine().Trim();

                    } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'y');
                    break;

                case '4':
                    do
                    {
                        Console.Clear();
                        GetTwoDigit("Деление", ref q, ref w);
                        Console.WriteLine("Ответ: " + (q / w));

                        Console.WriteLine("Хотите еще посчитать? Y/N");
                        result = Console.ReadLine().Trim();

                    } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'y');
                    break;

                case '5':
                    Console.WriteLine("Спасибо за использование. Для выхода, нажмите любую клавишу...");
                    break;

                default:
                    Console.WriteLine("Давайте сначала? Вы нажали не туда. \n");
                    Thread.Sleep(1000);
                    goto Start;
            }
            Console.ReadKey();
        }

        private static void GetTwoDigit(string operation, ref double q, ref double w)
        {
                Console.WriteLine(operation);
                Console.Write("Введите число: ");
                q = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите число: ");
                w = Convert.ToDouble(Console.ReadLine());
        }
    }
}