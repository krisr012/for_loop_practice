using console_stars.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            differentLoops dL = new differentLoops();

            dL.SquareLoopMethod();
            dL.IncreasingLoop();

            Console.ReadLine();
        }
    }
}
