using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Homework8
    {
        const int ROUNDS = 10000;

        static Duelist aaron = new Duelist("Aaron", 1 / (double)3);
        static Duelist bob = new Duelist("Bob", .5);
        static Duelist charlie = new Duelist("Charlie", .995);

        static void Main(string[] args)
        {
            int a_count = 0;
            int b_count = 0;
            int c_count = 0;

            for (int i = 0; i < ROUNDS; i++)
            {
                Duelist winner = SimulateDuel();

                if (winner.Equals(aaron))
                {
                    a_count++;
                }
                else if (winner.Equals(bob))
                {
                    b_count++;
                }
                else if (winner.Equals(charlie))
                {
                    c_count++;
                }
            }

            double a_percent = a_count / (double)ROUNDS;
            double b_percent = b_count / (double)ROUNDS;
            double c_percent = c_count / (double)ROUNDS;

            Console.WriteLine("Aaron won {0}/{1} duels or {2}", a_count, ROUNDS, a_percent.ToString("p"));
            Console.WriteLine("Bob won {0}/{1} duels or {2}", b_count, ROUNDS, b_percent.ToString("p"));
            Console.WriteLine("Charlie won {0}/{1} duels or {2}", c_count, ROUNDS, c_percent.ToString("p"));
            Console.ReadLine();
        }

        private static Duelist SimulateDuel()
        {
            aaron.Alive = true;
            bob.Alive = true;
            charlie.Alive = true;

            do
            {
                SimulateRound();
            } while (DuelWinner() == null);

            return DuelWinner();
        }

        private static void SimulateRound()
        {
            if (true == aaron.Alive)
            {
                if (true == charlie.Alive)
                {
                    aaron.ShootAtTarget(charlie);
                }
                else
                {
                    aaron.ShootAtTarget(bob);
                }
            }

            if (true == bob.Alive)
            {
                if (true == charlie.Alive)
                {
                    bob.ShootAtTarget(charlie);
                }
                else
                {
                    bob.ShootAtTarget(aaron);
                }
            }

            if (true == charlie.Alive)
            {
                if (true == bob.Alive)
                {
                    charlie.ShootAtTarget(bob);
                }
                else
                {
                    charlie.ShootAtTarget(aaron);
                }
            }
        }

        private static Duelist DuelWinner()
        {
            if (false == bob.Alive && false == charlie.Alive)
            {
                return aaron;
            }

            else if (false == aaron.Alive && false == charlie.Alive)
            {
                return bob;
            }

            else if (false == aaron.Alive && false == bob.Alive)
            {
                return charlie;
            }

            else
            {
                return null;
            }
        }
    }
}
