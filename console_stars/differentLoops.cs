using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_stars.Contracts
{
    class differentLoops : Iloops
    {
        public void IncreasingLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
            }
        }

        public void SquareLoopMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
            }
        }
    }
}
