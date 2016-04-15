using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class EditorLogic
    {
        private List<Line> lines = new List<Line>();
        private StateHandler handler = new StateHandler();

        public void AddLine(PointF start, PointF end)
        {
            Line newLine = new Line(start, end);
            lines.Add(newLine);
            handler.AddState(ref lines);            
        }

        public bool IsEndCatched(ref float X,ref float Y)
        {
            const float eps = 3F;
            foreach (var line in lines)
            {
                double distanceToStart = Math.Sqrt(Math.Pow(X - line.StartPoint.X, 2) + Math.Pow(Y - line.StartPoint.Y, 2));
                double distanceToEnd = Math.Sqrt(Math.Pow(X - line.EndPoint.X, 2) + Math.Pow(Y - line.EndPoint.Y, 2));
                if (distanceToStart < eps)
                {
                    X = line.EndPoint.X;
                    Y = line.EndPoint.Y;
                    lines.Remove(line);
                    return true;
                }
                else if (distanceToEnd < eps)
                {
                    X = line.StartPoint.X;
                    Y = line.StartPoint.Y;
                    lines.Remove(line);
                    return true;
                }
            }

            return false;
        }

        public bool CanDeleteLine(float X, float Y)
        {
            const float eps = 0.5F;
            foreach (var line in lines)
            {
                double distanceToStart = Math.Sqrt(Math.Pow(line.StartPoint.X - X, 2) + Math.Pow(line.StartPoint.Y - Y, 2));
                double distanceToEnd = Math.Sqrt(Math.Pow(line.EndPoint.X - X, 2) + Math.Pow(line.EndPoint.Y - Y, 2));
                if (Math.Abs(line.Length() - distanceToStart - distanceToEnd) < eps)
                {
                    lines.Remove(line);
                    handler.AddState(ref lines);
                    return true;
                }
            }

            return false;
        }

        public void Undo()
        {
            lines = handler.Undo();
        }
        public void Redo()
        {
            lines = handler.Redo();
        }

        public void DrawLine(ref PaintEventArgs e, PointF startPoint, PointF endPoint)
        {
            e.Graphics.DrawLine(new Pen(Color.Black), startPoint, endPoint);
        }

        public void ReDraw(ref PaintEventArgs e)
        {
            if (lines != null)
            {
                foreach (var line in lines)
                {
                    e.Graphics.DrawLine(new Pen(Color.Black), line.StartPoint, line.EndPoint);
                }
            }
        }
    }
}
