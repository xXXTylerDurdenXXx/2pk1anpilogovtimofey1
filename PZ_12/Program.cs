using System.Diagnostics.Metrics;

namespace PZ_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine(); // вводим строку

            double r = Str(str);
            
            Console.WriteLine(($"Процент символов пунктуации: {r}% ")); //Вывод на консоль
        }
        static  double Str(string str)
        {
            int count = 0;  
            //Создаем цикл который который прогоняет строку на проверку наличия пунктуационных символов
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsPunctuation(str[i]))
                {
                    count++; //Заполняем счетчик при выполнении условия
                }
            }


            double result = ((double)count / str.Length) * 100.0 ; // Выводим процентное соотношение
            
            return result ;
        }
    }
}
