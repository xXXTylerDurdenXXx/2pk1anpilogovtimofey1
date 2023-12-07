namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag) 
            {
                flag = false;
                Console.WriteLine("Введите полный путь к каталогу:");
                string path_cat = Console.ReadLine();

                if (Directory.Exists(path_cat)) // Проверка на  наличие директории
                {
                    DirectoryInfo dir = new DirectoryInfo(path_cat);

                    string[] files = Directory.GetFiles(path_cat);
                    int count = 0;

                    for (int i = 0; i < files.Length; i++)
                    {
                        if (files[i].Substring(files[i].LastIndexOf(".")) == ".exe")
                            count++;
                    }

                    string[] files_exe = new string[count];

                    count = 0;

                    for (int i = 0; i < files.Length; i++)
                    {
                        if (files[i].Substring(files[i].LastIndexOf(".")) == ".exe")
                        {
                            files_exe[count] = files[i];
                            count++;
                        }
                    }

                    foreach (string file in files_exe) // прогоняем через чикл массив и выводим
                    {
                        Console.WriteLine($"Название файла: {file.Substring(file.LastIndexOf(@"\") + 1)}");
                        Console.WriteLine($"Время создания файла: {Directory.GetCreationTime(file)}");
                    }
                }
                else
                    flag = true;
                Console.WriteLine("Директории с таким названием не существует :( Попробуйте еще раз :<");
            }

        }
    }
}
