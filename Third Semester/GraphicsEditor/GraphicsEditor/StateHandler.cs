using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    public class StateHandler
    {
        private Stack<List<Line>> undoStack = new Stack<List<Line>>();
        private Stack<List<Line>> redoStack = new Stack<List<Line>>();

        public List<Line> Undo()
        {
            if (undoStack.Count != 0)
                redoStack.Push(undoStack.Pop());
            if (undoStack.Count != 0)
                return (cloneList(undoStack.Peek()));
            else
                return (new List<Line>());
        }

        public List<Line> Redo()
        {
            if (redoStack.Count != 0)
                undoStack.Push(redoStack.Pop());
            if (undoStack.Count != 0)
                return (cloneList(undoStack.Peek()));
            else
                return (new List<Line>());
        }

        public void AddState(ref List<Line> lines)
        {
            List<Line> clone = cloneList(lines);
            undoStack.Push(clone);
            redoStack.Clear();
        }

        private List<Line> cloneList(List<Line> lines)
        {
            List<Line> clone = new List<Line>();
            foreach (var line in lines)
                clone.Add(line);
            return clone;
        }
    }
}
