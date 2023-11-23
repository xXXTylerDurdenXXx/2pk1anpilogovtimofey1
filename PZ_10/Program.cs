namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ranStrings = new string[] { "Kavazaki","Cago","Krico","Estriper" }; // Рандомные слова которые мы берем
            Random random = new Random();
            Console.WriteLine("Введите количество строк и столбцов массива");
            int range = int.Parse(Console.ReadLine());
            string[,] strings = new string[range, range]; // цикл в котором мы рандомно задаем массив
            for (int i = 0; i < strings.GetLength(0); i++)
            {
                for (int j = 0; j < strings.GetLength(1); j++)
                {
                    strings[i, j] = ranStrings[random.Next(0,4)];
                    Console.Write(strings[i,j] +  " ");
                }
                
                Console.WriteLine();
            }
            Console.WriteLine( "Книга пингвинов из мадагаскара"); // Выводим обновленнный массив
            for (int i = 0; i < strings.GetLength(0); i++)
            {
                for (int j = 0; j < strings.GetLength(1); j++)
                {
                   
                    Console.Write(strings[j, i] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}