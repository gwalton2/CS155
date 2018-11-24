using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Board
    {
        private Game game;

        public Board(Game game)
        {
            ChessBoard.Initialize();
            this.game = game;
        }

        private char[,] _myboard = new char[8, 8] { { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' }, //uppercase is white
                                              { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                                              { '-', '-', '-', '-', '-', '-', '-', '-' },
                                              { '-', '-', '-', '-', '-', '-', '-', '-' }, //Board reversed visually to match index
                                              { '-', '-', '-', '-', '-', '-', '-', '-' },
                                              { '-', '-', '-', '-', '-', '-', '-', '-' },
                                              { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                                              { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' } }; // lowercase is black    

        public char[,] MyBoard
        {
            get { return _myboard;  }
        }

        public bool IsOccupied(int rank, int file)
        {
            char loc = _myboard[rank, file];

            return !loc.Equals('-');
        }

        public bool IsRightColor(int rank, int file)
        {
            char piece = _myboard[rank, file];
            if ((char.IsUpper(piece) & game.Turn == Game.PieceColor.White) ||
                (!char.IsUpper(piece) & game.Turn == Game.PieceColor.Black))
            {
                return true;
            }
            return false;
        }

        public void MoveCharBoard(int og_index, int new_index)
        {
            int og_rank = og_index / 8;
            int og_file = og_index % 8;
            int new_rank = new_index / 8;
            int new_file = new_index % 8;

            char og_char = _myboard[og_rank, og_file];
            _myboard[og_rank, og_file] = '-';
            _myboard[new_rank, new_file] = og_char;

            game.NextTurn();
        }

        public void MoveBitBoard(int og_index, int new_index)
        {
            ulong move = Moves.GetMoveBitboard(og_index, new_index);
            ulong new_spot = (ulong)0x1 << new_index;
            ulong old_spot = (ulong)0x1 << og_index;
            List<ulong> boardList = ChessBoard.BoardList();

            for (int i = 0; i < boardList.Count; i++)
            {
                if ((boardList[i] ^ new_spot) < boardList[i])
                {
                    boardList[i] ^= new_spot;
                }
                else if ((boardList[i] ^ old_spot) < boardList[i])
                {
                    boardList[i] ^= move;
                }
            }
            ChessBoard.MakeMove(boardList);
        }

        public ulong GetMoves(int rank, int file)
        { 
            if (!IsRightColor(rank, file))
            {
                return 0;
            }

            char piece = _myboard[rank, file];

            switch (piece)
            {
                case 'r':
                    return Moves.GetRookMoves(rank, file, ChessBoard.AllPieces, ChessBoard.AllBlack);

                case 'n':
                    return Moves.GetKnightMoves(rank, file, ChessBoard.AllBlack);

                case 'b':
                    return Moves.GetBishopMoves(rank, file, ChessBoard.AllPieces, ChessBoard.AllBlack);

                case 'q':
                    return Moves.GetQueenMoves(rank, file, ChessBoard.AllPieces, ChessBoard.AllBlack);

                case 'k':
                    return Moves.GetKingMoves(rank, file, ChessBoard.AllBlack);

                case 'p':
                    return Moves.GetBlackPawnMoves(rank, file, ChessBoard.AllPieces, ChessBoard.AllWhite);

                case 'R':
                    return Moves.GetRookMoves(rank, file, ChessBoard.AllPieces, ChessBoard.AllWhite);

                case 'N':
                    return Moves.GetKnightMoves(rank, file, ChessBoard.AllWhite);

                case 'B':
                    return Moves.GetBishopMoves(rank, file, ChessBoard.AllPieces, ChessBoard.AllWhite);

                case 'Q':
                    return Moves.GetQueenMoves(rank, file, ChessBoard.AllPieces, ChessBoard.AllWhite);

                case 'K':
                    return Moves.GetKingMoves(rank, file, ChessBoard.AllWhite);

                case 'P':
                    return Moves.GetWhitePawnMoves(rank, file, ChessBoard.AllPieces, ChessBoard.AllBlack);

                default:
                    return 0;
            }
        }
    }
}
