using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class FigurePaint
    {
        int _size;
        public FigurePaint(int size)
        {
            this._size = size;
        }
        public void PrintAll()
        {
            PrintSquare();
            PrintTriangle();
            PrintRomb();
        }
        public void PrintSquare()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine(new string('*', _size));
            }
        }
        public void PrintTriangle()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        public void PrintRomb()
        {
            for (int i = 1; i < _size / 2; i++)
            {
                Console.Write(new string(' ', _size - i));
                Console.Write(new string('*', i * 2));
                Console.WriteLine();
            }
            for (int i = (_size - 1) / 2; i > 0; i--)
            {
                Console.Write(new string(' ', _size - i));
                Console.Write(new string('*', i * 2));
                Console.WriteLine();
            }
        }
    }
}
