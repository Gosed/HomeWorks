using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursorMove
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bPressed = new ButtonPressed();
            var cMove = new CursoreMove();
            bPressed.Move(new ArrowHandler(cMove.Up), new ArrowHandler(cMove.Down), new ArrowHandler(cMove.Left), new ArrowHandler(cMove.Right));
        }
    }
}
