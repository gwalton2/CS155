/// Homework No.10 Exercise No.1
/// File Name: Homework10.cs
/// @author: Grant Walton
/// Date: Nov. 19, 2018
/// Problem Statement: This program should test the new classes I created that inherited from Alien. All of these classes should include
/// a GetDamage method as well as properties for their instance variables. This program should also test the refactored CalculateDamage method in AlienPack.
/// Overall Plan:
/// 1. I will create three new classes, one for each type of alien. All of these classes will inherit from Alien.
/// 2. All of these new classes will override the GetDamage method from Alien to allow AlienPack to be able to use their unique damages.
/// 3. CalculateDamage in AlienPack will now simply loop through all its aliens and up their GetDamage returns.
/// 4. The driver program will test this by creating a few aliens of each type and adding them to AlienPack. It will test to make sure the properties work
/// for the Alien classes and finally that the new CalculateDamage method works.

/// Classes needed and Purpose: Alien, SnakeAlien, OgreAlien, and MarshmallowAlien are needed to represent all the types of aliens.
/// AlienPack is needed as a way to group aliens together and calculate their total damage. Finally, the main class is needed to test all the other classes.
/// main class - Homework10
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class Homework10
    {
        static void Main(string[] args)
        {
            Alien snake1 = new SnakeAlien(100, "snake1");
            Alien ogre = new OgreAlien(100, "ogre");
            Alien marsh = new MarshmallowAlien(100, "marsh");
            SnakeAlien snake2 = new SnakeAlien(50, "snake2");
            Alien alien = new Alien(75, "alien");

            AlienPack aliens = new AlienPack(5);
            aliens.AddAlien(snake1, 0);
            aliens.AddAlien(snake2, 1);
            aliens.AddAlien(ogre, 2);
            aliens.AddAlien(marsh, 3);
            aliens.AddAlien(alien, 4);

            snake2.Name = "Bob";
            snake2.Health += 50;

            Console.WriteLine("Snake2: {0}, {1}", snake2.Name, snake2.Health);
            Console.WriteLine();
            Console.WriteLine(aliens.CalculateDamage());
            Console.ReadLine();
        }
    }
}
