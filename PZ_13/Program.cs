﻿namespace PZ_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Задание 1
            Console.WriteLine("Задание для арифметической прогрессии");
            int a = 2;
            int d = 6;
            int n = 2;
            Arifmetic(a,d,n);
            // Задание 2
            Console.WriteLine("Задание для геометрической прогрессии");
            double b = 2.0;
            double q = 0.5;
            int n1 = 4;
            Geo(b,q,n1);
            // Задание 3
            Console.WriteLine("задание 3");
            int value1 = 50;
            int value2 = 200;
            Writline(value1,value2);
            //Задание 4 (НА пятерочку)
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите число до которого будет считаться сумма");
            int x = int.Parse(Console.ReadLine());
            int y = 0;
            int result = Summ(x,ref y);
           
            Console.WriteLine(result);

        }
        static int Summ(int x,ref int n) // Функция для 4 задания
        {
            
            if (x == 0) 
                return n;
            else
            {
                n += x;
            }
            Summ(x-1,ref n);
            return n;
        }
        static void Writline(int value1,int value2) // Функция для 3 задания
        {
            if (value1 == value2)
            {
                Console.WriteLine(value2);
                return;
            }
            Console.WriteLine(value1);
            Writline(value1+1,value2);

        }
        static int Arifmetic (int a,int d,int n) // Функция для 1 задания
        {
            
            if (n == 0)
            {
                return a;
            }
            else
            {
                Console.WriteLine(a);
                a += d;
                Arifmetic(a, d, n-1);

                
            }
            return a;
        }

        static double Geo(double b,double q,int n1)// Функция для 2 задания
        {
            if (n1 == 0)
             return b;
            else
            {
                Console.WriteLine(b);
                b *= q;
                Geo(b,q,n1-1);
            }
            return b;
        }


    }
}
