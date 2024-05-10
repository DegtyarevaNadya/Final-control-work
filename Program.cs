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
                    PrintArrayStrings(array);
                    break;
                default:
                    Console.WriteLine("Не понял вас");
                    break;
            }
            string[] newArray = new string[CheckArrayStrings(array)];
            CreateArrayStrings(array, newArray);
            PrintArrayStrings(newArray);
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

        static int CheckArrayStrings(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }

            Console.WriteLine($"Всего строки из 3 и менее символов: {count}");
            return count;
        }

        static void CreateArrayStrings(string[] array, string[] NewArray)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    NewArray[count] = array[i];
                    count++;
                }
                
            }

        }

    }

    
}
