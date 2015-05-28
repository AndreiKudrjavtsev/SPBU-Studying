using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursorControl
{
    class EventLoop
    {
        public delegate void ArrowHandler();

        public void Run(ArrowHandler left, ArrowHandler right, ArrowHandler up, ArrowHandler down)
        {
            while (true)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        left();
                        break;
                    case ConsoleKey.RightArrow:
                        right();
                        break;
                    case ConsoleKey.UpArrow:
                        up();
                        break;
                    case ConsoleKey.DownArrow:
                        down();
                        break;
                }
            }
        }
    }
}
