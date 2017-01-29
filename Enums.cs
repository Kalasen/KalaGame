using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaGame
{
    public enum Fonts
    {
        None,
        Vera,
        VeraSmall
    }

    public enum Directions
    {
        SW = 1,
        S = 2,
        SE = 3,
        W = 4,
        NONE = 5,
        E = 6,
        NW = 7,
        N = 8,
        NE = 9
    }

    public enum GameState
    {
        None,
        OpeningMenu,
        MainGame,
        CreatureSelect,
        HelpMenu,
        EscapeMenu,
        HealthMenu,
        InventoryMenu,
        NameSelect,
        WaitForPosition
    }
}
