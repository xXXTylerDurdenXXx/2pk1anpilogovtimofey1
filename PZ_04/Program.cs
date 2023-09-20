namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //первое задание
            Console.WriteLine("Первое задание:");
            for (int i = 0; i < 90; i += 5)
            {
                Console.WriteLine(i);
            }

            //ВТОРОЕ ЗАДАНИЕ           
            Console.WriteLine("Второе задание:");

            for (char i = 'B'; i < 'H'; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Третье задание:");




            //третье задание
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }


            //четвертое задание
            Console.WriteLine("Четвертое задание:");
            int count = 0;
            for (int i = -200; i < 200; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }

            Console.WriteLine();

            Console.WriteLine($"количество  чисел кратные семи: {count}");

            //пятое задание
            Console.WriteLine("пятое задание:");


            int limit, max;


            for (limit = 3, max = 50; max - limit > 17; max--, limit++)
            {
                Console.WriteLine(limit + " " + max);

            }
            Console.WriteLine(limit + " " + max);


        }





    }
}