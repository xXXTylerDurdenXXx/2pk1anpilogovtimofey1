namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество км для первого дня");
            double x = double.Parse(Console.ReadLine());    
            Console.WriteLine("Введите количество конечного результата");
            double y = double.Parse(Console.ReadLine());
            double prozent = 1.1;
            int countDays = 1;
            do  
            {
                Console.WriteLine($"День: {countDays}" + $"  Пробег: {x}");
                x =( x * prozent);
                x = Math.Round(x,1);  
                countDays++;
               

            } while (x <=  y);
            Console.WriteLine($"Номер дня: {countDays}");
        }
    }
}