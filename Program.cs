using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPictures = 52;
            int picturesAtATime = 3;
            int totalLines;
            int remainder;
            totalLines = totalPictures / picturesAtATime;
            remainder = totalPictures - totalLines*picturesAtATime;
            Console.WriteLine($"Полностью заполненных рядов {totalLines}, а картинок сверх меры {remainder}");
        }
    }
}
