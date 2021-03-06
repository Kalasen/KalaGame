using System;
using System.Collections.Generic;
using System.Text;

namespace KalaGame
{
    public struct AStarTile
    {
        public Point2D pos, parentpos;
        public int f, g, h, w; //TODO: Why, past-me, did you name these things as just letters? I know A* pathfinding was tricky, but damn.

        public AStarTile(Point2D xy, Point2D parent, int gz, int hz, int wz)
        {
            pos = xy; //This tile's position
            parentpos = parent; //Parent tile's position
            w = wz;
            g = gz;
            h = hz;
            f = g + h;
        }
        public AStarTile(Point2D xy, Point2D parent, int gz, int hz)
        {
            pos = xy; //This tile's position
            parentpos = parent; //Parent tile's position
            w = 100;
            g = gz;
            h = hz;
            f = g + h;
        }
    }
}
