using System;
using System.Collections.Generic;
using System.Text;

namespace KalaGame
{
    public struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public static bool operator ==(Point3D a, Point3D b)
        {
            if (a.X == b.X && a.Y == b.Y && a.Z == b.Z) //TODO: Simplify to one-liner
                return true;
            else
                return false;
        }

        public static bool operator !=(Point3D a, Point3D b)
        {
            if (a.X == b.X && a.Y == b.Y && a.Z == b.Z) //TODO: Simplify to one-liner
                return false;
            else
                return true;
        }

        public override bool Equals(Object b)
        {
            return this == (Point3D)b;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
