using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matr = new int[3, 3];
            matr[0, 0] = 1;
            matr[0, 1] = 2;
            matr[0, 2] = 3;
            matr[1, 0] = 4;
            matr[1, 1] = 5;
            matr[1, 2] = 6;
            matr[2, 0] = 7;
            matr[2, 1] = 8;
            matr[2, 2] = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matr[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
