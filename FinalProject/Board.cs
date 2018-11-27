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
        private ChessBoard chessboard;

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

        public Board(Game game, ChessBoard chessboard)
        {
            this.chessboard = chessboard;
            this.game = game;
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

        public bool IsCheck(ulong move, Game.PieceColor color)
        {
            List<int> indexes = Moves.ConvertBitboard(move);
            MoveBitBoard(indexes[0], indexes[1]);

            ulong attacks;
            ulong king;
            if (color == Game.PieceColor.White)
            {
                king = chessboard.WhiteKing;
                attacks = Moves.GetAllBlackMoves(chessboard);
            }
            else
            {
                king = chessboard.BlackKing;
                attacks = Moves.GetAllWhiteMoves(chessboard);
            }

            UndoLastMoveBitBoard();
            return (king & attacks) != 0;
        }

        public ulong ClipCheck(ulong moves)
        {
            ulong index = 1;
            for (int i = 0; i < 64; i++)
            {
                if ((index & moves) != 0)
                {
                    if (IsCheck(index, game.Turn))
                    {
                        moves ^= index;
                    }
                }
                index <<= 1;
            }
            return moves;
        }

        public void IsCheckMate()
        {
            ulong allmoves = 0;
            if (game.Turn == Game.PieceColor.White)
            {
                allmoves = ClipCheck(Moves.GetAllWhiteMoves(chessboard));
            }
            else
            {
                allmoves = ClipCheck(Moves.GetAllBlackMoves(chessboard));
            }

            if (allmoves == 0)
            {
                game.GameOver = true;
            }
        }

        public void MoveCharBoard(int og_index, int new_index)
        {
            int og_rank = og_index / 8;
            int og_file = og_index % 8;
            int new_rank = new_index / 8;
            int new_file = new_index % 8;

            char piece = _myboard[og_rank, og_file];
            _myboard[og_rank, og_file] = '-';
            _myboard[new_rank, new_file] = piece;
        }

        public void MoveBitBoard(int og_index, int new_index)
        {
            ulong move = Moves.GetMoveBitboard(og_index, new_index);
            ulong new_spot = (ulong)0x1 << new_index;
            ulong old_spot = (ulong)0x1 << og_index;
            List<ulong> boardList = chessboard.BoardList();

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
            chessboard.MakeMove(boardList);
            game.NextTurn();
        }

        public void UndoLastMoveBitBoard()
        {
            chessboard.UndoLastMove();
            game.NextTurn();
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
                    return ClipCheck(Moves.GetRookMoves(rank, file, chessboard.AllPieces, chessboard.AllBlack));

                case 'n':
                    return ClipCheck(Moves.GetKnightMoves(rank, file, chessboard.AllBlack));

                case 'b':
                    return ClipCheck(Moves.GetBishopMoves(rank, file, chessboard.AllPieces, chessboard.AllBlack));

                case 'q':
                    return ClipCheck(Moves.GetQueenMoves(rank, file, chessboard.AllPieces, chessboard.AllBlack));

                case 'k':
                    return ClipCheck(Moves.GetKingMoves(rank, file, chessboard.AllBlack));

                case 'p':
                    return ClipCheck(Moves.GetBlackPawnMoves(rank, file, chessboard.AllPieces, chessboard.AllWhite));

                case 'R':
                    return ClipCheck(Moves.GetRookMoves(rank, file, chessboard.AllPieces, chessboard.AllWhite));

                case 'N':
                    return ClipCheck(Moves.GetKnightMoves(rank, file, chessboard.AllWhite));

                case 'B':
                    return ClipCheck(Moves.GetBishopMoves(rank, file, chessboard.AllPieces, chessboard.AllWhite));

                case 'Q':
                    return ClipCheck(Moves.GetQueenMoves(rank, file, chessboard.AllPieces, chessboard.AllWhite));

                case 'K':
                    return ClipCheck(Moves.GetKingMoves(rank, file, chessboard.AllWhite));

                case 'P':
                    return ClipCheck(Moves.GetWhitePawnMoves(rank, file, chessboard.AllPieces, chessboard.AllBlack));

                default:
                    return 0;
            }
        }
    }
}
