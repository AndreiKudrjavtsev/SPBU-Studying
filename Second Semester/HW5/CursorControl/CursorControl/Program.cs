using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursorControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var cursorHandler = new CursorHadler();
            eventLoop.Run(cursorHandler.GoLeft, cursorHandler.GoRight, cursorHandler.GoUp, cursorHandler.GoDown);
        }
    }
}
