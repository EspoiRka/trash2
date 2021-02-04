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

            string[] list = { "1. Сложение", "2. Вычитание", "3. Умножение", "4. Деление", "5. Выход\n" };
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.Write("Выбор: ");

            int menu;
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
                        GetTwoDigit("Сложение\n", ref FirstNum, ref SecNum);
                        Console.WriteLine("Ответ: " + (FirstNum + SecNum));

                        Console.WriteLine("Хотите еще посчитать? Y/N");
                        result = Console.ReadLine().Trim();
                        ReturnToMenu();
                    } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'y');
                    break;

                case '2':

                    do
                    {
                        GetTwoDigit("Вычитание\n", ref FirstNum, ref SecNum);
                        Console.WriteLine("Ответ: " + (FirstNum - SecNum));

                        Console.WriteLine("Хотите еще посчитать? Y/N");
                        result = Console.ReadLine().Trim();

                    } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'y');
                    break;

                case '3':
                    do
                    {
                        GetTwoDigit("Умножение\n", ref FirstNum, ref SecNum);
                        Console.WriteLine("Ответ: " + (FirstNum * SecNum));

                        Console.WriteLine("Хотите еще посчитать? Y/N");
                        result = Console.ReadLine().Trim();

                    } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'y');
                    break;

                case '4':
                    do
                    {
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
            Console.Clear();
            Console.WriteLine(operation);
            
            Console.Write("Введите число: ");
            while (!double.TryParse(Console.ReadLine(), out firstNum))
            {
                Error();
            }
            
            Console.Write("\nВведите число(2): ");
            while (!double.TryParse(Console.ReadLine(), out SecNum))
            {
                Error();
            }
        }
        public static void Error()
        {
            Console.WriteLine("\nОшибка! Это не число\n");
            Console.Write("Введите еще раз: ");
        }
        public static void ReturnToMenu ()
        {
            string result;
            do
            {

            } while (result.Length > 0 && result.ToLowerInvariant()[0] == 'n');
        }
    }
    
}