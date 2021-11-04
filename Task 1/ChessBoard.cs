using System.Text;

namespace Task1
{
    class ChessBoard
    {
        public ushort Height { get; init; }
        public ushort Width { get; init; }
        public char WhiteSquare { get; set; }
        public char BlackSquare { get; set; }
        private string _board;
        public ChessBoard(ushort hgt, ushort wdt, char white = ' ', char black = '#')
        {
            WhiteSquare = white;
            BlackSquare = black;
            Height = hgt;
            Width = wdt;
            _board = MakeBoard();
        }
        private string MakeBoard()
        {
            StringBuilder strB = new StringBuilder();

            for (uint i = 0; i < Height; i++)
            {
                for (uint j = 0; j < Width; j++)
                {
                    if ((i + j) % 2 == 0)
                        strB.Append(BlackSquare);
                    else
                        strB.Append(WhiteSquare);
                }
                strB.Append('\n');
            }
            return strB.ToString();
        }
        public override string ToString()
        {
            return _board;
        }
    }
}
