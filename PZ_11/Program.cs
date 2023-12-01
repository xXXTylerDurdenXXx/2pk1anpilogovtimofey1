namespace PZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пределы");
            Console.WriteLine("Введите минимальный предел");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальный предел");
            int n = int.Parse(Console.ReadLine());
           int summ;
            GetSquareSumm(m, n,out summ);
            Console.WriteLine(summ);
        }
        static void GetSquareSumm(int m ,int n, out int summ)
        {
             summ = 0;
            for (int i = m; i < n; i++)
            {
                summ += i * i;
            }
            
        }

    }
}
