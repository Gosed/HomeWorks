using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursorMove
{
    public class Program
    {
        static void Main(string[] args)
        {
            var BPressed = new ButtonPressed();
            var CMove = new CursoreMove();
            BPressed.Move(new ArrowHandler(CMove.Up), new ArrowHandler(CMove.Down), new ArrowHandler(CMove.Left), new ArrowHandler(CMove.Right));//Я не понимаю, в чем ошибка
        }
    }
}
