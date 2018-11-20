using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Board board;
        Button selected;
        int selected_index;

        Dictionary<int, Button> buttons;
        Dictionary<char, string> piece_icons = new Dictionary<char, string>()
        {
            {'b', "b_bishop"}, {'k', "b_king"}, {'n', "b_knight"}, {'p', "b_pawn"}, {'q', "b_queen"}, {'r', "b_rook"},
            {'B', "w_bishop"}, {'K', "w_king"}, {'N', "w_knight"}, {'P', "w_pawn"}, {'Q', "w_queen"}, {'R', "w_rook"}, {'-', null}
        };

        public MainWindow()
        {
            InitializeComponent();
    
            board = new Board();

            buttons = new Dictionary<int, Button>
            {
                {0, _00}, {1, _01}, {2, _02}, {3, _03}, {4, _04}, {5, _05}, {6, _06}, {7, _07},
                {8, _10}, {9, _11}, {10, _12}, {11, _13}, {12, _14}, {13, _15}, {14, _16}, {15, _17},
                {16, _20}, {17, _21}, {18, _22}, {19, _23}, {20, _24}, {21, _25}, {22, _26}, {23, _27},
                {24, _30}, {25, _31}, {26, _32}, {27, _33}, {28, _34}, {29, _35}, {30, _36}, {31, _37},
                {32, _40}, {33, _41}, {34, _42}, {35, _43}, {36, _44}, {37, _45}, {38, _46}, {39, _47},
                {40, _50}, {41, _51}, {42, _52}, {43, _53}, {44, _54}, {45, _55}, {46, _56}, {47, _57},
                {48, _60}, {49, _61}, {50, _62}, {51, _63}, {52, _64}, {53, _65}, {54, _66}, {55, _67},
                {56, _70}, {57, _71}, {58, _72}, {59, _73}, {60, _74}, {61, _75}, {62, _76}, {63, _77}
            };

            CopyBoard();
        }

        private List<int> ConvertBitboard(ulong bitboard)
        {
            List<int> move_indexes = new List<int>();

            int counter = 0;
            while (bitboard > 0)
            {
                ulong square = bitboard & 1;
                if (square == 1)
                {
                    move_indexes.Add(counter);
                }
                counter++;
                bitboard >>= 1;
            }
            return move_indexes;
        }

        private void Move(Button new_square)
        {
            new_square.Content = selected.Content;
            selected.Content = null;
        }

        private void ResetColor()
        {
            foreach (int i in buttons.Keys)
            {
                int rank = i / 8;
                int file = i % 8;

                if ((rank + file) % 2 == 0)
                {
                    buttons[i].Background = Brushes.Black;
                }
                else
                {
                    buttons[i].Background = Brushes.White;
                }
            }
        }

        private void DisplayMoves(ulong moves)
        {
            List<int> valid_moves = ConvertBitboard(moves);

            foreach (int i in valid_moves)
            {
                buttons[i].Background = Brushes.Green;
            }
        }

        private void CopyBoard()
        {
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    int index = rank * 8 + file;
                    char piece = board.ChessBoard[rank, file];
                    string icon = piece_icons[piece];
                    if (icon != null)
                    {
                        buttons[index].Content = FindResource(piece_icons[piece]);
                    } 
                }
            }
        }

        private void _00_Click(object sender, RoutedEventArgs e)
        {
            if (_00.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_00);
                board.MoveCharBoard(selected_index, 0);
                board.MoveBitBoard(selected_index, 0);
            }
            else if (board.IsOccupied(0, 0))
            {
                selected = _00;
                selected_index = 0;

                ulong moves = board.GetMoves(0, 0);
                DisplayMoves(moves);
            }
        }

        private void _01_Click(object sender, RoutedEventArgs e)
        {
            if (_01.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_01);
                board.MoveCharBoard(selected_index, 1);
                board.MoveBitBoard(selected_index, 1);
            }
            else if (board.IsOccupied(0, 1))
            {
                selected = _01;
                selected_index = 1;

                ulong moves = board.GetMoves(0, 1);
                DisplayMoves(moves);
            }

        }

        private void _02_Click(object sender, RoutedEventArgs e)
        {
            if (_02.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_02);
                board.MoveCharBoard(selected_index, 2);
                board.MoveBitBoard(selected_index, 2);
            }
            else if (board.IsOccupied(0, 2))
            {
                selected = _02;
                selected_index = 2;

                ulong moves = board.GetMoves(0, 2);
                DisplayMoves(moves);
            }
        }

        private void _03_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _04_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _05_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _06_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _07_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _14_Click(object sender, RoutedEventArgs e)
        {
            if (_14.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_14);
                board.MoveCharBoard(selected_index, 12);
                board.MoveBitBoard(selected_index, 12);
            }
            else if (board.IsOccupied(1, 4))
            {
                selected = _14;
                selected_index = 12;

                ulong moves = board.GetMoves(1, 4);
                DisplayMoves(moves);
            }
        }

        private void _15_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _16_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _17_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _20_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _21_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _22_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _23_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _24_Click(object sender, RoutedEventArgs e)
        {
            if (_24.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_24);
                board.MoveCharBoard(selected_index, 20);
                board.MoveBitBoard(selected_index, 20);
            }
            else if (board.IsOccupied(2, 4))
            {
                selected = _24;
                selected_index = 20;

                ulong moves = board.GetMoves(2, 4);
                DisplayMoves(moves);
            }
        }

        private void _25_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _26_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _27_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _30_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _31_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _32_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _33_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _34_Click(object sender, RoutedEventArgs e)
        {
            if (_34.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_34);
                board.MoveCharBoard(selected_index, 28);
                board.MoveBitBoard(selected_index, 28);
            }
            else if (board.IsOccupied(3, 4))
            {
                selected = _34;
                selected_index = 28;

                ulong moves = board.GetMoves(3, 4);
                DisplayMoves(moves);
            }
        }

        private void _35_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _36_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _37_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _40_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _41_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _42_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _43_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _44_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _45_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _46_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _47_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _50_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _51_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _52_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _53_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _54_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _55_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _56_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _57_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _60_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _61_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _62_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _63_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _64_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _65_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _66_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _67_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _70_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _71_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _72_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _73_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _74_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _75_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _76_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _77_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
