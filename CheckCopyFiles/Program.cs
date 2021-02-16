using System;
using System.IO;

namespace CheckCopyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Run();
        }

        public static void Run()
        {
            string gotor = "D:\\Temp\\test1";

            Console.WriteLine("Следим за директорией :" + gotor);
            Console.ReadLine();

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = gotor;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "*.*";

        }
    }
}
