using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursorControl
{
    public class CursorHadler
    {
        public void GoLeft()
        {
            if (Console.CursorLeft > 0)
                Console.CursorLeft--;
        }
        public void GoRight()
        {
            if (Console.CursorLeft < Console.BufferWidth - 1)
                Console.CursorLeft++;
        }
        public void GoUp()
        {
            if (Console.CursorTop > 0)
                Console.CursorTop--;
        }
        public void GoDown()
        {
            if (Console.CursorTop < Console.BufferHeight - 1)
                Console.CursorTop++;
        }
    }
}
