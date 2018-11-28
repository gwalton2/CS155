using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class ChessBoard
    {
        public ulong WhitePawns
        {
            get; set;
        }
        public ulong WhiteKnights
        {
            get; set;
        }
        public ulong WhiteBishops
        {
            get; set;
        }
        public ulong WhiteRooks
        {
            get; set;
        }
        public ulong WhiteKing
        {
            get; set;
        }
        public ulong WhiteQueen
        {
            get; set;
        }

        public ulong BlackPawns
        {
            get; set;
        }
        public ulong BlackKnights
        {
            get; set;
        }
        public ulong BlackBishops
        {
            get; set;
        }
        public ulong BlackRooks
        {
            get; set;
        }
        public ulong BlackKing
        {
            get; set;
        }
        public ulong BlackQueen
        {
            get; set;
        }

        public ulong AllWhite
        {
            get; set;
        }
        public ulong AllBlack
        {
            get; set;
        }
        public ulong AllPieces
        {
            get; set;
        }

        public ChessBoard last;

        public ChessBoard()
        {
            Initialize();
            last = null;
        }

        public ChessBoard(ChessBoard board)
        {
            InternalCopy(board);
        }

        public void Initialize()
        {
            WhitePawns = 0xFF00;
            WhiteKnights = 0x42;
            WhiteBishops = 0x24;
            WhiteRooks = 0x81;
            WhiteQueen = 0x8;
            WhiteKing = 0x10;

            BlackPawns = 0xFF000000000000;
            BlackKnights = 0x4200000000000000;
            BlackBishops = 0x2400000000000000;
            BlackRooks = 0x8100000000000000;
            BlackQueen = 0x800000000000000;
            BlackKing = 0x1000000000000000;

            Update();
        }

        public void Update()
        {
            AllWhite = WhitePawns | WhiteKnights | WhiteBishops | WhiteRooks | WhiteQueen | WhiteKing;
            AllBlack = BlackPawns | BlackKnights | BlackBishops | BlackRooks | BlackQueen | BlackKing;
            AllPieces = AllWhite | AllBlack;
        }

        public List<ulong> BoardList()
        {
            return new List<ulong>() { WhitePawns, WhiteKnights, WhiteBishops, WhiteRooks, WhiteKing, WhiteQueen,
                                       BlackPawns, BlackKnights, BlackBishops, BlackRooks, BlackKing, BlackQueen };
        }

        public void MakeMove(List<ulong> boardList)
        {
            last = new ChessBoard(this);

            WhitePawns = boardList[0];
            WhiteKnights = boardList[1];
            WhiteBishops = boardList[2];
            WhiteRooks = boardList[3];
            WhiteKing = boardList[4];
            WhiteQueen = boardList[5];

            BlackPawns = boardList[6];
            BlackKnights = boardList[7];
            BlackBishops = boardList[8];
            BlackRooks = boardList[9];
            BlackKing = boardList[10];
            BlackQueen = boardList[11];

            Update();
        }

        public void UndoLastMove()
        {
            InternalCopy(last);
        }

        public void InternalCopy(ChessBoard board)
        {
            WhitePawns = board.WhitePawns;
            WhiteKnights = board.WhiteKnights;
            WhiteBishops = board.WhiteBishops;
            WhiteRooks = board.WhiteRooks;
            WhiteQueen = board.WhiteQueen;
            WhiteKing = board.WhiteKing;

            BlackPawns = board.BlackPawns;
            BlackKnights = board.BlackKnights;
            BlackBishops = board.BlackBishops;
            BlackRooks = board.BlackRooks;
            BlackQueen = board.BlackQueen;
            BlackKing = board.BlackKing;

            last = board.last;
            Update();
        }
    }
}
