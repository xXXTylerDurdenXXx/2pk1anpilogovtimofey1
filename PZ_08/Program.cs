﻿using System;
using System.Net.WebSockets;

namespace PZ_08
{
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 и 2");
            Random random = new Random(); // объект рандом
            string[][] arr = new string[15][]; // наш массив

            for (int i = 0; i < arr.Length; i++)  // генирируем наш массив
            {
                for (int j = 0; j < 15; j++)
                {
                    arr[j] = new string[random.Next(1, 26)];
                }

            }
            Console.WriteLine();
            string rndStr = "qwertyuiopasdfghjklzxcvbnm";

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    string a = Convert.ToString(rndStr[random.Next(rndStr.Length)]);
                    arr[i][j] = a + a + a + a;
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" Задание 3");
            string[] lastSimvol = new string[15];



            for (int i = 0; i < lastSimvol.Length; i++)
            {

                lastSimvol[i] = arr[i][^1];
                Console.Write(lastSimvol[i] + " ");




            }
            Console.WriteLine();
            Console.WriteLine("Задание 4");
            for (int i = 0;i < lastSimvol.Length ; i++)
            {
                lastSimvol[i] = arr[i].Max();
                Console.Write(lastSimvol[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Задание 5");
            for (int i = 0; i < arr.Length; i++)
            {
                string b = arr[i][0];
                string c = arr[i].Max();
                int n = Array.IndexOf(arr[i], c);
                arr[i][0] = c;
                arr[i][n] = b;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }








        }
    }
}