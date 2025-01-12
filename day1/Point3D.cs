using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class Point3D
    {
        int X { get; set; }
        int Y { get; set; }

        int z;
        int Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value; // validate here if needed
            }
        }

        // Constructor chaining
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Override ToString
        public override string ToString() => $"(x: {X}), (y: {Y}), (z: {Z})";

        // Override Equals
        public override bool Equals(object? obj)
        {
            if (obj is Point3D point)
            {
                return X == point.X && Y == point.Y && Z == point.Z;
            }
            return false;
        }

        public static bool operator ==(Point3D p1, Point3D p2) => p1.Equals(p2);
        public static bool operator !=(Point3D p1, Point3D p2) => !p1.Equals(p2);


    }
}
