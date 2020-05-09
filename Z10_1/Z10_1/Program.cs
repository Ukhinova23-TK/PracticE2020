using System;
using System.IO;

namespace Z10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(@"C:\temp"))
            {
                Directory.CreateDirectory(@"C:\temp");
            }
            Directory.CreateDirectory(@"C:\temp\K1");
            Directory.CreateDirectory(@"C:\temp\K2");

            using(StreamWriter sw = new StreamWriter(@"C:\temp\K1\t1.txt"))
            {
                sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
            }
            using (StreamWriter sw = new StreamWriter(@"C:\temp\K1\t2.txt"))
            {
                sw.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            }
            using(StreamWriter sw = new StreamWriter(@"C:\temp\K2\t3.txt"))
            {
                using(StreamReader sr = new StreamReader(@"C:\temp\K1\t1.txt"))
                {
                    sw.WriteLine(sr.ReadToEnd());
                }
                using (StreamReader sr = new StreamReader(@"C:\temp\K1\t2.txt"))
                {
                    sw.WriteLine(sr.ReadToEnd());
                }
            }

            FileInfo fileInfo = new FileInfo(@"C:\temp\K1\t1.txt");
            Console.WriteLine($"Директория: {fileInfo.DirectoryName}\n" +
                $"Полное имя файла: {fileInfo.FullName}\n" +
                $"Время создания: {fileInfo.CreationTime}\n" +
                $"Размер: {fileInfo.Length}");
            fileInfo = new FileInfo(@"C:\temp\K1\t2.txt");
            Console.WriteLine($"Директория: {fileInfo.DirectoryName}\n" +
                $"Полное имя файла: {fileInfo.FullName}\n" +
                $"Время создания: {fileInfo.CreationTime}\n" +
                $"Размер: {fileInfo.Length}");
            fileInfo = new FileInfo(@"C:\temp\K2\t3.txt");
            Console.WriteLine($"Директория: {fileInfo.DirectoryName}\n" +
                $"Полное имя файла: {fileInfo.FullName}\n" +
                $"Время создания: {fileInfo.CreationTime}\n" +
                $"Размер: {fileInfo.Length}");
            
            File.Move(@"C:\temp\K1\t2.txt", @"C:\temp\K2\t2.txt");
            File.Copy(@"C:\temp\K1\t1.txt", @"C:\temp\K2\t1.txt");

            Directory.Move(@"C:\temp\K2", @"C:\temp\ALL");
            Directory.Delete(@"C:\temp\K1", true);

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\temp\ALL");
            FileInfo[] files = directoryInfo.GetFiles();
            Console.WriteLine();
            foreach(FileInfo info in files)
            {
                Console.WriteLine($"Директория: {info.DirectoryName}\n" +
                $"Полное имя файла: {info.FullName}\n" +
                $"Время создания: {info.CreationTime}\n" +
                $"Размер: {info.Length}");
            }
            Console.ReadKey();
        }
    }
}
