namespace PZ_14
{
    internal class Program
    {
        static void ReadWrite(string txt) // Метод для прочтения нашего файла
        {
            using (FileStream file = new FileStream(txt, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    Console.WriteLine("текст в вашем файле:");
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random(); // Рандом
            string txt = @"text.txt"; // Создаем файл
            string[] randomStrings = new string[] { "Cook", "Mom", "Crico", "Enigma", "Naruto", "SLOVO", "Tomsk", "Cat" }; // Рандомные слова которыми будет заполнятся файл
            using(FileStream file = new FileStream(txt,FileMode.OpenOrCreate,FileAccess.ReadWrite)) 
            { 
                using (StreamWriter writer = new StreamWriter(file)) 
                {
                    
                    for (int i = 0; i < 5; i++)  // Заполняем наш файл
                    {
                        writer.WriteLine(randomStrings[random.Next(0,8)]);
                    }
                   
                }
            }
            ReadWrite(txt); // обращаемся к методу

            string[] lines = File.ReadAllLines(txt); // создаем массив строк куда записываем строки файла
            Console.WriteLine("Введите номер строчки которую хотите удалить ");
            int k = int.Parse(Console.ReadLine()); // Вводим с консоли номер строки которой хотим удалить
            string txt1 = @"1text.txt";
            if (k >=0 && k< lines.Length)  // проверка на то входит ли k в границы нашего массива строк
            {
                
                using (FileStream file = new FileStream(txt1, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (StreamWriter writer = new StreamWriter(file))
                    {

                        for (int i = 0; i < lines.Length; i++)
                        {

                            if (i != k) // заполняем новый файл пока k не равен номеру строчки
                            {
                                writer.WriteLine(lines[i]);
                            }
                            else // как только равен пропускаем строчку
                            {
                                continue;
                            }
                        }

                    }
                }
                ReadWrite(txt1); // выводим обновленный массив
            }
            else // если не входит обращаемся к методу и выводим массив без изменений 
            {
                Console.WriteLine("Вы ввели число больше чем количество строк изменений не последовало");
                ReadWrite(txt);
            }
                
          File.Delete(txt); // удаляем наши файлы 
            File.Delete(txt1);
        }
    }
}
