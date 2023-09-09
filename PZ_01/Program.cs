
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("введите число a");
            double a =double.Parse( Console.ReadLine());
            if (a <= 0 )
            {
                Console.WriteLine("Перездайте число недопустимое значение ");
                 a  = double.Parse( Console.ReadLine());
            }
            

            Console.WriteLine("введите число c");
            double c =double.Parse( Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = double.Parse( Console.ReadLine());
            double value1, value2, value3, value4, value5;     // Задаем переменные
          
            // разделяем пример на дествиия
            value1 = (3 * (Math.Log(8, a)));                   // действие 1    
           
         value2 = ( Math.Sin(b / (3 * a)));                    // действие 2

            value3 = Math.Cbrt(5 * (Math.Pow(a, 2)) + 7);      // действие 3
            value4 = 4 *  Math.Abs(c - (2 * a) + 1);          // действие 4
            value5 = Math.Sqrt(8*a);                          // действие 5
            double result = (value1 / value2) - (value3 ) + (value4 / value5);   // складываем все результаты
           double finish =  Math.Round(result, 0 );           // округляем

            Console.WriteLine("Ответ =  " + finish);                        //выводим результат на консоль




            Console.ReadLine();

          


        }
    }
    
}