using System.ComponentModel.Design;

namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год  ");
            int year = int.Parse(Console.ReadLine());   // вводим переменную с консоли
            Console.WriteLine("Введите номер месяца");
            uint month = uint.Parse(Console.ReadLine());// вводим переменную с консоли
            uint febr = 28;
            
            
                switch (month)      // Если проверка прошла выполняется следующий цикл
                {
                    case 1:
                        {
                            Console.WriteLine("Январь: " + 31 + "Дней");
                            break;
                        }
                       
                        

                    case 2:
                    if (year % 400 == 0)
                    {
                        febr++;
                    }
                    Console.WriteLine("Февраль: " + febr + " Дней");
                        break;
                    case 3:
                        Console.WriteLine("Март: " + 31 + " Дней");
                        break;
                    case 4:
                        Console.WriteLine("апрель: " + 30 + " Дней");
                        break;

                    case 5:
                        Console.WriteLine("Май: " + 31 + " Дней");
                        break;
                    case 6:
                        Console.WriteLine("Июнь: " + 30 + "  Дней");
                        break;
                    case 7:
                        Console.WriteLine("Июль: " + 31 + "  Дней");
                        break;
                    case 8:
                        Console.WriteLine("Август: " + 31 + "  Дней");
                        break;
                    case 9:
                        Console.WriteLine("Сентябрь: " + 30 + "  Дней");
                        break;

                    case 10:
                        Console.WriteLine("Октябрь: " + 31 + "  Дней");
                        break;
                    case 11: 
                        Console.WriteLine("Ноябрь: " + 30 + " Дней");
                        break;
                    case 12:
                        Console.WriteLine("Декабрь: " + 31 + " Дней");
                        break;
                    default:
                        Console.WriteLine("Введите номер месяца от 1 до 12");

                        break;
                }

            
            
                
            
            

        }
    }
}