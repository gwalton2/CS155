using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Game
    {
        public enum PieceColor { White, Black };

        public PieceColor Turn
        {
            get; set;
        }

        public Game()
        {
            Turn = PieceColor.White;
        }

        public void NextTurn()
        {
            if (Turn == PieceColor.White)
            {
                Turn = PieceColor.Black;
            }
            else
            {
                Turn = PieceColor.White;
            }
        }
    }
}
