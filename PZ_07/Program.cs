namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] arr = new char[8, 6]; //  Дан массив по условию
            int hight = arr.GetLength(0);
            int wight = arr.GetLength(1);
            char start = 'a';
            for (int x = 0; x < hight;  x++)
            {
               for (int y = 0; y < wight; y++) // Задаем и выводим исходный массив
                {
                    arr[x, y] = start;
                    start++;
                    Console.Write(arr[x,y]);
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("Измененый массив");
            for (int j = 0; j < 6; j++)
            {
                char temp = arr[0, j];
                arr[0, j] = arr[7, j];
                arr[7, j] = temp;
            }
            for (int j = 0;j < hight; j++) 
            {
                for (int i = 0; i < wight; i++)
                {
                    Console.Write(arr[j,i]);
                }
                Console.WriteLine();
            }


        }
    }
}