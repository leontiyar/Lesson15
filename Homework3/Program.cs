﻿using System;
//Создать калькулятор для 2 чисел используя if else и switch
namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Привет! Это калькулятор 2 чисел");
                Console.WriteLine("Введи операцию (+,-,*,/,%)");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        {
                            Console.WriteLine("Отлично! Сегодня будем суммировать? Теперь введи 1 число");
                            bool smart = double.TryParse(Console.ReadLine(), out double a);
                            if (!smart)//Переменная smart отвечает за то, умен ли юзер. Тоесть ввел ли он нормальное 1 число или бурду
                            {
                                Console.WriteLine("А начиналось так красиво...");
                                Console.WriteLine("Я думал ты не дурачок");
                                Console.WriteLine("Ну, впрочем, ладно. Попробуй еще раз, но по нормальному");
                            }
                            else
                            {
                                Console.WriteLine("Замечательно! Жду 2 число");
                                bool genius = double.TryParse(Console.ReadLine(), out double b);
                                if (!genius)//Так же работает и переменная genius, только для 2 числа
                                {
                                    Console.WriteLine("Мужик, ну ты чего?");
                                    Console.WriteLine("Я думал ты не дурачок");
                                    Console.WriteLine("Так глупо проиграть в самом конце!");
                                    Console.WriteLine("Ну, впрочем, ладно. Попробуй еще раз, но по нормальному");
                                }
                                else
                                {
                                    Console.WriteLine("Красава! Вот твоя сумма - " + (a + b));
                                }
                            }
                        }
                        break;
                    case "-":
                        {
                            Console.WriteLine("Отлично! Сегодня будем вычитать? Теперь введи 1 число");
                            bool smart = double.TryParse(Console.ReadLine(), out double a);
                            if (!smart)
                            {
                                Console.WriteLine("А начиналось так красиво...");
                                Console.WriteLine("Я думал ты не дурачок");
                                Console.WriteLine("Ну, впрочем, ладно. Попробуй еще раз, но по нормальному");
                            }
                            else
                            {
                                Console.WriteLine("Замечательно! Жду 2 число");
                                bool genius = double.TryParse(Console.ReadLine(), out double b);
                                if (!genius)
                                {
                                    Console.WriteLine("Мужик, ну ты чего?");
                                    Console.WriteLine("Я думал ты не дурачок");
                                    Console.WriteLine("Так глупо проиграть в самом конце!");
                                    Console.WriteLine("Ну, впрочем, ладно. Попробуй еще раз, но по нормальному");
                                }
                                else
                                {
                                    Console.WriteLine("Красава! Вот твоя разница - " + (a - b));
                                }
                            }
                        }
                        break;
                    case "/":
                        {
                            Console.WriteLine("Отлично! Сегодня будем делить? Теперь введи 1 число");
                            bool smart = double.TryParse(Console.ReadLine(), out double a);
                            if (!smart)
                            {
                                Console.WriteLine("А начиналось так красиво...");
                                Console.WriteLine("Я думал ты не дурачок");
                                Console.WriteLine("Ну, впрочем, ладно. Попробуй еще раз, но по нормальному");
                            }
                            else
                            {
                                Console.WriteLine("Замечательно! Жду 2 число");
                                bool genius = double.TryParse(Console.ReadLine(), out double b);
                                if (!genius)
                                {
                                    Console.WriteLine("Мужик, ну ты чего?");
                                    Console.WriteLine("Я думал ты не дурачок");
                                    Console.WriteLine("Так глупо проиграть в самом конце!");
                                    Console.WriteLine("Ну, впрочем, ладно. Попробуй еще раз, но по нормальному");
                                }
                                else
                                {
                                    Console.WriteLine("Красава! Вот результат деления - " + (a / b));
                                }
                            }
                        }
                        break;
                    case "*":
                        {
                            Console.WriteLine("Отлично! Сегодня будем умножать? Теперь введи 1 число");
                            bool smart = double.TryParse(Console.ReadLine(), out double a);
                            if (!smart)
                            {
                                Console.WriteLine("А начиналось так красиво...");
                                Console.WriteLine("Я думал ты не дурачок");
                                Console.WriteLine("Ну, впрочем, ладно. Попробуй еще раз, но по нормальному");
                            }
                            else
                            {
                                Console.WriteLine("Замечательно! Жду 2 число");
                                bool genius = double.TryParse(Console.ReadLine(), out double b);
                                if (!genius)
                                {
                                    Console.WriteLine("Мужик, ну ты чего?");
                                    Console.WriteLine("Я думал ты не дурачок");
                                    Console.WriteLine("Так глупо проиграть в самом конце!");
                                    Console.WriteLine("Ну, впрочем, ладно. Попробуй еще раз, но по нормальному");
                                }
                                else
                                {
                                    Console.WriteLine("Красава! Вот результат умножения - " + (a * b));
                                }
                            }
                        }
                        break;
                    case "%":
                        {
                            Console.WriteLine("Отлично! Сегодня будем находить остаток от деления? Теперь введи 1 число");
                            Console.WriteLine("С этой операцией доступны только натуральные числа!");//Вряд ли кому то нужны дробные числа при делении на остаток
                            bool smart = int.TryParse(Console.ReadLine(), out int a);
                            if (!smart)
                            {
                                Console.WriteLine("А начиналось так красиво...");
                                Console.WriteLine("Я думал ты не дурачок");
                                Console.WriteLine("Ну, впрочем, ладно. Попробуй еще раз, но по нормальному");
                            }
                            else
                            {
                                Console.WriteLine("Замечательно! Жду 2 число");
                                bool genius = int.TryParse(Console.ReadLine(), out int b);
                                if (!genius)
                                {
                                    Console.WriteLine("Мужик, ну ты чего?");
                                    Console.WriteLine("Я думал ты не дурачок");
                                    Console.WriteLine("Так глупо проиграть в самом конце!");
                                    Console.WriteLine("Ну, впрочем, ладно. Попробуй еще раз, но по нормальному");
                                }
                                else
                                {
                                    Console.WriteLine("Красава! Вот твой остаток от деления - " + (a % b));
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Дурачок, вводи доступные операции");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
