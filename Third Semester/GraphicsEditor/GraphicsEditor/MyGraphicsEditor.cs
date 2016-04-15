using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    public partial class MyGraphicsEditor : Form
    {

        private EditorLogic logic = new EditorLogic();
        enum OperationType { isDrawing, isMoving, isDeleting, None };
        private OperationType state;
        /// <summary>
        /// field, that shows if mouse button is pressed on picture box
        /// </summary>
        private bool isPressed = false;
        /// <summary>
        /// field, that shows if mouse cursor catched (with some sbservational error) end of the line
        /// </summary>
        private bool isEndCatched = false;

        /// <summary>
        /// fields for the first coord of drawing/moving line
        /// </summary>
        private float X;
        private float Y;
        /// <summary>
        /// fields for the second coord of drawing/moving line
        /// </summary>
        private float X1;
        private float Y1;


        public MyGraphicsEditor()
        {
            InitializeComponent();
            state = OperationType.isDrawing;
            drawButton.BackColor = Color.Aquamarine;
            moveButton.BackColor = SystemColors.Control;
            deleteButton.BackColor = SystemColors.Control;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Text)
            {
                case ("Draw"):
                    state = OperationType.isDrawing;
                    drawButton.BackColor = Color.Aquamarine;
                    moveButton.BackColor = SystemColors.Control;
                    deleteButton.BackColor = SystemColors.Control;
                    break;
                case ("Move"):
                    state = OperationType.isMoving;
                    drawButton.BackColor = SystemColors.Control;
                    moveButton.BackColor = Color.Aquamarine;
                    deleteButton.BackColor = SystemColors.Control;
                    break;
                case ("Delete"):
                    state = OperationType.isDeleting;
                    drawButton.BackColor = SystemColors.Control;
                    moveButton.BackColor = SystemColors.Control;
                    deleteButton.BackColor = Color.Aquamarine;
                    break;
                case ("Undo"):
                    state = OperationType.None;
                    drawButton.BackColor = SystemColors.Control;
                    moveButton.BackColor = SystemColors.Control;
                    deleteButton.BackColor = SystemColors.Control;
                    logic.Undo();
                    pictureBox.Invalidate();
                    break;
                case ("Redo"):
                    state = OperationType.None;
                    drawButton.BackColor = SystemColors.Control;
                    moveButton.BackColor = SystemColors.Control;
                    deleteButton.BackColor = SystemColors.Control;
                    logic.Redo();
                    pictureBox.Invalidate();
                    break;
            }
        }

        private void pictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            X = e.X;
            Y = e.Y;

            if (state == OperationType.isMoving)
            {
                if (logic.IsEndCatched(ref X, ref Y))
                {
                    isEndCatched = true;
                }
            }
        }

        private void pictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (state == OperationType.isDrawing)
            {
                if (isPressed)
                {
                    X1 = e.X;
                    Y1 = e.Y;
                    pictureBox.Invalidate();
                }
            }
            else if (state == OperationType.isMoving)
            {
                if (isPressed && isEndCatched)
                {
                    X1 = e.X;
                    Y1 = e.Y;
                    pictureBox.Invalidate();
                }
            }
        }

        private void pictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
            if (state == OperationType.isDrawing || (state == OperationType.isMoving && isEndCatched))
            {
                isEndCatched = false;
                PointF newStartPoint = new PointF(X, Y);
                PointF newEndPoint = new PointF(X1, Y1);
                logic.AddLine(newStartPoint, newEndPoint);
            }
            else if (state == OperationType.isDeleting)
            {
                if (logic.CanDeleteLine(X, Y))
                {
                    pictureBox.Invalidate();
                }
            }
        }

        private void pictureBoxPaint(object sender, PaintEventArgs e)
        {
            if (state == OperationType.isDrawing || (state == OperationType.isMoving && isEndCatched))
            {
                logic.DrawLine(ref e, new PointF(X, Y), new PointF(X1, Y1));
            }

            logic.ReDraw(ref e);
        }


    }
}
