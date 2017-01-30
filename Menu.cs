using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaGame
{
    //Represents a hierarchical menu structure
    public class Menu
    {
        Menu parent;
        List<Menu> children = new List<Menu>();
        List<string> menuItems = new List<string>();

        Point2D pos;
        string title;
        Color color;

        public Menu(string title, Point2D pos, Color color = default(Color))
        {
            this.title = title;
            this.pos = pos;
            this.color = color;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawText(title, new Point2D(pos.X, pos.Y), color, Fonts.Vera);
            graphics.DrawText("Child menus and menu items go here", new Point2D(pos.X + 30, pos.Y + 30), color, Fonts.Vera);
        }
    }
}
