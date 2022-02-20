using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Введите целое число Х = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число Y = ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n    1 - сложение\n    2 - вычитание\n    3 - произведение\n    4 - частное");
                Console.WriteLine("Ваш выбор:");
                int c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат равен = {0}", x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат равен = {0}", x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат равен = {0}", x * y);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат равен = {0:f2}", (double)x / y);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указаным номером");
                            break;
                        }
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.ReadKey();
        }
    }
}
