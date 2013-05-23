using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursorMove
{
    public class CursoreMove
    {
        /// <summary>
        /// If up pressed
        /// </summary>
        public void Up()
        {
            if (Console.CursorTop != 0)
                Console.CursorTop = Console.CursorTop - 1;
        }

        /// <summary>
        /// If down pressed
        /// </summary>
        public void Down()
        {
            if (Console.CursorTop < 299)
                Console.CursorTop = Console.CursorTop + 1;
        }

        /// <summary>
        /// If left pressed
        /// </summary>
        public void Left()
        {
            if (Console.CursorLeft != 0)
                Console.CursorLeft = Console.CursorLeft - 1;
        }

        /// <summary>
        /// If right pressed
        /// </summary>
        public void Right()
        {
            if (Console.CursorLeft < 79)
                Console.CursorLeft = Console.CursorLeft + 1;
        }        
    }
}
