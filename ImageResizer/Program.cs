using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = Path.Combine(Environment.CurrentDirectory, "images");
            string destinationPath = Path.Combine(Environment.CurrentDirectory, "output");

            //同步版
            //ImageProcess OriImageProcess2 = new ImageProcess();
            //OriImageProcess2.Clean(destinationPath);
            //Stopwatch OriWatch = new Stopwatch();
            //OriWatch.Start();
            //OriImageProcess2.ResizeImages(sourcePath, destinationPath, 2.0);
            //OriWatch.Stop();
            //Console.WriteLine($"花費時間: {OriWatch.ElapsedMilliseconds} ms");

            //非同步版
            ImageProcess imageProcess = new ImageProcess();
            imageProcess.CleanAsync(destinationPath).Wait();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            imageProcess.ResizeImagesAsync(sourcePath, destinationPath, 2.0).Wait();
            sw.Stop();
            Console.WriteLine($"花費時間: {sw.ElapsedMilliseconds} ms");



            Console.Read();

        }
    }
}
