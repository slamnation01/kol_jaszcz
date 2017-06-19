using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj x i y puntu a");

            int ax = Convert.ToInt32(Console.ReadLine());
            int ay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj x i y puntu b");

            int bx = Convert.ToInt32(Console.ReadLine());
            int by = Convert.ToInt32(Console.ReadLine());

            Line myLine = new Line(ax, ay, bx, by);

            Console.WriteLine("Podaj xnr prostej");

            int lineNr = Convert.ToInt32(Console.ReadLine());

            var angle = myLine.Angle(lineNr);

            Console.WriteLine("Kat wynosi {0}", angle);

        }
    }
}
