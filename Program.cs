using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор \n");

            double a, b, c, d;
            int menu;

            

            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Выход\n");
            Console.WriteLine("Ввод: ");

            String s = Console.ReadLine();
            menu = s.Length > 0 ? s[0] : ' ';

            Console.Clear();
            int valid = 0;
            switch (menu)
            {
                
                case '1':
                    bool Y, N;
                    int i = 0;
                    while (i < 1)
                    {
                        double q, w;
                        Console.WriteLine("Сложение:");
                        Console.Write("Введите число: ");
                        q = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите число: ");
                        w = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ответ: " + (q + w));
                        i++;
                    }
                    

                /* Console.WriteLine("Хотите еще посчитать? Y/N");
                 Y = Convert.ToBoolean(Console.ReadLine());
                 if (Y | N)
                     Console.WriteLine()*/
                break;

                case '2':
                    double e, r;
                    Console.WriteLine("Вычитание");
                    Console.Write("Введите число: ");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите число: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"Ответ: " + (e - r));
                    break;

                case '3':
                    double t, y;
                    Console.WriteLine("Умножение");
                    Console.Write("Введите число: ");
                    t = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите число: ");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"Ответ: " + (t * y));
                    break;

                case '4':
                    double u,g;
                    Console.WriteLine("Деление");
                    Console.Write("Введите число: ");
                    u = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите число: ");
                    g = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"Ответ: " + (u / g));
                    break;

                case '5':
                    Console.WriteLine("Спасибо за использование. Для выхода, нажмите любую клавишу...");
                    break;

                default:
                    Console.WriteLine("Давайте сначала? Вы нажали не туда");
                    return 0;
                    break;
            }


           /* while (true)
            {
                Console.WriteLine("")
            }*/
            Console.ReadKey();
        }
    }
}