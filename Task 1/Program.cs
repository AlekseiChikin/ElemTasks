using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard(5, 5);
            Console.WriteLine(board);

            //ushort height, width;
            //if (ushort.TryParse(Console.ReadLine(), out height) &&
            //   ushort.TryParse(Console.ReadLine(), out width))
            //{
            //    ChessBoard board = new ChessBoard(height, width);
            //    Console.WriteLine(board);
            //}
        }
    }
}
