using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отрисовка рамок закрепление размера окна
            Console.SetWindowSize(112, 25);
            Console.SetBufferSize(112, 25);

            HorizontalLine upLine = new HorizontalLine(0, 110, 0, '*');
            HorizontalLine downLine = new HorizontalLine(0, 110, 24, '*');
            VerticalLine vertticalLineRight = new VerticalLine(110, 0, 24, '*');
            VerticalLine verticalLineLeft = new VerticalLine(0, 0, 24, '*');
            upLine.Draw();
            downLine.Draw();
            vertticalLineRight.Draw();
            verticalLineLeft.Draw();

            Console.ReadKey();
        }
    }
}
