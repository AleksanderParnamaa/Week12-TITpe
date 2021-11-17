using System;
using System.IO;
namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderName = @"C:\Users\opilane\samples\TITpe21";
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            Console.ReadLine();
        }
    }
}