/// Homework No.9 Exercise No.1
/// File Name: Homework9.cs
/// @author: Grant Walton
/// Date: Nov. 5, 2018
/// Problem Statement: This program should test 3 different classes. One class will be Vehicle, another will
/// be Truck that inherits from Vehicle, and the third will be Person.
/// Overall Plan:
/// 1. I will create the Vehicle class which will contain a Manufacturuer(enum) field, a cylinder(int),
/// and an owner(Person). The class will have getters, setters, properties, tostring, and equals methods.
/// 2. I will also implement Truck. On top of what it inherits, it will have its own Constructors, contain
/// two more fields called load(double) and towing(int), have properties for these new fields, and have its
/// own tostring and equals methods.
/// 3. For the Person class I will just fill in the methods dictated in the hw instructions. The only method
/// that is a little different is the constructor that takes in another Person object. For this constructor,
/// I will simply set the name field equal to the name field from the Person passed in.
/// 4. For the driver program I will just create two Vehicles, two Trucks, and four Persons. I will then use
/// these to call all my implemented methods and constructors to make sure they work as expected.

/// Classes needed and Purpose: The Vehicle, Truck, and Person classes are needed to meet all the requirements.
/// main class - Homework9
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Homework9
    {  
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Grant");
            Vehicle v1 = new Vehicle();
            Vehicle v2 = new Vehicle(Vehicle.Manufacturer.Ford, 4, p2);

            p1.SetName("Bob");
            v1.SetOwner(p1);
            v1.SetManufacturer(Vehicle.Manufacturer.Lexus);
            v1.Cylinder = 6;

            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.ToString());
            if (v1.Equals(v2))
            {
                Console.WriteLine("the vehicles ARE equal");
            }
            else
            {
                Console.WriteLine("the vehicles ARE NOT equal");
            }

            Console.WriteLine();

            Person p3 = new Person("Bill");
            Person p4 = new Person(p3);

            Truck t1 = new Truck();
            Truck t2 = new Truck(Vehicle.Manufacturer.Chevrolet, 2, p4, 75, 50);
            t1.SetManufacturer(Vehicle.Manufacturer.Chevrolet);
            t1.SetOwner(p3);
            t1.Cylinder = 2;
            t1.Load = 75;
            t1.Towing = 50;

            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
            if (t1.Equals(t2))
            {
                Console.WriteLine("the trucks ARE equal");
            }
            else
            {
                Console.WriteLine("the trucks ARE NOT equal");
            }

            Console.ReadLine();
        }
    }
}
