﻿using System;
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

        private bool _captured;
        private int[] _lastmove;

        private char[,] _myboard = new char[8, 8] { { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' }, //uppercase is white
                                              { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                                              { '-', '-', '-', '-', '-', '-', '-', '-' },
                                              { '-', '-', '-', '-', '-', '-', '-', '-' }, //Board reversed visually to match index
                                              { '-', '-', '-', '-', '-', '-', '-', '-' },
                                              { '-', '-', '-', '-', '-', '-', '-', '-' },
                                              { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                                              { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' } }; // lowercase is black    

        public char[,] MyBoard { get { return _myboard; } }

        public bool Captured { get { return _captured; } }
        public int[] Lastmove { get { return _lastmove; } }

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

        public bool IsCheck(ulong move, int selected, Game.PieceColor color)
        {
            List<int> index = Moves.ConvertBitboard(move);
            MoveBitBoard(selected, index[0]);

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

        public ulong ClipCheck(ulong moves, int selected)
        {
            ulong index = 1;
            for (int i = 0; i < 64; i++)
            {
                if ((index & moves) != 0)
                {
                    if (IsCheck(index, selected, game.Turn))
                    {
                        moves ^= index;
                    }
                }
                index <<= 1;
            }
            return moves;
        }

        /*public void IsCheckMate()
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
        }*/

        private void SetLastMove(int og_rank, int og_file, int new_rank, int new_file)
        {
            _lastmove = new int[] { og_rank, og_file, new_rank, new_file };

            if (!_myboard[new_rank, new_file].Equals('-'))
            {
                _captured = true;
            }
            else
            {
                _captured = false;
            }
        }

        public void MoveCharBoard(int og_index, int new_index)
        {
            int og_rank = og_index / 8;
            int og_file = og_index % 8;
            int new_rank = new_index / 8;
            int new_file = new_index % 8;
            SetLastMove(og_rank, og_file, new_rank, new_file);

            char piece = _myboard[og_rank, og_file];
            _myboard[og_rank, og_file] = '-';
            _myboard[new_rank, new_file] = piece;

            ulong enpassant = Moves.GetEnPassant(new_index, chessboard);
            if (enpassant != 0)
            {
                int enp_index = Moves.ConvertBitboard(enpassant)[0];
                int enp_rank = enp_index / 8;
                int enp_file = enp_index % 8;
                _myboard[enp_rank, enp_file] = '-';

                _captured = true;
            }
        }

        public void MoveBitBoard(int og_index, int new_index)
        {
            ulong move = Moves.GetMoveBitboard(og_index, new_index);
            ulong new_spot = (ulong)0x1 << new_index;
            ulong old_spot = (ulong)0x1 << og_index;
            ulong enpassant = Moves.GetEnPassant(new_index, chessboard);
            List<ulong> boardList = chessboard.BoardList();

            for (int i = 0; i < boardList.Count; i++)
            {
                if ((boardList[i] ^ new_spot) < boardList[i])
                {
                    boardList[i] ^= new_spot;
                }
                else if ((boardList[i] ^ enpassant) < boardList[i])
                {
                    boardList[i] ^= enpassant;
                }
                else if ((boardList[i] ^ old_spot) < boardList[i])
                {
                    boardList[i] ^= move;

                    Moves.SetEnPassant(i, og_index, new_index, chessboard);
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

            int selected = rank * 8 + file;
            char piece = _myboard[rank, file];

            switch (piece)
            {
                case 'r':
                    return ClipCheck(Moves.GetRookMoves(rank, file, chessboard.AllPieces, chessboard.AllBlack), selected);

                case 'n':
                    return ClipCheck(Moves.GetKnightMoves(rank, file, chessboard.AllBlack), selected);

                case 'b':
                    return ClipCheck(Moves.GetBishopMoves(rank, file, chessboard.AllPieces, chessboard.AllBlack), selected);

                case 'q':
                    return ClipCheck(Moves.GetQueenMoves(rank, file, chessboard.AllPieces, chessboard.AllBlack), selected);

                case 'k':
                    return ClipCheck(Moves.GetKingMoves(rank, file, chessboard.AllBlack), selected);

                case 'p':
                    return ClipCheck(Moves.GetBlackPawnMoves(rank, file, chessboard.AllPieces, chessboard.AllWhite, chessboard.Enpassant), selected);

                case 'R':
                    return ClipCheck(Moves.GetRookMoves(rank, file, chessboard.AllPieces, chessboard.AllWhite), selected);

                case 'N':
                    return ClipCheck(Moves.GetKnightMoves(rank, file, chessboard.AllWhite), selected);

                case 'B':
                    return ClipCheck(Moves.GetBishopMoves(rank, file, chessboard.AllPieces, chessboard.AllWhite), selected);

                case 'Q':
                    return ClipCheck(Moves.GetQueenMoves(rank, file, chessboard.AllPieces, chessboard.AllWhite), selected);

                case 'K':
                    return ClipCheck(Moves.GetKingMoves(rank, file, chessboard.AllWhite), selected);

                case 'P':
                    return ClipCheck(Moves.GetWhitePawnMoves(rank, file, chessboard.AllPieces, chessboard.AllBlack, chessboard.Enpassant), selected);

                default:
                    return 0;
            }
        }
    }
}
