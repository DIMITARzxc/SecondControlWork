using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCW
{
    class Program
    {
        static void Main(string[] args)
        {
            File main = new File();
            //main.TakeString();
            string text = @"Text:file.txt(6B);Some string content
Movie:logan.2017.mkv(19GB);1920x1080;2h12m
Image:image.bmp(19MB);1920x1080";
            MyList res = new MyList();
            string[] files = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < files.Length; i++)
            {
                string[] split = files[i].Split(':');
                string fileType = split[0].ToLower();
                switch (fileType)
                {
                    case "text":
                        string[] splitText = split[1].Split(new char[] { '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine("Text");
                        Console.WriteLine("Name:" + splitText[0]);
                        Console.WriteLine("Exnesion:" + splitText[1]);
                        Console.WriteLine("Conntent:" + splitText[2]);
                        Console.ReadLine();
                        break;
                    case "movie":
                        string[] splitMovie = split[1].Split(new char[] { '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine("Movie");
                        Console.WriteLine("Name:" + splitMovie[0]);
                        Console.WriteLine("Exnesion:" + splitMovie[1]);
                        Console.WriteLine("Screen size:" + splitMovie[2]);
                        Console.WriteLine("Timing:" + splitMovie[3]);
                        Console.ReadLine();
                        break;
                    case "image":
                        string[] splitImage = split[1].Split(new char[] { '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine("Image");
                        Console.WriteLine("Name:" + splitImage[0]);
                        Console.WriteLine("Exnesion:" + splitImage[1]);
                        Console.WriteLine("Screen size:" + splitImage[2]);

                        Console.ReadLine();
                        break;
                    default:
                        break;
                }


            }
        }
    }
}
