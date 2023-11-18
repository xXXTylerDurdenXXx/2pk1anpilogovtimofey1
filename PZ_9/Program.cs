using System;
namespace PZ_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine(); // Произвольная строка с консоли
            // Создаем счетчики
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            double count4 = 0;
            // Создаем цикл который который прогоняет строку на проверку наличия заглавных букв
           for (int i = 0; i< str.Length; i++)
           {
                if (Char.IsUpper(str[i]) ) 
                {
                    count1++; //Заполняем счетчик при выполнении условия
                }

           }
            // Создаем цикл который который прогоняет строку на проверку наличия строчных  букв
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLower(str[i]))
                {
                    count2++; //Заполняем счетчик при выполнении условия
                }

            }
            // Создаем цикл который который прогоняет строку на проверку наличия пробельных символов
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsWhiteSpace(str[i]))
                {
                    count3++; //Заполняем счетчик при выполнении условия
                }

            }
            //Создаем цикл который который прогоняет строку на проверку наличия пунктуационных символов
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsPunctuation(str[i]))
                {
                    count4++; //Заполняем счетчик при выполнении условия
                }

            }
            
            double result = count4 / str.Length * 100  ; // Выводим процентное соотношение
            
           




            Console.WriteLine(str.Length);
            Console.WriteLine(count4);
            Console.WriteLine(($"Заглавных букв: {count1} ")); //Вывод на консоль
            Console.WriteLine(($"Строчных  букв: {count2} ")); //Вывод на консоль
            Console.WriteLine(($"Пробельных символов: {count3} ")); //Вывод на консоль
            Console.WriteLine(($"Процент символов пунктуации: {result}% ")); //Вывод на консоль
        }
    }
}