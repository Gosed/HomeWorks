using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursorMove
{
    public class ButtonPressed
    {
        public delegate void ArrowHandler();
        /// <summary>
        /// Method says what to do when button is pressed
        /// </summary>
        /// <param name="left">left</param>
        /// <param name="right">right</param>
        /// <param name="up">up</param>
        /// <param name="down">down</param>
        public void Move(ArrowHandler up, ArrowHandler down, ArrowHandler left, ArrowHandler right)
        {
            while (true)
            {
                var button = Console.ReadKey(true);
                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        up();
                    break;
                    case ConsoleKey.DownArrow:
                        down();
                    break;
                    case ConsoleKey.LeftArrow:
                        left();
                    break;
                    case ConsoleKey.RightArrow:
                        right();
                    break;                    
                }
            }
        }
    }
}
