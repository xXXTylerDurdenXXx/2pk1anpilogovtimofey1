namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random random = new Random();
            int[] myArray= new int[50]; // Задаем первый массив и его длинну
            int length = 0;             // Счетчик для определения длинны второго массива
            int count = 0;             // Счетчик 
            for (int i = 0; i < myArray.Length; i++)  // Пересчет масива 
            {
                myArray[i] = random.Next(-101, 101);  // задаем значения через рандом
                Console.WriteLine(myArray[i]);  // выводим  на консоль

                if (myArray[i] >= -10 && myArray[i] <= 10)   // условия для определения длинны второго массива
                {
                    length++;
                }

            }
            int[] youArray = new int[length];  // Задаем второй массив и его длинну

            for (int i = 0; i < myArray.Length; i++)  //Пересчет массива
            {


                if (myArray[i] >= -10 && myArray[i] <= 10) //  Условия для заполнения второго массива
                {
                    youArray[count] = myArray[i];
                    count++;
                }       
                

            }
            Console.WriteLine("Вывод второго массива "); // соответссвенно вывод второго массива
            for (int i = 0; i < youArray.Length; i++)
            {
                Console.WriteLine(youArray[i]);

            }

        }
    }
}