using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaGame
{
    public class GraphicsException : Exception
    {
        public GraphicsException(string message = null, Exception inner = null)
            : base(message, inner)
        {
        }
    }
}
