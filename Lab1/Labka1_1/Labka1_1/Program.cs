using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Lab1._1
{
    class Program
    {
       public static int FindTheIndex(string key,string path)
        {
            StreamReader downloaded_file = new StreamReader(new FileStream(path, FileMode.Open));
            string temp;
            using (downloaded_file)
            {
                int i = 0;
                while (!downloaded_file.EndOfStream) {
                    i++;
                    temp = downloaded_file.ReadLine();
                    if (temp.Contains(key))
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
        public static bool Validation(string[] args) {
            if (String.IsNullOrEmpty(args[0]) && String.IsNullOrEmpty(args[1]))
            {
                Console.WriteLine("The one of arguments is null of empty");
                return false;
            }
            return true;
        }
        public static void DownloadFile(string address) {
            using (WebClient webClient = new WebClient())
            {
                 webClient.DownloadFile(address, "index.html");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                bool access_to_download = Validation(args);
                if (access_to_download)
                {
                    string url = args[0];
                    string key = args[1];
                    string currentDir = Directory.GetCurrentDirectory();
                    DownloadFile(url);
                    string path = Path.Combine(currentDir, "index.html");
                    int index = FindTheIndex(key,path);
                    Process.Start(path);
                    if (index == -1)
                    {
                        Console.WriteLine($"{key} is absent.");
                    }
                    else
                    {
                        Console.WriteLine($"The number of row is {index} for {key} ");
                    }
                }
                else
                {
                    Console.WriteLine("Завершение программы");
                    Thread.Sleep(2000);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
          }
    }
}