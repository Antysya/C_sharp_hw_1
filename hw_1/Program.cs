/* 1.Изменить введенную строку пользователем на противоположный (верхний или нижний) регистр.

2.Выполнить реверс введенного пользователем числа. 1234    4321

3.Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; 
каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, 
равное его значению (например, число 3 выводится 3 раза). 
Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("Выберете действие, которое хотите произвести:\n " +
                    "1. Изменить регистр введенной строки; \n 2. Выполнить реверс введенного числа; \n " +
                    "3. Распечатать числа от А до В в виде пирамиды; \n 4. Выйти из программы.");
                string posnum = ReadLine();

                switch (posnum)
                {
                    case "1":
                        WriteLine("Изменить регистр введеной строки.\n Введите строку:");
                        string str = ReadLine();
                        string newStr = "";
                        foreach (var c in str)
                        {
                            if (char.IsLower(c))
                                newStr += char.ToUpper(c);
                            else
                                newStr += char.ToLower(c);
                        }
                        WriteLine(newStr);

                        /*На просторах интернета нашла вот такое решение, работает, но не понятен Select и =>
                        WriteLine(str.Select(ch => char.IsLower(ch) ? char.ToUpper(ch) : char.ToLower(ch)).ToArray());*/

                        break;

                    case "2": 
                        WriteLine("Выполнить реверс введенного числа.\n Введите число:");
                        int number;
                        int rezult = 0;

                        number = Int32.Parse(ReadLine());
                        if (number < 0)
                        {
                            WriteLine("Вы ввели отрицательное значение, реверс невозможен.\n Введите положительное число:");
                            number = Int32.Parse(ReadLine());
                        }
                             while (number > 0)
                             {
                                rezult *= 10;
                                rezult += number % 10;
                                number /= 10;
                             }
                        WriteLine(rezult);

                        //первый вариант был через строку:
                        //WriteLine("Выполнить реверс введенного числа.\n Введите число:");
                        //string numberString = ReadLine();
                        //foreach (var c in numberString)
                        //{
                        //    if (!char.IsDigit(c))
                        //    {
                        //        WriteLine("Внимание! Введенная строка не является числом.");
                        //    }
                        //}
                        //WriteLine(numberString.Reverse().ToArray());

                        break;
               
                    case "3":
                        WriteLine("Распечатать числа от А до В в виде пирамиды.\n Введите первое число:");

                        int a = Int32.Parse(ReadLine());

                        WriteLine("Введите второе число:");
                        int b = Int32.Parse(ReadLine());
                        if (a < 0 || b < 0)
                        {
                            WriteLine("Одно из чисел отрицательное. Введите корректные значения.\n Первое число:");
                            a = Int32.Parse(ReadLine());
                            WriteLine("Введите второе число:");
                            b = Int32.Parse(ReadLine());
                        }
                        if (a <= b)
                        
                            for (int i = a; i <= b; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                    Write(i);
                                Write("\n");
                            }
                        
                        else 
                            for (int i = a; i >=b; i--)
                            {
                                for (int j = 1; j <= i; j++)
                                    Write(i);
                                Write("\n");
                            }

                        break;
                    case "4":
                        return;

                    default:
                        WriteLine("Вы выбрали несуществующий пункт меню. Выберите снова.");
                        continue;

                }
            }
        }
    }
}
