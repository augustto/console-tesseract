using System;
using System.IO;

namespace ConsoleTesseractOcr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // path ocr, lang, path ocr langdata
            var service = new TesseractService(@"D:\programs\TesseractOcr", "eng", @"D:\programs\TesseractOcr\tessdata");
            var stream = File.OpenRead("D:\\DEV\\File\\TesseractOCRWebApi\\ocr\\tests\\8.jpg");
            var text = service.GetText(stream);            
            Console.WriteLine(text);
            Console.Read();
        }
    }
}
