namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int c = int.Parse(Console.ReadLine());          //Вводим переменную C с консоли
            Console.WriteLine("Введите число b");
            double d = double.Parse(Console.ReadLine());   // Вводим переменную D с консоли
            double p, q,r;                                // задаем переменные
            if (d > 0 )                                  // условие  если оно верно выполняется следующий цикл нахождения переменной
            
                p = (17 * c) - d;
           
            else                                       //Иначе выполняется этот цикл нахождения переменной
             
                p = Math.Log10((2*d)+50);

             
           
            if (p <= 11)                               // условие  если оно верно выполняется следующий цикл нахождения переменной

                q = Math.Tan(c + Math.Pow(p,2));
            else                                       //Иначе выполняется этот цикл нахождения переменной
                q = (p - (c*d))/(Math.Pow(p,2)+ c + d) ;
            
            r = Math.Pow((p + q),3) - 11;              //нахождение последней переменной
            double result = Math.Round(r,3);           // найденую переменную r округляем до трех знаков после запятой 
            Console.WriteLine($"Ваш результат: {result} "); // выводим на консоль наш результат
        }
    }
}