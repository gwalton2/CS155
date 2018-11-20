using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Board
    {
        ulong _whitepawns = 0xFF00;
        ulong _whiteknights = 0x42;
        ulong _whitebishops = 0x24;
        ulong _whiterooks = 0x81;
        ulong _whitequeen = 0x10;
        ulong _whiteking = 0x8;

        ulong _blackpawns = 0xFF000000000000;
        ulong _blackknights = 0x4200000000000000;
        ulong _blackbishops = 0x2400000000000000;
        ulong _blackrooks = 0x8100000000000000;
        ulong _blackqueen = 0x1000000000000000;
        ulong _blackking = 0x800000000000000;

        ulong _allwhite;
        ulong _allblack;
        ulong _allpieces;

        public Board()
        {
            Update();
        }

        char[,] _chessboard = new char[8, 8] { { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' }, //uppercase is white
                                              { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                                              { '-', '-', '-', '-', '-', '-', '-', '-' },
                                              { '-', '-', '-', '-', 'B', '-', '-', '-' }, //Board reversed visually to match index
                                              { '-', '-', '-', '-', '-', '-', '-', '-' },
                                              { '-', '-', '-', '-', '-', '-', '-', '-' },
                                              { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                                              { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' } }; // lowercase is black

        public ulong AllPieces
        {
            get { return _allpieces; }
        }

        public char[,] ChessBoard
        {
            get { return _chessboard;  }
        }

        public void Update()
        {
            _allwhite = _whitepawns | _whiteknights | _whitebishops | _whiterooks | _whitequeen | _whiteking;
            _allblack = _blackpawns | _blackknights | _blackbishops | _blackrooks | _blackqueen | _blackking;
            _allpieces = _allwhite | _allblack;
        }

        public bool IsOccupied(int rank, int file)
        {
            char loc = _chessboard[rank, file];

            return !loc.Equals('-');
        }

        public void Move(int og_index, int new_index)
        {

        }

        public ulong GetMoves(int rank, int file)
        {
            char piece = _chessboard[rank, file];

            switch (piece)
            {
                case 'r':
                    return Moves.GetRookMoves(rank, file, _allpieces, _allblack);

                case 'n':
                    return Moves.GetKnightMoves(rank, file, _allblack);

                case 'b':
                    return Moves.GetBishopMoves(rank, file, _allpieces, _allblack);

                case 'q':
                    return Moves.GetQueenMoves(rank, file, _allpieces, _allblack);

                case 'k':
                    return Moves.GetKingMoves(rank, file, _allblack);

                case 'p':
                    return Moves.GetBlackPawnMoves(rank, file, _allpieces, _allwhite);

                case 'R':
                    return Moves.GetRookMoves(rank, file, _allpieces, _allwhite);

                case 'N':
                    return Moves.GetKnightMoves(rank, file, _allwhite);

                case 'B':
                    return Moves.GetBishopMoves(rank, file, _allpieces, _allwhite);

                case 'Q':
                    return Moves.GetQueenMoves(rank, file, _allpieces, _allwhite);

                case 'K':
                    return Moves.GetKingMoves(rank, file, _allwhite);

                case 'P':
                    return Moves.GetWhitePawnMoves(rank, file, _allpieces, _allblack);

                default:
                    return 0;
            }
        }
    }
}
