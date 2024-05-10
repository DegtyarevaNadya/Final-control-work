using System;

namespace MainHW
{
    class Program
    {
        static void Main(string[] args)
        {
            int change = 0;
            Console.WriteLine("Если вы хотите использовать ваш массив, введите 1. Использовать массив по умолчанию - 2: ");
            change = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Вы ввели {change}");

            string[] example = new string[6] { "123", "4563", "example", "array", "what", "43" };
            string[] array = example;

            switch (change)
            {
                case 1: 
                    Console.WriteLine("Вы решили использовать ваш массив");
                    array = InputArrayStrings(6);
                    break;
                case 2:
                    Console.WriteLine("Вы решили использовать массив по умолчанию");
                    break;
                default:
                    Console.WriteLine("Не понял вас");
                    break;
            }
            CheckArrayStrings(array);
            PrintArrayStrings(array);
            Console.ReadKey();
        }
        static string[] InputArrayStrings(int arraySize)
        {
            string[] strings = new string[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Введите {i + 1} строку массива:");
                strings[i] = Console.ReadLine();
            }
            return strings;
        }

        static void PrintArrayStrings(string[] array)
        {
            for(int i = 0; i < array.Length;i++)
            {
                Console.Write($"{array[i]} ");
            }

        }

        static void CheckArrayStrings(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }

            Console.WriteLine($"Всего {count} таких строк");
        }

    }

    
}
