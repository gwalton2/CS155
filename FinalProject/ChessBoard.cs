using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class ChessBoard
    {
        public static ulong WhitePawns
        {
            get; set;
        }
        public static ulong WhiteKnights
        {
            get; set;
        }
        public static ulong WhiteBishops
        {
            get; set;
        }
        public static ulong WhiteRooks
        {
            get; set;
        }
        public static ulong WhiteKing
        {
            get; set;
        }
        public static ulong WhiteQueen
        {
            get; set;
        }

        public static ulong BlackPawns
        {
            get; set;
        }
        public static ulong BlackKnights
        {
            get; set;
        }
        public static ulong BlackBishops
        {
            get; set;
        }
        public static ulong BlackRooks
        {
            get; set;
        }
        public static ulong BlackKing
        {
            get; set;
        }
        public static ulong BlackQueen
        {
            get; set;
        }

        public static ulong AllWhite
        {
            get; set;
        }
        public static ulong AllBlack
        {
            get; set;
        }
        public static ulong AllPieces
        {
            get; set;
        }

        public static void Initialize()
        {
            WhitePawns = 0xFF00;
            WhiteKnights = 0x42;
            WhiteBishops = 0x24;
            WhiteRooks = 0x81;
            WhiteQueen = 0x10;
            WhiteKing = 0x8;

            BlackPawns = 0xFF000000000000;
            BlackKnights = 0x4200000000000000;
            BlackBishops = 0x2400000000000000;
            BlackRooks = 0x8100000000000000;
            BlackQueen = 0x1000000000000000;
            BlackKing = 0x800000000000000;

            Update();
        }

        public static void Update()
        {
            AllWhite = WhitePawns | WhiteKnights | WhiteBishops | WhiteRooks | WhiteQueen | WhiteKing;
            AllBlack = BlackPawns | BlackKnights | BlackBishops | BlackRooks | BlackQueen | BlackKing;
            AllPieces = AllWhite | AllBlack;
        }

        public static List<ulong> BoardList()
        {
            return new List<ulong>() { WhitePawns, WhiteKnights, WhiteBishops, WhiteRooks, WhiteKing, WhiteQueen,
                                       BlackPawns, BlackKnights, BlackBishops, BlackRooks, BlackKing, BlackQueen };
        }

        public static void MakeMove(List<ulong> boardList)
        {
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
    }
}
