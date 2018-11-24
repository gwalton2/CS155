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
        Game game;

        Dictionary<int, Button> buttons;
        Dictionary<char, string> piece_icons = new Dictionary<char, string>()
        {
            {'b', "b_bishop"}, {'k', "b_king"}, {'n', "b_knight"}, {'p', "b_pawn"}, {'q', "b_queen"}, {'r', "b_rook"},
            {'B', "w_bishop"}, {'K', "w_king"}, {'N', "w_knight"}, {'P', "w_pawn"}, {'Q', "w_queen"}, {'R', "w_rook"}, {'-', null}
        };

        public MainWindow()
        {
            InitializeComponent();

            game = new Game();
    
            board = new Board(game);

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

            ChangeTurn();
        }

        private void ChangeTurn()
        {
            if (game.Turn == Game.PieceColor.Black)
            {
                colorLabel.Content = "White";
                colorLabel.Foreground = Brushes.Black;
                colorLabel.Background = Brushes.White;
            }
            else
            {
                colorLabel.Content = "Black";
                colorLabel.Foreground = Brushes.White;
                colorLabel.Background = Brushes.Black;
            }
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
                    char piece = board.MyBoard[rank, file];
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
            else
            {
                ResetColor();
            }
        }

        private void _01_Click(object sender, RoutedEventArgs e)
        {
            if (_01.Background.Equals(Brushes.Green))
            {
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
            else
            {
                ResetColor();
            }
        }

        private void _02_Click(object sender, RoutedEventArgs e)
        {
            if (_02.Background.Equals(Brushes.Green))
            {
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
            else
            {
                ResetColor();
            }
        }

        private void _03_Click(object sender, RoutedEventArgs e)
        {
            if (_03.Background.Equals(Brushes.Green))
            {
                Move(_03);
                board.MoveCharBoard(selected_index, 3);
                board.MoveBitBoard(selected_index, 3);
            }
            else if (board.IsOccupied(0, 3))
            {
                selected = _03;
                selected_index = 3;

                ulong moves = board.GetMoves(0, 3);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _04_Click(object sender, RoutedEventArgs e)
        {
            if (_04.Background.Equals(Brushes.Green))
            {
                Move(_04);
                board.MoveCharBoard(selected_index, 4);
                board.MoveBitBoard(selected_index, 4);
            }
            else if (board.IsOccupied(0, 4))
            {
                selected = _04;
                selected_index = 4;

                ulong moves = board.GetMoves(0, 4);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _05_Click(object sender, RoutedEventArgs e)
        {
            if (_05.Background.Equals(Brushes.Green))
            {
                Move(_05);
                board.MoveCharBoard(selected_index, 5);
                board.MoveBitBoard(selected_index, 5);
            }
            else if (board.IsOccupied(0, 5))
            {
                selected = _05;
                selected_index = 5;

                ulong moves = board.GetMoves(0, 5);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _06_Click(object sender, RoutedEventArgs e)
        {
            if (_06.Background.Equals(Brushes.Green))
            {
                Move(_06);
                board.MoveCharBoard(selected_index, 6);
                board.MoveBitBoard(selected_index, 6);
            }
            else if (board.IsOccupied(0, 6))
            {
                selected = _06;
                selected_index = 6;

                ulong moves = board.GetMoves(0, 6);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _07_Click(object sender, RoutedEventArgs e)
        {
            if (_07.Background.Equals(Brushes.Green))
            {
                Move(_07);
                board.MoveCharBoard(selected_index, 7);
                board.MoveBitBoard(selected_index, 7);
            }
            else if (board.IsOccupied(0, 7))
            {
                selected = _07;
                selected_index = 7;

                ulong moves = board.GetMoves(0, 7);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _10_Click(object sender, RoutedEventArgs e)
        {
            if (_10.Background.Equals(Brushes.Green))
            {
                Move(_10);
                board.MoveCharBoard(selected_index, 8);
                board.MoveBitBoard(selected_index, 8);
            }
            else if (board.IsOccupied(1, 0))
            {
                selected = _10;
                selected_index = 8;

                ulong moves = board.GetMoves(1, 0);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _11_Click(object sender, RoutedEventArgs e)
        {
            if (_11.Background.Equals(Brushes.Green))
            {
                Move(_11);
                board.MoveCharBoard(selected_index, 9);
                board.MoveBitBoard(selected_index, 9);
            }
            else if (board.IsOccupied(1, 1))
            {
                selected = _11;
                selected_index = 9;

                ulong moves = board.GetMoves(1, 1);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _12_Click(object sender, RoutedEventArgs e)
        {
            if (_12.Background.Equals(Brushes.Green))
            {
                Move(_12);
                board.MoveCharBoard(selected_index, 10);
                board.MoveBitBoard(selected_index, 10);
            }
            else if (board.IsOccupied(1, 2))
            {
                selected = _12;
                selected_index = 10;

                ulong moves = board.GetMoves(1, 2);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _13_Click(object sender, RoutedEventArgs e)
        {
            if (_13.Background.Equals(Brushes.Green))
            {
                Move(_13);
                board.MoveCharBoard(selected_index, 11);
                board.MoveBitBoard(selected_index, 11);
            }
            else if (board.IsOccupied(1, 3))
            {
                selected = _13;
                selected_index = 11;

                ulong moves = board.GetMoves(1, 3);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _14_Click(object sender, RoutedEventArgs e)
        {
            if (_14.Background.Equals(Brushes.Green))
            {
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
            else
            {
                ResetColor();
            }
        }

        private void _15_Click(object sender, RoutedEventArgs e)
        {
            if (_15.Background.Equals(Brushes.Green))
            {
                Move(_15);
                board.MoveCharBoard(selected_index, 13);
                board.MoveBitBoard(selected_index, 13);
            }
            else if (board.IsOccupied(1, 5))
            {
                selected = _15;
                selected_index = 13;

                ulong moves = board.GetMoves(1, 5);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _16_Click(object sender, RoutedEventArgs e)
        {
            if (_16.Background.Equals(Brushes.Green))
            {
                Move(_16);
                board.MoveCharBoard(selected_index, 14);
                board.MoveBitBoard(selected_index, 14);
            }
            else if (board.IsOccupied(1, 6))
            {
                selected = _16;
                selected_index = 14;

                ulong moves = board.GetMoves(1, 6);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _17_Click(object sender, RoutedEventArgs e)
        {
            if (_17.Background.Equals(Brushes.Green))
            {
                Move(_17);
                board.MoveCharBoard(selected_index, 15);
                board.MoveBitBoard(selected_index, 15);
            }
            else if (board.IsOccupied(1, 7))
            {
                selected = _17;
                selected_index = 15;

                ulong moves = board.GetMoves(1, 7);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _20_Click(object sender, RoutedEventArgs e)
        {
            if (_20.Background.Equals(Brushes.Green))
            {
                Move(_20);
                board.MoveCharBoard(selected_index, 16);
                board.MoveBitBoard(selected_index, 16);
            }
            else if (board.IsOccupied(2, 0))
            {
                selected = _20;
                selected_index = 16;

                ulong moves = board.GetMoves(2, 0);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _21_Click(object sender, RoutedEventArgs e)
        {
            if (_21.Background.Equals(Brushes.Green))
            {
                Move(_21);
                board.MoveCharBoard(selected_index, 17);
                board.MoveBitBoard(selected_index, 17);
            }
            else if (board.IsOccupied(2, 1))
            {
                selected = _21;
                selected_index = 17;

                ulong moves = board.GetMoves(2, 1);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _22_Click(object sender, RoutedEventArgs e)
        {
            if (_22.Background.Equals(Brushes.Green))
            {
                Move(_22);
                board.MoveCharBoard(selected_index, 18);
                board.MoveBitBoard(selected_index, 18);
            }
            else if (board.IsOccupied(2, 2))
            {
                selected = _22;
                selected_index = 18;

                ulong moves = board.GetMoves(2, 2);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _23_Click(object sender, RoutedEventArgs e)
        {
            if (_23.Background.Equals(Brushes.Green))
            {
                Move(_23);
                board.MoveCharBoard(selected_index, 19);
                board.MoveBitBoard(selected_index, 19);
            }
            else if (board.IsOccupied(2, 3))
            {
                selected = _23;
                selected_index = 19;

                ulong moves = board.GetMoves(2, 3);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _24_Click(object sender, RoutedEventArgs e)
        {
            if (_24.Background.Equals(Brushes.Green))
            {
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
            else
            {
                ResetColor();
            }
        }

        private void _25_Click(object sender, RoutedEventArgs e)
        {
            if (_25.Background.Equals(Brushes.Green))
            {
                Move(_25);
                board.MoveCharBoard(selected_index, 21);
                board.MoveBitBoard(selected_index, 21);
            }
            else if (board.IsOccupied(2, 5))
            {
                selected = _25;
                selected_index = 21;

                ulong moves = board.GetMoves(2, 5);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _26_Click(object sender, RoutedEventArgs e)
        {
            if (_26.Background.Equals(Brushes.Green))
            {
                Move(_26);
                board.MoveCharBoard(selected_index, 22);
                board.MoveBitBoard(selected_index, 22);
            }
            else if (board.IsOccupied(2, 6))
            {
                selected = _26;
                selected_index = 22;

                ulong moves = board.GetMoves(2, 6);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _27_Click(object sender, RoutedEventArgs e)
        {
            if (_27.Background.Equals(Brushes.Green))
            {
                Move(_27);
                board.MoveCharBoard(selected_index, 23);
                board.MoveBitBoard(selected_index, 23);
            }
            else if (board.IsOccupied(2, 7))
            {
                selected = _27;
                selected_index = 23;

                ulong moves = board.GetMoves(2, 7);
                DisplayMoves(moves);
            }
            else
            {
                ResetColor();
            }
        }

        private void _30_Click(object sender, RoutedEventArgs e)
        {
            if (_30.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_30);
                board.MoveCharBoard(selected_index, 24);
                board.MoveBitBoard(selected_index, 24);
            }
            else if (board.IsOccupied(3, 0))
            {
                selected = _30;
                selected_index = 24;

                ulong moves = board.GetMoves(3, 0);
                DisplayMoves(moves);
            }
        }

        private void _31_Click(object sender, RoutedEventArgs e)
        {
            if (_31.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_31);
                board.MoveCharBoard(selected_index, 25);
                board.MoveBitBoard(selected_index, 25);
            }
            else if (board.IsOccupied(3, 1))
            {
                selected = _31;
                selected_index = 25;

                ulong moves = board.GetMoves(3, 1);
                DisplayMoves(moves);
            }
        }

        private void _32_Click(object sender, RoutedEventArgs e)
        {
            if (_32.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_32);
                board.MoveCharBoard(selected_index, 26);
                board.MoveBitBoard(selected_index, 26);
            }
            else if (board.IsOccupied(3, 2))
            {
                selected = _32;
                selected_index = 26;

                ulong moves = board.GetMoves(3, 2);
                DisplayMoves(moves);
            }
        }

        private void _33_Click(object sender, RoutedEventArgs e)
        {
            if (_33.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_33);
                board.MoveCharBoard(selected_index, 27);
                board.MoveBitBoard(selected_index, 27);
            }
            else if (board.IsOccupied(3, 3))
            {
                selected = _33;
                selected_index = 27;

                ulong moves = board.GetMoves(3, 3);
                DisplayMoves(moves);
            }
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
            if (_35.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_35);
                board.MoveCharBoard(selected_index, 29);
                board.MoveBitBoard(selected_index, 29);
            }
            else if (board.IsOccupied(3, 5))
            {
                selected = _35;
                selected_index = 29;

                ulong moves = board.GetMoves(3, 5);
                DisplayMoves(moves);
            }
        }

        private void _36_Click(object sender, RoutedEventArgs e)
        {
            if (_36.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_36);
                board.MoveCharBoard(selected_index, 30);
                board.MoveBitBoard(selected_index, 30);
            }
            else if (board.IsOccupied(3, 6))
            {
                selected = _36;
                selected_index = 30;

                ulong moves = board.GetMoves(3, 6);
                DisplayMoves(moves);
            }
        }

        private void _37_Click(object sender, RoutedEventArgs e)
        {
            if (_37.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_37);
                board.MoveCharBoard(selected_index, 31);
                board.MoveBitBoard(selected_index, 31);
            }
            else if (board.IsOccupied(3, 7))
            {
                selected = _37;
                selected_index = 31;

                ulong moves = board.GetMoves(3, 7);
                DisplayMoves(moves);
            }
        }

        private void _40_Click(object sender, RoutedEventArgs e)
        {
            if (_40.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_40);
                board.MoveCharBoard(selected_index, 32);
                board.MoveBitBoard(selected_index, 32);
            }
            else if (board.IsOccupied(4, 0))
            {
                selected = _40;
                selected_index = 32;

                ulong moves = board.GetMoves(4, 0);
                DisplayMoves(moves);
            }
        }

        private void _41_Click(object sender, RoutedEventArgs e)
        {
            if (_41.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_41);
                board.MoveCharBoard(selected_index, 33);
                board.MoveBitBoard(selected_index, 33);
            }
            else if (board.IsOccupied(4, 1))
            {
                selected = _41;
                selected_index = 33;

                ulong moves = board.GetMoves(4, 1);
                DisplayMoves(moves);
            }
        }

        private void _42_Click(object sender, RoutedEventArgs e)
        {
            if (_42.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_42);
                board.MoveCharBoard(selected_index, 34);
                board.MoveBitBoard(selected_index, 34);
            }
            else if (board.IsOccupied(4, 2))
            {
                selected = _42;
                selected_index = 34;

                ulong moves = board.GetMoves(4, 2);
                DisplayMoves(moves);
            }
        }

        private void _43_Click(object sender, RoutedEventArgs e)
        {
            if (_43.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_43);
                board.MoveCharBoard(selected_index, 35);
                board.MoveBitBoard(selected_index, 35);
            }
            else if (board.IsOccupied(4, 3))
            {
                selected = _43;
                selected_index = 35;

                ulong moves = board.GetMoves(4, 3);
                DisplayMoves(moves);
            }
        }

        private void _44_Click(object sender, RoutedEventArgs e)
        {
            if (_44.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_44);
                board.MoveCharBoard(selected_index, 36);
                board.MoveBitBoard(selected_index, 36);
            }
            else if (board.IsOccupied(4, 4))
            {
                selected = _44;
                selected_index = 36;

                ulong moves = board.GetMoves(4, 4);
                DisplayMoves(moves);
            }
        }

        private void _45_Click(object sender, RoutedEventArgs e)
        {
            if (_45.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_45);
                board.MoveCharBoard(selected_index, 37);
                board.MoveBitBoard(selected_index, 37);
            }
            else if (board.IsOccupied(4, 5))
            {
                selected = _45;
                selected_index = 37;

                ulong moves = board.GetMoves(4, 5);
                DisplayMoves(moves);
            }
        }

        private void _46_Click(object sender, RoutedEventArgs e)
        {
            if (_46.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_46);
                board.MoveCharBoard(selected_index, 38);
                board.MoveBitBoard(selected_index, 38);
            }
            else if (board.IsOccupied(4, 6))
            {
                selected = _46;
                selected_index = 38;

                ulong moves = board.GetMoves(4, 6);
                DisplayMoves(moves);
            }
        }

        private void _47_Click(object sender, RoutedEventArgs e)
        {
            if (_47.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_47);
                board.MoveCharBoard(selected_index, 39);
                board.MoveBitBoard(selected_index, 39);
            }
            else if (board.IsOccupied(4, 7))
            {
                selected = _47;
                selected_index = 39;

                ulong moves = board.GetMoves(4, 7);
                DisplayMoves(moves);
            }
        }

        private void _50_Click(object sender, RoutedEventArgs e)
        {
            if (_50.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_50);
                board.MoveCharBoard(selected_index, 40);
                board.MoveBitBoard(selected_index, 40);
            }
            else if (board.IsOccupied(5, 0))
            {
                selected = _50;
                selected_index = 40;

                ulong moves = board.GetMoves(5, 0);
                DisplayMoves(moves);
            }
        }

        private void _51_Click(object sender, RoutedEventArgs e)
        {
            if (_51.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_51);
                board.MoveCharBoard(selected_index, 41);
                board.MoveBitBoard(selected_index, 41);
            }
            else if (board.IsOccupied(5, 1))
            {
                selected = _51;
                selected_index = 41;

                ulong moves = board.GetMoves(5, 1);
                DisplayMoves(moves);
            }
        }

        private void _52_Click(object sender, RoutedEventArgs e)
        {
            if (_52.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_52);
                board.MoveCharBoard(selected_index, 42);
                board.MoveBitBoard(selected_index, 42);
            }
            else if (board.IsOccupied(5, 2))
            {
                selected = _52;
                selected_index = 42;

                ulong moves = board.GetMoves(5, 2);
                DisplayMoves(moves);
            }
        }

        private void _53_Click(object sender, RoutedEventArgs e)
        {
            if (_53.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_53);
                board.MoveCharBoard(selected_index, 43);
                board.MoveBitBoard(selected_index, 43);
            }
            else if (board.IsOccupied(5, 3))
            {
                selected = _53;
                selected_index = 43;

                ulong moves = board.GetMoves(5, 3);
                DisplayMoves(moves);
            }
        }

        private void _54_Click(object sender, RoutedEventArgs e)
        {
            if (_54.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_54);
                board.MoveCharBoard(selected_index, 44);
                board.MoveBitBoard(selected_index, 44);
            }
            else if (board.IsOccupied(5, 4))
            {
                selected = _54;
                selected_index = 44;

                ulong moves = board.GetMoves(5, 4);
                DisplayMoves(moves);
            }
        }

        private void _55_Click(object sender, RoutedEventArgs e)
        {
            if (_55.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_55);
                board.MoveCharBoard(selected_index, 45);
                board.MoveBitBoard(selected_index, 45);
            }
            else if (board.IsOccupied(5, 5))
            {
                selected = _55;
                selected_index = 45;

                ulong moves = board.GetMoves(5, 5);
                DisplayMoves(moves);
            }
        }

        private void _56_Click(object sender, RoutedEventArgs e)
        {
            if (_56.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_56);
                board.MoveCharBoard(selected_index, 46);
                board.MoveBitBoard(selected_index, 46);
            }
            else if (board.IsOccupied(5, 6))
            {
                selected = _56;
                selected_index = 46;

                ulong moves = board.GetMoves(5, 6);
                DisplayMoves(moves);
            }
        }

        private void _57_Click(object sender, RoutedEventArgs e)
        {
            if (_57.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_57);
                board.MoveCharBoard(selected_index, 47);
                board.MoveBitBoard(selected_index, 47);
            }
            else if (board.IsOccupied(5, 7))
            {
                selected = _57;
                selected_index = 47;

                ulong moves = board.GetMoves(5, 7);
                DisplayMoves(moves);
            }
        }

        private void _60_Click(object sender, RoutedEventArgs e)
        {
            if (_60.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_60);
                board.MoveCharBoard(selected_index, 48);
                board.MoveBitBoard(selected_index, 48);
            }
            else if (board.IsOccupied(6, 0))
            {
                selected = _60;
                selected_index = 48;

                ulong moves = board.GetMoves(6, 0);
                DisplayMoves(moves);
            }
        }

        private void _61_Click(object sender, RoutedEventArgs e)
        {
            if (_61.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_61);
                board.MoveCharBoard(selected_index, 49);
                board.MoveBitBoard(selected_index, 49);
            }
            else if (board.IsOccupied(6, 1))
            {
                selected = _61;
                selected_index = 49;

                ulong moves = board.GetMoves(6, 1);
                DisplayMoves(moves);
            }
        }

        private void _62_Click(object sender, RoutedEventArgs e)
        {
            if (_62.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_62);
                board.MoveCharBoard(selected_index, 50);
                board.MoveBitBoard(selected_index, 50);
            }
            else if (board.IsOccupied(6, 2))
            {
                selected = _62;
                selected_index = 50;

                ulong moves = board.GetMoves(6, 2);
                DisplayMoves(moves);
            }
        }

        private void _63_Click(object sender, RoutedEventArgs e)
        {
            if (_63.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_63);
                board.MoveCharBoard(selected_index, 51);
                board.MoveBitBoard(selected_index, 51);
            }
            else if (board.IsOccupied(6, 3))
            {
                selected = _63;
                selected_index = 51;

                ulong moves = board.GetMoves(6, 3);
                DisplayMoves(moves);
            }
        }

        private void _64_Click(object sender, RoutedEventArgs e)
        {
            if (_64.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_64);
                board.MoveCharBoard(selected_index, 52);
                board.MoveBitBoard(selected_index, 52);
            }
            else if (board.IsOccupied(6, 4))
            {
                selected = _64;
                selected_index = 52;

                ulong moves = board.GetMoves(6, 4);
                DisplayMoves(moves);
            }
        }

        private void _65_Click(object sender, RoutedEventArgs e)
        {
            if (_65.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_65);
                board.MoveCharBoard(selected_index, 53);
                board.MoveBitBoard(selected_index, 53);
            }
            else if (board.IsOccupied(6, 5))
            {
                selected = _65;
                selected_index = 53;

                ulong moves = board.GetMoves(6, 5);
                DisplayMoves(moves);
            }
        }

        private void _66_Click(object sender, RoutedEventArgs e)
        {
            if (_66.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_66);
                board.MoveCharBoard(selected_index, 54);
                board.MoveBitBoard(selected_index, 54);
            }
            else if (board.IsOccupied(6, 6))
            {
                selected = _66;
                selected_index = 54;

                ulong moves = board.GetMoves(6, 6);
                DisplayMoves(moves);
            }
        }

        private void _67_Click(object sender, RoutedEventArgs e)
        {
            if (_67.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_67);
                board.MoveCharBoard(selected_index, 55);
                board.MoveBitBoard(selected_index, 55);
            }
            else if (board.IsOccupied(6, 7))
            {
                selected = _67;
                selected_index = 55;

                ulong moves = board.GetMoves(6, 7);
                DisplayMoves(moves);
            }
        }

        private void _70_Click(object sender, RoutedEventArgs e)
        {
            if (_70.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_70);
                board.MoveCharBoard(selected_index, 56);
                board.MoveBitBoard(selected_index, 56);
            }
            else if (board.IsOccupied(7, 0))
            {
                selected = _70;
                selected_index = 56;

                ulong moves = board.GetMoves(7, 0);
                DisplayMoves(moves);
            }
        }

        private void _71_Click(object sender, RoutedEventArgs e)
        {
            if (_71.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_71);
                board.MoveCharBoard(selected_index, 57);
                board.MoveBitBoard(selected_index, 57);
            }
            else if (board.IsOccupied(7, 1))
            {
                selected = _71;
                selected_index = 57;

                ulong moves = board.GetMoves(7, 1);
                DisplayMoves(moves);
            }
        }

        private void _72_Click(object sender, RoutedEventArgs e)
        {
            if (_72.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_72);
                board.MoveCharBoard(selected_index, 58);
                board.MoveBitBoard(selected_index, 58);
            }
            else if (board.IsOccupied(7, 2))
            {
                selected = _72;
                selected_index = 58;

                ulong moves = board.GetMoves(7, 2);
                DisplayMoves(moves);
            }
        }

        private void _73_Click(object sender, RoutedEventArgs e)
        {
            if (_73.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_73);
                board.MoveCharBoard(selected_index, 59);
                board.MoveBitBoard(selected_index, 59);
            }
            else if (board.IsOccupied(7, 3))
            {
                selected = _73;
                selected_index = 59;

                ulong moves = board.GetMoves(7, 3);
                DisplayMoves(moves);
            }
        }

        private void _74_Click(object sender, RoutedEventArgs e)
        {
            if (_74.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_74);
                board.MoveCharBoard(selected_index, 60);
                board.MoveBitBoard(selected_index, 60);
            }
            else if (board.IsOccupied(7, 4))
            {
                selected = _74;
                selected_index = 60;

                ulong moves = board.GetMoves(7, 4);
                DisplayMoves(moves);
            }
        }

        private void _75_Click(object sender, RoutedEventArgs e)
        {
            if (_75.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_75);
                board.MoveCharBoard(selected_index, 61);
                board.MoveBitBoard(selected_index, 61);
            }
            else if (board.IsOccupied(7, 5))
            {
                selected = _75;
                selected_index = 61;

                ulong moves = board.GetMoves(7, 5);
                DisplayMoves(moves);
            }
        }

        private void _76_Click(object sender, RoutedEventArgs e)
        {
            if (_76.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_76);
                board.MoveCharBoard(selected_index, 62);
                board.MoveBitBoard(selected_index, 62);
            }
            else if (board.IsOccupied(7, 6))
            {
                selected = _76;
                selected_index = 62;

                ulong moves = board.GetMoves(7, 6);
                DisplayMoves(moves);
            }
        }

        private void _77_Click(object sender, RoutedEventArgs e)
        {
            if (_77.Background.Equals(Brushes.Green))
            {
                ResetColor();
                Move(_77);
                board.MoveCharBoard(selected_index, 63);
                board.MoveBitBoard(selected_index, 63);
            }
            else if (board.IsOccupied(7, 7))
            {
                selected = _77;
                selected_index = 63;

                ulong moves = board.GetMoves(7, 7);
                DisplayMoves(moves);
            }
        }
    }
}
