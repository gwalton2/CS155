/// Homework No.8 Exercise No.1
/// File Name: Homework8.cs
/// @author: Grant Walton
/// Date: Oct. 29, 2018
/// Problem Statement: This program should run simulations of a duel. The duel consists of three
/// fighters who have differing levels of accuracy. Each fighter will be represented by a class
/// named Duelist. The simulations should then display the chance for each fighter for a couple strategies.
/// Overall Plan:
/// 1. I will create the Duelist class which will contain a boolean property called alive,
/// a name, a random number generator, and an accuracy represented as a double between zero and 1.
/// 2. I will also implement get methods for the name and accuracy, a constructor, an equals method,
/// and a ShootAtTarget method that takes in a Duelist and uses the random number generator in tandem
/// with the accuracy to determine if the Duelist is shot and should have its alive property set to false.
/// 3. Then in the Homework8 file, I will create a method to simulate a single round of the duel
/// where each person gets a chance to shoot if they're alive.
/// 4. I will then implement a method to simulate an entire duel that returns the winner of the duel.
/// This method will use the SimulateRound method, as well as the DuelWinner method that simply checks
/// to see who is still alive and returns a winner or null if the game is still going.
/// 4. I will then create a second method to simulate a round that uses an alternate strategy where
/// aaron purposely misses his first shot. This will be simulated simply by having the order of shooting
/// go bob, charlie, and aaron. 
/// 5. I will then create a RunSimulation method that runs a certain number of rounds with one of
/// the two strategies and returns the number of wins for each fighter in an int[].
/// 6. In the main method I will run 10000 simulations for each strategy and print out the statistics
/// for each player in each strategy.
/// 7. I discovered that the new strategy where aaron misses on purpose the first shots drastically
/// increases his chance of winning. In the original strategy the order of likely winners goes
/// bob, aaron charlie. With the new strategy the order is aaron, charlie, bob.

/// Classes needed and Purpose: The Duelist class is needed to represent each fighter. The main
/// class is needed to run the simulations.
/// main class - Homework8
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

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
            int[] counts = RunSimulation(false, ROUNDS);
            int a_count = counts[0];
            int b_count = counts[1];
            int c_count = counts[2];

            double a_percent = a_count / (double)ROUNDS;
            double b_percent = b_count / (double)ROUNDS;
            double c_percent = c_count / (double)ROUNDS;

            Console.WriteLine("DEFAULT STRATEGY:");
            Console.WriteLine("Aaron won {0}/{1} duels or {2}", a_count, ROUNDS, a_percent.ToString("p"));
            Console.WriteLine("Bob won {0}/{1} duels or {2}", b_count, ROUNDS, b_percent.ToString("p"));
            Console.WriteLine("Charlie won {0}/{1} duels or {2}", c_count, ROUNDS, c_percent.ToString("p"));
            Console.WriteLine();

            int[] counts1 = RunSimulation(true, ROUNDS);
            int a_count1 = counts1[0];
            int b_count1 = counts1[1];
            int c_count1 = counts1[2];

            double a_percent1 = a_count1 / (double)ROUNDS;
            double b_percent1 = b_count1 / (double)ROUNDS;
            double c_percent1 = c_count1 / (double)ROUNDS;

            Console.WriteLine("NEW STRATEGY:");
            Console.WriteLine("Aaron won {0}/{1} duels or {2}", a_count1, ROUNDS, a_percent1.ToString("p"));
            Console.WriteLine("Bob won {0}/{1} duels or {2}", b_count1, ROUNDS, b_percent1.ToString("p"));
            Console.WriteLine("Charlie won {0}/{1} duels or {2}", c_count1, ROUNDS, c_percent1.ToString("p"));
            Console.ReadLine();
        }

        private static int[] RunSimulation(bool strategy, int rounds)
        {
            int[] counts = { 0, 0, 0 };

            for (int i = 0; i < rounds; i++)
            {
                Duelist winner = SimulateDuel(strategy);

                if (winner.Equals(aaron))
                {
                    counts[0]++;
                }
                else if (winner.Equals(bob))
                {
                    counts[1]++;
                }
                else if (winner.Equals(charlie))
                {
                    counts[2]++;
                }
            }
            return counts;
        }

        private static Duelist SimulateDuel(bool strategy)
        {
            aaron.Alive = true;
            bob.Alive = true;
            charlie.Alive = true;

            do
            {
                if (strategy)
                {
                    SimulateRoundStrategy();
                }
                else
                {
                    SimulateRound();
                }
                
            } while (DuelWinner() == null);

            return DuelWinner();
        }

        private static void SimulateRound()
        {
            if (aaron.Alive)
            {
                if (charlie.Alive)
                {
                    aaron.ShootAtTarget(charlie);
                }
                else
                {
                    aaron.ShootAtTarget(bob);
                }
            }

            if (bob.Alive)
            {
                if (charlie.Alive)
                {
                    bob.ShootAtTarget(charlie);
                }
                else
                {
                    bob.ShootAtTarget(aaron);
                }
            }

            if (charlie.Alive)
            {
                if (bob.Alive)
                {
                    charlie.ShootAtTarget(bob);
                }
                else
                {
                    charlie.ShootAtTarget(aaron);
                }
            }
        }

        private static void SimulateRoundStrategy()
        {
            if (bob.Alive)
            {
                if (charlie.Alive)
                {
                    bob.ShootAtTarget(charlie);
                }
                else
                {
                    bob.ShootAtTarget(aaron);
                }
            }

            if (charlie.Alive)
            {
                if (bob.Alive)
                {
                    charlie.ShootAtTarget(bob);
                }
                else
                {
                    charlie.ShootAtTarget(aaron);
                }
            }

            if (aaron.Alive)
            {
                if (charlie.Alive)
                {
                    aaron.ShootAtTarget(charlie);
                }
                else
                {
                    aaron.ShootAtTarget(bob);
                }
            }
        }

        private static Duelist DuelWinner()
        {
            if (!bob.Alive && !charlie.Alive)
            {
                return aaron;
            }

            else if (!aaron.Alive && !charlie.Alive)
            {
                return bob;
            }

            else if (!aaron.Alive && !bob.Alive)
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
