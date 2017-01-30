using System;

namespace KalaGame
{
    // Represents an (x,y) coordinate
    public struct Point2D
    {
        // Variables
        public short X;
        public short Y;

        // Constructors
        public Point2D(int X, int Y):this((short)X, (short)Y) { }
        public Point2D(short X, short Y)
        {
            this.X = X;
            this.Y = Y;
        }

        // Handle usual operators for structs
        public static bool operator ==(Point2D a, Point2D b)
        {
            if (a.X == b.X && a.Y == b.Y) //TODO: Simplify into one-liner
                return true;
            else
                return false;
		}
        public static bool operator !=(Point2D a, Point2D b)
        {
            if (a.X == b.X && a.Y == b.Y) //TODO: Simplify into one-liner
                return false;
            else
                return true;
		}
        public override bool Equals(object b)
        {
            return this == (Point2D)b; //Bluh to stop warnings
        }
        public override int GetHashCode()
        {
            return base.GetHashCode(); //Bluh to stop warnings
        }

        //Converts a relative direction into an absolute position
        public Point2D AdjacentVector(Directions dir)
        {
            switch (dir)
            {
                case Directions.SW:
                    return new Point2D(X - 1, Y + 1);
                case Directions.S:
                    return new Point2D(X    , Y + 1);
                case Directions.SE:
                    return new Point2D(X + 1, Y + 1);
                case Directions.W:
                    return new Point2D(X - 1, Y    );
                case Directions.E:
                    return new Point2D(X + 1, Y    );
                case Directions.NW:
                    return new Point2D(X - 1, Y - 1);
                case Directions.N:
                    return new Point2D(X    , Y - 1);
                case Directions.NE:
                    return new Point2D(X + 1, Y - 1);
                default:
                    throw new Exception("Received unhandled Direction");
            }
        }
    }
}
