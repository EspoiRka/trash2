using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Калькулятор \n");

            int menu;


            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Выход\n");
            Console.Write("Выбор: ");




            String s = Console.ReadLine();
            menu = s.Length > 0 ? s[0] : ' ';

            Console.Clear();

            double FirstNum = 0, SecNum = 0;


            switch (menu)
            {

                case '1':

                    string result;

                    do
                    {
                        Console.Clear();
                        GetTwoDigit("Сложение\n", ref FirstNum, ref SecNum);
                        Console.WriteLine("Ответ: " + (FirstNum + SecNum));

                        Console.WriteLine("Хотите еще посчитать? Y/N");
                        result = Console.ReadLine().Trim();

                    } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'y');
                    break;

                case '2':

                    do
                    {
                        Console.Clear();
                        GetTwoDigit("Вычитание\n", ref FirstNum, ref SecNum);
                        Console.WriteLine("Ответ: " + (FirstNum - SecNum));

                        Console.WriteLine("Хотите еще посчитать? Y/N");
                        result = Console.ReadLine().Trim();

                    } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'y');
                    break;

                case '3':
                    do
                    {
                        Console.Clear();
                        GetTwoDigit("Умножение\n", ref FirstNum, ref SecNum);
                        Console.WriteLine("Ответ: " + (FirstNum * SecNum));

                        Console.WriteLine("Хотите еще посчитать? Y/N");
                        result = Console.ReadLine().Trim();

                    } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'y');
                    break;

                case '4':
                    do
                    {
                        Console.Clear();
                        GetTwoDigit("Деление\n", ref FirstNum, ref SecNum);
                        Console.WriteLine("Ответ: " + (FirstNum / SecNum));

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
                    break;
            }
            Console.ReadKey();
        }
        
        private static void GetTwoDigit(string operation, ref double firstNum, ref double SecNum)
        {
            Console.WriteLine(operation);
            
            Console.Write("Введите число: ");
            while (!double.TryParse(Console.ReadLine(), out firstNum))
            {
                Console.WriteLine("Это не число");
                Console.Write("Вводи еще раз: ");
            }
            
            Console.Write("\nВведите число(2): ");
            while (!double.TryParse(Console.ReadLine(), out SecNum))
            {
                Console.WriteLine("Ошибка! Это не число");
                Console.Write("Введите еще раз: ");
            }
        }
    }
    
}