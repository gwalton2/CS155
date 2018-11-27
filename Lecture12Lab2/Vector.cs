using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12Lab2
{
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector operator -(Vector v1)
        {
            return new Vector(-v1.X, -v1.Y, -v1.Z);
        }

        public static Vector operator *(Vector v1, int scalar)
        {
            return new Vector(v1.X * scalar, v1.Y * scalar, v1.Z * scalar);
        }

        public static Vector operator /(Vector v1, int scalar)
        {
            return new Vector(v1.X / scalar, v1.Y / scalar, v1.Z / scalar);
        }
    }
}
